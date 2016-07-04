<%@ Page Title="Clients" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="DBGurus_Issue_Log.client_list.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">Clients</div>

                <div class="panel-body">
                    <div class="form-inline">
                        <div class="form-group">
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Name, UserName, or State..."></asp:TextBox>
                            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="table table-responsive">
                        <asp:UpdatePanel ID="upClients" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvClients"
                                    runat="server"
                                    CssClass="table table-striped table-hover dataTable"
                                    GridLines="None"
                                    AutoGenerateColumns="False"
                                    AllowPaging="True"
                                    AllowSorting="True"
                                    EmptyDataText="No Record(s) found"
                                    ShowHeaderWhenEmpty="True"
                                    DataKeyNames="ClientID"
                                    OnRowCommand="gvClients_RowCommand"
                                    DataSourceID="ClientsDataSource">
                                    <Columns>
                                        <asp:BoundField DataField="ClientName" HeaderText="Client Name" SortExpression="ClientName"  />
                                        <asp:BoundField DataField="UserName" HeaderText="User Name" SortExpression="UserName"  />
                                        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State"  />

                                        <asp:ButtonField Text="Edit" CommandName="editRecord" />
                                        <asp:ButtonField Text="Delete" CommandName="deleteRecord" />
                                    </Columns>
                                    <PagerStyle CssClass="pagination-ys" />
                                </asp:GridView>
                                <asp:LinkButton ID="lblCreate"
                                    runat="server"
                                    CssClass="navbar-link"
                                    PostBackUrl="~/client-list/add-client">Create Client Profile</asp:LinkButton>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Delete Modal -->
    <div id="deleteModal" class="modal fade" tabindex="-1" aria-labelledby="deleteModalLabel" aria-hidden="true" role="dialog">
        <div class="modal-dialog">
            <!-- Modal content-->
            <div class="modal-content">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Delete Record</h4>
                        </div>
                        <div class="modal-body">
                            Are you sure you want to delete this record ?
                            <asp:HiddenField ID="hfDeleteId" runat="server" />
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btnDelete_Click" />
                            <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnDelete" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

    <asp:LinqDataSource ID="ClientsDataSource"
        OnSelecting="ClientsDataSource_Selecting"
        runat="server">
    </asp:LinqDataSource>

</asp:Content>
