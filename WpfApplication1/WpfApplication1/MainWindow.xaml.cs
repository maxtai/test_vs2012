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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;


namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.Activated += WindowThd_Activated;

            this.Closing += WindowThd_Closing;

            this.ContentRendered += WindowThd_ContentRendered;

            this.Deactivated += WindowThd_Deactivated;

            this.Loaded += WindowThd_Loaded;

            this.Closed += WindowThd_Closed;

            this.Unloaded += WindowThd_Unloaded;

            this.SourceInitialized += WindowThd_SourceInitialized;

            InitializeComponent();
        }

        private void Modify()
        {
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate()
                {


                    this.lblHello.Content = "欢迎你光临WPF的世界,Dispatcher 同步方法";
                }
            );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StackPanels();
        }

        private void btnThd_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(Modify);

            thread.Start();
        }

        private void btnAppBeginInvoke_Click(object sender, RoutedEventArgs e)
        {
            new Thread(() =>
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                        new Action(()=>
                            {
                                Thread.Sleep(TimeSpan.FromSeconds(1));
                                this.lblHello.Content="欢迎你光临WPF的世界,Dispatcher 异步方法";
                            }
                            ));
                }
                ).Start();
        }

        void WindowThd_SourceInitialized(object sender, EventArgs e)
        {

            Console.WriteLine("1---SourceInitialized！");

        }



        void WindowThd_Unloaded(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("Unloaded！");

        }



        void WindowThd_Closed(object sender, EventArgs e)
        {

            Console.WriteLine("_Closed！");

        }



        void WindowThd_Loaded(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("3---Loaded！");

        }



        void WindowThd_Deactivated(object sender, EventArgs e)
        {

            Console.WriteLine("Deactivated！");

        }



        void WindowThd_ContentRendered(object sender, EventArgs e)
        {

            Console.WriteLine("ContentRendered！");

        }



        void WindowThd_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Console.WriteLine("---Closing！");

        }



        void WindowThd_Activated(object sender, EventArgs e)
        {

            Console.WriteLine("2---Activated！");

        }

        private void btnByCode_Click(object sender, RoutedEventArgs e)
        {
            DisplayCanvas();
        }

        private void DisplayCanvas()
        {
            Canvas canvas = new Canvas();
            this.Content = canvas;
            canvas.Margin = new Thickness(0, 0, 0, 0);
            canvas.Background = new SolidColorBrush(Colors.White);

            //Rectangle
            Rectangle r = new Rectangle();
            r.Fill = new SolidColorBrush(Colors.Blue);
            r.Stroke = new SolidColorBrush(Colors.Red);
            r.Width = 200;
            r.Height = 140;
            r.SetValue(LeftProperty, (double)200);
            r.SetValue(TopProperty, (double)120);
            canvas.Children.Add(r);

            //Ellipse
            Ellipse el = new Ellipse();
            el.Fill = new SolidColorBrush(Colors.BurlyWood);
            el.Stroke = new SolidColorBrush(Colors.BurlyWood);
            el.Width = 240;
            el.Height = 80;
            el.SetValue(Canvas.ZIndexProperty, 1);
            el.SetValue(Canvas.LeftProperty, (double)100);
            el.SetValue(Canvas.TopProperty, (double)80);
            canvas.Children.Add(el);
        }

        private void btnAddByCode_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel wp = new WrapPanel();
            this.Content = wp;
            wp.Margin = new Thickness(0, 0, 0, 0);
            wp.Background = new SolidColorBrush(Colors.White);
            

            TextBlock tb;
            for (int i = 0;i < 10;i++)
            {
                tb = new TextBlock();
                tb.Text = "后台代码添加控件：" + i.ToString();
                tb.Margin = new Thickness(10, 10, 10, 10);
                tb.Width = 160;
                tb.Height = 30;
                wp.Children.Add(tb);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.stackPanel.Orientation = Orientation.Horizontal;
        }

        private void StackPanels()
        {
            StackPanel sp = new StackPanel();
            this.Content = sp;
            sp.Margin = new Thickness(0, 0, 0, 0);
            sp.Background = new SolidColorBrush(Colors.White);
            sp.Orientation = Orientation.Horizontal;
            sp.FlowDirection = FlowDirection.RightToLeft;

            Button btn;
            btn = new Button();
            btn.Content = "Ht1";
            sp.Children.Add(btn);

            btn = new Button();
            btn.Content = "Ht2";
            sp.Children.Add(btn);

            btn = new Button();
            btn.Content = "Ht3";
            sp.Children.Add(btn);


        }

        
    }
}
