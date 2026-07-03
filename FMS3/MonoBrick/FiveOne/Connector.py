import serial

class Connector:
    def __init__(self, port2):
        self.ser = serial.Serial(
            port=port2,
            baudrate=11520,
        )
    def send(self, bytes):
        ser.write(bytes)
        
    def inject(self):
        ser.write(b'\x03\r')
        
