using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class myprofiled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User"] = Session["Name"].ToString();
            getaccountd.Service1SoapClient k = new getaccountd.Service1SoapClient();
            getaccountd.Class2[] ab = k.getaccount(Convert.ToInt32(Session["User"]));
            TextBox1.Text = ab[0].FirstName;
            TextBox2.Text = ab[0].LastName;
            TextBox3.Text = ab[0].MobileNo;
            TextBox4.Text = ab[0].Email;
            //GridView1.DataSource = ab;
            //GridView1.DataBind();
        }
    }
}