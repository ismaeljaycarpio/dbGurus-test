using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBGurus_Issue_Log.status_list
{
    public partial class list : System.Web.UI.Page
    {
        IssueDataContext db = new IssueDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gvStatus.DataBind();
        }

        protected void gvStatus_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("editRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //load status
                var status = (from s in db.Status
                         where s.StatusID.Equals((int)gvStatus.DataKeys[index].Value)
                         select s).FirstOrDefault();

                lblStatusID.Text = status.StatusID.ToString(); //bind to static control
                txtEditStatus.Text = status.StatusName;

                Helpers.ShowModal(this, this, "updateModal");
            }
            else if (e.CommandName.Equals("deleteRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string Id = gvStatus.DataKeys[index].Value.ToString();
                hfDeleteId.Value = Id;

                Helpers.ShowModal(this, this, "deleteModal");
            }
        }

        protected void StatusDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            e.Result = db.Status.Where(s => s.StatusName.Contains(txtSearch.Text.Trim())).ToList();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate("vgAdd");
            if(Page.IsValid)
            {
                Status stat = new Status();
                stat.StatusName = txtAddStatus.Text.Trim();

                db.Status.InsertOnSubmit(stat);
                db.SubmitChanges();

                gvStatus.DataBind();
                Helpers.HideModal(this, this, "addModal");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Page.Validate("vgEdit");
            if(Page.IsValid)
            {
                var status = db.Status.Where(i => i.StatusID == Convert.ToInt32(lblStatusID.Text)).FirstOrDefault();
                status.StatusName = txtEditStatus.Text.Trim();
                db.SubmitChanges();

                gvStatus.DataBind();
                Helpers.HideModal(this, this, "updateModal");             
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var status = db.Status.Where(i => i.StatusID == Convert.ToInt32(hfDeleteId.Value)).FirstOrDefault();
            db.Status.DeleteOnSubmit(status);
            db.SubmitChanges();

            gvStatus.DataBind();
            Helpers.HideModal(this, this, "deleteModal");
        }
    }
}