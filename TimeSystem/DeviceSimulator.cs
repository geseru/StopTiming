using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeSystem
{
    public class DeviceSimulator : IDevice
    {
        #region Fields
        private Stopwatch stopWatch;

        private List<double> randomTimes = new List<double>();
        #endregion

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IDevice" /> is connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if connected; otherwise, <c>false</c>.
        /// </value>
        public bool Connected
        {
            get
            {
                return true;
            }

            set
            {
                ;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSimulator"/> class.
        /// </summary>
        public DeviceSimulator()
        {
            stopWatch = new Stopwatch();
        }

        /// <summary>
        /// Connects the board
        /// </summary>
        /// <returns>Return connected state</returns>
        public bool Connect()
        {
            return true;
        }

        /// <summary>
        /// Disconnects the board
        /// </summary>
        public void Disconnect()
        {
        }

        static bool photocell = false;

        /// <summary>
        /// Reads the photo cell.
        /// </summary>
        /// <returns></returns>
        public bool ReadPhotoCell()
        {
            if ((randomTimes.Count > 0) && (stopWatch.Elapsed.TotalSeconds > randomTimes[0]))
            {
                photocell = !photocell;
                randomTimes.RemoveAt(0);
             }
            return photocell;
        }

        /// <summary>
        /// Reads the start command.
        /// </summary>
        /// <returns></returns>
        public bool ReadStartCommand()
        {
            photocell = false;
            GenerateRandomTimes();
            Thread.Sleep(1000);
            stopWatch.Reset();
            stopWatch.Start();
            return true;
        }

        /// <summary>
        /// Generates the random times.
        /// </summary>
        private void GenerateRandomTimes()
        {
            Random rnd = new Random();
            randomTimes.Clear();

            randomTimes.Add(8.0 + rnd.NextDouble());
            randomTimes.Add(randomTimes[0] + 0.25);

            randomTimes.Add(randomTimes[1] + rnd.NextDouble());
            randomTimes.Add(randomTimes[2] + 0.3);

            randomTimes.Add(randomTimes[3] + rnd.NextDouble());
            randomTimes.Add(randomTimes[4] + 0.4);

            randomTimes.Add(randomTimes[5] + rnd.NextDouble());
            randomTimes.Add(randomTimes[6] + 0.23);
        }
    }
}
