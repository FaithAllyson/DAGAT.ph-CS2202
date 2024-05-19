using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Policy;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics;

namespace dagatph
{
    public partial class Form1 : Form
    {
        private IConnectionManager connectionManager;
        private DataParser dataParser = new DataParser();
        private CSVManager csvManager = new CSVManager("Records1.csv");
        private LocationService locationService = new LocationService();
        bool logsShown = false;

        public Form1()
        {
            InitializeComponent();
            connectionManager = new SerialConnectionManager("COM15", 9600);
            trackBar1.Maximum = 140;
            dataGridView1.Visible = false;
            ((SerialConnectionManager)connectionManager).DataReceived += OnDataReceived;
        }

        private void Connect(object sender, EventArgs e)
        {
            if (!connectionManager.IsConnected)
            {
                try
                {
                    connectionManager.Connect();
                    connectionStatus.BackColor = Color.Green;
                    connectButton.Text = "Disconnect";
                    statusText.Text = "Connection Status: Active";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port: " + ex.Message);
                }
            }
            else
            {
                connectionManager.Disconnect();
                connectionStatus.BackColor = Color.Red;
                connectButton.Text = "Connect";
                statusText.Text = "Connection Status: Inactive";
            }
        }

        private void OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            DataModel entry = dataParser.Parse(e.Data);

            if (locationService.LastKnownLocation != null)
            {
                entry.Location = "x: " + locationService.LastKnownLocation.Latitude.ToString() + " y: " + locationService.LastKnownLocation.Longitude.ToString();
            }

            csvManager.AppendDataToCsv(entry);
            this.Invoke(new MethodInvoker(() => DisplayData(entry)));
        }
        private void DisplayData(DataModel entry)
        {
            if (entry.PH < 0)
            {
                trackBar1.Value = 1;
            }
            else if (entry.PH > 14)
            {
                trackBar1.Value = 140;
            }
            else trackBar1.Value = Convert.ToInt32(entry.PH * 10);

            if (locationService.LastKnownLocation != null) 
            {
                xAxis.Text = "X - Axis: " + locationService.LastKnownLocation.Latitude.ToString();
                yAxis.Text = "Y - Axis: " + locationService.LastKnownLocation.Longitude.ToString();
            }
            else
            {
                xAxis.Text = "X - Axis: Location data not available";
                yAxis.Text = "Y - Axis: Location data not available";
            }

            if (entry.PH < 6.5)
            {
                phClassify.Text = "pH Classification: Hazardous";
            }
            else
            {
                phClassify.Text = "pH Classification: Non-Hazardous";
            }
        }

        private async Task initialized()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await initialized();
            string url = string.Format("http://maps.google.com/maps?t=1&q=loc:{0},{1}",
            locationService.LastKnownLocation.Latitude.ToString(), locationService.LastKnownLocation.Longitude.ToString());

            webView21.CoreWebView2.Navigate(url);
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            if (!logsShown)
            {
                dataGridView1.DataSource = csvManager.ReadDataFromCsv();
                logsShown = true;
                dataGridView1.Visible = true;
                logsButton.Text = "Hide Logs";
            }
            else
            {
                dataGridView1.Visible = false;
                logsShown = false;
                logsButton.Text = "Show Logs";
            }
        }
    }
}
