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
    public partial class ListBindDemo : Page
    {
        public ListBindDemo()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Blog blog = new Blog();
            blog.Posts = new List<String>
            {
                "一步一步学Silverlight 2系列（10）：使用用户控件",
                "一步一步学Silverlight 2系列（9）：使用控件模板",
                "一步一步学Silverlight 2系列（8）：使用样式封装控件观感",
                "一步一步学Silverlight 2系列（7）：全屏模式支持"
            };

            PostList.DataContext = blog;
            //当然我们也可以使用ListBox的ItemsSource属性进行绑定
            //PostList.ItemsSource = blog.Posts;
        }

    }

    public class Blog
    {
        public List<String> Posts { get; set; }
    }
}
