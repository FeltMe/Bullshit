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
using System.ServiceModel;
using Bullshit.ServiceReference1;

namespace Bullshit
{
    public partial class LoginWindow : MahApps.Metro.Controls.MetroWindow
    {
        public int Key { get; set; } = 1;

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
            User loginer = new User()
            {
                Login = Encryption(UsernameTextBox.Text, Key),
                Password = Encryption(UserPasswordBox.Password, Key)
            };

            using (WcfInterfaceClient wcf = new WcfInterfaceClient())
            {
                if (wcf.IsLogined(loginer as object))
                {
                    this.Visibility = Visibility.Hidden;
                    MainWindow main = new MainWindow();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter data not corect");
                }
            }

        }

        private string Encryption(string data, int key) //Encryption password
        {
            string newdata = "";
            foreach (char ch in data.ToCharArray())
            {
                char tmp = (char)(ch ^ key);
                newdata += tmp;
            }
            return newdata;
        }
    }
}



