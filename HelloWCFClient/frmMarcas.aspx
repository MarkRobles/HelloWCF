<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMarcas.aspx.vb" Inherits="HelloWCFClient.frmMarcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="grdMarcas" runat="server"></asp:GridView>

   <asp:TextBox ID="txtDescripcionCorta" runat="server"  Text="DescripcionCorta" PlaceHolder="Descripción Corta" ></asp:TextBox>

</asp:Content>
