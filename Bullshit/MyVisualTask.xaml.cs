﻿using System;
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
    /// Логика взаимодействия для MyVisualTask.xaml
    /// </summary>
    public partial class MyVisualTask : UserControl
    {
        public MyVisualTask()
        {
            InitializeComponent();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data = new DataObject();
                data.SetData("Double", MyTask.Height);
                data.SetData("Object", this);

                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnGiveFeedback(e);
            if (e.Effects.HasFlag(DragDropEffects.Copy))
            {
                Mouse.SetCursor(Cursors.Cross);
            }
            else if (e.Effects.HasFlag(DragDropEffects.Move))
            {
                Mouse.SetCursor(Cursors.Pen);
            }
            else
            {
                Mouse.SetCursor(Cursors.No);
            }
            e.Handled = true;
        }

        private void ApplyClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Apply");
            CretedByBox.IsEnabled = false;
            DescriptionBox.IsEnabled = false;
        }

        private void EditClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Edited");
            CretedByBox.IsEnabled = true;
            DescriptionBox.IsEnabled = true;
        }
    }
}
