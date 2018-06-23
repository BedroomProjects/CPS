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
using CameraPingingSystem.Models;

namespace CameraPingingSystem.Views
{
    /// <summary>
    /// Interaction logic for LocalAdminEntryPage.xaml
    /// </summary>
    public partial class LocalAdminEntryPage : Window
    {

        private CPSEntities cpsEntities = null;
        private int _roadNumber;

        public LocalAdminEntryPage(int? roadNumber)
        {
            InitializeComponent();
            this._roadNumber = (int)roadNumber;
            cpsEntities = new CPSEntities();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.roadName.Content = cpsEntities.roads.Where(i => i.ID == _roadNumber).FirstOrDefault().NAME;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CameraCRUD _cameraCRUD = new CameraCRUD();
            _cameraCRUD.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CameraDashboard _cameraDashboard = new CameraDashboard();
            _cameraDashboard.Show();
        }
    }
}
