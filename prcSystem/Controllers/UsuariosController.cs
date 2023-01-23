using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Controllers
{
    public class UsuariosController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Usuarios obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Usuarios ([NomeUser], [Login],[Senha],[DtCadastroUser]) VALUES (@NomeUser, @Login, @Senha, @DtCadastroUser)";

                cn.Parameters.Add("NomeUser", SqlDbType.VarChar).Value = obj.NomeUser;
                cn.Parameters.Add("Login", SqlDbType.VarChar).Value = obj.Login;
                cn.Parameters.Add("Senha", SqlDbType.VarChar).Value = obj.Senha;
                cn.Parameters.Add("DtCadastroUser", SqlDbType.DateTime2).Value = obj.DtCadastroUser;
              

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de listar dos do db
        public List<Usuarios> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Usuarios";

                cn.Connection = con;

                SqlDataReader dr;
                List<Usuarios> lista = new List<Usuarios>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuarios dados = new Usuarios();

                        dados.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                        dados.NomeUser = Convert.ToString(dr["nomeUser"]);
                        dados.Login = Convert.ToString(dr["login"]);
                        dados.Senha = Convert.ToString(dr["senha"]);
                        dados.DtCadastroUser = Convert.ToDateTime(dr["dtCadastroUser"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        /// <summary>
        /// metodo de editar dados 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Usuarios obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//confuracao do appconfig- aponta sua conexao
                SqlCommand cn = new SqlCommand();//comando 
                cn.CommandType = CommandType.Text;//comando do tipo texto
                con.Open();//abrir conexao
                cn.CommandText = "UPDATE Usuarios SET nomeUser = @nomeUser, login = @login, senha = @senha WHERE idUsuario = @idUsuario";
               
                cn.Parameters.Add("IdUsuario", SqlDbType.Int).Value = obj.IdUsuario;//.int - aceita somente valores inteiros. obj.IdUsuario da entidade usuarios
                cn.Parameters.Add("NomeUser", SqlDbType.VarChar).Value = obj.NomeUser;
                cn.Parameters.Add("Login", SqlDbType.VarChar).Value = obj.Login;
                cn.Parameters.Add("Senha", SqlDbType.VarChar).Value = obj.Senha;
                //cn.Parameters.Add("DtCadastroUser", SqlDbType.DateTime2).Value = obj.DtCadastroUser;

                cn.Connection = con;//solicita a conexao 

                int qte = cn.ExecuteNonQuery();//
                return qte;
            }
        }

        //metodo de editar dados 
        public int Deletar(Usuarios obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Usuarios WHERE idUsuario = @idUsuario";

                cn.Parameters.Add("idUsuario", SqlDbType.Int).Value = obj.IdUsuario;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

    }
}
