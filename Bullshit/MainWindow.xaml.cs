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
        private CanbanControle canban = new CanbanControle();
        private UserChat chat = new UserChat();
        private const int Grid_row = 1;
        private const int Grid_col = 1;
        private const int Grid_row_span = 7;

        public MainWindow()
        {
            InitializeComponent();
            AddComponentToWokSpace(canban, Visibility.Visible);
            AddComponentToWokSpace(chat, Visibility.Hidden);
        }

        private void AddComponentToWokSpace(UserControl control, Visibility visibility)
        {
            control.Visibility = visibility;
            Grid.SetRow(control, Grid_row);
            Grid.SetColumn(control, Grid_col);
            Grid.SetRowSpan(control, Grid_row_span);
            MyMainGrid.Children.Add(control);
        }

        private void TeamTasksClick(object sender, RoutedEventArgs e)
        {
            Visible(canban, chat);
        }

        private void ChatOpenClick(object sender, RoutedEventArgs e)
        {
            Visible(chat, canban);
        }

        private void Visible(UserControl ToVisible, UserControl ToHide)
        {
            ToVisible.Visibility = Visibility.Visible;
            ToHide.Visibility = Visibility.Hidden;
        }
    }
}