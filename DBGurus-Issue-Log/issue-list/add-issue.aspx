<%@ Page Title="Create Issue" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add-issue.aspx.cs" Inherits="DBGurus_Issue_Log.issue_list.add_issue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-2">Client Name: </label>
                    <div class="col-sm-5">
                        <asp:DropDownList ID="ddlClientName" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server"
                            InitialValue="0"
                            ControlToValidate="ddlClientName"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Client Name is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Issue Description: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtIssueDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                            runat="server"
                            ControlToValidate="txtIssueDescription"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Issue Description is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Status: </label>
                    <div class="col-sm-5">
                        <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6"
                            runat="server"
                            InitialValue="0"
                            ControlToValidate="ddlStatus"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Status is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Resolution: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtResolution" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                            runat="server"
                            ControlToValidate="txtResolution"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Resolution is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Resolved Date: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtResolvedDate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btnSubmit"
                            runat="server"
                            CssClass="btn btn-primary"
                            Text="Submit"
                            CausesValidation="true"
                            OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnCancel"
                            runat="server"
                            CssClass="btn btn-default"
                            Text="Cancel"
                            CausesValidation="false"
                            OnClick="btnCancel_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        $(function () {
            $('#<%= txtResolvedDate.ClientID%>').datepicker()
        });
    </script>
</asp:Content>
