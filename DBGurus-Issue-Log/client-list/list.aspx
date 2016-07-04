<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="DBGurus_Issue_Log.client_list.list" %>

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

    <asp:LinqDataSource ID="ClientsDataSource"
        OnSelecting="ClientsDataSource_Selecting"
        runat="server">
    </asp:LinqDataSource>

</asp:Content>
