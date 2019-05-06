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
            Login();
        }

        private void Login()
        {
            AcceptLoginWCFData datas = new AcceptLoginWCFData();
            datas.CheckIn(UsernameTextBox.Text, UserPasswordBox.Password);
        }
    }
}



