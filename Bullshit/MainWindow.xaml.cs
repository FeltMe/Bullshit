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

    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        private UserControl CurrentUserControl = new UserControl(); 

        public MainWindow()
        {
            InitializeComponent();
            DefaultuserControl();
        }

        private void ChatOpenClick(object sender, RoutedEventArgs e)
        {
            MyChatOpen(CurrentUserControl);   
        }

        private void DefaultuserControl()
        {
            StrarupUserControl userControl = new StrarupUserControl();
            Grid.SetRow(userControl, 1);
            Grid.SetColumn(userControl, 1);
            Grid.SetRowSpan(userControl, 7);
            MyMainGrid.Children.Add(userControl);
            CurrentUserControl = userControl;
        }

        private void MyChatOpen(UserControl control)
        {
            MyMainGrid.Children.Remove(control);
            UserChat userControl = new UserChat();
            Grid.SetRow(userControl, 1);
            Grid.SetColumn(userControl, 1);
            Grid.SetRowSpan(userControl, 7);
            MyMainGrid.Children.Add(userControl);
            CurrentUserControl = userControl;
        }

        private void TeamTasksClick(object sender, RoutedEventArgs e)
        {
            TaskOpen(CurrentUserControl);
        }

        private void TaskOpen(UserControl control)
        {
            MyMainGrid.Children.Remove(control);
            StrarupUserControl userControl = new StrarupUserControl();
            Grid.SetRow(userControl, 1);
            Grid.SetColumn(userControl, 1);
            Grid.SetRowSpan(userControl, 7);
            MyMainGrid.Children.Add(userControl);
            CurrentUserControl = userControl;
        }
    }
}