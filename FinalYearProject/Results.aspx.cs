using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace FinalYearProject
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.QueryString["Category"])
            {
                case "Injuries Claim":
                    InjuriesCheck();
                    break;
                case "Family Law":
                    FamilyCheck();
                    break;
                case "Employment":
                    EmploymentCheck();
                    break;
                case "Car Accident":
                    CarAccidentCheck();
                    break;
                default:
                    lblResult.Text = "An Error has occurred.";
                    break;
            }
            if(Request.QueryString["Where"] == "Court")
            {
                hrTitle.InnerText = "The Court Will Make It's Decision";
            }
            else
            {
                hrTitle.InnerText += Request.QueryString["Where"].ToString();
            }
            
        }

        protected void InjuriesCheck()
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Trips and Slips":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if(Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof is on you to provide a preponderance of evidence to prove there has been negligence on the part of the ";
                                lblResult.Text += "defendant. This will require you to prove four specific claims; first you have must prove that the defendant had a duty of care ";
                                lblResult.Text += "in this incident. This would be done by proving that they are either the owner or occupier of the premises upon which the slip or trip ";
                                lblResult.Text += "took place. <br/>Second, you must then prove that the defendant had not followed proper industry practices regarding hazard prevention, such as ";
                                lblResult.Text += "insufficient inspections or maintenance procedures. Third, you must provide evidence that the defendant either was or should have been aware of the ";
                                lblResult.Text += "hazardous conditions that led to your slip or trip. This does not require you to prove that the defendant purposefully created the hazard, ";
                                lblResult.Text += "only that they were in a position that made it their responsibility to deal with this hazardous situation. Finally, you must prove that ";
                                lblResult.Text += "this hazardous situation has caused your injuries or other damages. This can be done using witnesses at the scene, doctors that ";
                                lblResult.Text += "that can provide their medical opinion the nature and severity of your injuries, pictures of the site of the accident, etc.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof is on the plaintiff to provide a preponderance of evidence to prove there has been negligence on your part. ";
                                lblResult.Text += "This will require them to prove four specific claims; first they have must prove that you had a duty of care ";
                                lblResult.Text += "in this incident. This would be done by proving that you are either the owner or occupier of the premises upon which the slip or trip ";
                                lblResult.Text += "took place. <br/>Second, they must then prove that you had not followed proper industry practices regarding hazard prevention, such as ";
                                lblResult.Text += "insufficient inspections or maintenance procedures. Third, they must provide evidence that you either was or should have been aware of the ";
                                lblResult.Text += "hazardous conditions that led to your their or trip. This does not require them to prove that you purposefully created the hazard, ";
                                lblResult.Text += "only that you were in a position that made it your responsibility to deal with this hazardous situation. Finally, they must prove that ";
                                lblResult.Text += "this hazardous situation has caused their injuries or other damages. They may do this using witnesses at the scene, doctors that ";
                                lblResult.Text += "that can provide their medical opinion the nature and severity of their injuries, pictures of the site of the accident, etc.";
                            }
                            break;
                        case "Evidence":
                            if(Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided your evidence of negligence on the part of the defendant, the judge will ";
                                lblResult.Text += "consider this evidence and come to a decision on whether it is enough to qualify as a preponderance of evidence. If it isn't the judge may ";
                                lblResult.Text += "choose to dismiss the case or you may be tasked with providing further evidence regarding certain aspects of your claims.";
                                lblResult.Text += " If however, the evidence you have provided is considered enough, the burden of proof will now pass to the defendant to ";
                                lblResult.Text += "counter your claims of negligence on their part having led to your trip or slip.<br/>They may do this by providing video of";
                                lblResult.Text += " the incident if any exists, witnesses that can counter any of your claims regarding their duty of care, their adherence ";
                                lblResult.Text += "to industry standards/practices, etc.";
                            }
                            else
                            {
                                /**
                                 * The possible defenses from the defendant https://www.justia.com/injury/premises-liability/defenses-in-slip-and-fall-cases/
                                 * Comparative Negligence
                                 * Inadequate notice
                                 * procedural defenses
                                 * statute of limitations
                                 */
                                lblResult.Text = "Now that the plaintiff has provided their evidence of negligence on your part, the judge will ";
                                lblResult.Text += "consider this evidence and come to a decision on whether it is enough to qualify as a preponderance of evidence. If it isn't the judge may ";
                                lblResult.Text += "choose to dismiss the case or they may be tasked with providing further evidence regarding certain aspects of their claims.";
                                lblResult.Text += " If however, the evidence they have provided is considered enough, the burden of proof will now pass to you to ";
                                lblResult.Text += "counter their claims of negligence on your part having led to their trip or slip.<br/>You may do this by providing video of";
                                lblResult.Text += " the incident if any exists, witnesses that can counter any of their claims regarding your duty of care, their adherence ";
                                lblResult.Text += "to industry standards/practices, etc. You may also build your defense upon the premise that the plaintiff was in fact partly or ";
                                lblResult.Text +=  "completely at fault for the trip or slip, or that the plaintiff's proof that you had knowledge of a hazard is not truly sufficient.";
                            }
                            break;
                        case "Counterclaim":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The judge will now either make a deliberation on your case now, deciding whether the defendant's evidence is enough for a ";
                                lblResult.Text += "dismissal, or the burden of proof will now be passed back to you to provide additional evidence to counter the evidence ";
                                lblResult.Text += "that the defendant has brought forward.";
                            }
                            else
                            {
                                lblResult.Text = "The judge will now either make a deliberation on the case now, deciding whether the your evidence is enough for to make their ";
                                lblResult.Text += "judgement on the case, or the burden of proof will now be passed back to plaintiff to provide additional evidence to counter the evidence ";
                                lblResult.Text += "that you have brought forward.";
                            }
                            break;
                    }
                    break;
                case "Medical Malpractice":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof is upon you to provide a preponderance of evidence that the defendant has breached their standard of care or were otherwise negligent, ";
                                lblResult.Text += "that this breach has led to the alleged damages and that these damages are cognizable (recognised by law). In order to first prove the standard of ";
                                lblResult.Text += "care has been breached or that the defendant was otherwise negligent, you must provide evidence that the medical care provided by the defendant wasn't an example of the skill that ";
                                lblResult.Text += "would be expected of someone in their position, eg. that they failed to properly diagnose a medical condition, failed to provided appriopriate ";
                                lblResult.Text += "treatment, or that they delayed said treatment for an unreasonable amount of time. Another way to prove a breach of standard of care is via the ";
                                lblResult.Text += "concept of informed consent, where you might provide evidence that you weren't fully informed of the treatment provided and it's consequences, and that ";
                                lblResult.Text += "had you been informed that you would have declined the treatment if this information had been provided to you at the time.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof is upon the plaintiff to provide a preponderance of evidence that you have breached your standard of care or were otherwise negligent, ";
                                lblResult.Text += "that this breach has led to the alleged damages and that these damages are cognizable (recognised by law). In order to first prove the standard of ";
                                lblResult.Text += "care has been breached or that you were otherwise negligent, they must provide evidence that the medical care provided by you wasn't an example of the skill that ";
                                lblResult.Text += "would be expected of someone in your position, eg. that you failed to properly diagnose a medical condition, failed to provided appriopriate ";
                                lblResult.Text += "treatment, or that you delayed said treatment for an unreasonable amount of time. Another way to prove a breach of standard of care is via the ";
                                lblResult.Text += "concept of informed consent, where they might provide evidence that they weren't fully informed of the treatment provided and it's consequences, and that ";
                                lblResult.Text += "had they been informed that they would have declined the treatment if this information had been provided to them at the time.";
                            }
                            break;
                        case "Standard":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided your evidence of a breach of standard of care, the burden is now on you to additionally prove ";
                                lblResult.Text += "that this breach is what led to the damages that you have suffered. So for example, if the damages are a result of side effects ";
                                lblResult.Text += "of inappropriate treatment that was provided, such as the defendant administering the use of a substance that you were allergic to, ";
                                lblResult.Text += "and your damages being caused by the following allergic reaction. In order to prove this, you will have to provide the details of when and how ";
                                lblResult.Text += "these damages were caused, making use of your medical records, expert witnesses, etc. ";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided their evidence of a breach of standard of care, the burden is now on them to additionally prove ";
                                lblResult.Text += "that this breach is what led to the damages that they have suffered. So for example, if the damages are a result of side effects ";
                                lblResult.Text += "of inappropriate treatment that was provided, such as you administering the use of a substance that they were allergic to, ";
                                lblResult.Text += "and their damages being caused by the following allergic reaction. In order to prove this, they would have to provide the details of when and how ";
                                lblResult.Text += "these damages were caused, making use of their medical records, expert witnesses, etc. ";
                            }
                            break;
                        case "Cause":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided the evidence that the defendant's breach of their standard of care or negligence was the cause of your ";
                                lblResult.Text += "damages, you must finally prove that the damages you have suffered fall within the jurisdiction of the law. This may include economic damages caused by ";
                                lblResult.Text += "results of the defendant's actions, such as loss of work caused by injuries incurred under the defendant's care, general damages, which cover ";
                                lblResult.Text += "pain or suffering caused by the care provided by the defendant, which requires evidence of a tangible loss of quality of life, physical injuries caused by ";
                                lblResult.Text += "the treatment, wrongful death if you are suing on behalf of a deceased family member, etc. ";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided the evidence that your breach of your standard of care or negligence was the cause of their ";
                                lblResult.Text += "damages, they must finally prove that the damages they have suffered fall within the jurisdiction of the law. This may include economic damages caused by ";
                                lblResult.Text += "results of your actions, such as loss of work caused by injuries incurred under your care, general damages, which cover ";
                                lblResult.Text += "pain or suffering caused by the care provided by you, which requires evidence of a tangible loss of quality of life, physical injuries caused by ";
                                lblResult.Text += "the treatment, wrongful death if they are suing on behalf of a deceased family member, etc. ";
                            }
                            break;
                        case "Cognizable":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "With the evidence you have previously provided, there should now be a preponderance of evidence that the defendant breached their standard of care, ";
                                lblResult.Text += "that this breach caused the alleged damages and that these damages can be recognised by the law. This means the burden of proof finally shifts to the ";
                                lblResult.Text += "defendant, who may be required to provide evidence to counter your claims, using medical records, witnesses, etc.";
                            }
                            else
                            {
                                lblResult.Text = "With the evidence they have previously provided, there should now be a preponderance of evidence that you breached your standard of care, ";
                                lblResult.Text += "that this breach caused the alleged damages and that these damages can be recognised by the law. This means the burden of proof finally shifts to ";
                                lblResult.Text += "you, and you may be required to provide evidence to counter the plaintiff's claims, using medical records, witnesses, etc. You may make the argument ";
                                lblResult.Text += "you actually didn't breach your standard of care, that the plaintiff's own negligence contributed to the cause of their own injuries or condition, that the outcome that ";
                                lblResult.Text += "led to the plaintiff's condition are such rare outcomes that nobody could have been able to foresee it, etc.";
                            }
                            break;
                        case "Counterclaim":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "With the defendant having made their counterclaim, the judge will now either make a deliberation on the case or will pass the burden of proof back onto ";
                                lblResult.Text += "you to disprove the counterclaims of the defendant.";
                            }
                            else
                            {
                                lblResult.Text = "With your counterclaim made, the judge will now either make a deliberation on the case or will pass the burden of proof back onto ";
                                lblResult.Text += "the plaintiff to disprove your counterclaims.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Wrongful Death":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof lies on you, and you must provide a preponderance of evidence that proves that the defendant was negligent, ";
                                lblResult.Text += "and that their negligence caused the death involved in this case. To do this you must provide evidence of multiple factors, first of which is that ";
                                lblResult.Text += "you must prove that the defendant had a duty of care for the deceased. An example of this would be during car accident, the defendant would ";
                                lblResult.Text += "have a duty of care to the deceased as all drivers have an obligation to obey the highway code and must always drive carefully.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof lies on the plaintiff, and they must provide a preponderance of evidence that proves that you were negligent, ";
                                lblResult.Text += "and that your negligence caused the death involved in this case. To do this they must provide evidence of multiple factors, first of which is that ";
                                lblResult.Text += "they must prove that you had a duty of care for the deceased. An example of this would be during car accident, you would ";
                                lblResult.Text += "have a duty of care to the deceased as all drivers have an obligation to obey the highway code and must always drive carefully.";
                            }
                            break;
                        case "Duty":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that the defendant had a duty of care towards the deceased, you must now provide evidence that the defendant ";
                                lblResult.Text += "breached that duty of care. This could be done by showing they created the unsafe conditions that led to the death, and provided no warning of these ";
                                lblResult.Text += "conditions if it was a death on their property, or in the case of a car accident that the defendant was driving in a reckless manner by speeding, driving while";
                                lblResult.Text += "under the influence or while sleep deprived, etc. This evidence could include photographs of the scene, reports provided by the police, witnesses, etc.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that you had a duty of care towards the deceased, they must now provide evidence that you ";
                                lblResult.Text += "breached that duty of care. This could be done by showing that you created the unsafe conditions that led to the death, and provided no warning of these ";
                                lblResult.Text += "conditions if it was a death on your property, or in the case of a car accident that you were driving in a reckless manner by speeding, driving while";
                                lblResult.Text += "under the influence or while sleep deprived, etc. This evidence could include photographs of the scene, reports provided by the police, witnesses, etc.";
                            }
                            break;
                        case "Breach":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that the defendant breached their duty of care, you must provide evidence that this breach is what caused the ";
                                lblResult.Text += "death in question. This may seem simple, as you have already proven they breached their duty of care and were acting recklessly, but if any other factor ";
                                lblResult.Text += "could be argued to have been the cause, such as a mechanical failure in the deceased's car in the case of a car accident, then your evidence won't be sufficient. ";
                                lblResult.Text += "This step will likely require medical reports or expert witnesses that can pinpoint the exact reason for the deceased's death and explain their reasoning ";
                                lblResult.Text += "for this conclusion.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that you breached your duty of care, they must provide evidence that this breach is what caused the ";
                                lblResult.Text += "death in question. This may seem simple, as they have already proven you breached your duty of care and were acting recklessly, but if any other factor ";
                                lblResult.Text += "could be argued to have been the cause, such as a mechanical failure in the deceased's car in the case of a car accident, then their evidence won't be sufficient. ";
                                lblResult.Text += "This step will likely require medical reports or expert witnesses that can pinpoint the exact reason for the deceased's death and explain their reasoning ";
                                lblResult.Text += "for this conclusion.";
                            }
                            break;
                        case "Cause":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof is now upon the defendant, who must now provide evidence that counters the evidence that you have provided, ";
                                lblResult.Text += "which will likely be similar to the evidence previously provided, including witnesses, police reports, photographs of the scene, etc. ";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof is now upon you, and you must now provide evidence that counters the evidence that the plaintiff has provided, ";
                                lblResult.Text += "which will likely be similar to the evidence previously provided, including witnesses, police reports, photographs of the scene, etc. ";
                                lblResult.Text += "You might focus your argument on negligence on the part of the deceased or another individual involved being the actual cause of ";
                                lblResult.Text += "the death for example.";
                            }
                            break;
                        case "Counterclaim":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has provided evidence to counter your claims, the judge will determine whether this evidence is sufficient, in which case ";
                                lblResult.Text += "either the burden of proof returns to you and you will be expected to provide further evidence of your claims, or your case will be dismissed. If ";
                                lblResult.Text += "the counter evidence isn't sufficient however, the judge will make their deliberation on if you are owed damages and if so, how much is owed.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have provided evidence to counter the plaintiff's claims, the judge will determine whether this evidence is sufficient, in which case ";
                                lblResult.Text += "either the burden of proof returns to the plaintiff and they will be expected to provide further evidence of their claims, or their case will be dismissed. If ";
                                lblResult.Text += "the counter evidence isn't sufficient however, the judge will make their deliberation on if you owe damages and if so, how much is owed.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Workplace Accident":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof lies on you, and you must provide a preponderance of evidence that shows the defendant had a duty of care ";
                                lblResult.Text += "towards you, that they breached this duty of care, and that this breach is what caused your accident. In a workplace dispute the ";
                                lblResult.Text += "duty of care from your employer obligates them to provide you with a safe place of work/premises to conduct your work, only equipment that ";
                                lblResult.Text += "is safe and maintained, safe working practices and a competent staff to prevent accidents that may cause harm.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof lies on the plaintiff, and they must provide a preponderance of evidence that shows you had a duty of care ";
                                lblResult.Text += "towards them, that you breached this duty of care, and that this breach is what caused their accident. In a workplace dispute the ";
                                lblResult.Text += "duty of care from the employer obligates them to provide the employee with a safe place of work/premises to conduct their work, only equipment that ";
                                lblResult.Text += "is safe and maintained, safe working practices and a competent staff to prevent accidents that may cause harm.";
                            }
                            break;
                        case "Duty":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence to show that the defendant had a duty of care, the burden of proof is on you to show that they have breached ";
                                lblResult.Text += "this duty of care. In the context of the workplace, you will need to provide proof that your place of work, the equipment or working practices ";
                                lblResult.Text += "do not provide employees safety, or that your employer allowed unfit staff to continue working alongside you. ";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence to show that you had a duty of care, the burden of proof is on them to show that you have breached ";
                                lblResult.Text += "this duty of care. In the context of the workplace, they will need to provide proof that their place of work, the equipment or working practices ";
                                lblResult.Text += "do not provide employees safety, or that you allowed unfit staff to continue working alongside them. ";
                                lblResult.Text += "";
                            }
                            break;
                        case "Breach":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that the defendant breached their duty of care, the burden of proof is on you to provide ";
                                lblResult.Text += "evidence that this breach is what led to the accident. This could involve providing photographs of the scene of the accident for ";
                                lblResult.Text += "example that show that it was the unsafe premise that caused the accident, or witnesses that can inform the court of how the accident ";
                                lblResult.Text += "took place and how the unfit member of staff caused it, etc.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that you breached your duty of care, the burden of proof is on them to provide ";
                                lblResult.Text += "evidence that this breach is what led to the accident. This could involve providing photographs of the scene of the accident for ";
                                lblResult.Text += "example that show that it was the unsafe premise that caused the accident, or witnesses that can inform the court of how the accident ";
                                lblResult.Text += "took place and how the unfit member of staff caused it, etc.";
                            }
                            break;
                        case "Cause":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence to show how the defendant's breach of their duty of care is what caused the accident, if the judge finds ";
                                lblResult.Text += "this evidence sufficient, the burden of proof is now on the defendant to provide evidence that disproves your claims. This could come in the ";
                                lblResult.Text += "form of witnesses that provide a different view on what happened during the accident, evidence of regular maintenance of the premises, etc. ";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence to show how your breach of your duty of care is what caused the accident, if the judge finds ";
                                lblResult.Text += "this evidence sufficient, the burden of proof is now on you to provide evidence that disproves their claims. This could come in the ";
                                lblResult.Text += "form of witnesses that provide a different view on what happened during the accident, evidence of regular maintenance of the premises, etc. ";
                            }
                            break;
                        case "Counterclaim":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has provided evidence to counter your own, the judge will decide whether this evidence is sufficient. The judge may make their ";
                                lblResult.Text += "deliberations on the case now, or they may ask you to provide additional evidence to support your claims.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have provided evidence to counter the plaintiff's, the judge will decide whether this evidence is sufficient. The judge may make their ";
                                lblResult.Text += "deliberations on the case now, or they may ask for additional evidence to support your or the plaintiff's claims.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        protected void FamilyCheck()
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Divorce Proceedings":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof currently lies on you to provide a preponderance of evidence that shows your marriage has irretrievably ";
                                lblResult.Text += "broken down. This can only be done by establishing one of five different facts, only four of which are applicable; that your partner has committed adultery ";
                                lblResult.Text += "and thus you find it intolerable to continue living with them, that they have behaved in a way that you can not be reasonably ";
                                lblResult.Text += "expected to continue living with them, that they have deserted you for a continous period of 2 years at a minimum or finally that you both ";
                                lblResult.Text += "have lived apart for a continous period for a minimum of 5 years.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof currently lies on the plaintiff to provide a preponderance of evidence that shows the marriage has irretrievably ";
                                lblResult.Text += "broken down. This can only be done by establishing one of five different facts, only four of which are applicable; that you have committed adultery ";
                                lblResult.Text += "and thus they find it intolerable to continue living with you, that you have behaved in a way that they can not be reasonably ";
                                lblResult.Text += "expected to continue living with you, that you have deserted them for a continous period of 2 years at a minimum or finally that you both ";
                                lblResult.Text += "have lived apart for a continous period for a minimum of 5 years.";
                            }
                            break;
                        case "Irretrievable":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided your evidence that the marriage has irretrievably broken down, assuming that it is considered sufficient by ";
                                lblResult.Text += "the court, the burden of proof is now on the defendant to either contest your evidence and provide their own, or concede that this evidence is accurate.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided their evidence that the marriage has irretrievably broken down, assuming that it is considered sufficient by ";
                                lblResult.Text += "the court, the burden of proof is now on you to either contest their evidence and provide your own, or concede that this evidence is accurate.";
                            }
                            break;
                        case "Contested":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has provided their own evidence to contest yours, depending on whether this evidence is considered sufficient by the court, ";
                                lblResult.Text += "the burden of proof may return to you and the court may ask for you to provide new evidence of your claims, or they make a deliberation now based on ";
                                lblResult.Text += "the evidence you and the defendant have brought forth.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have provided your own evidence to contest the plaintiff's, depending on whether this evidence is considered sufficient by the court, ";
                                lblResult.Text += "the burden of proof may return to them and the court may ask for them to provide new evidence of their claims, or they make a deliberation now based on ";
                                lblResult.Text += "the evidence you and the plaintiff have brought forth.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Non-Molestation Order":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof currently lies on you and you must first provide evidence that the defendant is an associated person ";
                                lblResult.Text += "person to you. This means that you are either connected to them through marriage, civil partnership, engagement, or other legal ";
                                lblResult.Text += "binding relationships, were previously living together as part of the aforementioned relationships, are family or otherwise related to them, ";
                                lblResult.Text += "have a child with them or share parental responsibility of your child with the defendant or you both were previously in an intimate relationship ";
                                lblResult.Text += "for an significant period of time.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof currently lies on the plaintiff and they must first provide evidence that you are an associated person ";
                                lblResult.Text += "person to them. This means that they are either connected to you through marriage, civil partnership, engagement, or other legal ";
                                lblResult.Text += "binding relationships, were previously living together as part of the aforementioned relationships, are family or otherwise related to you, ";
                                lblResult.Text += "have a child with you or share parental responsibility of their child with you or you both were previously in an intimate relationship ";
                                lblResult.Text += "for an significant period of time.";
                            }
                            break;
                        case "Applicable":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence to show the defendant is an associated person, and thus an eligible target of the non-molestation order, ";
                                lblResult.Text += "you must now provide evidence that you have a genuine need for protection from the defendant. This will involve providing evidence such as ";
                                lblResult.Text += "witnesses, police records, etc. of instances where the defendant has caused you distress or alarm.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence to show you are an associated person, and thus an eligible target of the non-molestation order, ";
                                lblResult.Text += "they must now provide evidence that they have a genuine need for protection from you. This will involve providing evidence such as ";
                                lblResult.Text += "witnesses, police records, etc. of instances where you have caused them distress or alarm.";
                            }
                            break;
                        case "Need":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that you have a genuine need for protection, the court will make a deliberation on whether to ";
                                lblResult.Text += "grant you the requested non-molestation order. If so, the defendant will be given the option to dispute the ruling and the burden of ";
                                lblResult.Text += "proof will fall to them to provide evidence in an additional hearing that disproves your claims.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that they have a genuine need for protection, the court will make a deliberation on whether to ";
                                lblResult.Text += "grant them the requested non-molestation order. If so, you will be given the option to dispute the ruling and the burden of ";
                                lblResult.Text += "proof will fall to you to provide evidence in an additional hearing that disproves their claims.";
                            }
                            break;
                        case "Disputed":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has disputed your claims, the court pass the burden of proof to you to provide additional evidence of your claims ";
                                lblResult.Text += "or they will make their deliberation on whether to uphold your non-molestation order or not now.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have disputed the plaintiff's claims, the court pass the burden of proof to them to provide additional evidence of their claims ";
                                lblResult.Text += "or they will make their deliberation on whether to uphold the non-molestation order or not now.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Custody Proceedings":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "In order to acquire sole custody, as the plaintiff the burden of proof will initially lie upon you to provide evidence ";
                                lblResult.Text += "that you are the better parent. The standard of better parent is determined based upon taking into account both the child's ";
                                lblResult.Text += "physical and psychological well being of the child. For the physical well being this will take into account the current routine ";
                                lblResult.Text += "of the child such as their sleeping schedule, are they involved in extra-curricular activities, where they go to school, etc. For ";
                                lblResult.Text += "the psychological well being this may involve whether a relationship with the other parent would be allowed, which parent does the child ";
                                lblResult.Text += "enjoy spending time with more, etc. Any potential abuse or proof of a dangerous environment will also need to be included.";
                            }
                            else
                            {
                                lblResult.Text = "In order to acquire sole custody, the burden of proof will initially lie upon the plaintiff to provide evidence ";
                                lblResult.Text += "that they are the better parent. The standard of better parent is determined based upon taking into account both the child's ";
                                lblResult.Text += "physical and psychological well being of the child. For the physical well being this will take into account the current routine ";
                                lblResult.Text += "of the child such as their sleeping schedule, are they involved in extra-curricular activities, where they go to school, etc. For ";
                                lblResult.Text += "the psychological well being this may involve whether a relationship with you would be allowed, which parent does the child ";
                                lblResult.Text += "enjoy spending time with more, etc. Any potential abuse or proof of a dangerous environment will also need to be included.";
                            }
                            break;
                        case "Better":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that you are the better parent, the burden of proof now passes to the defendant to counter ";
                                lblResult.Text += "this evidence, or provide their own evidence to show that they are the better parent. This can be done in the same ways that you ";
                                lblResult.Text += "have done so.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that they are the better parent, the burden of proof now passes to you to counter ";
                                lblResult.Text += "this evidence, or provide your own evidence to show that you are the better parent. This can be done in the same ways that the plaintiff ";
                                lblResult.Text += "has done so.";
                            }
                            break;
                        case "Disputed":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has disputed the evidence you provided/made their own case for being the better parent, the court will";
                                lblResult.Text += " now either determine whether additional evidence is needed from either parent or they will make their determination. ";
                                lblResult.Text += "If they find that neither party has provided sufficient evidence to prove themselves the better parent, they will likely rule ";
                                lblResult.Text += "in favour of Joint Custody.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have disputed the evidence they provided/made their own case for being the better parent, the court will";
                                lblResult.Text += " now either determine whether additional evidence is needed from either parent or they will make their determination. ";
                                lblResult.Text += "If they find that neither party has provided sufficient evidence to prove themselves the better parent, they will likely rule ";
                                lblResult.Text += "in favour of Joint Custody.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        protected void EmploymentCheck()
        {
            switch (Request.QueryString["Subcategory"])
            {
                case "Discrimination":
                        switch (Request.QueryString["Burden"])
                        {
                            case "Beginning":
                                if(Request.QueryString["Party"] == "Plaintiff")
                                {
                                lblResult.Text = "You must prove your prima facie case to shift the burden of proof. This means you must provide the minimum standard of evidence ";
                                lblResult.Text += "to prevent your case from being dismissed. <br/><br/>The requirements of a prima facie in a " + Request.QueryString["Subcategory"];
                                lblResult.Text += " suit are: <br/>Show that you are, or your client, belong to a protected class.<br/>";
                                lblResult.Text += "Show that you, or your client, applied for a role which the employer was seeking applications and that you  or your client";
                                lblResult.Text += " were qualified for said role.<br/>That despite you, or your client's, qualifications the application was rejected.<br/>";
                                lblResult.Text += "That since the rejection of the application, the position has remained open and the employer is still seeking applicants ";
                                lblResult.Text += "for said position with qualification matching yours or your client's.";
                                }
                                else
                                {
                                lblResult.Text = "The plaintiff must prove their prima facie case to shift the burden of proof. This means they must provide the minimum standard of evidence ";
                                lblResult.Text += "to prevent their case from being dismissed. <br/><br/>The requirements of a prima facie in a " + Request.QueryString["Subcategory"];
                                lblResult.Text += " suit are: <br/>Show that they  belong to a protected class.<br/>";
                                lblResult.Text += "Show that they applied for a role for which you were seeking applications and that they were qualified for said role.";
                                lblResult.Text += "<br/>That despite you, or your client's, qualifications the application was rejected.<br/> That since the rejection of the ";
                                lblResult.Text += "application, the position has remained open and the employer is still seeking applicants for said position with qualifications ";
                                lblResult.Text += "matching their's.";
                                }
                                break;
                            case "PrimaFacie":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that your prima facie case has been proven, the burden of proof now shifts to the defendant, who must now provide a ";
                                lblResult.Text += "legitimate and non-discriminatory rationale for the rejection of your application or dismissal, such as poor attendance at current ";
                                lblResult.Text += "or previous workplaces, anti-social behaviour that led to an unsafe environment for other employees, etc.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff's prima facie case has been proven, the burden of proof now shifts to you as the defendant, and you must now provide a ";
                                lblResult.Text += "legitimate and non-discriminatory rationale for the rejection of their application or dismissal, such as poor attendance at current ";
                                lblResult.Text += "or previous workplaces, anti-social behaviour that led to an unsafe environment for other employees, etc.";
                            }
                            break;
                            case "Rationale":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has provided a legitmate and non-discriminatory rationale for the rejection of your application or your dismissal ";
                                lblResult.Text += "you must prove that this rationale is a false pretext that was not the actual rationale. An example of how to prove this is if the defendant ";
                                lblResult.Text += "did not reject the applications of or dismiss others who would also fall within the rationale given, such as others with poor attendance in the ";
                                lblResult.Text += "workplace for example.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have provided a legitmate and non-discriminatory rationale for the rejection of the plaintiff's application or their dismissal, ";
                                lblResult.Text += "they must prove that this rationale is a false pretext that was not the actual rationale. An example of how to prove this is if you ";
                                lblResult.Text += "did not reject the applications of or dismiss others who would also fall within the rationale given, such as others with poor attendance in the ";
                                lblResult.Text += "workplace for example.";
                            }
                            break;
                        case "Disproven":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence to show that the rationale given by the defendant was merely pretextual, the court will ";
                                lblResult.Text += "now make it's determination on whether the evidence provided is sufficient to prove that discrimination was indeed the cause of ";
                                lblResult.Text += "your applications rejection/your dismissal. ";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence to show that the rationale given by you was merely pretextual, the court will ";
                                lblResult.Text += "now make it's determination on whether the evidence provided is sufficient to prove that discrimination was indeed the cause of ";
                                lblResult.Text += "their applications rejection/their dismissal. ";
                            }
                            break;
                            default:
                                break;
                        }
                    break;
                case "Retaliation":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {//must prove you engaged in a protected activity aka Opposition - opposed illegal acts such as discrimination/harassment/retaliation
                                //or participation aka filed discrimination charge or were involved in investigation into such illegal acts
                                lblResult.Text = "The burden of proof lies upon you to prove that the defendant has retaliated against you. To do this you must first prove ";
                                lblResult.Text += "that you were engaged in protected activity. This can come in two forms, the first is Opposition, where you opposed illegal ";
                                lblResult.Text += "acts undertaken by your employer such as discrimination/harassment/previous instances of retaliation against employees. An ";
                                lblResult.Text += "example of this would be if you refused to go along with the defendant implementing a policy against hiring people above a ";
                                lblResult.Text += "certain age or who were a certain race. <br/> The second is Participation, which refers to if you were participating in any ";
                                lblResult.Text += "form of internal investigation about such illegal acts as previously discussed or were already part of an ongoing discrimination ";
                                lblResult.Text += "or harassment lawsuit.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof lies upon the plaintiff to prove that you have retaliated against them. To do this they must first prove ";
                                lblResult.Text += "that they were engaged in protected activity. This can come in two forms, the first is Opposition, where they opposed illegal ";
                                lblResult.Text += "acts undertaken by their employer (you) such as discrimination/harassment/previous instances of retaliation against employees. An ";
                                lblResult.Text += "example of this would be if they refused to go along with you implementing a policy against hiring people above a ";
                                lblResult.Text += "certain age or who were a certain race. <br/> The second is Participation, which refers to if they were participating in any ";
                                lblResult.Text += "form of internal investigation about such illegal acts as previously discussed or were already part of an ongoing discrimination ";
                                lblResult.Text += "or harassment lawsuit.";
                            }
                            break;
                        case "Protected":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {//employer took negative action against you - "materially adverse" - 
                                lblResult.Text = "Now that you have provided evidence of your protected activity, you must also prove that the defendant took materially adverse action ";
                                lblResult.Text += "against you. This would be any action that might deter an employee from partaking in protected activity or making an official complaint. ";
                                lblResult.Text += "Some examples can include firing, demotion, reduction of wages, sudden transfers, unfair disciplinary actions, etc.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence of their protected activity, they must also prove that you took materially adverse action ";
                                lblResult.Text += "against them. This would be any action that might deter an employee from partaking in protected activity or making an official complaint. ";
                                lblResult.Text += "Some examples can include firing, demotion, reduction of wages, sudden transfers, unfair disciplinary actions, etc.";
                            }
                            break;
                        case "Action":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {//there is a causal link between the two
                                lblResult.Text = "You must now provide evidence that shows a causal link between your protected activity and the negative action the defendant ";
                                lblResult.Text += "took against you. An example of this would be if you filed a complaint to HR about harassment you experienced on the job ";
                                lblResult.Text += "and you are soon after fired for bad performance or as part of cutting costs. This causal link will usually be hard to prove ";
                                lblResult.Text += "directly without a confession. However, you can make use of the timing of the negative action if it came soon after the protected activity, ";
                                lblResult.Text += "if you can show the defendant had knowledge of your protected activity or if you can show there are no pausible alternative explanations.";
                            }
                            else
                            {
                                lblResult.Text = "The plaintiff must now provide evidence that shows a causal link between their protected activity and the negative action you ";
                                lblResult.Text += "took against them. An example of this would be if they filed a complaint to HR about harassment they experienced on the job ";
                                lblResult.Text += "and they were soon after fired for bad performance or as part of cutting costs. This causal link will usually be hard to prove ";
                                lblResult.Text += "directly without a confession. However, they can make use of the timing of the negative action if it came soon after the protected activity, ";
                                lblResult.Text += "if they can show you had knowledge of their protected activity or if they can show there are no pausible alternative explanations.";
                            }
                            break;
                        case "Causal":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have proven the causal link between your protected activity and the defendant's negative action against you, ";
                                lblResult.Text += "the burden of proof now shifts to the defendant, who must either provide evidence to dispute your claims, or concede your evidence is accurate and ";
                                lblResult.Text += "the court will make its determination now.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has proven the causal link between their protected activity and your negative action against them, ";
                                lblResult.Text += "the burden of proof now shifts to you, and you must either provide evidence to dispute their claims, or concede their evidence ";
                                lblResult.Text += "is accurate and the court will make its determination now.";
                            }
                            break;
                        case "Disputed":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has disputed your claim, the court will either require you to provide additional evidence for your claims ";
                                lblResult.Text += "or else they will make their deliberation based on the evidence provided.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have disputed the plaintiff's claims, the court will either require additional evidence for either of your claims ";
                                lblResult.Text += "or else they will make their deliberation based on the evidence provided.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Wrongful Dismissal":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "The burden of proof lies on you to provide evidence that your dismissal was a breach of your employment contract or that ";
                                lblResult.Text += "you were not provided the appropriate notice period. This notice period will depend on how long you had been employed in this ";
                                lblResult.Text += "role. The required notice is determined as a minimum of 1 week per year of service, with a minimum of 1 week and a maximum ";
                                lblResult.Text += "of 12 weeks.";
                            }
                            else
                            {
                                lblResult.Text = "The burden of proof lies on the plaintiff to provide evidence that their dismissal was a breach of their employment contract or that ";
                                lblResult.Text += "they were not provided the appropriate notice period. This notice period will depend on how long they had been employed in their ";
                                lblResult.Text += "role. The required notice is determined as a minimum of 1 week per year of service, with a minimum of 1 week and a maximum ";
                                lblResult.Text += "of 12 weeks.";
                            }
                            break;
                        case "Breach":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence that your dismissal was a breach of either your employment contract or the required notice period, ";
                                lblResult.Text += "you must now prove that said dismissal resulted in you taking losses. These losses can include lost wages, loss of insurance ";
                                lblResult.Text += "that was tied to employment, loss of means of travel via company car, etc.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence that their dismissal was a breach of either their employment contract or the required notice period, ";
                                lblResult.Text += "they must now prove that said dismissal resulted in them taking losses. These losses can include lost wages, loss of insurance ";
                                lblResult.Text += "that was tied to employment, loss of means of travel via company car, etc.";
                            }
                            break;
                        case "Losses":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "As you have provided the necessary evidence, the burden of proof now shifts to the defendant, who must now show the court the ";
                                lblResult.Text += "evidence for their justification for your dismissal. This may include any major breach of the employment contract on your part, ";
                                lblResult.Text += "or if you committed gross misconduct. Gross misconduct is any action on your part that undermines the assumed ";
                                lblResult.Text += "trust betwen you and the defendant, such as theft, vandalism, violence, bullying of colleagues, etc.";
                            }
                            else
                            {
                                lblResult.Text = "As the plaintiff has provided the necessary evidence, the burden of proof now shifts to you, and you must now show the court the ";
                                lblResult.Text += "evidence for your justification for the plaintiff's dismissal. This may include any major breach of the employment contract on their part, ";
                                lblResult.Text += "or if they committed gross misconduct. Gross misconduct is any action on their part that undermines the assumed ";
                                lblResult.Text += "trust betwen them and you, such as theft, vandalism, violence, bullying of colleagues, etc.";
                            }
                            break;
                        case "Justification":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that the defendant has sufficiently provided their justification for your dismissal, the court will be able to make its final determination.";
                            }
                            else
                            {
                                lblResult.Text = "Now that you have sufficiently provided your justification for the plaintiff's dismissal, the court will be able to make its final determination.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Workplace Harassment":
                    switch (Request.QueryString["Burden"])
                    {
                        case "Beginning":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "At the beginning of this tribunal, the burden of proof initially lies on you to provide evidence of the harassment you ";
                                lblResult.Text += "experienced in the workplace. Examples of actionable behaviour include but aren't limited to malicious rumours being spread about you, demeaning ";
                                lblResult.Text += "or ridiculing you, misuses of a position of power, unwelcome sexual advances such as inappropriate sexual comments, unwanted  ";
                                lblResult.Text += "touching, standing too close, etc. Threats made about your job security without justification or with the intent of soliciting ";
                                lblResult.Text += "sexual favours also fall under harssment. ";
                            }
                            else
                            {
                                lblResult.Text = "At the beginning of this tribunal, the burden of proof initially lies on the plaintiff to provide evidence of the harassment they ";
                                lblResult.Text += "experienced in the workplace. Examples of actionable behaviour include but aren't limited to malicious rumours being spread about them, demeaning ";
                                lblResult.Text += "or ridiculing them, misuses of a position of power, unwelcome sexual advances such as inappropriate sexual comments, unwanted  ";
                                lblResult.Text += "touching, standing too close, etc. Threats made about their job security without justification or with the intent of soliciting ";
                                lblResult.Text += "sexual favours also fall under harssment. ";
                            }
                            break;
                        case "Harassment":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "Now that you have provided evidence, the burden of proof lies on the defendant to dispute your claims of harassment with ";
                                lblResult.Text += "their own evidence or else the tribunal will likely rule in your favour. To do this they may provide counter evidence such ";
                                lblResult.Text += "as fellow employees testifing that the alleged conduct in fact never occurred or that intent was never malicious for example.";
                            }
                            else
                            {
                                lblResult.Text = "Now that the plaintiff has provided evidence, the burden of proof lies on you to dispute their claims of harassment with ";
                                lblResult.Text += "your own evidence or else the tribunal will likely rule in their favour. To do this you may provide counter evidence such ";
                                lblResult.Text += "as fellow employees testifing that the alleged conduct in fact never occurred or that intent was never malicious for example.";
                            }
                            break;
                        case "Disputed":
                            if (Request.QueryString["Party"] == "Plaintiff")
                            {
                                lblResult.Text = "With both you and the defendant having provided evidence to support your arguments, the tribunal will likely make their deliberation ";
                                lblResult.Text += "now, unless they feel that additional evidence is required for them to make a fair decision.";
                            }
                            else
                            {
                                lblResult.Text = "With both you and the plaintiff having provided evidence to support your arguments, the tribunal will likely make their deliberation ";
                                lblResult.Text += "now, unless they feel that additional evidence is required for them to make a fair decision.";
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        protected void CarAccidentCheck( )
        {
            switch (Request.QueryString["Subcategory"])
            {
                default:
                    break;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BurdenCheck.aspx/?Party=" + Request.QueryString["Party"] + "&Category=" + Request.QueryString["Category"] + "&Subcategory=" + Request.QueryString["Subcategory"]);
        }
    }
}