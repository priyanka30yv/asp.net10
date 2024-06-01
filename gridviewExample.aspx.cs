using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class gridviewExample : System.Web.UI.Page
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

        GridView1.DataSource = s.Tables[0];
        GridView1.DataBind();

    }
 

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}