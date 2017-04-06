using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSystem
{
    /// <summary>
    /// PoKeys Device 
    /// </summary>
    public class Device : IDevice
    {
        #region Fields
        PoKeysDevice_DLL.PoKeysDevice myDevice;

        public readonly byte PIN_START = 0;
        public readonly byte PIN_PHOTO_CELL = 1;
      
        private bool connected;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Device"/> is connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if connected; otherwise, <c>false</c>.
        /// </value>
        public bool Connected
        {
            get { return connected; }
            set { connected = value; }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Device"/> class.
        /// </summary>
        public Device()
        {
            myDevice = new PoKeysDevice_DLL.PoKeysDevice();
        }

        /// <summary>
        /// Connects the board
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Initializes the IO's
        /// </summary>
        private void Initialize()
        {
            // Set pin 1 (with index 0) as digital input
            myDevice.SetPinData(PIN_START, (byte)PoKeysDevice_DLL.ePinCap.digitalInput + (byte)(PoKeysDevice_DLL.ePinCap.invertPin));

            // Set pin 2 (with index 1) as digital input
            myDevice.SetPinData(PIN_PHOTO_CELL, (byte)PoKeysDevice_DLL.ePinCap.digitalInput /*+ (byte)(PoKeysDevice_DLL.ePinCap.invertPin)*/);
        }

        /// <summary>
        /// Disconnects the board
        /// </summary>
        public void Disconnect()
        {
            if (Connected)
                myDevice.DisconnectDevice();
        }

        /// <summary>
        /// Reads the pin.
        /// </summary>
        /// <param name="pinID">The pin identifier.</param>
        /// <returns>Return the digital value of the pin</returns>
        private bool ReadPin(byte pinID)
        {
            bool pinState = false;

            if (Connected)
                myDevice.GetInput(pinID, ref pinState);
            return pinState;
        }

        /// <summary>
        /// Reads the start command.
        /// </summary>
        /// <returns></returns>
        public bool ReadStartCommand()
        {
            return ReadPin(PIN_START);
        }

        /// <summary>
        /// Reads the photo cell.
        /// </summary>
        /// <returns></returns>
        public bool ReadPhotoCell()
        {
            return ReadPin(PIN_PHOTO_CELL);
        }
    }

}
