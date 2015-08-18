using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridviewData();
            }
        }
        protected void BindGridviewData()
        {

            List<prod> L = new List<prod>();
            prod p = new prod();
            p.Product_Id = "2";
            p.Product_name = "abc";
            L.Add(p);

            p = new prod();
            p.Product_Id = "3";
            p.Product_name = "4abc";
            L.Add(p);
            p = new prod();
            p.Product_Id = "4";
            p.Product_name = "ffabc";
            L.Add(p);


            //SqlConnection con = new SqlConnection("Data Source=MYSystem;Initial Catalog=MySamplesDB;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select UserId,UserName,FirstName,LastName,Location from User_Information", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
           // productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
           // productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID("2", 10003);
            gvdata.DataSource = L;
            gvdata.DataBind();
           // con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvdata.Rows.Count; i++)
            {
                RadioButton rb = (gvdata.Rows[i].FindControl("rdbUser")) as RadioButton;
                if (rb.Checked == true)
                {
                    TextBox1.Text = gvdata.Rows[i].Cells[1].Text;
                }
            }        
        }
    }
}