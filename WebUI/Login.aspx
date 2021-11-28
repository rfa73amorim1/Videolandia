<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Página de Login</h2>
        <div class="form-horizontal">            

             <div class="form-group">  
                 <h4>
                 <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" EnableTheming="True" Height="249px" Width="489px" BackColor="White" BorderColor="#CCCC99" BorderStyle="None" BorderWidth="1px" Font-Bold="False" Font-Names="Arial" Font-Size="Large" RememberMeText="    Lembrar na próxima vez." TitleText="Fazer Login">
                 <LabelStyle HorizontalAlign="Justify" />
                     <TitleTextStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                  </asp:Login>
                     </h4>
              </div>

                <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
                 <br />

                 <h4>Esqueceu a Senha?</h4>
                 <h4>Digite seu endereço de e-mail e nós lhe enviaremos instruções sobre como criar uma nova senha</h4>

              <div class="form-group">
                  <asp:Label ID="lblEmailCadastrado" runat="server" Text="E-mail cadastrado: " CssClass="col-md-2 control-label"></asp:Label>
                   &nbsp;&nbsp;&nbsp;
                   &nbsp;&nbsp;&nbsp;
                   &nbsp;
                  <asp:TextBox ID="txtEmailCadastrado" runat="server" CssClass="col-md-10 form-control" style="left: 0px; top: 0px" TextMode="Email"></asp:TextBox>
              </div>

              <div class="form-group">
                <div class="col-md-offset-2 col-md-02">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
              &nbsp;</div>





       


        &nbsp;&nbsp;&nbsp;
              </div>
        
      
        </div>
</asp:Content>
