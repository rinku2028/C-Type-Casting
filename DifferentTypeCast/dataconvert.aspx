<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataconvert.aspx.cs" Inherits="conversion.dataconvert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
             <tr>
            <td>
            <asp:Label ID="lblfirstnum" runat="server" Text="Enter First Number:"></asp:Label></td>
            <td><asp:TextBox ID="txtfirstnum" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
              <td><asp:Label ID="lblsecondnum" runat="server" Text="Enter Second Number:"></asp:Label></td>
              <td><asp:TextBox ID="txtsecondnum" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnadd" runat="server" Text="ADD" OnClick="btnadd_Click" /><asp:Button ID="btnmul" runat="server" Text="MULTIPLY" OnClick="btnmul_Click" /></td>
                <td><asp:Button ID="btndiv" runat="server" Text="DIVIDE" OnClick="btndiv_Click" /></td>
                <td><asp:Label ID="lblmessage" runat="server" Text=""/></td>
                
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
