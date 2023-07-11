using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auth
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStat.Visible = false;
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtPassCf.Text)
            {
                lblStat.Visible = true;
                lblStat.CssClass = "alert alert-danger p-2 text-center d-block";
                lblStat.Text = "Passwords do not match!";
                return;
            }

            Dictionary<string, string> res = Helper.register(txtFullname.Text, txtEmail.Text, txtPhone.Text, txtPassCf.Text);
            lblStat.Visible = true;
            if (res["success"] != ""){
                lblStat.CssClass= "alert alert-success p-2 text-center d-block";
                lblStat.Text = res["success"] + " Redirecting...";
                Session["email"] = txtEmail.Text;
                Thread.Sleep(3000);

                Response.Redirect("/dashboard.aspx");

            }else{
                lblStat.CssClass= "alert alert-danger p-2 text-center d-block";
                lblStat.Text = res["error"];
            }
        }
    }
}