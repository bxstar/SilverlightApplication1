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
    public partial class 飞机变换 : Page
    {
        public 飞机变换()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnLarge_Click(object sender, RoutedEventArgs e)
        {
            f1.Enlarge();
        }

        private void btnSmall_Click(object sender, RoutedEventArgs e)
        {
            f1.EnSmall();
        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            f1.ChangeColor();
        }

    }
}
