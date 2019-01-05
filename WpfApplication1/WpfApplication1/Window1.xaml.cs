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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAddByCode_Click(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            grid.Width = double.NaN;
            grid.Height = double.NaN;
            this.Content = grid;

            ColumnDefinition cd1 = new ColumnDefinition();
            cd1.Width = new GridLength(139);
            grid.ColumnDefinitions.Add(cd1);

            ColumnDefinition cd2 = new ColumnDefinition();
            cd2.Width = new GridLength(1, GridUnitType.Star);
            grid.ColumnDefinitions.Add(cd2);

            ColumnDefinition cd3 = new ColumnDefinition();
            cd3.Width = new GridLength(2, GridUnitType.Star);
            grid.ColumnDefinitions.Add(cd3);

            RowDefinition rd1 = new RowDefinition();
            rd1.Height = new GridLength(61);
            grid.RowDefinitions.Add(rd1);

            //行二

            RowDefinition row2 = new RowDefinition();

            row2.Height = new GridLength(1, GridUnitType.Star);

            grid.RowDefinitions.Add(row2);

            //行三

            RowDefinition row3 = new RowDefinition();

            row3.Height = new GridLength(200);

            grid.RowDefinitions.Add(row3);

            Rectangle rt1 = new Rectangle();
            rt1.Fill = new SolidColorBrush(Colors.Gray);
            rt1.SetValue(Grid.ColumnProperty,0);
            rt1.SetValue(Grid.RowProperty, 0);
            grid.Children.Add(rt1);

            Rectangle rt2 = new Rectangle();
            rt2.Fill = new SolidColorBrush(Colors.Yellow);
            rt2.SetValue(Grid.ColumnProperty,1);
            rt2.SetValue(Grid.RowProperty, 1);
            rt2.SetValue(Grid.RowSpanProperty, 2);
            rt2.SetValue(Grid.ColumnSpanProperty, 2);
            grid.Children.Add(rt2);

        }
    }
}
