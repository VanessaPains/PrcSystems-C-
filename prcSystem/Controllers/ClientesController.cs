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
    /// <summary>
    /// Impplementação tabela de cadastro de cliente das classes de CRUD de conexão com o banco de dados
    /// </summary>
    public class ClientesController
    {

        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /*public int Inserir(Clientes obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Clientes ([CnpjCpfCli], [InscEstadualCli], [OutrasInscCli], [NomeCli], [RazaoSocialCli], [EnderecoCli], [NumCli], [ComplementoCli], [CepCli],[BairroCli],[CidadeCli],[UfCli],[TelefoneCli],[CelularCli],[EmailCli],[SiteCli],[EnderecoCobCli],[NumCobCli],[ComplementoCobCli],[CepCobCli],[BairroCobCli],[CidadeCobCli],[UfCobCli],[ObservacaoCli],[DtCadastroCli]) VALUES " +
                                                       "(@CnpjCpfCli, @InscEstadualCli, @OutrasInscCli, @NomeCli, @RazaoSocialCli, @EnderecoCli, @NumCli, @ComplementoCli, @CepCli, @BairroCli, @CidadeCli, @UfCli, @TelefoneCli, @CelularCli, @EmailCli, @SiteCli, @EnderecoCobCli, @NumCobCli, @ComplementoCobCli, @CepCobCli, @BairroCobCli, @CidadeCobCli, @UfCobCli, @ObservacaoCli, @DtCadastroCli)";

                cn.Parameters.Add("CnpjCpfCli", SqlDbType.VarChar).Value = obj.CnpjCpfCli;
                cn.Parameters.Add("InscEstadualCli", SqlDbType.VarChar).Value = obj.InscEstadualCli;
                cn.Parameters.Add("OutrasInscCli", SqlDbType.VarChar).Value = obj.OutrasInscCli;
                cn.Parameters.Add("NomeCli", SqlDbType.VarChar).Value = obj.NomeCli;
                cn.Parameters.Add("RazaoSocialCli", SqlDbType.VarChar).Value = obj.RazaoSocialCli;
                cn.Parameters.Add("EnderecoCli", SqlDbType.VarChar).Value = obj.EnderecoCli;
                cn.Parameters.Add("NumCli", SqlDbType.VarChar).Value = obj.NumCli;
                cn.Parameters.Add("ComplementoCli", SqlDbType.VarChar).Value = obj.ComplementoCli;
                cn.Parameters.Add("CepCli", SqlDbType.VarChar).Value = obj.CepCli;
                cn.Parameters.Add("BairroCli", SqlDbType.VarChar).Value = obj.BairroCli;
                cn.Parameters.Add("CidadeCli", SqlDbType.VarChar).Value = obj.CidadeCli;
                cn.Parameters.Add("UfCli", SqlDbType.VarChar).Value = obj.UfCli;
                cn.Parameters.Add("TelefoneCli", SqlDbType.VarChar).Value = obj.TelefoneCli;
                cn.Parameters.Add("CelularCli", SqlDbType.VarChar).Value = obj.CelularCli;
                cn.Parameters.Add("EmailCli", SqlDbType.VarChar).Value = obj.EmailCli;
                cn.Parameters.Add("SiteCli", SqlDbType.VarChar).Value = obj.SiteCli;
                cn.Parameters.Add("EnderecoCobCli", SqlDbType.VarChar).Value = obj.EnderecoCobCli;
                cn.Parameters.Add("NumCobCli", SqlDbType.VarChar).Value = obj.NumCobCli;
                cn.Parameters.Add("ComplementoCobCli", SqlDbType.VarChar).Value = obj.ComplementoCobCli;
                cn.Parameters.Add("CepCobCli", SqlDbType.VarChar).Value = obj.CepCobCli;
                cn.Parameters.Add("BairroCobCli", SqlDbType.VarChar).Value = obj.BairroCobCli;
                cn.Parameters.Add("CidadeCobCli", SqlDbType.VarChar).Value = obj.CidadeCobCli;
                cn.Parameters.Add("UfCobCli", SqlDbType.VarChar).Value = obj.UfCobCli;
                cn.Parameters.Add("ObservacaoCli", SqlDbType.VarChar).Value = obj.ObservacaoCli;
                cn.Parameters.Add("DtCadastroCli", SqlDbType.DateTime2).Value = obj.DtCadastroCli;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }*/

        public int Inserir(Clientes obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Clientes ([CnpjCpfCli], [InscEstadualCli], [OutrasInscCli], [NomeCli], [RazaoSocialCli], [EnderecoCli], [NumCli], [ComplementoCli], [CepCli],[BairroCli],[CidadeCli],[UfCli],[TelefoneCli],[CelularCli],[EmailCli],[SiteCli],[EnderecoCobCli],[NumCobCli],[ComplementoCobCli],[CepCobCli],[BairroCobCli],[CidadeCobCli],[UfCobCli],[ObservacaoCli],[DtCadastroCli]) VALUES " +
                                                       "(@CnpjCpfCli, @InscEstadualCli, @OutrasInscCli, @NomeCli, @RazaoSocialCli, @EnderecoCli, @NumCli, @ComplementoCli, @CepCli, @BairroCli, @CidadeCli, @UfCli, @TelefoneCli, @CelularCli, @EmailCli, @SiteCli, @EnderecoCobCli, @NumCobCli, @ComplementoCobCli, @CepCobCli, @BairroCobCli, @CidadeCobCli, @UfCobCli, @ObservacaoCli, @DtCadastroCli)";

                cn.Parameters.Add("CnpjCpfCli", SqlDbType.VarChar).Value = obj.CnpjCpfCli;
                cn.Parameters.Add("InscEstadualCli", SqlDbType.VarChar).Value = obj.InscEstadualCli;
                cn.Parameters.Add("OutrasInscCli", SqlDbType.VarChar).Value = obj.OutrasInscCli;
                cn.Parameters.Add("NomeCli", SqlDbType.VarChar).Value = obj.NomeCli;
                cn.Parameters.Add("RazaoSocialCli", SqlDbType.VarChar).Value = obj.RazaoSocialCli;
                cn.Parameters.Add("EnderecoCli", SqlDbType.VarChar).Value = obj.EnderecoCli;
                cn.Parameters.Add("NumCli", SqlDbType.VarChar).Value = obj.NumCli;
                cn.Parameters.Add("ComplementoCli", SqlDbType.VarChar).Value = obj.ComplementoCli;
                cn.Parameters.Add("CepCli", SqlDbType.VarChar).Value = obj.CepCli;
                cn.Parameters.Add("BairroCli", SqlDbType.VarChar).Value = obj.BairroCli;
                cn.Parameters.Add("CidadeCli", SqlDbType.VarChar).Value = obj.CidadeCli;
                cn.Parameters.Add("UfCli", SqlDbType.VarChar).Value = obj.UfCli;
                cn.Parameters.Add("TelefoneCli", SqlDbType.VarChar).Value = obj.TelefoneCli;
                cn.Parameters.Add("CelularCli", SqlDbType.VarChar).Value = obj.CelularCli;
                cn.Parameters.Add("EmailCli", SqlDbType.VarChar).Value = obj.EmailCli;
                cn.Parameters.Add("SiteCli", SqlDbType.VarChar).Value = obj.SiteCli;
                cn.Parameters.Add("EnderecoCobCli", SqlDbType.VarChar).Value = obj.EnderecoCobCli;
                cn.Parameters.Add("NumCobCli", SqlDbType.VarChar).Value = obj.NumCobCli;
                cn.Parameters.Add("ComplementoCobCli", SqlDbType.VarChar).Value = obj.ComplementoCobCli;
                cn.Parameters.Add("CepCobCli", SqlDbType.VarChar).Value = obj.CepCobCli;
                cn.Parameters.Add("BairroCobCli", SqlDbType.VarChar).Value = obj.BairroCobCli;
                cn.Parameters.Add("CidadeCobCli", SqlDbType.VarChar).Value = obj.CidadeCobCli;
                cn.Parameters.Add("UfCobCli", SqlDbType.VarChar).Value = obj.UfCobCli;
                cn.Parameters.Add("ObservacaoCli", SqlDbType.VarChar).Value = obj.ObservacaoCli;
                cn.Parameters.Add("DtCadastroCli", SqlDbType.DateTime2).Value = obj.DtCadastroCli;
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
        /// 
        
        public int Editar(Clientes obj)
        {   //conexão com banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//conexão banco
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Clientes SET CnpjCpfCli = @CnpjCpfCli, InscEstadualCli = @InscEstadualCli," +
                    "OutrasInscCli = @OutrasInscCli, NomeCli = @NomeCli, RazaoSocialCli = @RazaoSocialCli," +
                    "EnderecoCli = @EnderecoCli, NumCli = @NumCli, ComplementoCli = @ComplementoCli," +
                    "CepCli = @CepCli, BairroCli = @BairroCli, CidadeCli = @CidadeCli, UfCli = @UfCli," +
                    "TelefoneCli = @TelefoneCli, CelularCli = @CelularCli, EmailCli = @EmailCli, SiteCli = @SiteCli," +
                    "EnderecoCobCli = @EnderecoCobCli,NumCobCli = @NumCobCli," +
                    "ComplementoCobCli = @ComplementoCobCli, CepCobCli = @CepCobCli, BairroCobCli = @BairroCobCli," +
                    "CidadeCobCli = @CidadeCobCli, UfCobCli = @UfCobCli, ObservacaoCli = @ObservacaoCli," +
                    "DtCadastroCli = @DtCadastroCli";
                cn.Parameters.Add("CnpjCpfCli", SqlDbType.VarChar).Value = obj.CnpjCpfCli;
                cn.Parameters.Add("InscEstadualCli", SqlDbType.VarChar).Value = obj.InscEstadualCli;
                cn.Parameters.Add("OutrasInscCli", SqlDbType.VarChar).Value = obj.OutrasInscCli;
                cn.Parameters.Add("NomeCli", SqlDbType.VarChar).Value = obj.NomeCli;
                cn.Parameters.Add("RazaoSocialCli", SqlDbType.VarChar).Value = obj.RazaoSocialCli;
                cn.Parameters.Add("EnderecoCli", SqlDbType.VarChar).Value = obj.EnderecoCli;
                cn.Parameters.Add("NumCli", SqlDbType.VarChar).Value = obj.NumCli;
                cn.Parameters.Add("ComplementoCli", SqlDbType.VarChar).Value = obj.ComplementoCli;
                cn.Parameters.Add("CepCli", SqlDbType.VarChar).Value = obj.CepCli;
                cn.Parameters.Add("BairroCli", SqlDbType.VarChar).Value = obj.BairroCli;
                cn.Parameters.Add("CidadeCli", SqlDbType.VarChar).Value = obj.CidadeCli;
                cn.Parameters.Add("UfCli", SqlDbType.VarChar).Value = obj.UfCli;
                cn.Parameters.Add("TelefoneCli", SqlDbType.VarChar).Value = obj.TelefoneCli;
                cn.Parameters.Add("CelularCli", SqlDbType.VarChar).Value = obj.CelularCli;
                cn.Parameters.Add("EmailCli", SqlDbType.VarChar).Value = obj.EmailCli;
                cn.Parameters.Add("SiteCli", SqlDbType.VarChar).Value = obj.SiteCli;
                cn.Parameters.Add("EnderecoCobCli", SqlDbType.VarChar).Value = obj.EnderecoCobCli;
                cn.Parameters.Add("NumCobCli", SqlDbType.VarChar).Value = obj.NumCobCli;
                cn.Parameters.Add("ComplementoCobCli", SqlDbType.VarChar).Value = obj.ComplementoCobCli;
                cn.Parameters.Add("CepCobCli", SqlDbType.VarChar).Value = obj.CepCobCli;
                cn.Parameters.Add("BairroCobCli", SqlDbType.VarChar).Value = obj.BairroCobCli;
                cn.Parameters.Add("CidadeCobCli", SqlDbType.VarChar).Value = obj.CidadeCobCli;
                cn.Parameters.Add("UfCobCli", SqlDbType.VarChar).Value = obj.UfCobCli;
                cn.Parameters.Add("ObservacaoCli", SqlDbType.VarChar).Value = obj.ObservacaoCli;
                cn.Parameters.Add("DtCadastroCli", SqlDbType.DateTime).Value = obj.DtCadastroCli;

                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.IdCliente;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }
        

    }
}
