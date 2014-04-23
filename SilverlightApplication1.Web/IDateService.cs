using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace SilverlightApplication1.Web
{
    public class ForumInfo
    {
        public int ForumID { get; set; }
        public int ParendID { get; set; }
        public string ForumName { get; set; }
    }


    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IDateService”。
    [ServiceContract]
    public interface IDateService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<ForumInfo> GetForumData();
    }
}
