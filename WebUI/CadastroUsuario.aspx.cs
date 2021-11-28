using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace WebUI
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {          
          
            Usuario usuario = new Usuario();
            usuario.NmUsuario = txtNmUsuario.Text;
            usuario.DsSenha = txtSenha.Text;
            usuario.Email = txtEmail.Text;
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.InserirUsuario(usuario);
            lblMensagem.Text = "Usuário Cadastrado com Sucesso";
            //Tem como fatorar o método "Limpar Campos" ou fazer algo mais elegante?
            txtNmUsuario.Text = "";
            txtEmail.Text = "";           
           
        }

        
    }
}