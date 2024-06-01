using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class repeatercontroll : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet s;
    int ans1;
    protected void Page_Load(object sender, EventArgs e)
    {

        con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
        da = new SqlDataAdapter("select * from employee", con);
        s = new DataSet();
        da.Fill(s);
        if (!Page.IsPostBack)
        {
            
                BindData();
            
        }
    }
    private void BindData()
    {
       con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
    
            da = new SqlDataAdapter("select * from employee", con);
            s = new DataSet();
            da.Fill(s);

            Repeater1.DataSource = s.Tables[0];
            Repeater1.DataBind();
        
    }

protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            Response.Write("edit button clicked" + e.CommandArgument.ToString());
            


        }

        else
            if (e.CommandName == "update")
            Response.Write("update button clicked" + e.CommandArgument.ToString());
        ans1 = Convert.ToInt32(e.CommandArgument);
        Response.Redirect("updateEmployee.aspx?a=" + ans1);

        if (e.CommandName == "delete")
        {
            con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
            
            con.Open();
            da.DeleteCommand = new SqlCommand();
            da.DeleteCommand.Connection = con;

            da.DeleteCommand.CommandText = "delete from employee where empid=@p1";
            da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int);
            da.DeleteCommand.Parameters["@p1"].Value = e.CommandArgument.ToString();
          int ans = da.DeleteCommand.ExecuteNonQuery();
            Response.Write(ans.ToString() + "record deleted");

            BindData();

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddEmployee.aspx");
    }
}