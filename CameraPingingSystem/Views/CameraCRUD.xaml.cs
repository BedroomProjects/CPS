using CameraPingingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;


namespace CameraPingingSystem.Views
{
    /// <summary>
    /// Interaction logic for CameraCRUD.xaml
    /// </summary>
    public partial class CameraCRUD : Window
    {

        private CPSEntities cpsEntities = null;
        private int _roadNumber;

        public CameraCRUD(int roadNumber)
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
            this._roadNumber = (int)roadNumber;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LaneComboBox.ItemsSource = cpsEntities.lanes.Select(i => i.NAME).ToList(); // populate road combobox
            this.BoothComboBox.ItemsSource = cpsEntities.booths.Select(i => i.NAME).ToList(); // populate booth combobox
            //this.GateComboBox.ItemsSource = cpsEntities.gates.Select(i => i.NAME).ToList(); // populate gate combobox
            this.GateComboBox.ItemsSource = cpsEntities.gates.SqlQuery("select * from gate where sector in (select id from sector where road = "+ _roadNumber +")").Select(i => i.NAME).ToList();
            //this.SectorComboBox.ItemsSource = cpsEntities.sectors.Select(i => i.NAME).ToList(); // populate sector combobox
            this.SectorComboBox.ItemsSource = cpsEntities.sectors.SqlQuery("select * from sector where road =" +_roadNumber).Select(i => i.NAME).ToList();
            this.RoadComboBox.ItemsSource = cpsEntities.roads.Where(i => i.ID == _roadNumber).Select(i => i.NAME).ToList();
            //this.RoadComboBox.IsEnabled = false;

            var _cameras = cpsEntities.cameras.Include(o => o.sector1).Include(g => g.road1).Include(m => m.lane1).Include(z => z.booth1).Where(i => i.ROAD == _roadNumber).Select(i => new CameraWrapper { ID = i.ID, IP_ADDRESS = i.IP_ADDRESS, ROAD = i.road1.NAME, SECTOR =  i.sector1.NAME, GATE = i.gate1.NAME, BOOTH = i.booth1.NAME, LANE = i.lane1.NAME  }).ToList();
            dataGridView.ItemsSource = _cameras;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ipAddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("برجاء ادخال الـ IP Address الخاص بالكاميرا");
            }
            else
            {
                camera cameraObj = new camera();
                cameraObj.IP_ADDRESS = this.ipAddressTextBox.Text;
                cameraObj.BOOTH = cpsEntities.booths.Where(i => i.NAME == this.BoothComboBox.Text).FirstOrDefault().ID;
                cameraObj.GATE = cpsEntities.gates.Where(i => i.NAME == this.GateComboBox.Text).FirstOrDefault().ID;
                cameraObj.SECTOR = cpsEntities.sectors.Where(i => i.NAME == this.SectorComboBox.Text).FirstOrDefault().ID;
                cameraObj.LANE = cpsEntities.lanes.Where(i => i.NAME == this.LaneComboBox.Text).FirstOrDefault().ID;
                cameraObj.ROAD = _roadNumber;
                cpsEntities.cameras.Add(cameraObj);
                cpsEntities.SaveChanges();
                updateGridView();
                this.hiddenLabel.Content = "";
                this.ipAddressTextBox.Text = "";
                this.LaneComboBox.Text = "";
                this.BoothComboBox.Text = "";
                this.GateComboBox.Text = "";
                this.SectorComboBox.Text = "";
                this.RoadComboBox.Text = "";
            }
        }

        private void updateGridView()
        {
            var _cameras = cpsEntities.cameras.Include(o => o.sector1).Include(g => g.road1).Include(m => m.lane1).Include(z => z.booth1).Where(i => i.ROAD == _roadNumber).Select(i => new CameraWrapper { ID = i.ID, IP_ADDRESS = i.IP_ADDRESS, ROAD = i.road1.NAME, SECTOR = i.sector1.NAME, GATE = i.gate1.NAME, BOOTH = i.booth1.NAME, LANE = i.lane1.NAME }).ToList();
            dataGridView.ItemsSource = _cameras;
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {

            saveButton.IsEnabled = false;
            // DataGridRow row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            object item = dataGridView.SelectedItem;
            string ID = (dataGridView.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            string IPADDRESS = (dataGridView.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            string GATE = (dataGridView.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            string LANE = (dataGridView.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            string BOOTH = (dataGridView.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            string SECTOR = (dataGridView.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
            string ROAD = (dataGridView.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;

            //string _laneValue = cpsEntities.lanes.Where(i => i.ID == LANE).FirstOrDefault().NAME;
            //string _boothValue = cpsEntities.booths.Where(i => i.ID == BOOTH).FirstOrDefault().NAME;
            //string _gateValue = cpsEntities.gates.Where(i => i.ID == GATE).FirstOrDefault().NAME;
            //string _sectorValue = cpsEntities.sectors.Where(i => i.ID == SECTOR).FirstOrDefault().NAME;
            //string _roadValue = cpsEntities.roads.Where(i => i.ID == ROAD).FirstOrDefault().NAME;


            this.hiddenLabel.Content = ID;
            this.ipAddressTextBox.Text = IPADDRESS;
            this.LaneComboBox.Text = LANE;
            this.BoothComboBox.Text = BOOTH;
            this.GateComboBox.Text = GATE;
            this.SectorComboBox.Text = SECTOR;
            this.RoadComboBox.Text = ROAD;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.ipAddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("برجاء ادخال الـ IP Address الخاص بالكاميرا");
            }
            else
            {
                int ID = int.Parse(this.hiddenLabel.Content.ToString());
                camera _camera = cpsEntities.cameras.Where(x => x.ID == ID).Select(x => x).FirstOrDefault();
                _camera.ID = ID;
                _camera.IP_ADDRESS = this.ipAddressTextBox.Text;
                _camera.BOOTH = cpsEntities.booths.Where(i => i.NAME == this.BoothComboBox.Text).FirstOrDefault().ID;
                _camera.GATE = cpsEntities.gates.Where(i => i.NAME == this.GateComboBox.Text).FirstOrDefault().ID;
                _camera.SECTOR = cpsEntities.sectors.Where(i => i.NAME == this.SectorComboBox.Text).FirstOrDefault().ID;
                _camera.LANE = cpsEntities.lanes.Where(i => i.NAME == this.LaneComboBox.Text).FirstOrDefault().ID;
                _camera.ROAD = cpsEntities.roads.Where(i => i.NAME == this.RoadComboBox.Text).FirstOrDefault().ID;
                cpsEntities.SaveChanges();
                updateGridView();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (this.hiddenLabel.Content.ToString() != "")
            {
                int ID = int.Parse(this.hiddenLabel.Content.ToString());
                camera _camera = cpsEntities.cameras.Where(i => i.ID == ID).First();
                cpsEntities.cameras.Remove(_camera);
                cpsEntities.SaveChanges();
                updateGridView();

                this.hiddenLabel.Content = "";
                this.ipAddressTextBox.Text = "";
                this.LaneComboBox.Text = "";
                this.BoothComboBox.Text = "";
                this.GateComboBox.Text = "";
                this.SectorComboBox.Text = "";
                this.RoadComboBox.Text = "";

                saveButton.IsEnabled = true;
            }
        }

      

    }
}
