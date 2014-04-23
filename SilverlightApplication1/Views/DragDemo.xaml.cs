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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightApplication1.Views
{
    public partial class DragDemo : Page
    {
        public DragDemo()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        bool trackingMouseMove = false;
        Point mousePosition;

        /// <summary>
        /// 开始拖放操作，实现MouseLeftButtonDown事件处理程序，用两个全局变量来记录当前鼠标的位置和鼠标是否保持移动。
        /// </summary>
        void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            mousePosition = e.GetPosition(null);
            trackingMouseMove = true;
            if (null != element)
            {
                element.CaptureMouse();
                element.Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// 移动对象，实现MouseMove事件处理程序，计算元素的位置并更新，同时更新鼠标的位置。
        /// </summary>
        void OnMouseMove(object sender, MouseEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (trackingMouseMove)
            {
                double deltaV = e.GetPosition(null).Y - mousePosition.Y;
                double deltaH = e.GetPosition(null).X - mousePosition.X;
                double newTop = deltaV + (double)element.GetValue(Canvas.TopProperty);
                double newLeft = deltaH + (double)element.GetValue(Canvas.LeftProperty);

                element.SetValue(Canvas.TopProperty, newTop);
                element.SetValue(Canvas.LeftProperty, newLeft);

                mousePosition = e.GetPosition(null);
            }
        }

        /// <summary>
        /// 完成拖放操作，实现MouseLeftButtonUp事件处理程序。
        /// </summary>
        void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            trackingMouseMove = false;
            element.ReleaseMouseCapture();

            mousePosition.X = mousePosition.Y = 0;
            element.Cursor = null;
        }
    }
}
