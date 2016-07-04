using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.issue_list
{
    public partial class edit_issue : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["IssueID"] == null)
                {
                    Response.Redirect("~/issue-list/list");
                }
                else
                {
                    //load data
                    loader();

                    var issue = db.Issues.Where(i => i.IssueID.ToString() == Request.QueryString["IssueID"]).FirstOrDefault();
                    if (issue != null)
                    {
                        ddlClientName.SelectedValue = issue.ClientID.ToString();
                        ddlStatus.SelectedValue = issue.StatusID.ToString();
                        txtIssueDescription.Text = issue.Issue1;
                        txtResolution.Text = issue.Resolution;
                        
                        if(issue.ResolvedDate != null)
                        {
                            txtResolvedDate.Text = issue.ResolvedDate.Value.ToString("MM/dd/yyyy");
                        }
                    }
                    else
                    {
                        Response.Redirect("~/issue-list/list");
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                var issue = db.Issues.Where(i => i.IssueID.ToString() == Request.QueryString["IssueID"]).FirstOrDefault();
                issue.ClientID = Convert.ToInt32(ddlClientName.SelectedValue);
                issue.StatusID = Convert.ToInt32(ddlStatus.SelectedValue);
                issue.Issue1 = txtIssueDescription.Text;
                issue.Resolution = txtResolution.Text;

                if(txtResolvedDate.Text != String.Empty)
                {
                    issue.ResolvedDate = Convert.ToDateTime(txtResolvedDate.Text);
                }

                db.SubmitChanges();
                Response.Redirect("~/issue-list/list");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/issue-list/list");
        }

        protected void loader()
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
}