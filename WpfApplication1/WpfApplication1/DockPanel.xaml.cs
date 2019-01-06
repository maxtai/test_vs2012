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
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnAddByCode_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dp = new DockPanel();
            dp.Width = double.NaN;
            dp.Height = double.NaN;

            this.Content = dp;

            Rectangle rt1 = new Rectangle();
            rt1.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            rt1.Stroke = new SolidColorBrush(Colors.BlanchedAlmond);
            rt1.Height = 30;
            rt1.SetValue(DockPanel.DockProperty, Dock.Top);
            dp.Children.Add(rt1);

            Rectangle rLeft = new Rectangle();

            rLeft.Fill = new SolidColorBrush(Colors.Gray);

            rLeft.Stroke = new SolidColorBrush(Colors.Gray);

            rLeft.HorizontalAlignment = HorizontalAlignment.Left;

            rLeft.Height = 30;

            rLeft.Width = 30;

            dp.Children.Add(rLeft);

            rLeft.SetValue(DockPanel.DockProperty, Dock.Left);

            Rectangle rBottom = new Rectangle();

            rBottom.Fill = new SolidColorBrush(Colors.Red);

            rBottom.VerticalAlignment = VerticalAlignment.Bottom;

            rBottom.Height = 30;

            dp.Children.Add(rBottom);

            rBottom.SetValue(DockPanel.DockProperty, Dock.Bottom);

        }
    }
}
