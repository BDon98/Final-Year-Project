<%@ Page Title="Account Creation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="FinalYearProject.SignUp" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center">
        <h1>Shifting Burdens</h1>
        <h2>Account Creation</h2>
    </div>

    <div class="row">
        <Table class="table" style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="width:35%;">
                    </td>
                    <td style="text-align:left">
                        <asp:Label runat="server" ID="lblName" style="margin-right:28px" Text="Name: "/>
                        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="RF_Name" ControlToValidate="txtName" ValidationGroup="SignUp" ForeColor="Red" ErrorMessage="*Please enter a name"/>
                        <br />
                        <br />

                        <asp:Label runat="server" ID="lblUsername" Text="Username: "/>
                        <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="RF_Username" ControlToValidate="txtUsername" ValidationGroup="SignUp" ForeColor="Red" ErrorMessage="*Please enter a username"/>
                        <br />
                        <asp:CustomValidator ValidationGroup="SignUp" ID="err_SignUp" runat="server" ErrorMessage="*The entered username is already in use" ForeColor = "Red"/>
                        <br />
                        <br />

                        <asp:Label runat="server" ID="lblPassword" style="margin-right:5px" Text="Password: "/>
                        <asp:TextBox runat="server" TextMode="Password" ID="txtPassword"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="RF_Password" ControlToValidate="txtPassword" ValidationGroup="SignUp" ForeColor="Red" ErrorMessage="*Please enter a password"/>
                        <br />
                        <br />
                        <br />
                        <asp:Button runat="server" ValidationGroup="SignUp" ID="btnSignUp" CssClass="btn btn-primary" style="margin-left:60px" Width="20%" Height="30pt" Text="Sign-Up" OnClick="btnSignUp_Click"/>
                    </td>
                    <td style="width:10%">

                    </td>
                </tr>
            </Table>
        <div class="col-md-4">
            <div style="min-width:768px;text-align:center">
                
            </div>
        </div>
    </div>
</asp:Content>
