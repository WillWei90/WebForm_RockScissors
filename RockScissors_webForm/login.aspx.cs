using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class login : System.Web.UI.Page
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
            //        {
            //        Response.Redirect("https://www.google.com.tw");
            //    }
            //    else
            //    {
            //        Response.Redirect("https://www.yahoo.com.tw");
            //    }
            //}

            ////Application示範數字往上加
            //if (Application["count"] == null) { Application["count"] = 0; }

            ////Application暫存課程內容
            //if (Application["taik"] == null) { Application["talk"] = ""; }
            //else { Label1.Text = Application["talk"].ToString(); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ////Application示範數字往上加
            //var count = int.Parse(Application["count"].ToString());
            //count++;
            //Application["count"] = count;
            //Label1.Text = Application["count"].ToString();

            //Application["talk"] = Application["talk"].ToString() + TextBox1.Text + "</br>";
            //Label1.Text = Application["talk"].ToString();

            ////內部跳轉
            //Server.Transfer("rockScissorsGame.aspx");

            ////外部跳轉
            Response.Redirect("rockScissorsGame.aspx");
        }

        //protected void Timer1_Tick(object sender, EventArgs e)
        //{
        //    //if (Application["talk"] == null) { Application["talk"] = ""; }
        //    //else { Label1.Text = Application["talk"].ToString(); }
        //}
    }
}