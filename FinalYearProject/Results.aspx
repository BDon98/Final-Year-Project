<%@ Page Title="Results" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="FinalYearProject.Results" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center">
        <br />
        <h2 runat="server" id="hrTitle">Burden of Proof lies on </h2>
    </div>
    <br />
    <div class="row">
        <Table class="table" style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="width:25%;">
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblResult">
                        </asp:Label>
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
