using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem
{
    public class Device
    {
        PoKeysDevice_DLL.PoKeysDevice myDevice;

        public readonly byte PIN_START = 0;
        public readonly byte PIN_PHOTO_CELL = 1;
      
        private bool connected;

        public bool Connected
        {
            get { return connected; }
            set { connected = value; }
        }


        public Device()
        {
            myDevice = new PoKeysDevice_DLL.PoKeysDevice();
        }

        public bool Connect()
        {
            // Enumerate and list USB devices
            if (myDevice.EnumerateDevices() > 0)
            {
                Connected = myDevice.ConnectToDevice(0);
                Initialize();
            }

            return Connected;
        }

        private void Initialize()
        {
            // Set pin 1 (with index 0) as digital input
            myDevice.SetPinData(PIN_START, (byte)PoKeysDevice_DLL.ePinCap.digitalInput);

            // Set pin 2 (with index 1) as digital input
            myDevice.SetPinData(PIN_PHOTO_CELL, (byte)PoKeysDevice_DLL.ePinCap.digitalInput);
        }

        public void Disconnect()
        {
            if (Connected)
                myDevice.DisconnectDevice();
        }

        private bool ReadPin(byte pinID)
        {
            bool pinState = false;

            if (Connected)
                myDevice.GetInput(pinID, ref pinState);
            return pinState;
        }

        public bool ReadStartCommand()
        {
            return ReadPin(PIN_START);
        }

        public bool ReadPhotoCell()
        {
            return ReadPin(PIN_PHOTO_CELL);
        }
    }

}
