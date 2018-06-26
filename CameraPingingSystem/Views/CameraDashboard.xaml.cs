using CameraPingingSystem.Models;
using CameraPingingSystem.Services;
using System;
using System.Collections.Generic;
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
        int secondsPerPing = 1;
        Array _ipaddresses;
        static object lockObj = new object();
        private int _nFound = 0;
        private int _Found = 0;
        private int timeout = 100;
        List<Task> tasks = new List<Task>();
        public CameraDashboard()
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
            _ipaddresses = cpsEntities.cameras.Select(i => i.IP_ADDRESS).ToArray();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            runContinuously();
        }

        private void runContinuously()
        {
            while (true)
            {
                //RunPingSweep_Async();
                Thread.Sleep(1000 * secondsPerPing);
            }
        }



        //public async void RunPingSweep_Async()
        //{
        //    _Found = 0;

        //    var tasks = new List<Task>();
        //    for (int i = StartIP; i <= StopIP; i++)
        //    {
        //        ip = BaseIP + i.ToString();

        //        System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
        //        var task = PingAndUpdateAsync(p, ip);
        //        tasks.Add(task);
        //    }
        //    await Task.WhenAll(tasks).ContinueWith(t =>
        //    {

        //    });
        //}


        private async Task PingAndUpdateAsync(System.Net.NetworkInformation.Ping ping, string ip)
        {
            var reply = await ping.SendPingAsync(ip, timeout);
            

            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
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



    }
}
