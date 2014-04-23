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
    public partial class DataGrid展开 : Page
    {
        public DataGrid展开()
        {
            InitializeComponent();
            dataGrid1.SelectionChanged += new SelectionChangedEventHandler(dg_SelectionChanged);
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (temp != null)
            {
                temp.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
        Grid temp;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DataGridRow dgr = DataGridRow.GetRowContainingElement(sender as Button);
            
            //var i = dgr.GetVisualDescendants().Where(r => (r.GetType().Equals(typeof(Grid)) && (r as Grid).Name == "tb"));
            //temp = i.First() as Grid;
            //temp.Visibility = System.Windows.Visibility.Visible;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<CustomEntity> list = new List<CustomEntity>();
            list.Add(new CustomEntity("a", true, "a_note"));
            list.Add(new CustomEntity("b", false, "b_note"));

            dataGrid1.ItemsSource = list;

        }

    }

    public class CustomEntity
    {
        public CustomEntity(string name, Boolean complete, string note)
        {
            Name = name;
            Complete = complete;
            Note = note;
        }

        public string Name { get; set; }
        public Boolean Complete { get; set; }
        public string Note { get; set; }
    }
}
