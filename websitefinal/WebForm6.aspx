<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="websitefinal.WebForm6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Grdview with Arraylist</title>
<style type="text/css">
.Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:black;
width:300px;
}
</style>
<script language="javascript" type="text/javascript">
    function SelectSingleRadiobutton(rdbtnid) {
        var rdBtn = document.getElementById(rdbtnid);
        var rdBtnList = document.getElementsByTagName("input");
        for (i = 0; i < rdBtnList.length; i++) {
            if (rdBtnList[i].type == "radio" && rdBtnList[i].id != rdBtn.id) {
                rdBtnList[i].checked = false;
            }
        }
    }
</script>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:GridView ID="gvdata" runat="server" CssClass="Gridview" 
        AutoGenerateColumns="false" DataKeyNames="Product_Id" 
        HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="White" GridLines="None">
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:RadioButton id="rdbUser" runat="server" OnClick="javascript:SelectSingleRadiobutton(this.id)" />
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="Product_name" HeaderText="Product Name"/>
<asp:BoundField DataField ="Product_description" HeaderText="Product description" />
<asp:BoundField DataField ="Prod_eff_date" HeaderText=" Start Date" />
<asp:BoundField DataField ="Prod_end_date" HeaderText="End DATE" />
<asp:BoundField DataField ="Rate" HeaderText="Rate (rs)" />

</Columns>
</asp:GridView>
<asp:button ID="Button1" runat="server" text="Button" onclick="Button1_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</div>
</form>
</body>
</html>
