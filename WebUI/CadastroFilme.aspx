<%@ Page Title="CadastroFilme" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroFilme.aspx.cs" Inherits="WebUI.CadastroFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastro de Filmes</h2>
    <h3>Página para cadastro e atualização de filmes e Séries</h3>
    <div class="form-horizontal"> 
        <f class="text-sucess">
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </f>

        <hr/>
        <div class="form-group">
            <asp:Label ID="lblCodigo" runat="server" Text="Código" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
            <div class="col-md-offset-2 col-md-02">
                 &nbsp;&nbsp;
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-default" OnClick="btnBuscar_Click" CausesValidation="False" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCodigoBarra" runat="server" Text="Código de Barras" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtCodigoBarra" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

         
        <div class="form-group">
            <asp:Label ID="lblTitulo" runat="server" Text="Título" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblGenero" runat="server" Text="Gênero" CssClass="col-md-2 control-label"></asp:Label>
            <asp:DropDownList ID="ddlGenero" runat="server">
                <asp:ListItem>Ação</asp:ListItem>
                <asp:ListItem>Aventura</asp:ListItem>
                <asp:ListItem>Comédia</asp:ListItem>
                <asp:ListItem>Drama</asp:ListItem>
                <asp:ListItem>Fantasia</asp:ListItem>
                <asp:ListItem>Ficção</asp:ListItem>
                <asp:ListItem>Musical</asp:ListItem>
                <asp:ListItem>Romance</asp:ListItem>
                <asp:ListItem>Suspense</asp:ListItem>
                <asp:ListItem>Terror</asp:ListItem>
            </asp:DropDownList>            
        </div>
        
        <div class="form-group">
             <div class="col-md-offset-2 col-md-02">
             <asp:LinkButton ID="lblInserirAtor" runat="server" PostBackUrl="~/CadastroAtor.aspx">Inserir/Selecionar Ator</asp:LinkButton>
             </div>
         </div>

         <div class="form-group">
            <asp:Label ID="lblAtor" runat="server" Text="Ator" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtAtor" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px" ></asp:TextBox>
        </div>


         <div class="form-group">
            <asp:Label ID="lblAno" runat="server" Text="Ano de Lançamento" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtAno" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDiretor" runat="server" Text="Diretor" CssClass="col-md-2 control-label"></asp:Label>            
            <asp:TextBox ID="txtDiretor" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTipo" runat="server" Text="Tipo" CssClass="col-md-2 control-label"></asp:Label>
            <asp:DropDownList ID="ddlTipo" runat="server">
                <asp:ListItem>Filme</asp:ListItem>
                <asp:ListItem>Série</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <asp:Label ID="lblTecnologia" runat="server" Text="Tecnologia" CssClass="col-md-2 control-label"></asp:Label>
            <asp:DropDownList ID="ddlTecnologia" runat="server">
                <asp:ListItem>Dvd</asp:ListItem>
                <asp:ListItem>Blu-ray</asp:ListItem>
                <asp:ListItem>Blu-ray 3D</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <asp:Label ID="lblPreco" runat="server" Text="Preço" CssClass="col-md-2 control-label"></asp:Label>
            <asp:CompareValidator ID="cvPreco" runat="server" ControlToValidate="txtPreco" ErrorMessage="Valor inválido" ForeColor="Red" Operator="DataTypeCheck" Type="Currency">*</asp:CompareValidator>
            <asp:TextBox ID="txtPreco" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblCusto" runat="server" Text="Custo" CssClass="col-md-2 control-label"></asp:Label>
            <asp:CompareValidator ID="cvCusto" runat="server" ControlToValidate="txtCusto" ErrorMessage="Valor inválido" ForeColor="Red" Operator="DataTypeCheck" Type="Currency">*</asp:CompareValidator>
            <asp:TextBox ID="txtCusto" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDtAquisicao" runat="server" Text="Data de Aquisição" CssClass="col-md-2 control-label"></asp:Label>
            <asp:CompareValidator ID="cvDtAquisicao" runat="server" ControlToValidate="txtDtAquisicao" ErrorMessage="Data inválida" ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
            <asp:TextBox ID="txtDtAquisicao" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblStatus" runat="server" Text="Status" CssClass="col-md-2 control-label"></asp:Label>
            <asp:DropDownList ID="ddlStatus" runat="server">
                <asp:ListItem>Disponível</asp:ListItem>
                <asp:ListItem>Indisponível</asp:ListItem>
            </asp:DropDownList>
        </div>

         <div class="form-group">
            <asp:Label ID="lblFoto" runat="server" Text="Url da foto" CssClass="col-md-2 control-label"></asp:Label>
            <asp:TextBox ID="txtURLdaFoto" runat="server" CssClass="col-md-5 form-control" style="left: 0px; top: 0px"></asp:TextBox>
        </div>
       
        <div class="form-group">
             <div class="col-md-offset-2 col-md-02">
                <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-default" OnClick="btnAtualizar_Click" />
                
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-default" OnClick="btnExcluir_Click" CausesValidation="False" OnClientClick="return confirm('Deseja realmente excluir esse filme?') " />
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" CssClass="btn btn-default" OnClick="btnInserir_Click" />               
                 &nbsp;&nbsp;
                 <asp:LinkButton ID="lkbVoltar" runat="server" PostBackUrl="~/Default.aspx">Voltar</asp:LinkButton>
               
                 <br />
                 <br />
                 
                 
                 <br />               
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                 <br />
                
                 <asp:GridView ID="grvFilmes" runat="server" AutoGenerateColumns="False" OnRowCommand="grvFilmes_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="grvFilmes_SelectedIndexChanged">
                     <AlternatingRowStyle BackColor="#CCCCCC" />
                     <Columns>
                         <asp:BoundField DataField="idFilme" HeaderText="Códig" >
                         <HeaderStyle HorizontalAlign="Center" />
                         <ItemStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Titulo" HeaderText="Título" >
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Genero" HeaderText="Gênero">
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Ano" HeaderText="Ano " >
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Ator" HeaderText="Ator Principal" >
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Diretor" HeaderText="Diretor">
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         <asp:BoundField DataField="Status" HeaderText="Status" >                         
                         <HeaderStyle HorizontalAlign="Center" />
                         </asp:BoundField>
                         
                         <asp:TemplateField HeaderText="Ação">
                             <ItemTemplate>
                                 <asp:LinkButton ID="lkbSelecionarFilme" runat="server" CommandName="SelecionarFilme" CommandArgument='<%# Eval("idFilme") %>'>Selecionar</asp:LinkButton>
                             </ItemTemplate>
                         </asp:TemplateField>
                         
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
                 <br/>                       
               </div>
          </div>

    </div>
</asp:Content>
