using System;
using System.IO.Ports;

namespace dagatph
{
    internal class SerialConnectionManager : IConnectionManager
    {
        private SerialPort serialPort;
        private bool connected;

        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public SerialConnectionManager(string portName, int baudRate)
        {
            serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        public void Connect()
        {
            if (!connected)
            {
                serialPort.Open();
                connected = true;
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                serialPort.Close();
                connected = false;
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();

            OnDataReceived(new DataReceivedEventArgs(data));
        }
        public bool IsConnected
        {
            get { return connected; }
        }

        protected virtual void OnDataReceived(DataReceivedEventArgs e)
        {
            DataReceived?.Invoke(this, e);
        }
    }

    internal class DataReceivedEventArgs : EventArgs
    {
        public string Data { get; }

        public DataReceivedEventArgs(string data)
        {
            Data = data;
        }
    }
}