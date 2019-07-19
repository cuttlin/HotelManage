using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using 数据访问与类库;
using System.Web.SessionState;

namespace WEB用户访问
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class regist : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string telephone = context.Request.Params["telephone"].ToString();
            string username = context.Request.Params["username"].ToString();
            string password = MD5Helper.ToMD5(context.Request.Params["password"].ToString());
           int i = DBHelper.Execute("insert into WebUser (username,password,telephone) values('" + username + "','" + password + "','" + telephone + "')");
           if (i > 0)
           {
               //context.Response.Write("注册成功！");
              //context.Request["isOk"]= "注册成功";
               context.Response.Redirect("login.aspx?isRegist=ok");
           }
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}
