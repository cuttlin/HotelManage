using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using 数据访问与类库;
using System.Text.RegularExpressions;

namespace WEB用户访问
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UserService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.Params.AllKeys.Contains("cancel"))//取消预定方法
            {
                foreach (string item in context.Request.Params.Keys)
                {
                    if (Regex.IsMatch(item, @"^\d{3}$"))
                    {
                        string username = context.Request.Cookies["login_name"].Value;
                        DataSet ds = DBHelper.ExecuteQuery("select * from WebUser where username='" + username + "'");
                        if (DBHelper.Execute("delete from BookInfo where RoomNumber='" + item + "'") > 0
                            && DBHelper.Execute("update RoomInfo set RoomStatus='可供' where RoomNumber='" + item + "'") > 0)
                        {

                        }

                    }
                }
            }
            else if (context.Request.Params.AllKeys.Contains("reserve"))//预定方法
            {

                foreach (string item in context.Request.Params.Keys)
                {
                    if (Regex.IsMatch(item, @"^\d{3}$"))
                    {
                        string username = context.Request.Cookies["login_name"].Value;
                        DataSet ds = DBHelper.ExecuteQuery("select * from WebUser where username='" + username + "'");
                        if (DBHelper.Execute("insert into BookInfo (CustomerName,Phone,CheckInTime,RoomNumber) values('" + username.Trim() + "','" + ds.Tables[0].Rows[0][3].ToString().Trim() + "','" +DateTime.Now.AddDays(1)+ "','" + item + "')") > 0
                            && DBHelper.Execute("update RoomInfo set RoomStatus='预定' where RoomNumber='" + item + "'") > 0)
                        {
                            
                        }

                    }
                    

                }
            }
            //else
            //{
            //    string username = context.Request.Cookies["login_name"].Value;
            //    string msg = context.Request.Params["contact_message"].ToString();

            //    DBHelper.Execute("insert into FeedBack values ('" + username + "','" + msg + "')");
            //}
            context.Response.Redirect("index.aspx");
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
