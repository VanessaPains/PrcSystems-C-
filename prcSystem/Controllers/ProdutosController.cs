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
    public class ProdutosController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Produtos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Produtos ([DescProduto], [MarcaProduto], [UnidadeProduto], [ValorProduto], [DtCadastroProduto]) VALUES " +
                                                       "(@DescProduto, @MarcaProduto, @UnidadeProduto, @ValorProduto, @DtCadastroProduto)";

                cn.Parameters.Add("DescProduto", SqlDbType.VarChar).Value = obj.DescProduto;
                cn.Parameters.Add("MarcaProduto", SqlDbType.VarChar).Value = obj.MarcaProduto;
                cn.Parameters.Add("UnidadeProduto", SqlDbType.VarChar).Value = obj.UnidadeProduto;
                cn.Parameters.Add("ValorProduto", SqlDbType.Decimal).Value = obj.ValorProduto;
                cn.Parameters.Add("DtCadastroProduto", SqlDbType.DateTime2).Value = obj.DtCadastroProduto;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        /// <summary>
        /// metodo editar dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Produtos obj)
        {   //conexão com banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//conexão banco
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Produtos SET DescProduto = @DescProduto, MarcaProduto = @MarcaProduto," +
                    "UnidadeProduto = @UnidadeProduto, ValorProduto = @ValorProduto WHERE idProduto = @idProduto";

                cn.Parameters.Add("IdProduto", SqlDbType.Int).Value = obj.IdProduto;
                cn.Parameters.Add("DescProduto", SqlDbType.VarChar).Value = obj.DescProduto;
                cn.Parameters.Add("MarcaProduto", SqlDbType.VarChar).Value = obj.MarcaProduto;
                cn.Parameters.Add("UnidadeProduto", SqlDbType.VarChar).Value = obj.UnidadeProduto;
                cn.Parameters.Add("ValorProduto", SqlDbType.Decimal).Value = obj.ValorProduto;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de editar dados 
        public int Deletar(Produtos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Produtos WHERE IdProduto = @idProduto";

                cn.Parameters.Add("IdProduto", SqlDbType.Int).Value = obj.IdProduto;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //buscar dos dados do db
        public List<Produtos> Buscar(Produtos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Produtos WHERE IdProduto = @IdProduto";
                cn.Parameters.Add("idProduto", SqlDbType.Int).Value = obj.IdProduto;
                cn.Connection = con;

                SqlDataReader dr;
                List<Produtos> lista = new List<Produtos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produtos dados = new Produtos();
                        dados.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                        dados.DescProduto = Convert.ToString(dr["DescProduto"]);
                        dados.MarcaProduto = Convert.ToString(dr["MarcaProduto"]);
                        dados.UnidadeProduto = Convert.ToString(dr["UnidadeProduto"]);
                        dados.ValorProduto = Convert.ToDecimal(dr["ValorProduto"]);
                        dados.DtCadastroProduto = Convert.ToDateTime(dr["DtCadastroProduto"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        //metodo de listar dos do db
        public List<Produtos> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Produtos";

                cn.Connection = con;

                SqlDataReader dr;
                List<Produtos> lista = new List<Produtos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produtos dados = new Produtos();

                        dados.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                        dados.DescProduto = Convert.ToString(dr["DescProduto"]);
                        dados.MarcaProduto = Convert.ToString(dr["MarcaProduto"]);
                        dados.UnidadeProduto = Convert.ToString(dr["UnidadeProduto"]);
                        dados.ValorProduto = Convert.ToDecimal(dr["ValorProduto"]);
                        dados.DtCadastroProduto = Convert.ToDateTime(dr["DtCadastroProduto"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }
    }
}

