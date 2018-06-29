using CameraPingingSystem.Models;
using CameraPingingSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CameraPingingSystem.Views
{
    /// <summary>
    /// Interaction logic for CameraDashboard.xaml
    /// </summary>
    public partial class CameraDashboard : Window
    {

        private CPSEntities cpsEntities = null;
        Thread t;
        int secondsPerPing = 60;
        string[] _ipaddresses;
        static object lockObj = new object();
        private volatile int _nFound = 0;
        private volatile int _Found = 0;
        private int timeout = 100;
        private int _roadNumber;
        List<Task> tasks = new List<Task>();
        public CameraDashboard(int roadNumber)
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
            this._roadNumber = (int)roadNumber;
            _ipaddresses = cpsEntities.cameras.Where(i => i.ROAD == _roadNumber).Select(i => i.IP_ADDRESS).ToArray();
        }



        private void runContinuously()
        {

            t = new Thread(new ThreadStart(RunPingSweep_Async));
            t.IsBackground = true;
            t.Start();


        }



        public async void RunPingSweep_Async()
        {
            while (true)
            {
                _Found = 0;

                var tasks = new List<Task>();
                for (int i = 0; i < _ipaddresses.Length; i++)
                {
                    Ping p = new Ping();
                    var task = PingAndUpdateAsync(p, _ipaddresses[i]);
                    tasks.Add(task);
                }
                await Task.WhenAll(tasks).ContinueWith(t =>
                {
                    this.Dispatcher.Invoke(() =>
     {
         CameraUpLabel.Content = _Found;
         CameraDownLabel.Content = _nFound;
         timeLabel.Content = DateTime.Now.ToString("h:mm:ss tt");
     });

                });

                Thread.Sleep(1000 * secondsPerPing);

            }
        }




        private async Task PingAndUpdateAsync(System.Net.NetworkInformation.Ping ping, string ip)
        {
            var reply = await ping.SendPingAsync(ip, timeout);


            if (reply.Status == IPStatus.Success)
            {
                lock (lockObj)
                {
                    _Found++;
                }
            }
            else
            {
                lock (lockObj)
                {
                    _nFound++;
                }

            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            runContinuously();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CameraDashboardDetailed cdd = new CameraDashboardDetailed(_roadNumber);
            cdd.Show();
        }






    }
}
