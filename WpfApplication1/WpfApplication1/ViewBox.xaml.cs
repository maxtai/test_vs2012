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
    /// Window3.xaml 的交互逻辑
    /// </summary>
    public partial class Window3 : Window
    {
        List<StretchClass> stretch = new List<StretchClass>();
        List<StretchDirectionClass> stretchdirectionclass = new List<StretchDirectionClass>();

        public Window3()
        {
            InitializeComponent();
        }

        private void cbStretch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbStretch.SelectedIndex < 0)
                return;

            //this.viewBoxTest.Stretch = (cbStretch.SelectedItem as StretchClass).stretchMode;
            this.viewBoxTest.Stretch = ((StretchClass)cbStretch.SelectedItem).stretchMode;
        }

        private void cbStretchDirection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbStretchDirection.SelectedIndex < 0)
                return;

            //this.viewBoxTest.Stretch = (cbStretch.SelectedItem as StretchClass).stretchMode;
            this.viewBoxTest.StretchDirection = ((StretchDirectionClass)cbStretchDirection.SelectedItem).stretchDirectionMode;
        }

        private void Bindcb()
        {
            //cbStretch

            stretch.Add(new StretchClass() { stretchname = "Fill", stretchMode = Stretch.Fill });
            stretch.Add(new StretchClass() { stretchname = "Uniform", stretchMode = Stretch.Uniform });
            stretch.Add(new StretchClass() { stretchname = "UniformToFill", stretchMode = Stretch.UniformToFill });
            stretch.Add(new StretchClass() { stretchname = "None", stretchMode = Stretch.None });

            cbStretch.ItemsSource = stretch;
            cbStretch.DisplayMemberPath = "stretchname";

            //cbStretchDirection

            stretchdirectionclass.Add(new StretchDirectionClass() { stretchDirectionName = "Both", stretchDirectionMode = StretchDirection.Both });
            stretchdirectionclass.Add(new StretchDirectionClass() { stretchDirectionName = "DownOnly", stretchDirectionMode = StretchDirection.DownOnly });
            stretchdirectionclass.Add(new StretchDirectionClass() { stretchDirectionName = "UpOnly", stretchDirectionMode = StretchDirection.UpOnly });


            cbStretchDirection.ItemsSource = stretchdirectionclass;
            cbStretchDirection.DisplayMemberPath = "stretchDirectionName";

        }

        public class StretchClass
        {
            public string stretchname { get; set; }
            public Stretch stretchMode { get; set; }
        }

        public class StretchDirectionClass
        {
            public string stretchDirectionName { get; set; }
            public StretchDirection stretchDirectionMode { get; set; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Bindcb();
            cbStretch.SelectedIndex = 0;
            cbStretchDirection.SelectedIndex = 0;

        }
    }
}
