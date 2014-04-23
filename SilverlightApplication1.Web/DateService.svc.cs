using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace SilverlightApplication1.Web
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“DateService”。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DateService : IDateService
    {
        public void DoWork()
        {

        }


        public List<ForumInfo> GetForumData()
        {
            List<ForumInfo> forumList = new List<ForumInfo>();
            forumList.Add(new ForumInfo() { ForumID = 1, ParendID = 0, ForumName = "笔记本版块" });
            forumList.Add(new ForumInfo() { ForumID = 2, ParendID = 0, ForumName = "台式机版块" });

            forumList.Add(new ForumInfo() { ForumID = 3, ParendID = 1, ForumName = "Dell笔记本" });
            forumList.Add(new ForumInfo() { ForumID = 4, ParendID = 1, ForumName = "IBM笔记本" });
            forumList.Add(new ForumInfo() { ForumID = 5, ParendID = 4, ForumName = "IBM-T系列" });
            forumList.Add(new ForumInfo() { ForumID = 6, ParendID = 4, ForumName = "IBM-R系列" });

            forumList.Add(new ForumInfo() { ForumID = 7, ParendID = 2, ForumName = "联想台式机" });
            forumList.Add(new ForumInfo() { ForumID = 8, ParendID = 2, ForumName = "方正台式机" });
            forumList.Add(new ForumInfo() { ForumID = 9, ParendID = 2, ForumName = "HP台式机" });
            forumList.Add(new ForumInfo() { ForumID = 10, ParendID = 7, ForumName = "联想家悦H系列" });
            forumList.Add(new ForumInfo() { ForumID = 11, ParendID = 7, ForumName = "联想IdeaCentre系列" });

            return forumList;
        }

    }
}
