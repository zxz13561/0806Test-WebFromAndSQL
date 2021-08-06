<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="OutputTable.aspx.cs" Inherits="Test0806.OutputTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PlaceHolder runat="server" ID="plcTableMsg" Visible="false">
        <p style="color:red">
             請輸入正確數字!
        </p>
        <asp:Button Text="回上頁" runat="server" ID="btnReturn" OnClick="btnReturn_Click"/>
    </asp:PlaceHolder>
    <asp:Table runat="server" ID="Table1" BorderStyle="Solid" GridLines="vertical">
    </asp:Table>
</asp:Content>
