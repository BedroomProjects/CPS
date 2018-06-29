using CameraPingingSystem.Models;
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
    /// Interaction logic for CameraDashboardDetailed.xaml
    /// </summary>
    /// 


    public partial class CameraDashboardDetailed : Window
    {

        private CPSEntities cpsEntities = null;
        private int _roadNumber;
        Thread t;
        volatile List<object> _nFound = new List<object>();
        volatile List<object> _Found = new List<object>();
        private int timeout = 100;
        string[] _ipaddresses;
        private int secondsPerPing = 60;
        static object lockObj = new object();
        List<Task> listOfTasks = new List<Task>();

        public CameraDashboardDetailed(int roadNumber)
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
            this._roadNumber = (int)roadNumber;
            _ipaddresses = cpsEntities.cameras.Where(i => i.ROAD == _roadNumber).Select(i => i.IP_ADDRESS).ToArray();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            runContinuously();
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
                var lisfOfTasks = new List<Task>();
                for (int i = 0; i < _ipaddresses.Length; i++)
                {
                    Ping p = new Ping();
                    var task = PingAndUpdateAsync(p, _ipaddresses[i]);
                    listOfTasks.Add(task);
                }
                await Task.WhenAll(listOfTasks).ContinueWith(t =>
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        notWorkingCamerasDataGrid.DataContext = _nFound.ToList();
                        WorkingCamerasDataGrid.DataContext = _Found.ToList();
                        timeLabel.Content = DateTime.Now.ToString("h:mm:ss tt");
                    });

                });
                Thread.Sleep(1000 * secondsPerPing);
                _nFound.Clear();
                _Found.Clear();
                listOfTasks.Clear();
                this.Dispatcher.Invoke(() =>
                {
                    notWorkingCamerasDataGrid.Items.Clear();
                    WorkingCamerasDataGrid.Items.Clear();
                });
            }
        }
        private async Task PingAndUpdateAsync(Ping ping, string ip)
        {
            var reply = await ping.SendPingAsync(ip, timeout);

            if (reply.Status == IPStatus.Success)
            {
                lock (lockObj)
                {
                    var _camera = cpsEntities.cameras.Where(i => i.ROAD == _roadNumber).Select(i => new camera { ID = i.ID, IP_ADDRESS = i.IP_ADDRESS, ROAD = i.ROAD, SECTOR = i.SECTOR, GATE = i.GATE, BOOTH = i.BOOTH, LANE = i.LANE });
                    _Found.Add(_camera);
                }
            }
            else
            {
                lock (lockObj)
                {
                    var _camera = cpsEntities.cameras.Where(i => i.ROAD == _roadNumber).Select(i => new camera { ID = i.ID, IP_ADDRESS = i.IP_ADDRESS, ROAD = i.ROAD, SECTOR = i.SECTOR, GATE = i.GATE, BOOTH = i.BOOTH, LANE = i.LANE });
                    _nFound.Add(_camera);
                }

            }
        }
    }
}
