using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace FinalYearProject
{
    public partial class BurdenCheck : System.Web.UI.Page
    {
        String WhereBurden = "Error";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    lblUsername.Text = User.Identity.Name + "&emsp;";
                    btnSignOut.Enabled = true;
                    btnSignOut.Visible = true;
                    btnHome.Visible = false;
                }
                lblWhichParty.Text = Request.QueryString["Party"];
                lblCategory.Text = Request.QueryString["Category"];
                lblSubcategory.Text = Request.QueryString["Subcategory"];

                switch (Request.QueryString["Category"])
                {
                    case "Injuries Claim":
                        InjuriesCheck(0);
                        break;
                    case "Family Law":
                        FamilyCheck(0);
                        break;
                    case "Employment":
                        EmploymentCheck(0);
                        break;
                    default:
                        rblBurden.Items.Add("An Error has occurred.");
                        break;
                }
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            switch (Request.QueryString["Category"])
            {
                case "Injuries Claim":
                    InjuriesCheck(1);
                    break;
                case "Family Law":
                    FamilyCheck(1);
                    break;
                case "Employment":
                    EmploymentCheck(1);
                    break;
                default:
                    WhereBurden = "Error";
                    break;
            }
            if(WhereBurden == "Error")
            {
                valBurden.Text = "Error has occurred.";
                valBurden.Enabled = true;
            }
            else
            {
                Response.Redirect("~/Results.aspx?" + Request.QueryString.ToString() + "&Burden=" + rblBurden.SelectedValue + "&Where=" + WhereBurden);
            }
        }

        protected void InjuriesCheck(int method)
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Trips and Slips":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue) //REPLACE WITH RELATION TO TRIPS AND SLIPS CASES
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Evidence":
                                WhereBurden = "Defendant";
                                break;
                            case "Counterclaim":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence of negligence on the part of the defendant?");
                        rblBurden.Items.Add("Has the defendant provided evidence, such as an expert witness, that counters some or all of the evidence of negligence?");
                        rblBurden.Items[1].Value = "Evidence";
                        rblBurden.Items[2].Value = "Counterclaim";
                    }
                    break;
                case "Medical Malpractice":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue) //REPLACE WITH RELATION TO MEDICAL MALPRACTICE CASES
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Standard":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Cause":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Cognizable":
                                WhereBurden = "Defendant";
                                break;
                            case "Counterclaim":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant departed from their standard of care?");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that this departure from the standard of care caused their injuries?");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that they have suffered cognizable damages?");
                        rblBurden.Items.Add("Has the defendant provided evidence that counters the claims of the plaintiff?");
                        rblBurden.Items[1].Value = "Standard";
                        rblBurden.Items[2].Value = "Cause";
                        rblBurden.Items[3].Value = "Cognizable";
                        rblBurden.Items[4].Value = "Counterclaim";
                    }
                    break;
                case "Wrongful Death":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue) //REPLACE WITH RELATION TO WRONGFUL DEATH CASES
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Duty":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Breach":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Cause":
                                WhereBurden = "Defendant";
                                break;
                            case "Counterclaim":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant had a duty of care towards the deceased?");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant breached their duty of care?");
                        rblBurden.Items.Add("Has the plaintff provided evidence that this breach directly lead to the death of the deceased?");
                        rblBurden.Items.Add("Has the defendant provided a counterclaim to the evidence provided by the plaintiff?");
                        rblBurden.Items[1].Value = "Duty";
                        rblBurden.Items[2].Value = "Breach";
                        rblBurden.Items[3].Value = "Cause";
                        rblBurden.Items[4].Value = "Counterclaim";
                    }
                    break;
                case "Workplace Accident":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue) //REPLACE WITH RELATION TO WORKPLACE ACCIDENT CASES
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Duty":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Breach":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Cause":
                                WhereBurden = "Defendant";
                                break;
                            case "Counterclaim":
                                WhereBurden = "Court";
                                    break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant had a duty of care towards them?");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant breached their duty of care?");
                        rblBurden.Items.Add("Has the plaintff provided evidence that this breach directly led to the accident?");
                        rblBurden.Items.Add("Has the defendant provided a counterclaim to the evidence shown by the plaintiff?");
                        rblBurden.Items[1].Value = "Duty";
                        rblBurden.Items[2].Value = "Breach";
                        rblBurden.Items[3].Value = "Cause";
                        rblBurden.Items[4].Value = "Counterclaim";
                    }
                    break;
                default:
                    rblBurden.Items.Add("Placeholder text.");
                    break;
            }
        }
        protected void FamilyCheck(int method)
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Divorce Proceedings":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue) 
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Irretrievable":
                                WhereBurden = "Defendant";
                                break;
                            case "Contested":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the marriage has irretrievably broken down?");
                        rblBurden.Items.Add("Has the defendant contested the evidence provided by the plaintiff?");
                        rblBurden.Items[1].Value = "Irretrievable";
                        rblBurden.Items[2].Value = "Contested";
                    }
                    break;
                case "Non-Molestation Order":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Applicable":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Need":
                                WhereBurden = "Defendant";
                                break;
                            case "Disputed":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant is an applicable target of a non-molestation order?");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that they have a genuine need for protection from the defendant?");
                        rblBurden.Items.Add("Has the defendant disputed the plaintiff's claims and provided their own evidence?");
                        rblBurden.Items[1].Value = "Applicable";
                        rblBurden.Items[2].Value = "Need";
                        rblBurden.Items[3].Value = "Disputed";
                    }
                    break;
                case "Custody Proceedings":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Better":
                                WhereBurden = "Defendant";
                                break;
                            case "Disputed":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that they are the better parent?");
                        rblBurden.Items.Add("Has the defendant disputed the evidence provided by the plaintiff/provided counter evidence to demonstrate they are the better parent?");
                        rblBurden.Items[1].Value = "Better";
                        rblBurden.Items[2].Value = "Disputed";
                    }
                    break;
                default:
                    rblBurden.Items.Add("Placeholder text.");
                    break;
            }
        }
        protected void EmploymentCheck(int method)
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Discrimination":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "PrimaFacie":
                                WhereBurden = "Defendant";
                                break;
                            case "Rationale":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Disproven":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff proven their prima facie case?");
                        rblBurden.Items.Add("Has the defendant provided a legitimate and non-discriminatory rationale?");
                        rblBurden.Items.Add("Has the plaintiff disproven the provided rationale, or proven it was a pretext to the alleged discriminatory conduct?");
                        rblBurden.Items[1].Value = "PrimaFacie";
                        rblBurden.Items[2].Value = "Rationale";
                        rblBurden.Items[3].Value = "Disproven";
                    }
                    break;
                case "Retaliation":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Protected":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Action":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Causal":
                                WhereBurden = "Defendant";
                                break;
                            case "Disputed":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {//must prove you engaged in a protected activity, employer took action against you, there is a causal link between the two
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence they engaged in a protected activity");
                        rblBurden.Items.Add("Has evidence been provided to show the defendant took action against the plaintiff?");
                        rblBurden.Items.Add("Is there evidence that has shown a causal link between the two?");
                        rblBurden.Items.Add("Has the defendant provided evidence that disputes the evidence provided by the plaintiff?");
                        rblBurden.Items[1].Value = "Protected";
                        rblBurden.Items[2].Value = "Action";
                        rblBurden.Items[3].Value = "Causal";
                        rblBurden.Items[4].Value = "Disputed";
                    }
                    
                    break;
                case "Wrongful Dismissal":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Breach":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Losses":
                                WhereBurden = "Defendant";
                                break;
                            case "Justification":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence that the defendant dismissed them in breach of the employment contract or without proper notice");
                        rblBurden.Items.Add("Has the plaintiff provided evidence that they suffered losses as a result of this dismissal?");
                        rblBurden.Items.Add("Was the defendant able to provide justification for the dismissal of the plaintiff?");
                        rblBurden.Items[1].Value = "Breach";
                        rblBurden.Items[2].Value = "Losses";
                        rblBurden.Items[3].Value = "Justification";
                    }
                    break;
                case "Workplace Harassment":
                    if (method == 1)
                    {
                        switch (rblBurden.SelectedValue)
                        {
                            case "Beginning":
                                WhereBurden = "Plaintiff";
                                break;
                            case "Harassment":
                                WhereBurden = "Defendant";
                                break;
                            case "Disputed":
                                WhereBurden = "Court";
                                break;
                            default:
                                WhereBurden = "Error";
                                break;
                        }
                    }
                    else
                    {
                        rblBurden.Items.Add("Beginning.");
                        rblBurden.Items[0].Value = "Beginning";
                        rblBurden.Items.Add("Has the plaintiff provided evidence of the alleged harassment?");
                        rblBurden.Items.Add("Has the defendant disputed the plaintiff's claims with their own evidence?");
                        rblBurden.Items[1].Value = "Harassment";
                        rblBurden.Items[2].Value = "Disputed";
                    }
                    break;
                default:
                    rblBurden.Items.Add("Placeholder text.");
                    break;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SubCategory.aspx/?&Party=" + Request.QueryString["Party"] + "&Category=" + Request.QueryString["Category"]);
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