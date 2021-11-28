using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MostrarLista();
            }

        }

        public void MostrarLista()
        {
            FilmeDAL filmeDal = new FilmeDAL();
            grvPrincipal.DataSource = filmeDal.ListarFilmesCadastrados();
            grvPrincipal.DataBind();


        }


        protected void ibtnBuscarPorNome_Click(object sender, ImageClickEventArgs e)
        {
            string nome = txtBuscarPorNome.Text;
            FilmeDAL filmeDal = new FilmeDAL();

            grvPrincipal.DataSource = filmeDal.ListarFilmesPorNomes(txtBuscarPorNome.Text);
            grvPrincipal.DataBind();
            lblMensagem.Text = "**";
        }

        protected void grvPrincipal_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            int idFilme = Convert.ToInt32(e.CommandArgument);
            FilmeDAL filmeDAL1 = new FilmeDAL();

            switch (comando)
            {
                case "SelecionarPrincipal":
                    filmeDAL1.BuscarFilmePorCodigo(idFilme);
                    lblMensagem.Text = "Como eu faço pra jogar esse filme pelo idFilme e mandar para a pagina Aluguel?";
                    break;

            }

        }

        protected void grvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}