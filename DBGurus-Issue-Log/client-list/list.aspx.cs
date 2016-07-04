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

        }

        protected void ClientsDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            string search = txtSearch.Text.Trim();

            e.Result = db.Clients.Where(s =>
                s.ClientName.Contains(search) ||
                s.UserName.Contains(search) ||
                s.State.Contains(search)).ToList();
        }
    }
}