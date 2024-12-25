using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class testApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Application["taik"] == null) { Application["talk"] = ""; }
            //else { Label1.Text = Application["talk"].ToString(); }

            //Page&Server物件課程, 練習用Server.Execute跳轉另一個aspx(detail.aspx)做登入
            Response.Write(".Execute方法:");
            Server.Execute("detail.aspx");
            Response.Write("測試Execute");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Application["talk"] = Application["talk"].ToString() + TextBox1.Text + "</br>";
            //Label1.Text = Application["talk"].ToString();
        }
    }
}