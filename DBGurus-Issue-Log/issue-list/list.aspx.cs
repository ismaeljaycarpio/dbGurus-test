using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.issue_list
{
    public partial class list : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //bind clients
                ddlClient.DataSource = db.Clients.ToList();
                ddlClient.DataValueField = "ClientID";
                ddlClient.DataTextField = "ClientName";
                ddlClient.DataBind();

                ddlClient.Items.Insert(0, new ListItem("--Select One--", "0"));
            }
        }

        protected void gvIssues_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("editRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string Id = gvIssues.DataKeys[index].Value.ToString();
                Response.Redirect("~/issue-list/edit-issue?IssueID=" + Id);
            }
            else if (e.CommandName.Equals("deleteRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string Id = gvIssues.DataKeys[index].Value.ToString();
                hfDeleteId.Value = Id;
                Helpers.ShowModal(this, this, "deleteModal");
            }
        }

        protected void IssueDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            IQueryable issues = null;

            if(ddlClient.SelectedValue != "0")
            {
                issues = db.Issues.Where(c => c.ClientID.ToString() == ddlClient.SelectedValue);
            }
            else
            {
                issues = db.Issues;
            }

            e.Result = issues;
        }

        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gvIssues.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var i = db.Issues.Where(n => n.IssueID.ToString() == hfDeleteId.Value).FirstOrDefault();
            db.Issues.DeleteOnSubmit(i);
            db.SubmitChanges();

            this.gvIssues.DataBind();
            Helpers.HideModal(this, this, "deleteModal");
        }
    }
}