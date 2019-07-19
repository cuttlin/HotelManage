using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using 数据访问与类库;

namespace WEB用户访问
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string username = context.Request.Params["username"].ToString();
            string password = MD5Helper.ToMD5(context.Request.Params["password"].ToString());
            if (DBHelper.ExecuteQuery("select * from WebUser where username='" + username + "' and password='" + password + "'").Tables[0].Rows.Count > 0)
            {
                //放一个Cookie来指示是哪名用户登陆了
                HttpCookie cookie = new HttpCookie("login_name", username);
                context.Response.Cookies.Add(cookie);
                context.Response.Redirect("index.aspx");
            }
            else
            {
                context.Response.Redirect("login.aspx?login_msg=false");
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
