
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace prcSystem.Controllers
{
    public class LancamentoController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                //cn.CommandText = "INSERT INTO Lancamentos ([TipoLancamento], [IdPessoa], [IdCdc], [NumDocumento], [DtLancamento], [DtEmissao], [DtVencimento], [DtPagamento], [IdUsuario], [Prod01], [Prod02], [Prod03], [Prod04], [Prod05], [Qte01], [Qte02], [Qte03], [Qte04], [Qte05], [VrUnit01], [VrUnit02], [VrUnit03], [VrUnit04], [VrUnit05], [TtItens01], [TtItens02], [TtItens03], [TtItens04], [TtItens05], [ValorTotal], [Comentarios]) VALUES " +
                //                                     "(@TipoLancamento, @IdPessoa, @IdCdc, @NumDocumento, @DtLancamento, @DtEmissao, @DtVencimento, @DtPagamento, @IdUsuario, @Prod01, @Prod02, @Prod03, @Prod04, @Prod05, @Qte01, @Qte02, @Qte03, @Qte04, @Qte05, @VrUnit01, @VrUnit02, @VrUnit03, @VrUnit04, @VrUnit05, @TtItens01, @TtItens02, @TtItens03, @TtItens04, @TtItens05, @ValorTotal, @Comentarios)";

                cn.CommandText = "INSERT INTO Lancamentos ([TipoLancamento], [IdPessoa], [IdCdc], [NumDocumento], [DtLancamento], [DtEmissao], [DtVencimento], [DtPagamento], [ValorTotal], [Comentarios]) " +
                                            "VALUES (@TipoLancamento, @IdPessoa, @IdCdc, @NumDocumento, @DtLancamento, @DtEmissao, @DtVencimento, @DtPagamento, @ValorTotal, @Comentarios)";
                          
                cn.Parameters.Add("TipoLancamento", SqlDbType.VarChar).Value = obj.TipoLancamento;
                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                cn.Parameters.Add("IdCdc", SqlDbType.Int).Value = obj.IdCdc;
                cn.Parameters.Add("NumDocumento", SqlDbType.VarChar).Value = obj.NumDocumento;
                cn.Parameters.Add("DtLancamento", SqlDbType.DateTime2).Value = obj.DtLancamento;
                cn.Parameters.Add("DtEmissao", SqlDbType.DateTime2).Value = obj.DtEmissao;
                cn.Parameters.Add("DtVencimento", SqlDbType.DateTime2).Value = obj.DtVencimento;
                cn.Parameters.Add("DtPagamento", SqlDbType.DateTime2).Value = obj.DtPagamento;         
                cn.Parameters.Add("ValorTotal", SqlDbType.Decimal).Value = obj.ValorTotal;
                cn.Parameters.Add("Comentarios", SqlDbType.VarChar).Value = obj.Comentarios;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        /// <summary>
        /// metodo editar dados no banco de dados de Lacamentos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Lancamentos obj)
        {   //conexão com banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//conexão banco
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Lancamentos SET TipoLancamento = @TipoLancamento, IdPessoa = @IdPessoa, IdCdc = @IdCdc, NumDocumento = @NumDocumento, " +
                    "DtLancamento = @DtLancamento, DtEmissao = @DtEmissao, DtVencimento = @DtVencimento, DtPagamento = @DtPagamento, " +
                    "ValorTotal = @ValorTotal, Comentarios = @Comentarios WHERE IdLancamento = @IdLancamento";

                cn.Parameters.Add("IdLancamento", SqlDbType.Int).Value = obj.IdLancamento;
                cn.Parameters.Add("TipoLancamento", SqlDbType.VarChar).Value = obj.TipoLancamento;
                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                cn.Parameters.Add("IdCdc", SqlDbType.Int).Value = obj.IdCdc;
                cn.Parameters.Add("NumDocumento", SqlDbType.VarChar).Value = obj.NumDocumento;
                cn.Parameters.Add("DtLancamento", SqlDbType.DateTime2).Value = obj.DtLancamento;
                cn.Parameters.Add("DtEmissao", SqlDbType.DateTime2).Value = obj.DtEmissao;
                cn.Parameters.Add("DtVencimento", SqlDbType.DateTime2).Value = obj.DtVencimento;
                cn.Parameters.Add("DtPagamento", SqlDbType.DateTime2).Value = obj.DtPagamento;
                cn.Parameters.Add("ValorTotal", SqlDbType.Decimal).Value = obj.ValorTotal;
                cn.Parameters.Add("Comentarios", SqlDbType.VarChar).Value = obj.Comentarios;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de editar dados do db Lancamentos
        public int Deletar(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Lancamentos WHERE IdLancamento = @IdLancamento";

                cn.Parameters.Add("IdLancamento", SqlDbType.Int).Value = obj.IdLancamento;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }        

        //buscar dos dados do db campo de pesquisar lancamentos do menu de lancamentos
        public List<Lancamentos> PesquisarFornCLi(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT " +
                    "               l.IdLancamento,l.TipoLancamento, " +
                    "               p.IdPessoa, p.RazaoNome, " +
                    "               c.IdCdc, c.CodCdc, c.DescricaoCdc," +
                    "               l.NumDocumento, l.DtLancamento, l.DtEmissao, l.DtVencimento, " +
                    "               l.DtPagamento,l.ValorTotal, l.Comentarios" +
                    "               FROM Lancamentos l"+
                    "               INNER JOIN Cdc c ON l.IdCdc = c.CodCdc" +
                    "               INNER JOIN Pessoa p ON l.IdPessoa = p.IdPessoa WHERE RazaoNome = @RazaoNome";
                             
                cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;

                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dados = new Lancamentos();
                        Cdc cdc = new Cdc();
                        Pessoa pessoa = new Pessoa();

                        dados.IdLancamento = Convert.ToInt32(dr["IdLancamento"]);
                        dados.TipoLancamento = Convert.ToString(dr["TipoLancamento"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.IdCdc = Convert.ToInt32(dr["IdCdc"]);
                        dados.DescricaoCdc = Convert.ToString(dr["DescricaoCdc"]);
                        dados.CodCdc = Convert.ToString(dr["CodCdc"]);
                        dados.NumDocumento = Convert.ToString(dr["NumDocumento"]);
                        dados.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                        dados.DtEmissao = Convert.ToDateTime(dr["DtEmissao"]);
                        dados.DtVencimento = Convert.ToDateTime(dr["DtVencimento"]);
                        dados.DtPagamento = Convert.ToDateTime(dr["DtPagamento"]);
                        dados.ValorTotal = Convert.ToDecimal(dr["ValorTotal"]);
                        dados.Comentarios = Convert.ToString(dr["Comentarios"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        //metodo de listar dos do db do menu de lancamentos
        public List<Lancamentos> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                //cn.CommandText = "SELECT * FROM Lancamentos ";
                cn.CommandText = "SELECT " +
                    "               l.IdLancamento,l.TipoLancamento, " +
                    "               p.IdPessoa, p.RazaoNome, " +
                    "               c.IdCdc, c.CodCdc, c.DescricaoCdc," +
                    "               l.NumDocumento, l.DtLancamento, l.DtEmissao, l.DtVencimento, " +
                    "               l.DtPagamento,l.ValorTotal, l.Comentarios" +
                    "               FROM Lancamentos l" +
                    "               INNER JOIN Pessoa p ON l.IdPessoa = p.IdPessoa" +
                    "               INNER JOIN Cdc c ON l.IdCdc = c.CodCdc";
               
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dados = new Lancamentos();
                        Cdc cdc = new Cdc();  
                        Pessoa pessoa = new Pessoa();   

                        dados.IdLancamento = Convert.ToInt32(dr["IdLancamento"]);
                        dados.TipoLancamento = Convert.ToString(dr["TipoLancamento"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.IdCdc = Convert.ToInt32(dr["IdCdc"]);
                        dados.DescricaoCdc = Convert.ToString(dr["DescricaoCdc"]);
                        dados.CodCdc = Convert.ToString(dr["CodCdc"]);
                        dados.NumDocumento = Convert.ToString(dr["NumDocumento"]);
                        dados.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                        dados.DtEmissao = Convert.ToDateTime(dr["DtEmissao"]);
                        dados.DtVencimento = Convert.ToDateTime(dr["DtVencimento"]);
                        dados.DtPagamento = Convert.ToDateTime(dr["DtPagamento"]);
                        dados.ValorTotal = Convert.ToDecimal(dr["ValorTotal"]);
                        dados.Comentarios = Convert.ToString(dr["Comentarios"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }
    }
}
