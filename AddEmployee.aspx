<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddEmployee.aspx.cs" Inherits="AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        <asp:Label ID="Label1" runat="server" Text="Employee id : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />

            <br />
                    <asp:Label ID="Label2" runat="server" Text="Employee Name : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
                        <br />

                    
                    <asp:Label ID="Label4" runat="server" Text="Employee designation"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
                        <br />

                    <asp:Label ID="Label5" runat="server" Text="Employee location"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
                        <br />

            <asp:Button ID="btncreate" runat="server" Text="Add" OnClick="btncreate_Click" />
        </div>
    </form>
</body>
</html>
