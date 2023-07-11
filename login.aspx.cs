using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auth
{
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStat.Visible =false;
        }


        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            string res = Helper.login(txtEmail.Text, txtPass.Text);

            lblStat.Visible = true;
            lblStat.Text = res;
        }
    }
}