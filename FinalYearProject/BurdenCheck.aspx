<%@ Page Title="Checking Burden of Proof" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BurdenCheck.aspx.cs" Inherits="FinalYearProject.BurdenCheck" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center">
        <table style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
            <tr>
                <td style="text-align:left;">
                    <asp:Label runat="server" ID="lblUsername"></asp:Label> <asp:Label runat="server" ID="lblCategory"></asp:Label>&emsp; 
                    <asp:Label runat="server" ID="lblSubcategory"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblWhichParty"></asp:Label>
                </td>
                <td style="text-align:right;width:50%">
                    <asp:Button runat="server" ID="btnHome" Width="15%" Height="30pt" Text="Home" OnClick="btnHome_Click" /> &emsp;
                    <asp:Button runat="server" ID="btnSignOut" Width="15%" Height="30pt" Text="Sign Out" Enabled="false" Visible="false" OnClick="btnSignOut_Click" />
                </td>
            </tr>
        </table>
        <h1>Checking Burden of Proof</h1>
        <h2>Select Current Stage of Suit</h2>
    </div>
    <br />
    <div class="row">
        <Table class="table" style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="width:30%;">
                    </td>
                    <td style="text-align:left">
                        <asp:RadioButtonList ValidationGroup="Next" ID="rblBurden" runat="server" CssClass="Space" Style="font-size:24px;text-align:left">
                            
                        </asp:RadioButtonList>
                        <br />
                        <br />
                        <asp:Button ValidationGroup="Next" runat="server" ID="btnNext" CssClass="btn btn-primary" Width="15%" Height="30pt" Text="Next" style="margin-left:50px" OnClick="btnNext_Click"/>
                        <br />
                        <asp:RequiredFieldValidator runat="server" ValidationGroup="Next" ID="RF_Burden" ForeColor="Red" ErrorMessage="*Please select what stage of the law suit you are at" ControlToValidate="rblBurden"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CustomValidator runat="server" ID="valBurden" ForeColor="Red"></asp:CustomValidator>
                    </td>
                    <td style="width:10%">

                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        <asp:Button runat="server" ID="btnBack" CssClass="btn btn-primary" Width="25%" Height="30pt" Text="Back" style="margin-left:5px" OnClick="btnBack_Click"/>
                    </td>
                </tr>
            </Table>
    </div>
</asp:Content>
