<%@ Page Title="Edit Client" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit-client.aspx.cs" Inherits="DBGurus_Issue_Log.client_list.edit_client" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-2">Client Name: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtClientName" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server"
                            ControlToValidate="txtClientName"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Client's Name is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">User Name: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                            runat="server"
                            ControlToValidate="txtUserName"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="UserName is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Email Address: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                            runat="server"
                            ControlToValidate="txtEmail"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Email is required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                            runat="server"
                            ControlToValidate="txtEmail"
                            Display="Dynamic"
                            CssClass="label label-danger"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ErrorMessage="Invalid Email format"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Phone Number: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                            runat="server"
                            ControlToValidate="txtPhoneNumber"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="Phone Number is required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                            runat="server"
                            ControlToValidate="txtPhoneNumber"
                            Display="Dynamic"
                            CssClass="label label-danger"
                            ValidationExpression="^(0)[0-9]"
                            ErrorMessage="10 digits - must start with a 0"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">State: </label>
                    <div class="col-sm-5">
                        <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                            runat="server"
                            InitialValue="0"
                            ControlToValidate="ddlState"
                            CssClass="label label-danger"
                            Display="Dynamic"
                            ErrorMessage="State is required"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btnUpdate"
                            runat="server"
                            CssClass="btn btn-primary"
                            Text="Update"
                            CausesValidation="true"
                            OnClick="btnUpdate_Click" />
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
</asp:Content>
