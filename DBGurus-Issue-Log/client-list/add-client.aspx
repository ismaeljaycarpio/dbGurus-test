<%@ Page Title="Add Client" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add-client.aspx.cs" Inherits="DBGurus_Issue_Log.client_list.add_client" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-2">Client Name: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtClientName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        runat="server"
                        ControlToValidate="txtClientName"
                        CssClass="label label-danger"
                        Display="Dynamic"
                        ErrorMessage="Client's Name is required"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">User Name: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Email Address: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">Phone Number: </label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-sm-2">State: </label>
                    <div class="col-sm-5">
                        <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btnSubmit" 
                            runat="server" 
                            CssClass="btn btn-primary" 
                            Text="Submit"
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
</asp:Content>
