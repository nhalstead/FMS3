/*
 * there is a better way to do this with interfaces and polymorphism
 * it would be good to rewrite this in the future :)
 */


using MonoBrick.EV3;
using MonoBrick.NXT;
using MonoBrick.FiveOne;
using System;
using System.Threading;
using System.Diagnostics;

namespace FMS3
{
	/**
	 * Wrapper class for two different MonoBrick "Brick" classes - EV3.Brick and NXT.Brick
	 * Keeps track of state
	 */
	abstract class GenericBrick
	{
		// Represent brick 'states' whether connected as NXT or EV3, unconnected, once-connected-but-now-missing, etc.

		// States <=0 are used to denote "invalid" (not connected) bricks.

		// "LOST" (used when a previously good connection has gone bad, and an exception was caught)
		public const int STATE_BROKEN = -2;
		// "new" (initialization state)
		public const int STATE_NEW = -1;
		// "none" (used to be used for a particular broken state)
		public const int STATE_NOTFOUND = 0;

		// States >0 are used to denote "valid" (connected) bricks.

		// "EV3" - brick connected as EV3
		public const int STATE_EV3 = 1;
		// "NXT" - brick connected as NXT
		public const int STATE_NXT = 2;

		public const int STATE_51515 = 3;

		public const int OFFSET_STATE_NAMES = -2;
		public static string[] STATE_NAMES = new string[] {
			"LOST", "new", "none", "EV3", "NXT", "51515"
		};

		// For tracking the motors
		public const int MOTOR_A = 0;
		public const int MOTOR_B = 1;
		public const int MOTOR_C = 2;
		public const int MOTOR_D = 3;

		// Bricks initialize as 'new'
		protected int state = STATE_NEW;
		protected string brickName;
		protected string connName;

		protected volatile int _desiredMotorA = 0;
		protected volatile int _desiredMotorB = 0;
		protected volatile int _desiredMotorC = 0;
		protected volatile int _desiredMotorD = 0;

		protected volatile bool _requestStopAllMotors = false;
		protected volatile bool _requestStopAllPrograms = false;
		protected volatile ushort _requestBeepDuration = 0;
		protected volatile Tuple<ushort, ushort> _requestPlayTone = null; // Frequency, Duration

		public volatile int IOStatus = 0; // 0: IDLE, 1: WRITING, 2: ERROR
		public long LastWriteStartTime = 0;

		protected Thread _ioThread;
		protected volatile bool _isRunning = false;


		//
		// Constructor: name of brick, COM port to use, and whether this is an EV3 or not
		// (MonoBrick cannot auto-detect whether or not a brick is EV3)
		//
		public GenericBrick(string newBrickName, string newConnName)
		{
			brickName = newBrickName + "";
			connName = newConnName + "";

			connectToBrick(true);
		}

		// Attempt to connect to this brick; optionally, play the connection tones to represent a successful connection
		protected abstract void connectToBrick(bool playConnectTones);

		//
		// Static helper method: Given a state constant, return the name. Use the 'offset' because the state constants start below zero (0)
		//
		public static string getStateName(int state)
		{
			return STATE_NAMES[state - OFFSET_STATE_NAMES];
		}

		/*******************************************************************/

		//
		// Various getters
		//
		public int getState()
		{
			return state;
		}
		public string getStateName()
		{
			return GenericBrick.getStateName(state);
			//return STATE_NAMES[state - OFFSET_STATE_NAMES];
		}
		public string getBrickName()
		{
			return brickName;
		}
		public string getConnName()
		{
			return connName;
		}

		/*
		 * For the "actions" below, only do the action if it's connected as an EV3 or NXT.
		 * In each case, if connected, use the appropriate private Brick object (MonoBrick.EV3.Brick or NXT)
		 * Use try/catch, and set brick state to BROKEN ("LOST") if an action fails.
		 * Why might it fail? -- Battery could have died, it was powered off, taken out of range, etc.
		 */

		//
		// Make the brick beep.
		//
		public abstract int beep(ushort durationMs);

		//
		// Make the brick play a particular tone.
		//
		public abstract int playTone(ushort frequency, ushort durationMs);

		//
		// Stop all the motors. For EV3, include stopping the 'D' motor.
		//
		public abstract int stopAllMotors();

		//
		// Stop all programs.
		//
		public abstract int stopAllPrograms();

		///
		/// Set a specific motor to a particular speed. Automatically restricts speed to -100 to 100.
		///
		public abstract int setMotor(int whichMotor, int speed);

		//
		// When a brick is "LOST", we can try to reconnect to it; but if so, we need to close the old Connection
		//
		public abstract int resetBrokenState();
	}


	class Ev3Brick : GenericBrick
	{
		private MonoBrick.EV3.Brick<MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor> ev3Brick;

		private int _actualMotorA = 0;
		private int _actualMotorB = 0;
		private int _actualMotorC = 0;
		private int _actualMotorD = 0;

		public Ev3Brick(string newBrickName, string newConnName) : base(newBrickName, newConnName)
		{
			this.state = STATE_EV3;
		}

		protected override void connectToBrick(bool playConnectTones)
		{
			int oldState = state;
			state = STATE_NEW;
			bool notFound = true;

			try
			{
				ev3Brick = new MonoBrick.EV3.Brick<MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor, MonoBrick.EV3.Sensor>(connName);
				Console.WriteLine("DEBUG: got an EV3 brick");
				ev3Brick.Connection.Open();
				Console.WriteLine("DEBUG: opened EV3 brick");

				if (playConnectTones)
				{
					ev3Brick.PlayTone(100, 440, 500);
					System.Threading.Thread.Sleep(200);
					ev3Brick.PlayTone(100, 550, 500);
					System.Threading.Thread.Sleep(200);
					ev3Brick.PlayTone(100, 660, 500);
					System.Threading.Thread.Sleep(200);
					ev3Brick.PlayTone(100, 770, 500);
					System.Threading.Thread.Sleep(200);
					ev3Brick.PlayTone(100, 880, 400);
				}

				state = STATE_EV3;
				notFound = false;

				_isRunning = true;
				_ioThread = new Thread(IoThreadLoop);
				_ioThread.Start();
			}
			catch (Exception e)
			{
				Console.WriteLine("DEBUG: brick=" + brickName + ",conn=" + connName + " - not an EV3");
			}

			if (notFound)
			{
				Console.WriteLine("DEBUG: Ev3Brick.connectToBrick(): brick=" + brickName + " not found");
				state = STATE_NOTFOUND;
			}

			if (state == STATE_NOTFOUND && oldState == STATE_BROKEN)
			{
				Console.WriteLine("DEBUG: Ev3Brick.connectToBrick(): brick=" + brickName + " was unable to reconnect");
				state = STATE_BROKEN;
			}
		}

		private void IoThreadLoop()
		{
			Stopwatch stopwatch = new Stopwatch();
			while (_isRunning)
			{
				IOStatus = 0; // IDLE

				// Handle motor commands
				if (_desiredMotorA != _actualMotorA)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.MotorA.On((sbyte)_desiredMotorA);
						_actualMotorA = _desiredMotorA;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorB != _actualMotorB)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.MotorB.On((sbyte)_desiredMotorB);
						_actualMotorB = _desiredMotorB;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorC != _actualMotorC)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.MotorC.On((sbyte)_desiredMotorC);
						_actualMotorC = _desiredMotorC;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorD != _actualMotorD)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.MotorD.On((sbyte)_desiredMotorD);
						_actualMotorD = _desiredMotorD;
					} catch (Exception) { state = STATE_BROKEN; }
				}

				// Handle one-off commands
				if (_requestStopAllMotors)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.MotorA.Off();
						ev3Brick.MotorB.Off();
						ev3Brick.MotorC.Off();
						ev3Brick.MotorD.Off();
						_actualMotorA = _actualMotorB = _actualMotorC = _actualMotorD = 0;
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllMotors = false;
				}

				if (_requestStopAllPrograms)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.StopProgram();
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllPrograms = false;
				}

				if (_requestBeepDuration > 0)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.Beep(100, _requestBeepDuration);
					} catch (Exception) { state = STATE_BROKEN; }
					_requestBeepDuration = 0;
				}

				if (_requestPlayTone != null)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						ev3Brick.PlayTone(100, _requestPlayTone.Item1, _requestPlayTone.Item2);
					} catch (Exception) { state = STATE_BROKEN; }
					_requestPlayTone = null;
				}

				System.Threading.Thread.Sleep(10); // Small delay to prevent busy-waiting
			}
			ev3Brick.Connection.Close(); // Close connection when thread stops
		}

		public override int beep(ushort durationMs)
		{
			_requestBeepDuration = durationMs;
			return state;
		}

		public override int playTone(ushort frequency, ushort durationMs)
		{
			_requestPlayTone = Tuple.Create(frequency, durationMs);
			return state;
		}

		public override int stopAllMotors()
		{
			_requestStopAllMotors = true;
			_desiredMotorA = _desiredMotorB = _desiredMotorC = _desiredMotorD = 0;
			return state;
		}

		public override int stopAllPrograms()
		{
			_requestStopAllPrograms = true;
			return state;
		}

		public override int setMotor(int whichMotor, int speed)
		{
			int newSpeed = speed;
			if (newSpeed > 100)
				newSpeed = 100;
			if (newSpeed < -100)
				newSpeed = -100;

			switch (whichMotor)
			{
				case MOTOR_A: _desiredMotorA = newSpeed; break;
				case MOTOR_B: _desiredMotorB = newSpeed; break;
				case MOTOR_C: _desiredMotorC = newSpeed; break;
				case MOTOR_D: _desiredMotorD = newSpeed; break;
			}
			return state;
		}

		public override int resetBrokenState()
		{
			if (state == STATE_BROKEN)
			{
				_isRunning = false; // Signal thread to stop
				_ioThread.Join(); // Wait for thread to finish
				ev3Brick.Connection.Close();
				connectToBrick(true);
			}
			return state;
		}
	}

	class NxtBrick : GenericBrick
	{
		private MonoBrick.NXT.Brick<MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor> nxtBrick;

		private int _actualMotorA = 0;
		private int _actualMotorB = 0;
		private int _actualMotorC = 0;

		public NxtBrick(string newBrickName, string newConnName) : base(newBrickName, newConnName)
		{
			this.state = STATE_NXT;
		}

		protected override void connectToBrick(bool playConnectTones)
		{
			int oldState = state;
			state = STATE_NEW;
			bool notFound = true;

			try
			{
				nxtBrick = new MonoBrick.NXT.Brick<MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor, MonoBrick.NXT.Sensor>(connName);
				Console.WriteLine("DEBUG: got an NXT brick");
				nxtBrick.Connection.Open();
				Console.WriteLine("DEBUG: opened NXT brick");

				if (playConnectTones)
				{
					nxtBrick.PlayTone(440, 500);
					System.Threading.Thread.Sleep(200);
					nxtBrick.PlayTone(550, 500);
					System.Threading.Thread.Sleep(200);
					nxtBrick.PlayTone(660, 500);
					System.Threading.Thread.Sleep(200);
					nxtBrick.PlayTone(770, 500);
					System.Threading.Thread.Sleep(200);
					nxtBrick.PlayTone(880, 400);
				}

				string name = nxtBrick.GetBrickName();
				Console.WriteLine("DEBUG: NXT name='" + name + "'");

				state = STATE_NXT;
				notFound = false;

				_isRunning = true;
				_ioThread = new Thread(IoThreadLoop);
				_ioThread.Start();
			}
			catch (Exception e)
			{
				Console.WriteLine("DEBUG: brick=" + brickName + ",conn=" + connName + " - not an NXT");
			}

			if (notFound)
			{
				Console.WriteLine("DEBUG: NxtBrick.connectToBrick(): brick=" + brickName + " not found");
				state = STATE_NOTFOUND;
			}

			if (state == STATE_NOTFOUND && oldState == STATE_BROKEN)
			{
				Console.WriteLine("DEBUG: NxtBrick.connectToBrick(): brick=" + brickName + " was unable to reconnect");
				state = STATE_BROKEN;
			}
		}

		private void IoThreadLoop()
		{
			Stopwatch stopwatch = new Stopwatch();
			while (_isRunning)
			{
				IOStatus = 0; // IDLE

				// Handle motor commands
				if (_desiredMotorA != _actualMotorA)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.MotorA.On((sbyte)_desiredMotorA);
						_actualMotorA = _desiredMotorA;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorB != _actualMotorB)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.MotorB.On((sbyte)_desiredMotorB);
						_actualMotorB = _desiredMotorB;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorC != _actualMotorC)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.MotorC.On((sbyte)_desiredMotorC);
						_actualMotorC = _desiredMotorC;
					} catch (Exception) { state = STATE_BROKEN; }
				}

				// Handle one-off commands
				if (_requestStopAllMotors)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.MotorA.Off();
						nxtBrick.MotorB.Off();
						nxtBrick.MotorC.Off();
						_actualMotorA = _actualMotorB = _actualMotorC = 0;
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllMotors = false;
				}

				if (_requestStopAllPrograms)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.StopProgram();
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllPrograms = false;
				}

				if (_requestBeepDuration > 0)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.Beep(_requestBeepDuration);
					} catch (Exception) { state = STATE_BROKEN; }
					_requestBeepDuration = 0;
				}

				if (_requestPlayTone != null)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						nxtBrick.PlayTone(_requestPlayTone.Item1, _requestPlayTone.Item2);
					} catch (Exception) { state = STATE_BROKEN; }
					_requestPlayTone = null;
				}

				System.Threading.Thread.Sleep(10); // Small delay to prevent busy-waiting
			}
			nxtBrick.Connection.Close(); // Close connection when thread stops
		}

		public override int beep(ushort durationMs)
		{
			_requestBeepDuration = durationMs;
			return state;
		}

		public override int playTone(ushort frequency, ushort durationMs)
		{
			_requestPlayTone = Tuple.Create(frequency, durationMs);
			return state;
		}

		public override int stopAllMotors()
		{
			_requestStopAllMotors = true;
			_desiredMotorA = _desiredMotorB = _desiredMotorC = 0;
			return state;
		}

		public override int stopAllPrograms()
		{
			_requestStopAllPrograms = true;
			return state;
		}

		public override int setMotor(int whichMotor, int speed)
		{
			int newSpeed = speed;
			if (newSpeed > 100)
				newSpeed = 100;
			if (newSpeed < -100)
				newSpeed = -100;

			switch (whichMotor)
			{
				case MOTOR_A: _desiredMotorA = newSpeed; break;
				case MOTOR_B: _desiredMotorB = newSpeed; break;
				case MOTOR_C: _desiredMotorC = newSpeed; break;
					// Special: NXT does not have a 'D' motor
				case MOTOR_D: _desiredMotorA = newSpeed; break; // Fallback to MotorA
			}
			return state;
		}

		public override int resetBrokenState()
		{
			if (state == STATE_BROKEN)
			{
				_isRunning = false; // Signal thread to stop
				_ioThread.Join(); // Wait for thread to finish
				nxtBrick.Connection.Close();
				connectToBrick(true);
			}
			return state;
		}
	}

	class FiveOneBrick : GenericBrick
	{
		private MonoBrick.FiveOne.Brick fiveOneBrick;

		private int _actualMotorA = 0;
		private int _actualMotorB = 0;
		private int _actualMotorC = 0;
		private int _actualMotorD = 0;
		// private int _actualMotorE = 0;
		// private int _actualMotorF = 0;

		public FiveOneBrick(string newBrickName, string newConnName) : base(newBrickName, newConnName)
		{
			this.state = STATE_51515;
		}

		protected override void connectToBrick(bool playConnectTones)
		{
			int oldState = state;
			state = STATE_NEW;
			bool notFound = true;

			try
			{
				fiveOneBrick = new MonoBrick.FiveOne.Brick(connName);
				state = STATE_51515;
				notFound = false;

				_isRunning = true;
				_ioThread = new Thread(IoThreadLoop);
				_ioThread.Start();
			}
			catch (Exception e)
			{
				Console.WriteLine("DEBUG: brick=" + brickName + ",conn=" + connName + " - not an 51515");
			}

			if (notFound)
			{
				Console.WriteLine("DEBUG: FiveOneBrick.connectToBrick(): brick=" + brickName + " not found");
				state = STATE_NOTFOUND;
			}

			if (state == STATE_NOTFOUND && oldState == STATE_BROKEN)
			{
				Console.WriteLine("DEBUG: FiveOneBrick.connectToBrick(): brick=" + brickName + " was unable to reconnect");
				state = STATE_BROKEN;
			}
		}

		private void IoThreadLoop()
		{
			Stopwatch stopwatch = new Stopwatch();
			while (_isRunning)
			{
				IOStatus = 0; // IDLE

				// Handle motor commands
				if (_desiredMotorA != _actualMotorA)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.MotorA.On((sbyte)_desiredMotorA);
						_actualMotorA = _desiredMotorA;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorB != _actualMotorB)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.MotorB.On((sbyte)_desiredMotorB);
						_actualMotorB = _desiredMotorB;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorC != _actualMotorC)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.MotorC.On((sbyte)_desiredMotorC);
						_actualMotorC = _desiredMotorC;
					} catch (Exception) { state = STATE_BROKEN; }
				}
				if (_desiredMotorD != _actualMotorD)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.MotorD.On((sbyte)_desiredMotorD);
						_actualMotorD = _desiredMotorD;
					} catch (Exception) { state = STATE_BROKEN; }
				}

				// Handle one-off commands
				if (_requestStopAllMotors)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.MotorA.Off();
						fiveOneBrick.MotorB.Off();
						fiveOneBrick.MotorC.Off();
						fiveOneBrick.MotorD.Off();
						_actualMotorA = _actualMotorB = _actualMotorC = _actualMotorD = 0;
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllMotors = false;
				}

				if (_requestStopAllPrograms)
				{
					try {
						IOStatus = 1; // WRITING
						LastWriteStartTime = stopwatch.ElapsedMilliseconds;
						fiveOneBrick.stopPrograms();
					} catch (Exception) { state = STATE_BROKEN; }
					_requestStopAllPrograms = false;
				}

				if (_requestBeepDuration > 0)
				{
					// FiveOneBrick does not have a beep method.
					// Handle as appropriate, e.g., log a warning or ignore silently.
					_requestBeepDuration = 0;
				}

				if (_requestPlayTone != null)
				{
					// FiveOneBrick does not have a PlayTone method.
					// Handle as appropriate, e.g., log a warning or ignore silently.
					_requestPlayTone = null;
				}

				System.Threading.Thread.Sleep(10); // Small delay to prevent busy-waiting
			}
			// fiveOneBrick.Connection.Close(); // FiveOneBrick does not have a Connection.Close()
		}


		public override int beep(ushort durationMs)
		{
			// FiveOneBrick does not have a beep method, so we'll just ignore it.
			return state;
		}

		public override int playTone(ushort frequency, ushort durationMs)
		{
			// FiveOneBrick does not have a playTone method, so we'll just ignore it.
			return state;
		}

		public override int stopAllMotors()
		{
			_requestStopAllMotors = true;
			_desiredMotorA = _desiredMotorB = _desiredMotorC = _desiredMotorD = 0;
			return state;
		}

		public override int stopAllPrograms()
		{
			_requestStopAllPrograms = true;
			return state;
		}

		public override int setMotor(int whichMotor, int speed)
		{
			int newSpeed = speed;
			if (newSpeed > 100)
				newSpeed = 100;
			if (newSpeed < -100)
				newSpeed = -100;

			switch (whichMotor)
			{
				case MOTOR_A: _desiredMotorA = newSpeed; break;
				case MOTOR_B: _desiredMotorB = newSpeed; break;
				case MOTOR_C: _desiredMotorC = newSpeed; break;
				case MOTOR_D: _desiredMotorD = newSpeed; break;
			}
			return state;
		}

		public override int resetBrokenState()
		{
			if (state == STATE_BROKEN)
			{
				_isRunning = false; // Signal thread to stop
				_ioThread.Join(); // Wait for thread to finish
				// fiveOneBrick.Connection.Close(); // FiveOneBrick does not have Connection.Close()
				connectToBrick(true);
			}
			return state;
		}
	}
}
