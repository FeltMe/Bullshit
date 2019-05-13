using Bullshit.ServiceReference1;
using System;
using System.Collections.Generic;
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
        private const int port = 8080;
        private const string server = "127.0.0.1";

        public User Currentuser { get; set; }

        public UserChat()
        {
            InitializeComponent();
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            ReadMsg(TextToSend.Text);
        }

        private void ReadMsg(string text)
        {
            TextToSend.Clear();
            ChatTextBox.Document.Blocks.Add(new Paragraph(new Run(Currentuser.Login + ": " + text)));
            //SendText(text);
        }

        private void SendText(string text)
        {
            TcpClient client = new TcpClient();
            client.Connect(server, port);

            StringBuilder response = new StringBuilder();
            NetworkStream stream = client.GetStream();

            byte[] data = Encoding.UTF8.GetBytes(text);


            stream.Write(data, 0, data.Length);

            MessageBox.Show(response.ToString());

            stream.Close();
            client.Close();
        }
    }
}
