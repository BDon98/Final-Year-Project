<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuitManagement.aspx.cs" Inherits="FinalYearProject.SuitManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align:center">
        <Table class="table" style="width:100%;min-width:768px;margin-left: auto;margin-right: auto;">
                <tr>
                    <td style="width:25%;">
                        <asp:Label runat="server" ID="lblUsername" Text="(Username)"/>
                        <br />
                        <asp:Label runat="server" ID="lblName" Text="(Name)"/>
                    </td>
                    <td style="text-align:left;">
                        <asp:CheckBox runat="server" Text=" "/>
                        &emsp;
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblSuitName" Text="Suit Name"/>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Description" Text="Description"/>
                    </td>
                    <td>

                    </td>
                    <td>
                        <br /><br /><br />
                    </td>
                </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnCreate" Height="50%" Width="50%" Text="Start New Suit" />
                    <br />
                    <br />
                    <asp:Button runat="server" ID="btnDelete" Height="50%" Width="50%" Text="Delete Selected Suit" />
                </td>
                <td style="width:100%">
                    <asp:GridView runat="server" ID="gvSuits">
                        <Columns>
                            <asp:CheckBoxField />
                            <asp:BoundField DataField="SuitName" />
                            <asp:BoundField DataField="Description" />
                            <asp:ButtonField  />
                            <asp:BoundField DataField="WhichParty"/>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnChange" Height="50%" Width="50%" Text="Change User Details" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" ID="btnSignOut" Height="50%" Width="50%" Text="Sign-Out" />
                </td>
            </tr>
            </Table>

    </div>
</asp:Content>
