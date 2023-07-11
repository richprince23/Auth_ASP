using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auth
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblStat.Visible = false;
        }


         protected void btnLogin_Click1(object sender, EventArgs e)
        {
            Dictionary<string,string> res = Helper.login(txtEmail.Text, txtPass.Text);

            lblStat.Visible = true;
            if (res["success"] != "")
            {
                lblStat.CssClass = "alert alert-success p-2 text-center d-block";
                lblStat.Text = res + " Redirecting...";
                Session["email"] = txtEmail.Text;
                Thread.Sleep(3000);

                 Response.Redirect("/dashboard.aspx");
            }
            else
            {
                lblStat.CssClass = "alert alert-danger p-2 text-center d-block";
                lblStat.Text= res["error"];
            }
        }
    }
}