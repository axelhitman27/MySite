<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SharkSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="table table-striped"
                      PageSize="10" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        </asp:GridView>

    </div>
</asp:Content>