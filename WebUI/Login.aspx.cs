using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            e.Authenticated = usuarioDAL.ValidarUsuario(Login1.UserName, Login1.Password);

            
            //Comando para senha criptografada no BD
            /*UsuarioDAL usuarioDAL = new UsuarioDAL();
            string nome = Login1.UserName;
            string senhaHash = Criptografia.GetMD5Hash(Login1.Password);
             e.Authenticated = usuarioDAL.ValidarUsuario(nome, senhaHash);*/

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string emailCadastrado = txtEmailCadastrado.Text;
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Usuario usuario = usuarioDAL.BuscarUsuarioEmail(emailCadastrado);
            if (usuario!=null)
            {
                lblMensagem.Text = "Instruções para recuperação de senha enviada para o e-mail:  " + emailCadastrado;
                txtEmailCadastrado.Text = "";
            }
            else
            {
                lblMensagem.Text = "E-mail não encontrado, digite novamente";
                txtEmailCadastrado.Text = "";
            }
        }
    }        
 }