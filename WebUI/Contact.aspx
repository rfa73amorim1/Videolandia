<%@ Page Title="Videolândia" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebUI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Página de Contato</h3>
    <address>
        Rua xxx, nº xx<br />
        Sorocaba<br />
        <abbr title="Phone">P:</abbr>
        (15) 333-33333
    </address>

    <address>
        <strong>Contato:</strong>   <a href="mailto:conato@videolandia.com">contato@videolandia.com</a><br />
        <strong>SAC:</strong> <a href="mailto:sac@videlonadia.com">sac@videolandia.com</a>
    </address>
</asp:Content>
