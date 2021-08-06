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
            <td>係數 : </td>
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
        <p style="color:red">
            請輸入基數與係數!
        </p>
    </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="plcIntMsg" visible="false">
        <p style="color:red">
            請輸入正確數字!!
        </p>
    </asp:PlaceHolder>
</asp:Content>
