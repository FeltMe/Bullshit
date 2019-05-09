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
    /// Interaction logic for StrarupUserControl.xaml
    /// </summary>
    public partial class StrarupUserControl : UserControl
    {
        public StrarupUserControl()
        {
            InitializeComponent();
        }

        private void panel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Object"))
            {
                if (e.KeyStates == DragDropKeyStates.ControlKey)
                {
                    e.Effects = DragDropEffects.Copy;
                }
                else
                {
                    e.Effects = DragDropEffects.Move;
                }
            }
        }

        private void panel_Drop(object sender, DragEventArgs e)
        {
            if (e.Handled == false)
            {
                Panel _panel = (Panel)sender;
                UIElement _element = (UIElement)e.Data.GetData("Object");

                if (_panel != null && _element != null)
                {
                    Panel _parent = (Panel)VisualTreeHelper.GetParent(_element);

                    if (_parent != null)
                    {
                        if (e.AllowedEffects.HasFlag(DragDropEffects.Move))
                        {
                            _parent.Children.Remove(_element);
                            _panel.Children.Add(_element);
                            e.Effects = DragDropEffects.Move;
                        }
                    }
                }
            }
        }
    }
}
