<%@ Page Title="Cadastro Ator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAtor.aspx.cs" Inherits="WebUI.CadastroAtor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Videolândia -&nbsp; Atores</h2>
    <h3>Página para cadastro de Ator(es)</h3>

    <div class="form-horizontal">
         <div class="form-horizontal">
             
        <f class="text-sucess">
           <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </f>
         <hr/>

         <div class="form-group">
             <asp:Label ID="lblidAtor" runat="server" Text="Código do Ator" CssClass="col-md-2 control-label"></asp:Label>
             <asp:TextBox ID="txtidAtor" runat="server" CssClass="col-md-10 form-control"></asp:TextBox>
         </div>

         <div class="form-group">
             <asp:Label ID="lblNmAtor" runat="server" Text="Nome do Ator" CssClass="col-md-2 control-label"></asp:Label>
             <asp:TextBox ID="txtNmAtor" runat="server" CssClass="col-md-10 form-control"></asp:TextBox>
         </div>

         <div class="form-group">
             <asp:Label ID="lblDtNascimento" runat="server" Text="Data Nascimento Ator" CssClass="col-md-2 control-label"></asp:Label>
             <asp:TextBox ID="txtDtNascimento" runat="server" CssClass="col-md-10 form-control"></asp:TextBox>
         </div>

         <div class="form-group">
             <asp:Label ID="lblNacionalidade" runat="server" Text="Nacionalidade" CssClass="col-md-2 control-label"></asp:Label>
             <asp:TextBox ID="txtNacionalidade" runat="server" CssClass="col-md-10 form-control"></asp:TextBox>
         </div>

         <div class="form-group">
             <div class="col-md-offset-2 col-md-02">
                 <asp:Button ID="btnInserirAtor" runat="server" Text="Inserir" CssClass="btn btn-default" OnClick="btnInserirAtor_Click"  />
                 <asp:Button ID="btnExcluirAtor" runat="server" CssClass="btn btn-default" OnClientClick="return confirm('Deseja realmente excluir esse registro?') " PostBackUrl="~/CadastroFilme.aspx" Text="Excluir" OnClick="btnExcluirAtor_Click" />
                 <asp:LinkButton ID="lkbVoltar" runat="server" PostBackUrl="~/CadastroFilme.aspx" OnClick="Page_Load">Voltar</asp:LinkButton>
                 &nbsp;&nbsp;&nbsp;
                 <br />
                 <br />


                 <asp:GridView ID="grvAtores" runat="server" AutoGenerateColumns="False" OnRowCommand="grvAtores_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                     <AlternatingRowStyle BackColor="#CCCCCC" />
                     <Columns>



                         <asp:BoundField DataField="idAtor" HeaderText="Código" >
                         <ItemStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="NmAtor" HeaderText="Ator" />
                         <asp:BoundField DataField="DtNascimento" HeaderText="Data Nasc." />
                         <asp:BoundField DataField="Nacionalidade" HeaderText="Nacionalidade" />
                         <asp:TemplateField HeaderText="Ação">
                             <ItemTemplate>
                                 <asp:LinkButton ID="lkbSelecionarAtor" runat="server" CommandName ="SelecionarAtor" CommandArgument='<%# Eval("idAtor") %>'>Selecionar</asp:LinkButton>
                             </ItemTemplate>
                             <FooterStyle HorizontalAlign="Right" />
                             <HeaderStyle HorizontalAlign="Center" />
                         </asp:TemplateField>
                         <asp:HyperLinkField DataNavigateUrlFields="NmAtor" DataNavigateUrlFormatString="CadastroFilme?NmAtor={0}" HeaderText="Carregar em &quot;filmes&quot;" Text="OK" >
                         <HeaderStyle HorizontalAlign="Center" />
                         <ItemStyle HorizontalAlign="Center" />
                         </asp:HyperLinkField>
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
