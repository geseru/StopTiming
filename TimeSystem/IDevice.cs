namespace TimeSystem
{
    /// <summary>
    /// Interface of class Device
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IDevice"/> is connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if connected; otherwise, <c>false</c>.
        /// </value>
        bool Connected { get; set; }

        /// <summary>
        /// Connects the board
        /// </summary>
        /// <returns></returns>
        bool Connect();

        /// <summary>
        /// Disconnects the board
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Reads the photo cell.
        /// </summary>
        /// <returns></returns>
        bool ReadPhotoCell();

        /// <summary>
        /// Reads the start command.
        /// </summary>
        /// <returns></returns>
        bool ReadStartCommand();
    }
}