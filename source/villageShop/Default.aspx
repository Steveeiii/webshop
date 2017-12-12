<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webShop._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>.</h1>

    <asp:ListView ID="lstProducts" runat="server">
        <LayoutTemplate>
            <table runat="server" id="tblProducts">
                <tr runat="server" id="itemPlaceholder"></tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr runat="server">
                <td>
                    <asp:Image ID="imgPreview" runat="server" Width="50" Height="50" ImageUrl='<%#Eval("Image") %>' />
                </td>
                <td>
                    <asp:Label ID="lblProductName" runat="server" Text='<%#Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="lblSpecialOffer" runat="server" Text='<%#Eval("SpecialOffer") %>' />
                </td>
                <td>
                    <asp:Label ID="lblNormalPrice" runat="server" Text='<%#Eval("NormalPrice") %>' />
                </td>
                <td>
                    <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
