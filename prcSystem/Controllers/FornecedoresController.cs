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
    internal class FornecedoresController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="objForn"></param>
        /// <returns></returns>
        public int Inserir(Fornecedores objForn)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Fornecedores ([CnpjCpfForn], [InscEstadualForn], [OutrasInscForn], [NomeForn], [RazaoSocialForn], [EnderecoForn], [NumForn], [ComplementoForn], [CepForn],[BairroForn],[CidadeForn],[UfForn],[TelefoneForn],[CelularForn],[EmailForn],[SiteForn],[EnderecoCobForn],[NumCobForn],[ComplementoCobForn],[CepCobForn],[BairroCobForn],[CidadeCobForn],[UfCobForn],[ObservacaoForn],[DtCadastroForn]) VALUES " +
                                                       "(@CnpjCpfForn, @InscEstadualForn, @OutrasInscForn, @NomeForn, @RazaoSocialForn, @EnderecoForn, @NumForn, @ComplementoForn, @CepForn, @BairroForn, @CidadeForn, @UfForn, @TelefoneForn, @CelularForn, @EmailForn, @SiteForn, @EnderecoCobForn, @NumCobForn, @ComplementoCobForn, @CepCobForn, @BairroCobForn, @CidadeCobForn, @UfCobForn, @ObservacaoForn, @DtCadastroForn)";

                cn.Parameters.Add("CnpjCpfForn", SqlDbType.VarChar).Value = objForn.CnpjCpfForn;
                cn.Parameters.Add("InscEstadualForn", SqlDbType.VarChar).Value = objForn.InscEstadualForn;
                cn.Parameters.Add("OutrasInscForn", SqlDbType.VarChar).Value = objForn.OutrasInscForn;
                cn.Parameters.Add("NomeForn", SqlDbType.VarChar).Value = objForn.NomeForn;
                cn.Parameters.Add("RazaoSocialForn", SqlDbType.VarChar).Value = objForn.RazaoSocialForn;
                cn.Parameters.Add("EnderecoForn", SqlDbType.VarChar).Value = objForn.EnderecoForn;
                cn.Parameters.Add("NumForn", SqlDbType.VarChar).Value = objForn.NumForn;
                cn.Parameters.Add("ComplementoForn", SqlDbType.VarChar).Value = objForn.ComplementoForn;
                cn.Parameters.Add("CepForn", SqlDbType.VarChar).Value = objForn.CepForn;
                cn.Parameters.Add("BairroForn", SqlDbType.VarChar).Value = objForn.BairroForn;
                cn.Parameters.Add("CidadeForn", SqlDbType.VarChar).Value = objForn.CidadeForn;
                cn.Parameters.Add("UfForn", SqlDbType.VarChar).Value = objForn.UfForn;
                cn.Parameters.Add("TelefoneForn", SqlDbType.VarChar).Value = objForn.TelefoneForn;
                cn.Parameters.Add("CelularForn", SqlDbType.VarChar).Value = objForn.CelularForn;
                cn.Parameters.Add("EmailForn", SqlDbType.VarChar).Value = objForn.EmailForn;
                cn.Parameters.Add("SiteForn", SqlDbType.VarChar).Value = objForn.SiteForn;
                cn.Parameters.Add("EnderecoCobForn", SqlDbType.VarChar).Value = objForn.EnderecoCobForn;
                cn.Parameters.Add("NumCobForn", SqlDbType.VarChar).Value = objForn.NumCobForn;
                cn.Parameters.Add("ComplementoCobForn", SqlDbType.VarChar).Value = objForn.ComplementoCobForn;
                cn.Parameters.Add("CepCobForn", SqlDbType.VarChar).Value = objForn.CepCobForn;
                cn.Parameters.Add("BairroCobForn", SqlDbType.VarChar).Value = objForn.BairroCobForn;
                cn.Parameters.Add("CidadeCobForn", SqlDbType.VarChar).Value = objForn.CidadeCobForn;
                cn.Parameters.Add("UfCobForn", SqlDbType.VarChar).Value = objForn.UfCobForn;
                cn.Parameters.Add("ObservacaoForn", SqlDbType.VarChar).Value = objForn.ObservacaoForn;
                cn.Parameters.Add("DtCadastroForn", SqlDbType.DateTime2).Value = objForn.DtCadastroForn;


                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        /// <summary>
        /// metodo editar dados no banco de dados
        /// </summary>
        /// <param name="objForn"></param>
        /// <returns></returns>
        public int Editar(Fornecedores objForn)
        {   //conexão com banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//conexão banco
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Fornecedores SET CnpjCpfForn = @CnpjCpfForn, InscEstadualForn = @InscEstadualForn," +
                    "OutrasInscForn = @OutrasInscForn, NomeForn = @NomeForn, RazaoSocialForn = @RazaoSocialForn," +
                    "EnderecoForn = @EnderecoForn, NumForn = @NumForn, ComplementoForn = @ComplementoForn," +
                    "CepForn = @CepForn, BairroForn = @BairroForn, CidadeForn = @CidadeForn, UfForn = @UfForn," +
                    "TelefoneForn = @TelefoneForn, CelularForn = @CelularForn, EmailForn = @EmailForn, SiteForn = @SiteForn," +
                    "EnderecoCobForn = @EnderecoCobForn,NumCobForn = @NumCobForn," +
                    "ComplementoCobForn = @ComplementoCobForn, CepCobForn = @CepCobForn, BairroCobForn = @BairroCobForn," +
                    "CidadeCobForn = @CidadeCobForn, UfCobForn = @UfCobForn, ObservacaoForn = @ObservacaoForn," +
                    "DtCadastroForn = @DtCadastroForn";

                cn.Parameters.Add("CnpjCpfForn", SqlDbType.VarChar).Value = objForn.CnpjCpfForn;
                cn.Parameters.Add("InscEstadualForn", SqlDbType.VarChar).Value = objForn.InscEstadualForn;
                cn.Parameters.Add("OutrasInscForn", SqlDbType.VarChar).Value = objForn.OutrasInscForn;
                cn.Parameters.Add("NomeForn", SqlDbType.VarChar).Value = objForn.NomeForn;
                cn.Parameters.Add("RazaoSocialForn", SqlDbType.VarChar).Value = objForn.RazaoSocialForn;
                cn.Parameters.Add("EnderecoForn", SqlDbType.VarChar).Value = objForn.EnderecoForn;
                cn.Parameters.Add("NumForn", SqlDbType.VarChar).Value = objForn.NumForn;
                cn.Parameters.Add("ComplementoForn", SqlDbType.VarChar).Value = objForn.ComplementoForn;
                cn.Parameters.Add("CepForn", SqlDbType.VarChar).Value = objForn.CepForn;
                cn.Parameters.Add("BairroForn", SqlDbType.VarChar).Value = objForn.BairroForn;
                cn.Parameters.Add("CidadeForn", SqlDbType.VarChar).Value = objForn.CidadeForn;
                cn.Parameters.Add("UfForn", SqlDbType.VarChar).Value = objForn.UfForn;
                cn.Parameters.Add("TelefoneForn", SqlDbType.VarChar).Value = objForn.TelefoneForn;
                cn.Parameters.Add("CelularForn", SqlDbType.VarChar).Value = objForn.CelularForn;
                cn.Parameters.Add("EmailForn", SqlDbType.VarChar).Value = objForn.EmailForn;
                cn.Parameters.Add("SiteForn", SqlDbType.VarChar).Value = objForn.SiteForn;
                cn.Parameters.Add("EnderecoCobForn", SqlDbType.VarChar).Value = objForn.EnderecoCobForn;
                cn.Parameters.Add("NumCobForn", SqlDbType.VarChar).Value = objForn.NumCobForn;
                cn.Parameters.Add("ComplementoCobForn", SqlDbType.VarChar).Value = objForn.ComplementoCobForn;
                cn.Parameters.Add("CepCobForn", SqlDbType.VarChar).Value = objForn.CepCobForn;
                cn.Parameters.Add("BairroCobForn", SqlDbType.VarChar).Value = objForn.BairroCobForn;
                cn.Parameters.Add("CidadeCobForn", SqlDbType.VarChar).Value = objForn.CidadeCobForn;
                cn.Parameters.Add("UfCobForn", SqlDbType.VarChar).Value = objForn.UfCobForn;
                cn.Parameters.Add("ObservacaoForn", SqlDbType.VarChar).Value = objForn.ObservacaoForn;
                cn.Parameters.Add("DtCadastroForn", SqlDbType.DateTime2).Value = objForn.DtCadastroForn;

                cn.Parameters.Add("id", SqlDbType.Int).Value = objForn.IdFornecedores;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

    }
}