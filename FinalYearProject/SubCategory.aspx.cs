using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Web.Security;


namespace FinalYearProject
{
    public partial class SubCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                btnSignOut.Enabled = true;
                btnSignOut.Visible = true;
                btnHome.Visible = false;
                lblUsername.Text = User.Identity.Name + "&emsp;";
            }
            lblWhichParty.Text = Request.QueryString["Party"];
            lblCategory.Text = Request.QueryString["Category"];

            hrTitle.InnerText = "What type of " + Request.QueryString["Category"] + " suit is it?";
            switch(Request.QueryString["Category"])
            {
                case "Injuries Claim":
                    rblSubcategories.Items.Add("Trips and Slips");
                    rblSubcategories.Items.Add("Medical Malpractice");
                    rblSubcategories.Items.Add("Wrongful Death");
                    rblSubcategories.Items.Add("Workplace Accident");
                    break;
                case "Family Law":
                    rblSubcategories.Items.Add("Divorce Proceedings");
                    rblSubcategories.Items.Add("Non-Molestation Order");
                    rblSubcategories.Items.Add("Custody Proceedings");
                    break;
                case "Employment":
                    rblSubcategories.Items.Add("Discrimination");
                    rblSubcategories.Items.Add("Retaliation");
                    rblSubcategories.Items.Add("Wrongful Dismissal");
                    rblSubcategories.Items.Add("Workplace Harassment");
                    break;
                default:
                    rblSubcategories.Items.Add("An Error has occurred.");
                    break;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BurdenCheck.aspx?" + Request.QueryString.ToString() + "&Subcategory=" + rblSubcategories.SelectedValue);
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            NameValueCollection queryString = new NameValueCollection(Request.QueryString);
            queryString.Remove("Category");
            Response.Redirect("~/Category.aspx/?&Party=" + Request.QueryString["Party"]);
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