<%@ Page Title="Issues" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="DBGurus_Issue_Log.issue_list.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">Issues</div>

                <div class="panel-body">
                    <div class="form-inline">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlClient" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="table table-responsive">
                        <asp:UpdatePanel ID="upIssues" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvIssues"
                                    runat="server"
                                    CssClass="table table-striped table-hover dataTable"
                                    GridLines="None"
                                    AutoGenerateColumns="False"
                                    AllowPaging="True"
                                    AllowSorting="True"
                                    EmptyDataText="No Record(s) found"
                                    ShowHeaderWhenEmpty="True"
                                    DataKeyNames="IssueID"
                                    OnRowCommand="gvIssues_RowCommand"
                                    DataSourceID="IssueDataSource">
                                    <Columns>
                                        <asp:BoundField DataField="ClientName" HeaderText="Client Name" SortExpression="ClientName" />
                                        <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                                        <asp:BoundField DataField="ResolvedDate" HeaderText="Resolved Date" SortExpression="ResolvedDate" />
                                    </Columns>
                                    <PagerStyle CssClass="pagination-ys" />
                                </asp:GridView>
                                <asp:LinkButton ID="lblCreate"
                                    runat="server"
                                    CssClass="navbar-link"
                                    PostBackUrl="~/issue-list/add-issue">Create Issue</asp:LinkButton>
                            </ContentTemplate>
                            <Triggers>
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:LinqDataSource ID="IssueDataSource"
        OnSelecting="IssueDataSource_Selecting"
        runat="server">
    </asp:LinqDataSource>

</asp:Content>
