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
        List<Task> tasks = new List<Task>();
        public CameraDashboard()
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
            _ipaddresses = cpsEntities.cameras.Select(i => i.IP_ADDRESS).ToArray();
        }



        private void runContinuously()
        {

            t = new Thread(new ThreadStart(RunPingSweep_Async));
            t.IsBackground = true;
            t.Start();

            //Thread.Sleep(1000 * secondsPerPing);
            //t.Abort();




            //_nFound = 0;
            //_Found = 0;
        }

        //public void RunPinginBackground() {
        //    foreach (var ipaddress in _ipaddresses)
        //    {
        //        Ping p = new Ping();
        //        PingReply reply = p.Send(ipaddress, 100);
        //        if (reply.Status == IPStatus.Success)
        //        {
        //            _Found++;
        //        }
        //        else {
        //            _nFound++;
        //        }

        //    }



        //}

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





        // private async Task<List<PingReply>> PingAsync(string[] ipaddresses)
        //{
        //    Ping pingSender = new Ping();

        //    var tasks = new List<Task>();
        //    foreach (var ipaddress in ipaddresses)
        //    {
        //        tasks.Add(new Ping().SendPingAsync(ipaddress, 2000));
        //    }

        //    var results = await Task.WhenAll(tasks);

        //    return results.ToList();
        //}



    }
}
