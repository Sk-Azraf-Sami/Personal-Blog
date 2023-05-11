using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Create_Project.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButLogin_Click(object sender, EventArgs e)
        {
            if(TxtAdminLogin.Text=="Admin" && TxtPassword.Text=="abcd")
            {
                Response.Redirect("~/Admin/Admin-Panel.aspx");
            }
            else
            {
                Response.Redirect("~/Admin/Admin-login.aspx");
            }
        }
    }
}