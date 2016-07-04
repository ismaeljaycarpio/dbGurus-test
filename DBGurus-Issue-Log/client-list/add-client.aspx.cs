using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.client_list
{
    public partial class add_client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                using(var db = new IssueDataContext())
                {
                    Client c = new Client();
                    c.ClientName = txtClientName.Text.Trim();
                    c.UserName = txtUserName.Text.Trim();
                    c.Email = txtEmail.Text.Trim();
                    c.Phone = txtPhoneNumber.Text.Trim();
                    c.State = ddlState.SelectedValue;

                    db.Clients.InsertOnSubmit(c);
                    db.SubmitChanges();

                    Response.Redirect("~/client-list/list");
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/client-list/list");
        }
    }
}