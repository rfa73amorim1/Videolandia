<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="WebUI.CadastroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Novo Cadastro</h2>
    <h3>Página para cadastro de novo usuario</h3>

    <div class="form-horizontal"> 

        <f class="text-sucess">
           <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </f>

         <hr/>

        <div class="form-group">
            <asp:Label ID="lblNmUsuario" runat="server" Text="Nome do Usuário" CssClass="col-md-2 control-label"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNmUsuario" runat="server" CssClass="col-md-10 form-control"></asp:TextBox>
        </div>

          <div class="form-group">
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="col-md-2 control-label"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" CssClass="col-md-10 form-control" TextMode="Email"></asp:TextBox>
        </div>

         <div class="form-group">
            <asp:Label ID="lblSenha" runat="server" Text="Digite a Senha" CssClass="col-md-2 control-label"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSenha" runat="server" CssClass="col-md-10 form-control" style="left: 0px; top: 0px" TextMode="Password"></asp:TextBox>
         </div>

        <div class="form-group">
            <asp:Label ID="lblSenhaConfima" runat="server" Text="Repia a Senha digitada" CssClass="col-md-2 control-label"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="cvSenhaConfirma" runat="server" ControlToValidate="txtSenhaConfirma" ErrorMessage="Senha Não confere" ControlToCompare="txtSenha" ForeColor="Red"></asp:CompareValidator>
            <asp:TextBox ID="txtSenhaConfirma" runat="server" CssClass="col-md-10 form-control" TextMode="Password"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <div class="col-md-offset-2 col-md-02">
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="btnCadastrar_Click" />
            </div>
            
        </div>
        </div>



</asp:Content>
