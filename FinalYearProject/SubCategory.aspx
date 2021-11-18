<%@ Page Title="Subcategory Selection" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubCategory.aspx.cs" Inherits="FinalYearProject.SubCategory" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center">
        <table style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
            <tr>
                <td style="text-align:left;">
                    <asp:Label runat="server" ID="lblUsername"></asp:Label> <asp:Label runat="server" ID="lblCategory"></asp:Label>
                    <br />
                    <asp:Label runat="server" ID="lblWhichParty"></asp:Label>
                </td>
                <td style="text-align:right;width:50%">
                    <asp:Button runat="server" ID="btnHome" Width="15%" Height="30pt" Text="Home" OnClick="btnHome_Click" /> &emsp;
                    <asp:Button runat="server" ID="btnSignOut" Width="15%" Height="30pt" Text="Sign Out" Enabled="false" Visible="false" OnClick="btnSignOut_Click" />
                </td>
            </tr>
        </table>
        <h2 runat="server" id="hrTitle"></h2>
    </div>
    <br />
    <div class="row">
        <Table class="table" style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="width:35%;">
                    </td>
                    <td style="text-align:left">
                        <asp:RadioButtonList ID="rblSubcategories" runat="server" CssClass="Space" Style="font-size:24px;text-align:left">
                            
                        </asp:RadioButtonList>
                        <br />
                        <br />
                        <asp:Button ValidationGroup="Next" runat="server" ID="btnNext" CssClass="btn btn-primary" Width="15%" Height="30pt" Text="Next" style="margin-left:50px" OnClick="btnNext_Click"/>
                        <br />
                        <asp:RequiredFieldValidator ValidationGroup="Next" runat="server" ID="RF_Subcategory" ForeColor="Red" ErrorMessage="*Please select a subcategory" ControlToValidate="rblSubcategories"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        <asp:Button runat="server" ID="btnBack" CssClass="btn btn-primary" Width="20%" Height="30pt" Text="Back" style="margin-left:5px" OnClick="btnBack_Click"/>
                    </td>
                </tr>
            </Table>
    </div>
</asp:Content>
