<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Escuela.aspx.cs" Inherits="ClienteCsharp.Escuela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consultas a la Tabla Escuela</h1>
    <br/>
    <p>Consultar: <asp:TextBox runat="Server" ID="txtTexto"/>
        <asp:DropDownList runat="server" ID="ddlCriterio">
        <asp:ListItem Text="CodEscuela"/>
        <asp:ListItem Text="Escuela"/>
        </asp:DropDownList>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click"/>
        &nbsp;CodEscuela:<asp:TextBox runat="Server" ID="txtTexto0"/>
        &nbsp;Escuela:<asp:TextBox runat="Server" ID="txtTexto1"/>
            <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click"/>
            <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click"/>
            <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click"/>
        </p>
    <p>
        <asp:Gridview runat="server" ID="gvEscuela">
            </asp:Gridview>
        </p>

</asp:Content>
