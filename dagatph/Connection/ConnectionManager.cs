namespace dagatph
{
    internal interface IConnectionManager
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
    }
}