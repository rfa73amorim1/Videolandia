using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FilmeDAL
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=BDLOCADORA;Integrated Security=True";
        //Post
        public void InserirFilme(Filme filme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();           
            string sql = "DECLARE @IDGENERO INT = (SELECT idGenero FROM GENEROS WHERE Genero = @GENERO), @IDATOR INT = (SELECT idAtor FROM ATORES WHERE Ator = @ATOR); INSERT INTO FILMES VALUES(@CODIGOBARRAS, @TITULO, @IDGENERO, @ANO, @IDATOR, @DIRETOR, @TIPO, @TECNOLOGIA, @PRECO, @CUSTO, @DTAQUISICAO, @STATUS, @FOTO)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CODIGOBARRAS", filme.CodigoBarras);
            cmd.Parameters.AddWithValue("@TITULO", filme.Titulo);
            cmd.Parameters.AddWithValue("@GENERO", filme.Genero);
            cmd.Parameters.AddWithValue("@ANO", filme.Ano);
            cmd.Parameters.AddWithValue("@ATOR", filme.Ator);
            cmd.Parameters.AddWithValue("@DIRETOR", filme.Diretor);             
            cmd.Parameters.AddWithValue("@TIPO", filme.Tipo);
            cmd.Parameters.AddWithValue("@TECNOLOGIA", filme.Tecnologia);
            cmd.Parameters.AddWithValue("@PRECO", filme.Preco);
            cmd.Parameters.AddWithValue("@CUSTO", filme.Custo);
            cmd.Parameters.AddWithValue("@DTAQUISICAO", filme.DtAquisicao);
            cmd.Parameters.AddWithValue("@STATUS", filme.Status);
            cmd.Parameters.AddWithValue("@FOTO", filme.ImageUrl);
            cmd.ExecuteNonQuery();
            conn.Close();

           
        }
       
        //Put
        public void AtualizarFilme(Filme filme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "UPDATE FILMES SET CodigoBarras = @CODIGOBARRAS, Titulo = @TITULO, idGenero = (SELECT idGenero FROM GENEROS WHERE Genero = @GENERO), Ano = @ANO, idAtor = (SELECT idAtor FROM ATORES WHERE Ator = @ATOR), " +
                "Diretor = @DIRETOR, Tipo = @TIPO, Tecnologia = @TECNOLOGIA, Preco = @PRECO, Custo = @CUSTO,  DtAquisicao = @DTAQUISICAO, Status = @STATUS, Foto = @FOTO WHERE idFilme = @IDFILME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CODIGOBARRAS", filme.CodigoBarras);
            cmd.Parameters.AddWithValue("@TITULO", filme.Titulo);           
            cmd.Parameters.AddWithValue("@GENERO", filme.Genero);
            cmd.Parameters.AddWithValue("@ANO", filme.Ano);
            cmd.Parameters.AddWithValue("@ATOR", filme.Ator);
            cmd.Parameters.AddWithValue("@DIRETOR", filme.Diretor);
            cmd.Parameters.AddWithValue("@TIPO", filme.Tipo);
            cmd.Parameters.AddWithValue("@TECNOLOGIA", filme.Tecnologia);
            cmd.Parameters.AddWithValue("@PRECO", filme.Preco);
            cmd.Parameters.AddWithValue("@CUSTO", filme.Custo);
            cmd.Parameters.AddWithValue("@DTAQUISICAO", filme.DtAquisicao);
            cmd.Parameters.AddWithValue("@STATUS", filme.Status);
            cmd.Parameters.AddWithValue("@IDFILME", filme.idFilme);
            cmd.Parameters.AddWithValue("@FOTO", filme.ImageUrl);
           
            cmd.ExecuteNonQuery();
            conn.Close();
        }       

        //Get
        public Filme BuscarFilmePorCodigo (int idFilme)

        {
            Filme filme = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT F.idFilme, F.CodigoBarras, F.Titulo, G.Genero, F.Ano, A.Ator, F.Diretor, F.Tipo, F.Tecnologia, F.Preco, F.Custo, F.DtAquisicao, F.Status, F.Foto" +
                " FROM FILMES F, ATORES A, GENEROS G " +
                "WHERE F.idGenero = G.idGenero AND F.idAtor = A.idAtor AND IdFilme = @IDFILME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFILME", idFilme);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                filme = new Filme();                
                filme.idFilme = idFilme;
                filme.CodigoBarras = dr["CodigoBarras"].ToString();
                filme.Titulo = dr["Titulo"].ToString();
                filme.Genero = dr["Genero"].ToString();
                filme.Ano = dr["Ano"].ToString();
                filme.Ator = dr["Ator"].ToString();
                filme.Diretor = dr["Diretor"].ToString();
                filme.Tipo = dr["Tipo"].ToString();
                filme.Tecnologia = dr["Tecnologia"].ToString();
                filme.Preco = Convert.ToDecimal(dr["Preco"]);
                filme.Custo = Convert.ToDecimal(dr["Custo"]);
                filme.DtAquisicao = Convert.ToDateTime(dr["DtAquisicao"]);
                filme.Status = dr["Status"].ToString();
                filme.ImageUrl = dr["Foto"].ToString();
            }
            conn.Close();
            return filme;           

        }
        public Filme BuscarFilmesPorNomes(string nome)
        {
            Filme filme = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT TOP 10 F.idFilme, F.Titulo, G.Genero, F.Ano, A.Ator, F.Diretor, F.Status FROM FILMES F LEFT JOIN ATORES A ON F.idAtor = A.idAtor LEFT JOIN GENEROS G ON F.idGenero = G.idGenero WHERE F.Titulo = @NOME OR A.Ator = @NOME% OR G.Genero = @NOME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NOME", nome);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                filme = new Filme();
                filme.idFilme = Convert.ToInt32(dr["idFilme"]);
                filme.Titulo = dr["Titulo"].ToString();
                filme.Genero = dr["Genero"].ToString();
                filme.Ano = dr["Ano"].ToString();
                filme.Ator = dr["Ator"].ToString();
                filme.Diretor = dr["Diretor"].ToString();
                filme.Status = dr["Status"].ToString();
            }
            conn.Close();
            return filme;
        }
        public string BuscarFotoDoFilmePorIdFilme(int idfilme)
        {
            Filme filme = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT Foto FROM FILMES WHERE idFilme = @IDFILME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFILME", idfilme);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                filme = new Filme();
                filme.ImageUrl = dr["Foto"].ToString();
            }
            conn.Close();
            return filme.ImageUrl;
        }
        public List<Filme> ListarFilmesCadastrados()
        {
            List<Filme> filmesCadastrados = new List<Filme>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT F.idFilme, F.CodigoBarras, F.Titulo, G.Genero, F.Ano, A.Ator, F.Diretor, F.Tipo, F.Tecnologia, F.Preco, F.Custo, F.DtAquisicao, F.Status, F.Foto" +
               " FROM FILMES F, ATORES A, GENEROS G " +
               "WHERE F.idGenero = G.idGenero AND F.idAtor = A.idAtor";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Filme filme;
                while (dr.Read())
                {
                    filme = new Filme();
                    filme.idFilme = Convert.ToInt32(dr["idFilme"]);
                    filme.CodigoBarras = dr["CodigoBarras"].ToString();
                    filme.Titulo = dr["Titulo"].ToString();
                    filme.Genero = dr["Genero"].ToString();
                    filme.Ano = dr["Ano"].ToString();
                    filme.Ator = dr["Ator"].ToString();
                    filme.Diretor = dr["Diretor"].ToString();
                    filme.Tipo = dr["Tipo"].ToString();
                    filme.Tecnologia = dr["Tecnologia"].ToString();
                    filme.Preco = Convert.ToDecimal(dr["Preco"]);
                    filme.Custo = Convert.ToDecimal(dr["Custo"]);
                    filme.DtAquisicao = Convert.ToDateTime(dr["DtAquisicao"]);
                    filme.Status = dr["Status"].ToString();
                    filme.ImageUrl = dr["Foto"].ToString();

                    filmesCadastrados.Add(filme);
                }
            }

            conn.Close();
            return filmesCadastrados;
        }
        public List<Filme> ListarFilmesPorNomes(string nome)
        {
            List<Filme> filmesCadastradosPorNome = new List<Filme>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT TOP 10 F.idFilme, F.Titulo, G.Genero, F.Ano, A.Ator, F.Diretor, F.Status FROM FILMES F LEFT JOIN ATORES A ON F.idAtor = A.idAtor LEFT JOIN GENEROS G ON F.idGenero = G.idGenero WHERE F.Titulo = @NOME OR A.Ator = @NOME OR G.Genero = @NOME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NOME", nome);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Filme filme;
                while (dr.Read())
                {
                    filme = new Filme();
                    filme.idFilme = Convert.ToInt32(dr["idFilme"]);
                    filme.Titulo = dr["Titulo"].ToString();
                    filme.Genero = dr["Genero"].ToString();
                    filme.Ano = dr["Ano"].ToString();
                    filme.Ator = dr["Ator"].ToString();
                    filme.Diretor = dr["Diretor"].ToString();
                    filme.Status = dr["Status"].ToString();
                    filmesCadastradosPorNome.Add(filme);
                }
            }


            conn.Close();
            return filmesCadastradosPorNome;
        }

        //Delete
        public void ExcluirFilme(int IdFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "DELETE FROM FILMES WHERE IdFilme= @IDFILME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFILME", IdFilme);
            cmd.ExecuteNonQuery();
            conn.Close();                      
        }   
        
        public void AlugarFilme(int idfilme)

        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "UPDATE FILMES SET Status = 'Indisponível' WHERE idFilme = @IDFILME";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDFILME", idfilme);
            cmd.ExecuteNonQuery();
            conn.Close();

        }




    }
}
