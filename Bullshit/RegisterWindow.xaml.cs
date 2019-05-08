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
            Reg();
        }
        
        private void Reg()
        {
            RegisterQuery query = new RegisterQuery();
            if(query.AddNewUser(CreateNewUser()))
            {
                MessageBox.Show("Ok!");
            }
            else MessageBox.Show("Ne ok");
        }

        private ServiceReference1.User CreateNewUser()
        {
            ServiceReference1.User user = new ServiceReference1.User
            {
                Login = "11",
                Password = "11",
                Right = false
            };
            return user;
        }
    }
}
