using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.client_list
{
    public partial class list : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.gvClients.DataBind();
        }

        protected void gvClients_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("editRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string Id = gvClients.DataKeys[index].Value.ToString();
                Response.Redirect("~/client-list/edit-client?ClientID=" + Id);
            }
            else if(e.CommandName.Equals("deleteRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string Id = gvClients.DataKeys[index].Value.ToString();
                hfDeleteId.Value = Id;
                Helpers.ShowModal(this, this, "deleteModal");
            }
        }

        protected void ClientsDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            string search = txtSearch.Text.Trim();

            e.Result = db.Clients.Where(s =>
                s.ClientName.Contains(search) ||
                s.UserName.Contains(search) ||
                s.State.Contains(search)).ToList();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var client = db.Clients.Where(i => i.ClientID.ToString() == hfDeleteId.Value).FirstOrDefault();
            db.Clients.DeleteOnSubmit(client);
            db.SubmitChanges();

            this.gvClients.DataBind();
            Helpers.HideModal(this, this, "deleteModal");
        }
    }
}