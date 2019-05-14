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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bullshit
{
    /// <summary>
    /// Логика взаимодействия для CoonectToProject.xaml
    /// </summary>
    public partial class CoonectToProject : UserControl
    {
        public CoonectToProject()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.WcfInterfaceClient client = new ServiceReference1.WcfInterfaceClient();
            ServiceReference1.User user = new ServiceReference1.User()
            {
                Login = "q",
                Password = "q",
                CurrentProject = client.ReturnProjectWithCurrentId(1),
                Gmail = "q",
                Right = false,
                
            };
        }
    }
}
