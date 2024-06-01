<%@ Page Language="C#" AutoEventWireup="true" CodeFile="repeatercontroll.aspx.cs" Inherits="repeatercontroll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
     <div>

         <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
     <HeaderTemplate>
         <table>
             <tr>

                    <td>Emp id</td>
                    <td>Emp name</td>
                    <td>Emp designation</td>
                    <td>Emp location</td>
                    <td>Edit</td>
                    <td>Update</td>
                    <td>Delete</td>
             </tr>
     
     </HeaderTemplate>
     <ItemTemplate>
         <tr>
                  <td><asp:TextBox ID="TextBox1" runat="server" Enabled="false" Text='<%# DataBinder.Eval(Container.DataItem,"empid") %>'></asp:TextBox>
</td>
                  <td>             <asp:TextBox ID="TextBox2" Enabled="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"empname") %>'></asp:TextBox>
                  <td>             <asp:TextBox ID="TextBox3" Enabled="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"empdesignation") %>'></asp:TextBox>

                    <td><asp:TextBox ID="TextBox4" runat="server" Enabled="false" Text='<%# DataBinder.Eval(Container.DataItem,"emplocation") %>'></asp:TextBox>

          <td> <asp:LinkButton ID="linkedit" runat="server" CommandName="edit" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"empid") %>'>Edit</asp:LinkButton></td>
          <td>   <asp:LinkButton Visible="true" ID="linkupdate" runat="server" CommandName="update" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"empid") %>'>Update</asp:LinkButton></td>
        <td>    <asp:LinkButton ID="linkdelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("are you sure you want to delete?")' CommandArgument='<%# DataBinder.Eval(Container.DataItem,"empid") %>'>Delete</asp:LinkButton></td>
        </tr>
     </ItemTemplate>
         </asp:Repeater>
         <hr />
         <asp:Button ID="btnAdd" runat="server" Text="Add Employee" OnClick="btnAdd_Click" />
           </div>
 </form>
</body>
</html>
