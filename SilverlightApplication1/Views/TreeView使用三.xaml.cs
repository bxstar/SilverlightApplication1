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
    public partial class TreeView使用三 : Page
    {
        public TreeView使用三()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //处理Checkbox点击事件
        private void ItemCheckbox_Click(object sender, RoutedEventArgs e)
        {

            TreeViewItem item = GetParentTreeViewItem((DependencyObject)sender);
            if (item != null)
            {
                Feature feature = item.DataContext as Feature;
                if (feature != null)
                {
                    UpdateChildrenCheckedState(feature);//更新子组件选中状态
                    UpdateParentCheckedState(item);//更新父组件选中状态
                }
            }
        }

        //静态方法：获取父级TreeViewItem
        private static TreeViewItem GetParentTreeViewItem(DependencyObject item)
        {
            if (item != null)
            {
                DependencyObject parent = VisualTreeHelper.GetParent(item);//获取依赖的父级对象
                TreeViewItem parentTreeViewItem = parent as TreeViewItem;//对象转换
                return (parentTreeViewItem != null) ? parentTreeViewItem : GetParentTreeViewItem(parent);//如果父级TreeViewItem存在则返回，否则就递归寻找
            }
            //找不到父对象，返回父对象不存在
            return null;
        }

        //静态方法：更新父级TreeViewItem选中状态
        private static void UpdateParentCheckedState(TreeViewItem item)
        {
            TreeViewItem parent = GetParentTreeViewItem(item);//获取父级TreeViewItem
            if (parent != null)//如果父对象不为空，为空则退出递归寻找
            {
                Feature feature = parent.DataContext as Feature;//对象转换
                if (feature != null)//如果对象不为空
                {
                    //更新子组件的选中状态
                    bool? childrenCheckedState = feature.Subcomponents.First<Feature>().ShouldInstall;//得到第一个子组件的选中状态
                    for (int i = 1; i < feature.Subcomponents.Count(); i++)
                    {
                        if (childrenCheckedState != feature.Subcomponents[i].ShouldInstall)
                        {
                            childrenCheckedState = null;
                            break;
                        }
                    }
                    //将父组件的选中状态与子组件置为相同
                    feature.ShouldInstall = childrenCheckedState;
                    //继续递归搜索.
                    UpdateParentCheckedState(parent);
                }
            }
        }

        //用递归更新子组件的选中状态
        private static void UpdateChildrenCheckedState(Feature feature)
        {
            if (feature.ShouldInstall.HasValue)
            {
                foreach (Feature childFeature in feature.Subcomponents)
                {
                    childFeature.ShouldInstall = feature.ShouldInstall;
                    if (childFeature.Subcomponents.Count() > 0)
                    {
                        UpdateChildrenCheckedState(childFeature);
                    }
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnUseCodeData_Click(object sender, RoutedEventArgs e)
        {
            ObjectCollection o = new ObjectCollection();
            Feature test1 = new Feature("主测试1", "主测试1提示");
            test1.Subcomponents.Add(new Feature("子测试1", "子测试提示1"));

            o.Add(test1);
            o.Add(new Feature("测试2", "测试提示2"));
            tv1.ItemsSource = o;

            //tv1.Items.Add(
        }

        private void btnUseCodeData2_Click(object sender, RoutedEventArgs e)
        {
            //if (tvEmployee.SelectedItem != null)
            //{
            //    TreeViewItem tvi = (TreeViewItem)tvEmployee.SelectedItem;//当前选中结点
            //    TreeViewItem newNode = new TreeViewItem();//新结点
            //    newNode.Header = "Test" + Convert.ToString(i);
            //    tvi.Items.Add(newNode);//添加

            //    tvi.IsExpanded = true;
            //    i++;
            //}


            TreeViewItem newNode = new TreeViewItem();//新结点
            newNode.Header = "Test" + Convert.ToString("1");
            //newNode.Template = "{StaticResource NodeTemplate}";

            tv2.Items.Add(newNode);//添加
        }
    }
}
