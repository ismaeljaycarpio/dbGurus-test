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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void gvStatus_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("editRecord"))
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //load room
                //var q = (from r in db.Rooms
                //         where r.Id.Equals((int)gvRoom.DataKeys[index].Value)
                //         select r).FirstOrDefault();

                //lblRowId.Text = q.Id.ToString();
                //txtEditType.Text = q.Type;
                //txtEditRoom.Text = q.Room1;

                Helpers.ShowModal(this, this, "updateModal");
            }
            else if (e.CommandName.Equals("deleteRecord"))
            {
                //int index = Convert.ToInt32(e.CommandArgument);
                //string rowId = ((Label)gvRoom.Rows[index].FindControl("lblRowId")).Text;
                //hfDeleteId.Value = rowId;

                Helpers.ShowModal(this, this, "deleteModal");
            }
        }

        protected void StatusDataSource_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}