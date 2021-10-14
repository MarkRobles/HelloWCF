<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="HelloWCFClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>WCF</h1>
        <p class="lead">Proyecto cliente dummy para pruebas de WCF</p>
        <p>
            <asp:TextBox ID="txtNumero" runat="server" Text="Ingresa un numero"></asp:TextBox>
            <asp:Button  ID="btnTestWCF" runat="server" OnClick="btnTestWCF_Click" Text="Invocar WCF"/>
              <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </p>
    </div>

   
</asp:Content>
