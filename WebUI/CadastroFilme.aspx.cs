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
    public partial class CadastroFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["NmAtor"] != null)
                {
                    string nmAtor = Request.QueryString["NmAtor"].ToString();
                    txtAtor.Text = nmAtor;
                }
                MostrarLista();
            }           

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.CodigoBarras = txtCodigoBarra.Text;
            filme.Titulo = txtTitulo.Text;
            filme.Genero = ddlGenero.SelectedValue;
            filme.Ano = txtAno.Text;
            filme.Ator = txtAtor.Text;
            filme.Diretor = txtDiretor.Text;
            filme.Tipo = ddlTipo.SelectedValue;
            filme.Tecnologia = ddlTecnologia.SelectedValue;
            filme.Preco = Convert.ToDecimal(txtPreco.Text);
            filme.Custo = Convert.ToDecimal(txtCusto.Text);
            filme.DtAquisicao = Convert.ToDateTime(txtDtAquisicao.Text);
            filme.Status = ddlStatus.SelectedValue;
            filme.ImageUrl = txtURLdaFoto.Text;
            FilmeDAL fiLmeDAL = new FilmeDAL();
            fiLmeDAL.InserirFilme(filme);
            lblMensagem.Text = "Filme cadastrado com sucesso";
            LimparCampos();
            MostrarLista();
           


        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            FilmeDAL filmeDAL = new FilmeDAL();
            Filme filme = filmeDAL.BuscarFilmePorCodigo(codigo);

            if (filme != null)

                {
                // Filme filme = new Filme();
                filme.idFilme = Convert.ToInt32(txtCodigo.Text);
                filme.CodigoBarras = txtCodigoBarra.Text;
                filme.Titulo = txtTitulo.Text;
                filme.Genero = ddlGenero.SelectedValue;
                filme.Ano = txtAno.Text;
                filme.Ator = txtAtor.Text;
                filme.Diretor = txtDiretor.Text;
                filme.Tipo = ddlTipo.SelectedValue;
                filme.Tecnologia = ddlTecnologia.SelectedValue;
                filme.Preco = Convert.ToDecimal(txtPreco.Text);
                filme.Custo = Convert.ToDecimal(txtCusto.Text);
                filme.DtAquisicao = Convert.ToDateTime(txtDtAquisicao.Text);
                filme.Status = ddlStatus.SelectedValue;
                filme.ImageUrl = txtURLdaFoto.Text;

                FilmeDAL fiLmeDAL = new FilmeDAL();
                    fiLmeDAL.AtualizarFilme(filme);
                    LimparCampos();
                    lblMensagem.Text = "Filme atualizado com sucesso";
                }
                else
                {
                    lblMensagem.Text = "Código do filme inválido";
                }

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            Excluir(codigo);            
        }

       protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            BuscarFilme(codigo);

        }

        private void Excluir(int codigo)
        {
            FilmeDAL filmeDAL = new FilmeDAL();
            Filme filme = filmeDAL.BuscarFilmePorCodigo(codigo);

            if (filme != null)
            {
                filmeDAL.ExcluirFilme(codigo);
                LimparCampos();
                lblMensagem.Text = "Filme excluido com sucesso";
            }
            else
            {
                lblMensagem.Text = "Código do filme inválido";
            }
        }        

        public void BuscarFilme(int codigo)
        {
            FilmeDAL filmeDAL = new FilmeDAL();
            Filme filme = filmeDAL.BuscarFilmePorCodigo(codigo);

            if (filme != null)
            {
                txtCodigo.Text = filme.idFilme.ToString();
                txtCodigoBarra.Text = filme.CodigoBarras;
                txtTitulo.Text = filme.Titulo;
                ddlGenero.SelectedValue = filme.Genero;
                txtAno.Text = filme.Ano;
                txtAtor.Text = filme.Ator;
                txtDiretor.Text = filme.Diretor;
                ddlTipo.SelectedValue = filme.Tipo;
                ddlTecnologia.SelectedValue = filme.Tecnologia;
                txtPreco.Text = Convert.ToString(filme.Preco);
                txtCusto.Text = Convert.ToString(filme.Custo);
                txtDtAquisicao.Text = Convert.ToString(filme.DtAquisicao);
                ddlStatus.SelectedValue = filme.Status;
                txtURLdaFoto.Text = filme.ImageUrl;
                lblMensagem.Text = "Filme selecionado com sucesso";
            }
            else
            {
                LimparCampos();
                lblMensagem.Text = "Filme não encontrado";
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCodigoBarra.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            ddlGenero.SelectedIndex = 0;
            txtAno.Text = string.Empty;
            txtAtor.Text = string.Empty;
            txtDiretor.Text = string.Empty;
            ddlTipo.SelectedIndex = 0;
            ddlTecnologia.SelectedIndex = 0;
            txtPreco.Text = string.Empty;
            txtCusto.Text = string.Empty;
            txtDtAquisicao.Text = string.Empty;
            ddlStatus.SelectedIndex = 0;
            txtURLdaFoto.Text = string.Empty;
            MostrarLista();
        }

        public void MostrarLista()
        {
            FilmeDAL filmeDal = new FilmeDAL();
            grvFilmes.DataSource = filmeDal.ListarFilmesCadastrados();
            grvFilmes.DataBind();      
        }

        protected void grvFilmes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            int codigo = Convert.ToInt32(e.CommandArgument);

            switch (comando)
            {             

                case "SelecionarFilme":
                    BuscarFilme(codigo);
                    break;
            }

        }

        protected void grvFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}