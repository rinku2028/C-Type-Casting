<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="typecast1.aspx.cs" Inherits="typecast1.typecast1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.4.1.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 50%;">
                <tr>
                    <td>Add First Number:</td>
                    <td><asp:TextBox ID="firstnum" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="r1" runat="server" ErrorMessage="Please input numeric values only" ControlToValidate="firstnum" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                <tr>
                    <td>Add Second Number:</td>
                    <td><asp:TextBox ID="secondnum" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="r2" runat="server" ErrorMessage="Please input numeric values only" ControlToValidate="secondnum" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    
                </tr>
                <tr>
                    <td>Result:</td>
                    <td><asp:TextBox ID="txtsum" runat="server"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td>
                    <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnadd_Click" />
                    <asp:Button ID="btnmul" runat="server" Text="Multiply" OnClick="btnmul_Click" />
                    <asp:Button ID="btndelete" runat="server" Text="Divide" OnClick="btndelete_Click"/>             
                    </td>
                </tr>
            </table>
            
            
        </div>
    </form>
</body>
</html>
