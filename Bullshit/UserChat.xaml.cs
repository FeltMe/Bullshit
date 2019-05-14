using Bullshit.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для UserChat.xaml
    /// </summary>
    public partial class UserChat : UserControl
    {
        //private const int port = 8080;
        //private const string server = "127.0.0.1";

        public User Currentuser { get; set; }

        public ObservableCollection<ServiceReference1.UserViewClass> UserViews { get; set; } = new ObservableCollection<ServiceReference1.UserViewClass>();
        public dynamic Data { get; set; }

        public UserChat()
        {
            InitializeComponent();
            UserViewChat.ItemsSource = UserViews;
            //AddingUsersToView()
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            ReadMsg(TextToSend.Text);
        }

        private void ReadMsg(string text)
        {
            TextToSend.Clear();
            ChatTextBox.Document.Blocks.Add(new Paragraph(new Run(Currentuser.Login + ": " + text)));
        }

        //public void AddingUsersToView()
        //{
        //    using (ServiceReference1.WcfInterfaceClient client = new WcfInterfaceClient())
        //    {
        //        Data = client.ReturnAllUsersForChat(Currentuser.CurrentProject.Id);
        //    }
        //
        //    foreach (var item in Data as UserViewClass[])
        //    {
        //        UserViews.Add(item);
        //    }
        //}
    }
}
