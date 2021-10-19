<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMarcas.aspx.vb" Inherits="HelloWCFClient.frmMarcas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grdMarcas" runat="server"></asp:GridView>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Width="200px"  />

    <asp:Panel ID="popDatos" runat="server" Visible="false" ScrollBars="Both">
        <asp:Label ID="lblDescripcionCorta" runat="server" Text="Descripción Corta"></asp:Label>
        <asp:TextBox ID="txtDescripcionCorta" runat="server" Text="DescripcionCorta" PlaceHolder="Descripción Corta"></asp:TextBox>

        <asp:Label ID="lblDescripcionLarga" runat="server" Text="Descripción Larga"></asp:Label>
        <asp:TextBox ID="txtDescripcionLarga" runat="server" Text="DescripcionLarga" PlaceHolder="Descripción Larga"></asp:TextBox>

        <asp:Label ID="lblMargen" runat="server" Text="Margen"></asp:Label>
        <asp:TextBox ID="txtMargen" runat="server" Text="Margen" PlaceHolder="Margen"></asp:TextBox>

        <asp:Label ID="lblVisibilidad" runat="server" Text="¿Precio Visible al publico?"></asp:Label>
        <asp:CheckBox ID="chkVisibilidad" runat="server" />

        <asp:Label ID="lblSlogan" runat="server" Text="Slogan"></asp:Label>
        <asp:TextBox ID="txtSlogan" runat="server" Text="Slogan" PlaceHolder="Slogan"></asp:TextBox>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar"  OnClick="btnGuardar_Click" />
    </asp:Panel>
</asp:Content>
