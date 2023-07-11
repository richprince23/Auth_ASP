using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auth
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStat.Visible =false;
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtPassCf.Text)
            {
                lblStat.Text = 
            }
        }
    }
}