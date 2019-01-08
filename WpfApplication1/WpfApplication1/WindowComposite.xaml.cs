using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// WindowComposite.xaml 的交互逻辑
    /// </summary>
    public partial class WindowComposite : Window
    {
        public WindowComposite()
        {
            InitializeComponent();
        }

        private void grdTest_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void grdTest_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            label.Content= "hello;";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
