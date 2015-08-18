<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myprofiled.aspx.cs" Inherits="websitefinal.myprofiled" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #form1
        {
            height: 581px;
        }
        .style1
        {
            width: 252px;
        }
        .style2
        {
            width: 397px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <div style="position: fixed; top: 83px; left: 503px;"  >
    <asp:Label ID="Label5" runat="server" class="vzh2" Text="My Profile Information"></asp:Label>
    </div>
    <div style="position: fixed; top: 138px; left: 415px; width: 405px;">
        <table class="vztable1" style="width: 100%;" frame="box">
            <tr>
                <td class="style1">
                    <asp:Label  class="vzred" ID="Label1" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label2" class="vzred" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox2"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" class="vzred" Text="Mobile Number"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" class="vzred" Text="Email"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    
    </div>



    </form>
</body>
</html>
