using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBM26Nov2024_ASPNETIntro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitClick(object sender, EventArgs e)
        {
            lblMsg.Text = txtInput.Text+", Welcome to ASP.NET !!";
        }
    }
}