using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace DAL
{
    public class AtorDAL
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=BDLOCADORA;Integrated Security=True";
        //Post
        public void InserirAtor(Ator ator)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "INSERT INTO ATORES VALUES (@NMATOR, @DTNASCIMENTO, @NACIONALIDADE)";
            SqlCommand cmd = new SqlCommand(sql, conn);            
            cmd.Parameters.AddWithValue("@NMATOR", ator.NmAtor);
            cmd.Parameters.AddWithValue("@DTNASCIMENTO", ator.DtNascimento);
            cmd.Parameters.AddWithValue("@NACIONALIDADE", ator.Nacionalidade);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Delete
        public void ExcluirAtor(int idAtor)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "DELETE FROM ATORES WHERE IdAtor= @IDATOR";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDATOR", idAtor);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //Get
        public Ator BuscarAtorPorId (int idAtor)

        {
            Ator ator = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM ATORES WHERE idAtor = @IDATOR";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDATOR", idAtor);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                ator = new Ator();
                ator.idAtor = idAtor;
                ator.NmAtor = dr["Ator"].ToString();
                ator.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                ator.Nacionalidade = dr["Nacionalidade"].ToString();           
                
            }
            conn.Close();
            return ator;
        }

        public List<Ator> ListarAtores()
        {
            List<Ator> listaAtores = new List<Ator>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM ATORES";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Ator ator;
                while (dr.Read())
                {
                    ator = new Ator();
                    ator.idAtor = Convert.ToInt32(dr["idAtor"]);
                    ator.NmAtor = dr["Ator"].ToString();
                    ator.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    ator.Nacionalidade = dr["Nacionalidade"].ToString();
                    listaAtores.Add(ator);                    
                }
            }
            conn.Close();
            return listaAtores;
        }
    }
}
