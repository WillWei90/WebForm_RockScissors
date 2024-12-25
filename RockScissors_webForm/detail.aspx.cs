using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////練習題,帳號密碼登入
            //if (!IsPostBack) { }
            //else
            //{
            //    var user = Request.Form["user"];
            //    var password = Request.Form["password"];
            //    if (user.Equals("lccnet") && password.Equals("123456"))
            //    //if (String.Equals(user,"lccnet") && String.Equals(password,"123456"))
            //    {
            //        Response.Redirect("https://www.google.com.tw");
            //    }
            //    else
            //    {
            //        Response.Redirect("https://www.yahoo.com.tw");
            //    }
            //}

            try
            {
                var user = Request.Form["user"];
                var password = Request.Form["password"];
                if (user.Equals("lccnet") && password.Equals("123456"))
                //if (String.Equals(user,"lccnet") && String.Equals(password,"123456"))
                {
                    Response.Redirect("https://www.google.com.tw");
                }
                else
                {
                    Response.Redirect("https://www.yahoo.com.tw");
                }
            }
            catch
            {

            }
        }
    }
}