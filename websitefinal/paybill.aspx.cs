﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class paybill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I4.Attributes.Add("src", "http://192.168.0.80:82/payBillFinal.aspx/?V4=" + Session["Name"].ToString());
        }
    }
}