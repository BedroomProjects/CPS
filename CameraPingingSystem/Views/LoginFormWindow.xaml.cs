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
    /// Interaction logic for LoginFormWindow.xaml
    /// </summary>
    public partial class LoginFormWindow : Window
    {

        private CPSEntities cpsEntities = null;
        public LoginFormWindow()
        {
            InitializeComponent();
            cpsEntities = new CPSEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Login Logic
            if (this.usernameTextBox.Text.Length == 0 || this.passwordTextBox.Password.Length == 0)
                MessageBox.Show(messageBoxText: "برجاء ادخال اسم المستخدم و/او كلمة السر", caption: "تسجيل الدخول");


            var user = cpsEntities.users.Where(i => i.USERNAME == this.usernameTextBox.Text).Where(i => i.PASS == this.passwordTextBox.Password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("هذا المستخدم غير موجود بقاعدة البيانات", caption: "تسجيل الدخول");
            }
            else
            {
                if (user.ADMIN_PRIVILEGE == 1) { // Road\Local Admin
                    this.Close(); // Close the current window

                    LocalAdminEntryPage _localAdminEntryPage = new LocalAdminEntryPage(user.ROAD);
                    _localAdminEntryPage.Show();
                }
            }
        }
    }
}
