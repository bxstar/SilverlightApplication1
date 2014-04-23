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
    public partial class 绑定到带复选框列表 : Page
    {
        List<Seat> listSeat = null;

        public 绑定到带复选框列表()
        {
            InitializeComponent();
            btnOk.Click += new RoutedEventHandler(btnOk_Click);
        }

        void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //循环读取List的数据源
            //foreach(Seat seat in listSeat)
            //{
            //    if (seat.IsSelected)
            //        MessageBox.Show(seat.SeatName);
            //}

            foreach(ListBoxItem item in PostList.Items)
            {
                //TextBlock tb = GetChildByName<TextBlock>(item, "test");
                //tb.Text = "changed";
                //TextBlock tb = (TextBlock)this.GetTemplateChild("test");
                //tb.Text = "changed";
            }
        }

        public T GetChildByName<T>(DependencyObject parent, string name) where T : class
        {
            T obj = RecGetChildByName<T>(parent, name) as T;
            if (obj == null) throw new Exception("could find control of name as child");
            return obj;
        }

        private DependencyObject RecGetChildByName<T>(DependencyObject parent,
                     string name)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                Control childControl = child as Control;
                if (childControl != null)
                {
                    if (childControl.Name == name) return child;
                }

                if (VisualTreeHelper.GetChildrenCount(child) > 0)
                    return RecGetChildByName<T>(child, name);
            }

            return null;
        }


        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listSeat = new List<Seat>
            {
                new Seat("D1"),
                new Seat("D2"),
                new Seat(true,"D3"),
                new Seat("D4")
            };

            PostList.ItemsSource = listSeat;
        }

    }

    public class Seat
    {
        public Seat(Boolean isSelected, string seatName)
        {
            IsSelected = isSelected;
            SeatName = seatName;
        }

        public Seat(string seatName)
        {
            IsSelected = false;
            SeatName = seatName;
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        public Boolean IsSelected { get; set; }


        public string SeatName { get; set; }
    }

}
