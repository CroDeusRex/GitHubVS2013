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

namespace Domaci1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int SelectedIndex = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LeftButton.Click += new RoutedEventHandler(LeftButton_Click);
            this.RightButton.Click += new RoutedEventHandler(RightButton_Click);
        }

        void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle rectangle = new Rectangle();
            /*var rectangle = new Rectangle();

            rectangle.Width = 80;
            rectangle.Height = 80;
            rectangle.Fill = Brushes.Orange;
            rectangle.Margin = new Thickness(5);*/

            this.RectangleContainer.Children.Add(new Rectangle()
            {
                Width = 80,
                Height = 80,
                Fill = Brushes.Orange,
                Margin = new Thickness(5)
            });
        }

        void RightButton_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle rectangle = new Rectangle();
            /*var rectangle = new Rectangle();

            rectangle.Width = 80;
            rectangle.Height = 80;
            rectangle.Fill = Brushes.Orange;
            rectangle.Margin = new Thickness(5);*/

            this.RectangleContainer2.Children.Add(new Rectangle()
            {
                Height = 40,
                Fill = Brushes.Red,
                Margin = new Thickness(5)
            });
        }

    }
}
