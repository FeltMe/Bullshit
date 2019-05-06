using Bullshit.Db;
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
using Bullshit.ServiceReference1;
using Bullshit.Classes;

namespace Bullshit
{
    public partial class LoginWindow : MahApps.Metro.Controls.MetroWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            //WcfInterfaceClient wcf = new WcfInterfaceClient();
            //var s = wcf.Test("Test");
            //var q = wcf.IsLogined(new Bullshit.ServiceReference1.User() { Login = UsernameTextBox.Text });
            //MessageBox.Show(q.ToString());


            Login();
        }

        private void Login()
        {
            AcceptLoginWCFData datas = new AcceptLoginWCFData();
            if (datas.CheckIn(UsernameTextBox.Text, UserPasswordBox.Password))
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Eror while Logi in");
            }
        }
    }
}



