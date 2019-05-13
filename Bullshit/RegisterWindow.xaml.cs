using Bullshit.Classes;
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

namespace Bullshit
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterWindow : MahApps.Metro.Controls.MetroWindow
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            Register();
        }
        
        private void Register()
        {
            RegisterQuery query = new RegisterQuery();

            if(query.AddNewUser(new ServiceReference1.User()))
            {
                MainWindow window = new MainWindow();
                window.ShowDialog();
            }
            else MessageBox.Show("Ne ok");
        }
    }
}
