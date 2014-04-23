using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightApplication1.Web
{
    /// <summary>
    /// BookHandler 的摘要说明
    /// </summary>
    public class BookHandler : IHttpHandler
    {
        public static readonly string[] PriceList = new string[] { 
            "66.00",
            "78.30",
            "56.50",
            "28.80",
            "77.00"
        };

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(PriceList[Int32.Parse(context.Request.QueryString["No"])]);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}