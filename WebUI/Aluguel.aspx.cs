using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;
using System.Data.SqlClient;

namespace WebUI
{
    public partial class Aluguel : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblData.Text = DateTime.Now.ToShortDateString();

                if (Request.QueryString["idFilme"] != null)
                {
                    int idfilme = Convert.ToInt32(Request.QueryString["idFilme"]);                      
                    
                    FilmeDAL filmeDAL = new FilmeDAL();
                    Filme filme = filmeDAL.BuscarFilmePorCodigo(idfilme);
                    List<Filme> lista = new List<Filme>();
                    lista.Add(filme);
                    grvAlugar.DataSource = lista;
                    grvAlugar.DataBind();
                    lblMensagem.Text = "Codigo Filme# " + idfilme;
                    imgFilme.ImageUrl = filmeDAL.BuscarFotoDoFilmePorIdFilme(idfilme);     


                }


                

            }
        }

        protected void btnAlugar_Click(object sender, EventArgs e)
        {
           
            DateTime dtLocacao = Convert.ToDateTime(txtDtLocacao.Text);
            DateTime dtDevolucao = Convert.ToDateTime(txtDtDevolucao.Text);
            TimeSpan periodo = dtDevolucao - dtLocacao;
            lblMensagem.Text = string.Empty;
            lblMensagem.Text = "Período de Locação: " + periodo + " dias. Devolução para: " + dtDevolucao;

            int idfilme = Convert.ToInt32(Request.QueryString["idFilme"]);
            
            FilmeDAL filmeDAL = new FilmeDAL();
            filmeDAL.AlugarFilme(idfilme);    
            

            

        }

    }
}