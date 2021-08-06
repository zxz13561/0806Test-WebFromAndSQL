<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test0806.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>基數 : </td>
            <td>
                <asp:TextBox runat="server" ID="txtBaseNumber"/>
            </td>
        </tr>
        <tr>
            <td>系數 : </td>
            <td>
                <asp:TextBox runat="server" ID="txtColNumber"/>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button Text="產生" runat="server" ID="btnCreate" OnClick="btnCreate_Click" />
            </td>
        </tr>
    </table>
    <asp:PlaceHolder runat="server" ID="plcMsg" visible="false">
        Wrong Input!!
    </asp:PlaceHolder>
</asp:Content>
