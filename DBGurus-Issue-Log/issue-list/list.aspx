<%@ Page Title="Issues" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="DBGurus_Issue_Log.issue_list.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">Issues</div>

                <div class="panel-body">
                    <div class="form-inline">
                        <div class="form-group">
                            <asp:DropDownList ID="ddlClient" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlClient_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
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
                                        <asp:TemplateField HeaderText="Client Name" SortExpression="Client.ClientName">
                                            <ItemTemplate>
                                                <asp:Label ID="lbtnClientName" runat="server" Text='<%# Eval("Client.ClientName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status" SortExpression="Status.StatusName">
                                            <ItemTemplate>
                                                <asp:Label ID="lbtnStatus" runat="server" Text='<%# Eval("Status.StatusName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="ResolvedDate" HeaderText="Resolved Date" SortExpression="ResolvedDate" DataFormatString="{0:d}" />
                                        <asp:ButtonField Text="Edit" CommandName="editRecord" />
                                        <asp:ButtonField Text="Delete" CommandName="deleteRecord" />
                                    </Columns>
                                    <PagerStyle CssClass="pagination-ys" />
                                </asp:GridView>
                                <asp:LinkButton ID="lblCreate"
                                    runat="server"
                                    CssClass="navbar-link"
                                    PostBackUrl="~/issue-list/add-issue">Create Issue</asp:LinkButton>
                            </ContentTemplate>
                            <Triggers>
                                <asp:PostBackTrigger ControlID="ddlClient" />
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

    <asp:LinqDataSource ID="IssueDataSource"
        OnSelecting="IssueDataSource_Selecting"
        runat="server">
    </asp:LinqDataSource>

</asp:Content>
