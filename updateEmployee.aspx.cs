using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateEmployee : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
   

    protected void Page_Load(object sender, EventArgs e)
    {
        string str = Request.QueryString.Get("a");
        int empid = Convert.ToInt32(str);
        
        con=new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");    
        con.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "select * from employee where empid=@p1";
        cmd.Parameters.Add("@p1",SqlDbType.Int);
        cmd.Parameters["@p1"].Value = empid;
       cmd.Connection = con;
      
        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.Read())
        {
            TextBox1.Text = dr[0].ToString();
            TextBox2.Text = dr[1].ToString();
            TextBox3.Text = dr[2].ToString();
            TextBox4.Text   = dr[3].ToString();

        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string a = TextBox2.Text;
        string b = TextBox3.Text; 
        string c=TextBox4.Text;
      string d = TextBox1.Text;
        con = new SqlConnection("server=DESKTOP-NJ7SO96\\SQLEXPRESS;database=Greysoft;user id=sa;password=greysoft");
        con.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "update employee set empname=@p1,empdesignation=@p2,emplocation=@p3 where empid=@p4";
      
        cmd.Parameters.Add("@p1", SqlDbType.VarChar,50);
        cmd.Parameters.Add("@p2", SqlDbType.VarChar,50);
        cmd.Parameters.Add("@p3", SqlDbType.VarChar,50);
        cmd.Parameters.Add("@p4", SqlDbType.Int);
        cmd.Parameters["@p1"].Value = a;
        cmd.Parameters["@p2"].Value = b;
        cmd.Parameters["@p3"].Value = c;
        cmd.Parameters["@p4"].Value = d;
        cmd.Connection = con;
        int ans = cmd.ExecuteNonQuery();
        
        if(ans==1)
        {
            Response.Redirect("repeatercontroll.aspx");
         
        }
    }
}