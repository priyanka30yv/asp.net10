<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateEmployee.aspx.cs" Inherits="updateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="emp id" ></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox>
             <asp:Label ID="Label2" runat="server" Text="emp name"></asp:Label>
 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <asp:Label ID="Label3" runat="server" Text="emp designation"></asp:Label>
 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             <asp:Label ID="Label4" runat="server" Text="emp location"></asp:Label>
 <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
