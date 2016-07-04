using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.client_list
{
    public partial class edit_client : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Request.QueryString["ClientID"] == null)
                {
                    Response.Redirect("~/client-list/list");
                }
                else
                {
                    var client = db.Clients.Where(i => i.ClientID.ToString() == Request.QueryString["ClientID"]).FirstOrDefault();
                    if (client != null)
                    {
                        txtClientName.Text = client.ClientName;
                        txtUserName.Text = client.UserName;
                        txtEmail.Text = client.Email;
                        txtPhoneNumber.Text = client.Phone;
                        ddlState.SelectedValue = client.State;
                    }
                    else
                    {
                        Response.Redirect("~/client-list/list");
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                var c = db.Clients.Where(i => i.ClientID.ToString() == Request.QueryString["ClientID"]).FirstOrDefault();
                c.ClientName = txtClientName.Text.Trim();
                c.UserName = txtUserName.Text.Trim();
                c.Email = txtEmail.Text;
                c.Phone = txtPhoneNumber.Text;
                c.State = ddlState.SelectedValue;

                db.SubmitChanges();
                Response.Redirect("~/client-list/list");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/client-list/list");
        }
    }
}