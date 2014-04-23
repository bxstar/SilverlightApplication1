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
using System.Windows.Interop;

namespace SilverlightApplication1.Views
{
    public partial class FullScreenDemo : Page
    {
        public FullScreenDemo()
        {
            InitializeComponent();
            Application.Current.Host.Content.FullScreenChanged += new EventHandler(Content_FullScreenChanged);
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            Content contentObject = Application.Current.Host.Content;
            contentObject.IsFullScreen = !contentObject.IsFullScreen;
        }

        private void Content_FullScreenChanged(object sender, EventArgs e)
        {
            Content contentObject = Application.Current.Host.Content;
            if (contentObject.IsFullScreen)
            {
                toggleButton.Background = new SolidColorBrush(Colors.Green);
                toggleButton.Content = "切换普通模式";
            }
            else
            {
                toggleButton.Background = new SolidColorBrush(Colors.Red);
                toggleButton.Content = "切换全屏模式";
            }
        }

    }
}
