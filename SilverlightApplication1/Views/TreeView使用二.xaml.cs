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
using System.Collections.ObjectModel;
using SilverlightApplication1.ServiceReference1;

namespace SilverlightApplication1.Views
{
    public partial class TreeView使用二 : Page
    {
        DateServiceClient client = new DateServiceClient();
        ObservableCollection<ForumInfo> forumList = new ObservableCollection<ForumInfo>();


        public TreeView使用二()
        {
            InitializeComponent();

            client.GetForumDataCompleted += new EventHandler<GetForumDataCompletedEventArgs>(client_GetForumDataCompleted);
            client.GetForumDataAsync();

            TreeOfLife.ItemContainerStyle = this.Resources["RedItemStyle"] as Style;
        }

        void client_GetForumDataCompleted(object sender, GetForumDataCompletedEventArgs e)
        {
            try
            {
                forumList = e.Result;
                AddTreeNode(0, null);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void AddTreeNode(int parentID, TreeViewItem treeViewItem)
        {
            List<ForumInfo> result = (from forumInfo in forumList
                                      where forumInfo.ParendID == parentID
                                      select forumInfo).ToList<ForumInfo>();

            if (result.Count > 0)
            {
                foreach (ForumInfo foruminfo in result)
                {
                    TreeViewItem objTreeNode = new TreeViewItem();
                    objTreeNode.Header = foruminfo.ForumName;
                    objTreeNode.DataContext = foruminfo;

                    //此样式将会添加的所有叶子结点上
                    objTreeNode.ItemContainerStyle = this.Resources["RedItemStyle"] as Style;

                    //添加根节点
                    if (treeViewItem == null)
                    {
                        TreeOfLife.Items.Add(objTreeNode);
                    }
                    else
                    {
                        treeViewItem.Items.Add(objTreeNode);
                    }
                    AddTreeNode(foruminfo.ForumID, objTreeNode);
                }
            }
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
