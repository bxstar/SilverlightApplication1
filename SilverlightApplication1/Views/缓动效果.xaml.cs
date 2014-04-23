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
    public partial class 缓动效果 : Page
    {
        public 缓动效果()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void rect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sb.Begin();
        }

        Boolean IsMouseEnterRunning = false;
        private void rect_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!IsMouseEnterRunning)
            {
                IsMouseEnterRunning = true;
                sb.Begin();
            }
        }

        private void rect_MouseLeave(object sender, MouseEventArgs e)
        {
            IsMouseEnterRunning = false;
            sb.Stop();
        }



    }
}
