<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2>Videolândia</h2>
<h3>Bem Vindo!</h3>
<h4>Busque o filme desejado ou selecione na lista abaixo</h4>

    <div class="form-horizontal">
         <div class="form-horizontal">             
         <hr/>
             <div class="form-group">
                 <asp:Label ID="lblBuscarPorNome" runat="server" Text="Buscar por Título, Ator ou Gênero" CssClass="col-md-2 control-label"></asp:Label>
                 <asp:TextBox ID="txtBuscarPorNome" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
                 <asp:ImageButton ID="ibtnBuscarPorNome" runat="server" Height="35px" ImageUrl="~/Imagens/buscar.png" OnClick="ibtnBuscarPorNome_Click" />
             </div>

             <f class="text-sucess">
                 <asp:Label ID="lblMensagem" runat="server"></asp:Label>
             
             <br />
             <br />
             </f>

             <div class="form-group">

             </div>
         

         <div class="form-group">
              <div class="col-md-offset-2 col-md-02">
                  <asp:LinkButton ID="lkbRefresh" runat="server" PostBackUrl="~/Default.aspx">Refresh</asp:LinkButton>
                  <asp:GridView ID="grvPrincipal" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnRowCommand="grvPrincipal_RowCommand" OnSelectedIndexChanged="grvPrincipal_SelectedIndexChanged">
                      <AlternatingRowStyle BackColor="#CCCCCC" />
                      <Columns>
                          <asp:BoundField DataField="Titulo" HeaderText="Título" />
                          <asp:BoundField DataField="Genero" HeaderText="Gênero" />
                          <asp:BoundField DataField="Ator" HeaderText="Ator" />
                          <asp:BoundField DataField="Ano" HeaderText="Ano" />
                          <asp:BoundField DataField="Diretor" HeaderText="Diretor" />
                          <asp:BoundField DataField="Status" HeaderText="Status" />

                          <asp:HyperLinkField DataNavigateUrlFields="idFilme" DataNavigateUrlFormatString="Aluguel?idFilme={0}" HeaderText="Ação" Text="Selecionar" />

                      </Columns>

                      <FooterStyle BackColor="#CCCCCC" />
                      <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                      <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#808080" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#383838" />

                  </asp:GridView>

              </div>
             </div>

         </div>

    </div>
   
</asp:Content>
