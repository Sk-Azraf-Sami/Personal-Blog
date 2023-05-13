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
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss"); // use the format that matches your database's datetime format
                LabelBPosteddate.Text = formattedDate;
                DDLBCat.Items.Insert(0,"--Select Category--");
            }
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            if(DDLBCat.SelectedItem.Text.ToString().Equals("--Select Category--")) {
                Response.Redirect("~/Admin/Admin-Panel.aspx");
            }
            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[blog] (Btitle,Bcatagory,BDesc,BUrl,Bposteddate) values (@Btitle,@Bcatagory,@BDesc,@BUrl,@Bposteddate)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@Btitle", TxtBlogTitle.Text);
                sqlcomm.Parameters.AddWithValue("@Bcatagory", DDLBCat.SelectedItem.Text.ToString());
                sqlcomm.Parameters.AddWithValue("@BDesc", TxtBDesc.Text);
                sqlcomm.Parameters.AddWithValue("@BUrl", TxtBurl.Text);
                sqlcomm.Parameters.AddWithValue("@Bposteddate", LabelBPosteddate.Text);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();

                //IF I use this line, double entry insert in database.
                Response.Redirect("~/Admin/Admin-Panel.aspx");
            }
        }
    }
}