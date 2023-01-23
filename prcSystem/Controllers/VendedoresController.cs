using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prcSystem.Entidades;

namespace prcSystem.Controllers
{
    public class VendedoresController
    {
        //metodo inserir dados no banco de dados
        public int Inserir(Vendedores obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Vendedores ([NomeVendedor], [DtCadastroVendedor]) VALUES (@NomeVendedor, @DtCadastroVendedor)";

                cn.Parameters.Add("NomeVendedor", SqlDbType.VarChar).Value = obj.NomeVendedor;
                cn.Parameters.Add("DtCadastroVendedor", SqlDbType.DateTime2).Value = obj.DtCadastroVendedor;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de editar dados 
        public int Editar(Vendedores obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Vendedores SET nomeVendedor = @nomeVendedor  WHERE idVendedores = @idVendedores";

                cn.Parameters.Add("IdVendedores", SqlDbType.Int).Value = obj.IdVendedores;
                cn.Parameters.Add("NomeVendedor", SqlDbType.VarChar).Value = obj.NomeVendedor;
                //cn.Parameters.Add("DtCadastroVendedor", SqlDbType.DateTime2).Value = obj.DtCadastroVendedor;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de editar dados 
        public int Deletar(Vendedores obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Vendedores WHERE idVendedores = @idVendedores";

                cn.Parameters.Add("IdVendedores", SqlDbType.Int).Value = obj.IdVendedores;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }
        //metodo de listar dos do db
        public List<Vendedores> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Vendedores";

                cn.Connection = con;

                SqlDataReader dr;
                List<Vendedores> lista = new List<Vendedores>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vendedores dados = new Vendedores();

                        dados.IdVendedores = Convert.ToInt32(dr["idVendedores"]);
                        dados.NomeVendedor = Convert.ToString(dr["nomeVendedor"]);
                        dados.DtCadastroVendedor = Convert.ToDateTime(dr["dtCadastroVendedor"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }
    }
}
