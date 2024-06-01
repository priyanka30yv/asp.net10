using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEmployee : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet s;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btncreate_Click(object sender, EventArgs e)
    {
        con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
        con.Open();
        cmd = new SqlCommand();
      cmd.CommandText="insert into employee values(@p1,@p2,@p3,@p4)";
      cmd.Connection = con;
     cmd.Parameters.Add("@p1", SqlDbType.Int);
        cmd.Parameters.Add("@p2", SqlDbType.VarChar,50);
       cmd.Parameters.Add("@p3", SqlDbType.VarChar, 50);
     cmd.Parameters.Add("@p4", SqlDbType.VarChar, 50);
        cmd.Parameters["@p1"].Value = TextBox1.Text;
       cmd.Parameters["@p2"].Value = TextBox2.Text;
      cmd.Parameters["@p3"].Value = TextBox4.Text;
       cmd.Parameters["@p4"].Value = TextBox5.Text;
        int ans = cmd.ExecuteNonQuery();
        if(ans==1)
        {
            Response.Redirect("repeatercontroll.aspx");
        }
    }
}