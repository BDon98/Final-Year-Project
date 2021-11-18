<%@ Page Title="Sign-In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalYearProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align:center">
        <h1>&nbsp;Shifting Burdens</h1>
        <h2>Sign-In</h2>
    </div>

    <div class="row">
        <Table class="table" style="min-width:768px;text-align:center;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="border-right: 2px solid gray;width:50%;">
                        <h3>Sign in as user</h3>
                            <br />
                            <br />
                            <asp:Label runat="server" ID="lblUsername" Text="Username: " CssClass="inputLabel"/>
                            <asp:TextBox runat="server" Width="40%" ID="txtUsername"/><br />
                            <asp:RequiredFieldValidator validationgroup="SignIn" ID="RF_User" runat="server" ForeColor="Red" ErrorMessage="*Username Required" ControlToValidate="txtUsername"/>
                        <br />
                        <br />
                        <div>
                            <asp:Label runat="server" ID="lblPassword" Text="Password: " CssClass="inputLabel"/>
                            <asp:TextBox runat="server" Width="40%" ID="txtPassword"/><br />
                            <asp:RequiredFieldValidator ValidationGroup="SignIn" ID="RF_Pass" runat="server" ForeColor="Red" ErrorMessage="*Password Required" ControlToValidate="txtPassword"/>
                            <br />
                            <asp:CustomValidator ValidationGroup="SignIn" ID="err_Login" runat="server" ForeColor = "Red"/>
                            <br />
                            <br />
                            <div style="text-align:center;">
                                <asp:Button runat="server" ValidationGroup="SignIn" ID="btnSignIn" CssClass="btn btn-primary" Width="25%" Height="30pt" Text="Sign-In" OnClick="btnSignIn_Click"/>
                            </div>
                        </div>
                    </td>
                    <td>
                        <h3>Or sign in as a guest</h3>
                        <br />
                        <br />
                        <div style="text-align:center">
                            <asp:Button runat="server" ID="btnPlaintiff" CssClass="btn btn-primary" Width="35%" Height="50pt" Text="Plaintiff" OnClick="btnPlaintiff_Click"/>
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Button runat="server" ID="btnDefendant" CssClass="btn btn-primary" Width="35%" Height="50pt" Text="Defendant" OnClick="btnDefendant_Click"/>
                            <br />
                            <br />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td style="text-align:left">
                        
                    </td>
                </tr>
            </Table>
        <div style="width:100%;min-width:768px;text-align:center">
            <h3 runat="server">Create An Account</h3>
            <br />
            <asp:Button runat="server" ID="btnSignUp" CssClass="btn btn-primary" Width="15%" Height="30pt" Text="Sign-Up" OnClick="btnSignUp_Click"/>
        </div>
    </div>
</asp:Content>