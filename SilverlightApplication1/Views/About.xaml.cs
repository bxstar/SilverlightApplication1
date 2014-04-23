using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();

            ellipse1.MouseEnter += new MouseEventHandler(OnMouseEnter);
            ellipse1.MouseLeave += new MouseEventHandler(OnMouseLeave);
            ellipse2.MouseEnter += new MouseEventHandler(OnMouseEnter);
            ellipse2.MouseLeave += new MouseEventHandler(OnMouseLeave);
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void AlphaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            Color color = Color.FromArgb((byte)AlphaSlider.Value, (byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            PreviewColor.Fill = new SolidColorBrush(color);
            HexColor.Text = color.ToString();
        }

        void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Yellow);
        }
        void OnMouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            ell.Fill = new SolidColorBrush(Colors.Green);
        }
    }
}