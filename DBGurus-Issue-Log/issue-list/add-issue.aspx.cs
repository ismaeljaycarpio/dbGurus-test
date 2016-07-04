using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.issue_list
{
    public partial class add_issue : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //bind clients
                ddlClientName.DataSource = db.Clients.ToList();
                ddlClientName.DataValueField = "ClientID";
                ddlClientName.DataTextField = "ClientName";
                ddlClientName.DataBind();

                ddlClientName.Items.Insert(0, new ListItem("--Select One--", "0"));

                //bind status
                ddlStatus.DataSource = db.Status.ToList();
                ddlStatus.DataValueField = "StatusID";
                ddlStatus.DataTextField = "StatusName";
                ddlStatus.DataBind();

                ddlStatus.Items.Insert(0, new ListItem("-- Select One --", "0"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                Issue i = new Issue();
                i.ClientID = Convert.ToInt32(ddlClientName.SelectedValue);
                i.StatusID = Convert.ToInt32(ddlStatus.SelectedValue);
                i.Issue1 = txtIssueDescription.Text;
                i.Resolution = txtResolution.Text;
                
                if(txtResolvedDate.Text != String.Empty)
                {
                    i.ResolvedDate = Convert.ToDateTime(txtResolvedDate.Text);
                }

                db.Issues.InsertOnSubmit(i);
                db.SubmitChanges();

                Response.Redirect("~/issue-list/list");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/issue-list/list");
        }
    }
}