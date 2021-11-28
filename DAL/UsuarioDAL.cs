using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace DAL
{




    public class UsuarioDAL
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=BDLOCADORA;Integrated Security=True";

        //Post        
        public void InserirUsuario (Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "INSERT INTO USUARIOS VALUES (@NmUsuario, @DsSenha, @Email)";
            SqlCommand cmd = new SqlCommand(sql, conn);//trocar os parametros de comando pelos valores
            cmd.Parameters.AddWithValue("@NmUsuario", usuario.NmUsuario);
            cmd.Parameters.AddWithValue("@DsSenha", usuario.DsSenha);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Get
         public Usuario BuscarUsuarioEmail (string email)

        {
            Usuario usuario = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM USUARIOS WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                usuario = new Usuario();
                
                usuario.NmUsuario = dr["NmUsuario"].ToString();
                usuario.DsSenha = dr["DsSenha"].ToString();
                usuario.Email = dr["Email"].ToString();
            }
            conn.Close();
            return usuario;           

        }

        public bool ValidarUsuario (string nome, string senha)
        {
            bool validado = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM USUARIOS WHERE NmUsuario = @nome AND DsSenha = @senha";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            SqlDataReader dr = cmd.ExecuteReader();
            validado = dr.HasRows;
            return validado;           
            //conn.Close();
        }

    }
}
