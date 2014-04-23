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
using SilverlightApplication1.BlogService;

namespace SilverlightApplication1.Views
{
    public partial class AsmxDemo : Page
    {
        public AsmxDemo()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            BlogServiceSoapClient client = new BlogServiceSoapClient();
            client.GetPostsCompleted += new EventHandler<GetPostsCompletedEventArgs>(client_GetPostsCompleted);
            client.GetPostsAsync();
        }

        void client_GetPostsCompleted(object sender, GetPostsCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Posts.ItemsSource = e.Result;
            }
        }
    }
}
