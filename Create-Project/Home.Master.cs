using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Create_Project
{
    public partial class Site2 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select COUNT(case when Bcatagory = 'Food' then 1 end) as Food, COUNT(case when Bcatagory = 'Sports' then 1 end) as Sports, COUNT(case when Bcatagory = 'Movies' then 1 end) as Movies from [dbo].[blog]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if(sdr.Read())
            {
                LabFood.Text = sdr.GetValue(0).ToString();
                LabSports.Text = sdr.GetValue(1).ToString();
                LabMovies.Text = sdr.GetValue(2).ToString();    
            }
            sqlconn.Close();
        }
    }
}