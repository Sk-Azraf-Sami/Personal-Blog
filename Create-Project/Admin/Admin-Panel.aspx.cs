using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;   

namespace Create_Project.Admin
{
    public partial class Admin_Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LabelBPosteddate.Text = DateTime.Now.ToString();
                DDLBCat.Items.Insert(0,"--Select Category--");
            }
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[blog] (Btitle,Bcatagory,BDesc,BUrl,Bposteddate) values (@Btitle,@Bcatagory,@BDesc,@BUrl,@Bposteddate)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Btitle",TxtBlogTitle.Text);
            sqlcomm.Parameters.AddWithValue("@Bcatagory", DDLBCat.SelectedItem.Text.ToString());
            sqlcomm.Parameters.AddWithValue("@BDesc", TxtBDesc.Text);
            sqlcomm.Parameters.AddWithValue("@BUrl", TxtBurl.Text);
            sqlcomm.Parameters.AddWithValue("@Bposteddate", "20100221 22:00:32");
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            Response.Redirect("~/Admin/Admin-Panel.aspx");
        }
    }
}