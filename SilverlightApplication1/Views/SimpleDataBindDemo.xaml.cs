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
using SilverlightApplication1.Model;

namespace SilverlightApplication1.Views
{
    public partial class SimpleDataBindDemo : Page
    {
        public SimpleDataBindDemo()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Name = "TerryLee";
            user.Address = "中国 天津";

            lblName.DataContext = user;
            lblAddress.DataContext = user;
        }

    }
}
