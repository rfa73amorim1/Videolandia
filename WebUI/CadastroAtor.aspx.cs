using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class CadastroAtor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarAtores();
            }

        }

        protected void btnInserirAtor_Click(object sender, EventArgs e)
        {
            Ator ator = new Ator();
            //txtidAtor.Text = Convert.ToString(ator.idAtor);
            ator.NmAtor = txtNmAtor.Text;
            ator.DtNascimento = Convert.ToDateTime(txtDtNascimento.Text);
            ator.Nacionalidade = txtNacionalidade.Text;
            AtorDAL atorDAL = new AtorDAL();
            atorDAL.InserirAtor(ator);
            lblMensagem.Text = "Ator cadastrado com sucesso";
            LimparCampos();
        }
        

        protected void btnExcluirAtor_Click(object sender, EventArgs e)
        {
            int idAtor = Convert.ToInt32(txtidAtor.Text);
            Excluir(idAtor);
        }


        private void Excluir(int idAtor)
        {
            AtorDAL atorDAL = new AtorDAL();
            Ator ator = atorDAL.BuscarAtorPorId(idAtor);

            if (ator != null)
            {
                atorDAL.ExcluirAtor(idAtor);
                LimparCampos();
                lblMensagem.Text = "Ator excluido com sucesso";
            }
            else
            {
                lblMensagem.Text = "Código do Ator inválido";
            }
        }

        private void CarregarAtores()
        {
            AtorDAL atorDAL = new AtorDAL();
            grvAtores.DataSource = atorDAL.ListarAtores();
            grvAtores.DataBind();
        }

        private void BuscarAtor(int idAtor)
        {
            AtorDAL atorDAL = new AtorDAL();
            Ator ator = atorDAL.BuscarAtorPorId(idAtor);
            txtidAtor.Text = Convert.ToString(ator.idAtor);
            if (ator!=null)
            {
                txtidAtor.Text = ator.idAtor.ToString();
                txtNmAtor.Text = ator.NmAtor;
                txtDtNascimento.Text = Convert.ToString(ator.DtNascimento);
                txtNacionalidade.Text = ator.Nacionalidade;
            }

            else
            {
                LimparCampos();
                lblMensagem.Text = "Ator não cadastrado";
            }
            

        }

        public void LimparCampos()
        {
            txtidAtor.Text = string.Empty;
            txtNmAtor.Text = string.Empty;
            txtDtNascimento.Text = string.Empty;
            txtNacionalidade.Text = string.Empty;
            CarregarAtores();

        }

        protected void grvAtores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            int idAtor = Convert.ToInt32(e.CommandArgument);
            switch (comando)
            {
                case "SelecionarAtor":
                    BuscarAtor(idAtor);
                    break;
            }
        }

    } 
 }
