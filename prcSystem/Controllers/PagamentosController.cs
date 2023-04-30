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
    public class PagamentosController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Pagamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                //cn.CommandText = "INSERT INTO Lancamentos ([TipoLancamento], [IdPessoa], [IdCdc], [NumDocumento], [DtLancamento], [DtEmissao], [DtVencimento], [DtPagamento], [IdUsuario], [Prod01], [Prod02], [Prod03], [Prod04], [Prod05], [Qte01], [Qte02], [Qte03], [Qte04], [Qte05], [VrUnit01], [VrUnit02], [VrUnit03], [VrUnit04], [VrUnit05], [TtItens01], [TtItens02], [TtItens03], [TtItens04], [TtItens05], [ValorTotal], [Comentarios]) VALUES " +
                //                                     "(@TipoLancamento, @IdPessoa, @IdCdc, @NumDocumento, @DtLancamento, @DtEmissao, @DtVencimento, @DtPagamento, @IdUsuario, @Prod01, @Prod02, @Prod03, @Prod04, @Prod05, @Qte01, @Qte02, @Qte03, @Qte04, @Qte05, @VrUnit01, @VrUnit02, @VrUnit03, @VrUnit04, @VrUnit05, @TtItens01, @TtItens02, @TtItens03, @TtItens04, @TtItens05, @ValorTotal, @Comentarios)";

                cn.CommandText = "INSERT INTO Pagamentos ([IdLancamento], [TipoLancamento], [IdPessoa], [IdCdc], [NumDoc], [DtLancamento], [DtEmissao], [DtVencimento], [DtPagamento], [ValorTotal], [Comentarios], [Situacao],[JurosPagto], [TotalPagoPagto], [PagoEm]) " +
                                            "VALUES (@IdLancamento, @TipoLancamento, @IdPessoa, @IdCdc, @NumDoc, @DtLancamento, @DtEmissao, @DtVencimento, @DtPagamento, @ValorTotal, @Comentarios, @Situacao, @JurosPagto, @TotalPagoPagto, @PagoEm)";

                cn.Parameters.Add("IdLancamento", SqlDbType.Int).Value = obj.IdLancamento;
                cn.Parameters.Add("TipoLancamento", SqlDbType.VarChar).Value = obj.TipoLancamento;
                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                cn.Parameters.Add("IdCdc", SqlDbType.Int).Value = obj.IdCdc;
                cn.Parameters.Add("NumDoc", SqlDbType.VarChar).Value = obj.NumDoc;
                cn.Parameters.Add("DtLancamento", SqlDbType.DateTime2).Value = obj.DtLancamento;
                cn.Parameters.Add("DtEmissao", SqlDbType.DateTime2).Value = obj.DtEmissao;
                cn.Parameters.Add("DtVencimento", SqlDbType.DateTime2).Value = obj.DtVencimento;
                cn.Parameters.Add("DtPagamento", SqlDbType.DateTime2).Value = obj.DtPagamento;
                cn.Parameters.Add("ValorTotal", SqlDbType.Decimal).Value = obj.ValorTotal;
                cn.Parameters.Add("Comentarios", SqlDbType.VarChar).Value = obj.Comentarios;
                cn.Parameters.Add("Situacao", SqlDbType.VarChar).Value = obj.Situacao;

                cn.Parameters.Add("JurosPagto", SqlDbType.Decimal).Value = obj.JurosPagto;
                cn.Parameters.Add("TotalPagoPagto", SqlDbType.Decimal).Value = obj.TotalPagoPagto;
                cn.Parameters.Add("PagoEm", SqlDbType.VarChar).Value = obj.PagoEm;

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
                    "ValorTotal = @ValorTotal, Comentarios = @Comentarios, Situacao = @Situacao," +
                    "JurosPagto = @JurosPagto, TotalPagoPagto = @TotalPagoPagto, PagoEm = @PagoEm WHERE IdPagamntos = @IdPagamentos";
              
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
                cn.Parameters.Add("Situacao", SqlDbType.VarChar).Value = obj.Situacao;

                cn.Parameters.Add("JurosPagto", SqlDbType.Decimal).Value = obj.JurosPagto;
                cn.Parameters.Add("TotalPagoPagto", SqlDbType.Decimal).Value = obj.TotalPagoPagto;
                cn.Parameters.Add("PagoEm", SqlDbType.VarChar).Value = obj.PagoEm;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de listar dos do db do menu de lancamentos
        public List<Pagamentos> ListarTodos()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                //cn.CommandText = "SELECT * FROM Lancamentos ";
                cn.CommandText = "SELECT " +
                    "               l.IdPagamentos," +
                    "               l.IdLancamento,l.TipoLancamento, " +
                    "               p.IdPessoa, p.RazaoNome, p.CnpjCpf, " +
                    "               c.IdCdc, c.CodCdc, c.DescricaoCdc," +
                    "               l.NumDoc, l.DtLancamento, l.DtEmissao, l.DtVencimento, " +
                    "               l.DtPagamento,l.ValorTotal, l.Comentarios, l.Situacao" +
                    "               FROM Pagamentos l" +
                    "               INNER JOIN Pessoa p ON l.IdPessoa = p.IdPessoa" +
                    "               INNER JOIN Cdc c ON l.IdCdc = c.CodCdc" +
                    "               ORDER BY l.IdLancamento";

                cn.Connection = con;

                SqlDataReader dr;
                List<Pagamentos> lista = new List<Pagamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pagamentos dados = new Pagamentos();
                        Cdc cdc = new Cdc();
                        Pessoa pessoa = new Pessoa();

                        dados.IdPagamentos = Convert.ToInt32(dr["IdPagamentos"]);
                        dados.IdLancamento = Convert.ToInt32(dr["IdLancamento"]);
                        dados.TipoLancamento = Convert.ToString(dr["TipoLancamento"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.CnpjCpf = Convert.ToString(dr["CnpjCpf"]);
                        dados.IdCdc = Convert.ToInt32(dr["IdCdc"]);
                        dados.DescricaoCdc = Convert.ToString(dr["DescricaoCdc"]);
                        dados.CodCdc = Convert.ToString(dr["CodCdc"]);
                        dados.NumDoc = Convert.ToString(dr["NumDoc"]);
                        dados.DtLancamento = Convert.ToDateTime(dr["DtLancamento"]);
                        dados.DtEmissao = Convert.ToDateTime(dr["DtEmissao"]);
                        dados.DtVencimento = Convert.ToDateTime(dr["DtVencimento"]);
                        dados.DtPagamento = Convert.ToDateTime(dr["DtPagamento"]);
                        dados.ValorTotal = Convert.ToDecimal(dr["ValorTotal"]);
                        dados.Comentarios = Convert.ToString(dr["Comentarios"]);
                        dados.Situacao = Convert.ToString(dr["Situacao"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

    }
}
