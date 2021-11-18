using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace FinalYearProject
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString.Count > 0)
            {
                if(User.Identity.IsAuthenticated)
                {
                    lblUsername.Text = User.Identity.Name;
                    btnSignOut.Enabled = true;
                    btnSignOut.Visible = true;
                    btnHome.Visible = false;
                }
                lblWhichParty.Text = Request.QueryString["Party"];
            }

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SubCategory.aspx?" + Request.QueryString.ToString() + "&Category=" + rblCategories.SelectedValue);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}