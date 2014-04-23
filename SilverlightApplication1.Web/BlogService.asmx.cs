using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SilverlightApplication1.Web
{
    /// <summary>
    /// BlogService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class BlogService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Post[] GetPosts()
        {
            List<Post> posts = new List<Post>()
            {
                new Post{ Id=1, Title="一步一步学Silverlight 2系列（13）：数据与通信之WebRequest", Author="TerryLee" },
                new Post{ Id=2, Title="一步一步学Silverlight 2系列（12）：数据与通信之WebClient", Author="TerryLee" },
                new Post{ Id=3, Title="一步一步学Silverlight 2系列（11）：数据绑定", Author="TerryLee" },
                new Post{ Id=4, Title="一步一步学Silverlight 2系列（10）：使用用户控件", Author="TerryLee" },
                new Post{ Id=5, Title="一步一步学Silverlight 2系列（9）：使用控件模板", Author="TerryLee" },
                new Post{ Id=6, Title="一步一步学Silverlight 2系列（8）：使用样式封装控件观感", Author="TerryLee" }
            };

            return posts.ToArray();
        }
    }

    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
