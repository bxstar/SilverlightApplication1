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
    public partial class TreeView使用一 : Page
    {
        private int i = 1;

        public TreeView使用一()
        {
            InitializeComponent();
            //注册事件触发处理

            this.btnCreateNode.Click += new RoutedEventHandler(btnCreateNode_Click);
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        void btnCreateNode_Click(object sender, RoutedEventArgs e)
        {
            if (tvEmployee.SelectedItem != null)
            {
                TreeViewItem tvi = (TreeViewItem)tvEmployee.SelectedItem;//当前选中结点
                TreeViewItem newNode = new TreeViewItem();//新结点
                newNode.Header = "Test" + Convert.ToString(i);
                tvi.Items.Add(newNode);//添加

                tvi.IsExpanded = true;
                i++;
            }
            
        }

    }
}
