using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBM26Nov2024_ASPNETIntro
{
    public partial class ServerControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            txtHtmlTextbox.Value = "HTML Ctrl Default Value Set in Page_Load";
            txtWebCtrlTextbox.Text = "Web Ctrl Default Value Set in Page_Load";


            if (this.IsPostBack==false)
            {
                DropDownListCity.Items.Add("Bangalore");
                DropDownListCity.Items.Add("Delhi");
                DropDownListCity.Items.Add("Chennai");
            }





        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}