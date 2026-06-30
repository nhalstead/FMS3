using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

///
/// It is used to replace the SlimDX library with the XInput library.
/// The XInput library is a native library that is used to interact with the XInput API.
/// The XInput API is a native API that is used to interact with the XInput API.
/// 
namespace SlimDX
{
    public struct Result
    {
        public int Code { get; private set; }
        public bool IsFailure => Code < 0;
        public bool IsSuccess => Code >= 0;

        public static Result Last { get; internal set; }

        public static Result FromCode(int code)
        {
            return new Result { Code = code };
        }
    }

    public class SlimDXException : Exception
    {
        public SlimDXException() { }
        public SlimDXException(string message) : base(message) { }
        public SlimDXException(string message, Exception innerException) : base(message, innerException) { }
    }
}

namespace SlimDX.DirectInput
{
    public enum DeviceClass
    {
        All,
        GameController,
        Keyboard,
        Mouse
    }

    public enum DeviceEnumerationFlags
    {
        AllDevices,
        AttachedOnly,
        ForceFeedback,
    }

    public enum CooperativeLevel
    {
        None = 0,
        Exclusive = 1,
        Nonexclusive = 2,
        Foreground = 4,
        Background = 8,
        NoWinKey = 16
    }

    [Flags]
    public enum ObjectDeviceType
    {
        All = 0,
        Axis = 1,
        Button = 2,
        Pov = 4,
        Slider = 8,
        PointOfViewController = 16
    }

    public class DeviceInstance
    {
        public Guid InstanceGuid { get; set; }
        public string ProductName { get; set; }
        public string InstanceName { get; set; }
    }

    public class DeviceObjectInstance
    {
        public ObjectDeviceType ObjectType { get; set; }
        public Guid ObjectTypeGuid { get; set; }
        public string Name { get; set; }
    }

    public static class ObjectGuid
    {
        public static readonly Guid XAxis = new Guid("A36D02E0-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid YAxis = new Guid("A36D02E1-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid ZAxis = new Guid("A36D02E2-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid RotationalXAxis = new Guid("A36D02E3-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid RotationalYAxis = new Guid("A36D02E4-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid RotationalZAxis = new Guid("A36D02E5-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid Slider = new Guid("A36D02E6-C9F3-11CF-BFC7-444553540000");
        public static readonly Guid PovController = new Guid("A36D02F2-C9F3-11CF-BFC7-444553540000");
    }

    public class DirectInput : IDisposable
    {
        public List<DeviceInstance> GetDevices(DeviceClass deviceClass, DeviceEnumerationFlags flags)
        {
            var devices = new List<DeviceInstance>();
            if (deviceClass == DeviceClass.GameController || deviceClass == DeviceClass.All)
            {
                for (uint i = 0; i < 4; i++)
                {
                    XInputState state = new XInputState();
                    if (XInputNative.XInputGetState(i, ref state) == 0)
                    {
                        devices.Add(new DeviceInstance
                        {
                            InstanceGuid = new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, (byte)i),
                            ProductName = "XInput Controller " + (i + 1),
                            InstanceName = "XInput Controller " + (i + 1)
                        });
                    }
                }
            }
            return devices;
        }

        public void Dispose() { }
    }

    public class JoystickState
    {
        public int X { get; internal set; }
        public int Y { get; internal set; }
        public int Z { get; internal set; }
        public int RotationX { get; internal set; }
        public int RotationY { get; internal set; }
        public int RotationZ { get; internal set; }

        private bool[] buttons = new bool[128];
        private int[] sliders = new int[2];
        private int[] povs = new int[4] { -1, -1, -1, -1 };

        public bool[] GetButtons() => buttons;
        public int[] GetSliders() => sliders;
        public int[] GetPointOfViewControllers() => povs;

        internal void SetButton(int index, bool pressed)
        {
            if (index >= 0 && index < buttons.Length)
                buttons[index] = pressed;
        }

        internal void SetSlider(int index, int value)
        {
            if (index >= 0 && index < sliders.Length)
                sliders[index] = value;
        }

        internal void SetPov(int index, int value)
        {
            if (index >= 0 && index < povs.Length)
                povs[index] = value;
        }
    }

    public class Joystick : IDisposable
    {
        private uint userIndex;
        private JoystickState currentState = new JoystickState();
        private bool acquired = false;

        public Joystick(DirectInput dinput, Guid guid)
        {
            byte[] bytes = guid.ToByteArray();
            userIndex = bytes[15];
        }

        public void SetCooperativeLevel(System.Windows.Forms.Form window, CooperativeLevel level) { }
        public void SetCooperativeLevel(IntPtr windowHandle, CooperativeLevel level) { }

        public IEnumerable<DeviceObjectInstance> GetObjects()
        {
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.XAxis, Name = "X Axis" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.YAxis, Name = "Y Axis" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.ZAxis, Name = "Z Axis" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.RotationalXAxis, Name = "Rotation X" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.RotationalYAxis, Name = "Rotation Y" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.RotationalZAxis, Name = "Rotation Z" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Axis, ObjectTypeGuid = ObjectGuid.Slider, Name = "Slider 0" };
            yield return new DeviceObjectInstance { ObjectType = ObjectDeviceType.Pov, ObjectTypeGuid = ObjectGuid.PovController, Name = "Point of View Controller 0" };
        }

        public JoystickProperties GetObjectPropertiesById(int id)
        {
            return new JoystickProperties();
        }

        public Result Acquire()
        {
            acquired = true;
            return Result.FromCode(0);
        }

        public Result Poll()
        {
            if (!acquired) return Result.FromCode(-1);
            return Result.FromCode(0);
        }

        public void Unacquire()
        {
            acquired = false;
        }

        public void Dispose()
        {
            Unacquire();
        }

        public JoystickState GetCurrentState()
        {
            XInputState xState = new XInputState();
            int result = XInputNative.XInputGetState(userIndex, ref xState);
            Result.Last = Result.FromCode(result == 0 ? 0 : -1);

            if (result == 0)
            {
                // XInput ranges:
                // Thumbs: -32768 to 32767
                // Triggers: 0 to 255
                
                // Map to -100 to 100 as requested by the app's SetRange calls
                currentState.X = (int)(xState.Gamepad.sThumbLX / 327.68);
                currentState.Y = (int)(-xState.Gamepad.sThumbLY / 327.68); // Invert Y to match DirectInput convention
                currentState.RotationX = (int)(xState.Gamepad.sThumbRX / 327.68);
                currentState.RotationY = (int)(-xState.Gamepad.sThumbRY / 327.68); // Invert Y

                // Map Triggers to Z and RotationZ (-100 to 100)
                currentState.Z = (int)(xState.Gamepad.bLeftTrigger * 200.0 / 255.0 - 100.0);
                currentState.RotationZ = (int)(xState.Gamepad.bRightTrigger * 200.0 / 255.0 - 100.0);

                // Buttons mapping (XInput to DirectInput standard)
                currentState.SetButton(0, (xState.Gamepad.wButtons & 0x1000) != 0); // A
                currentState.SetButton(1, (xState.Gamepad.wButtons & 0x2000) != 0); // B
                currentState.SetButton(2, (xState.Gamepad.wButtons & 0x4000) != 0); // X
                currentState.SetButton(3, (xState.Gamepad.wButtons & 0x8000) != 0); // Y
                currentState.SetButton(4, (xState.Gamepad.wButtons & 0x0100) != 0); // LB
                currentState.SetButton(5, (xState.Gamepad.wButtons & 0x0200) != 0); // RB
                currentState.SetButton(6, (xState.Gamepad.wButtons & 0x0020) != 0); // Back
                currentState.SetButton(7, (xState.Gamepad.wButtons & 0x0010) != 0); // Start
                currentState.SetButton(8, (xState.Gamepad.wButtons & 0x0040) != 0); // LThumb
                currentState.SetButton(9, (xState.Gamepad.wButtons & 0x0080) != 0); // RThumb

                // POV mapping (DPad) - values are in hundredths of degrees
                int pov = -1;
                bool up = (xState.Gamepad.wButtons & 0x0001) != 0;
                bool down = (xState.Gamepad.wButtons & 0x0002) != 0;
                bool left = (xState.Gamepad.wButtons & 0x0008) != 0;
                bool right = (xState.Gamepad.wButtons & 0x0004) != 0;

                if (up)
                {
                    if (right) pov = 4500;
                    else if (left) pov = 31500;
                    else pov = 0;
                }
                else if (down)
                {
                    if (right) pov = 13500;
                    else if (left) pov = 22500;
                    else pov = 18000;
                }
                else if (right) pov = 9000;
                else if (left) pov = 27000;

                currentState.SetPov(0, pov);
            }

            return currentState;
        }
    }

    public class JoystickProperties
    {
        public void SetRange(int min, int max) { }
    }

    public class DirectInputException : SlimDX.SlimDXException
    {
        public DirectInputException() { }
        public DirectInputException(string message) : base(message) { }
    }

    internal static class XInputNative
    {
        [DllImport("xinput1_4.dll")]
        public static extern int XInputGetState(uint dwUserIndex, ref XInputState pState);
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct XInputState
    {
        public uint dwPacketNumber;
        public XInputGamepad Gamepad;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct XInputGamepad
    {
        public ushort wButtons;
        public byte bLeftTrigger;
        public byte bRightTrigger;
        public short sThumbLX;
        public short sThumbLY;
        public short sThumbRX;
        public short sThumbRY;
    }
}
