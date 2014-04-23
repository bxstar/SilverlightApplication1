using System;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace SilverlightApplication1.UC
{
    public class Flight : Control
    {
        public Flight()
        {
            
        }

        /// <summary>
        /// 等比放大
        /// </summary>
        public void Enlarge()
        {
            double increaseStep = 30.0;
            double ratio = Height / Width;
            this.Width = this.Width + increaseStep;
            this.Height = this.Height + ratio * increaseStep;
        }

        /// <summary>
        /// 等比缩小
        /// </summary>
        public void EnSmall()
        {
            double increaseStep = 30.0;
            double ratio = Height / Width;
            this.Width = this.Width - increaseStep;
            this.Height = this.Height - ratio * increaseStep;
        }

        /// <summary>
        /// 改变颜色
        /// </summary>
        public void ChangeColor()
        {
            DependencyObject childBorder = VisualTreeHelper.GetChild(this, 0);
            DependencyObject childContentPresenter = VisualTreeHelper.GetChild(childBorder, 0);
            DependencyObject childPolygon = VisualTreeHelper.GetChild(childContentPresenter, 0);

            Polygon poly = (Polygon)childPolygon;

            if (((SolidColorBrush)poly.Stroke).Color == Colors.Red)
            {
                poly.Stroke = poly.Fill = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                poly.Stroke = poly.Fill = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
