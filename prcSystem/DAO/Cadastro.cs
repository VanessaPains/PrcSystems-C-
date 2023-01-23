using prcSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.DAO
{
    public class CadastroProduto//faz as solicitações de inclusões no banco de dados cadastro produto
    {
        /*
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        SqlDataAdapter adapt;

        public CadastroProduto(String TxtDescProduto, String TxtMarcaProduto, String TxtUnidadeProduto, String TxtValorProduto)
        {
            //1º- comando sql ---SqlCommand
            cmd.CommandText = "insert into Produtos (DescProduto, MarcaProduto, UnidadeProduto, ValorProduto) values (@DescProduto, @MarcaProduto, @UnidadeProduto, @ValorProduto)";

            //parametros
            cmd.Parameters.AddWithValue("DescProduto", TxtDescProduto);
            cmd.Parameters.AddWithValue("MarcaProduto", TxtMarcaProduto);
            cmd.Parameters.AddWithValue("UnidadeProduto", TxtUnidadeProduto);
            cmd.Parameters.AddWithValue("ValorProduto", TxtValorProduto);

            //conectar banco dados --- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comandos
                cmd.ExecuteNonQuery();
                //desonetar
                conexao.desconectar();
                //mostrar mensagens de erros ou sucesso --- Variavel
                this.mensagem = "Cadastrado com Sucesso.";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar conectar com banco de dados.";
            }          
        }
      
    }
    //------ exibir produtos na lista datagridview pela de produoto

 

    //FIM PRODUTOS ----------------------------------------------------------------

    //------ cadadstro de clientes-------------------------------------------------
    public class CadastroClientes//faz as solicitações de inclusões no banco de dados cadastro clientes
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastroClientes(String TxtCnpjCpfCli, String TxtInscEstadualCli, String TxtOutrasInscCli, String TxtNomeCli, String TxtRazaoSocialCli, String TxtEnderecoCli, String TxtNumCli, String TxtComplementoCli, String TxtCepCli, String TxtBairroCli, String TxtCidadeCli, String TxtUfCli, String TxtTelefoneCli, String TxtCelularCli, String TxtEmailCli, String TxtSiteCli, String TxtEnderecoCobCli, String TxtNumCobCli, String TxtComplementoCobCli, String TxtCepCobCli, String TxtBairroCobCli, String TxtCidadeCobCli, String TxtUfCobCli, String TxtObservacaoCli, String TxtDtCadastroCli)
        {
            //1º- comando sql ---SqlCommand
            cmd.CommandText = "insert into Clientes (CnpjCpfCli, InscEstadualCli, OutrasInscCli, NomeCli, RazaoSocialCli, EnderecoCli, NumCli, ComplementoCli, CepCli, BairroCli, CidadeCli, UfCli, TelefoneCli, CelularCli, EmailCli, SiteCli, EnderecoCobCli, NumCobCli, ComplementoCobCli, CepCobCli, BairroCobCli, CidadeCobCli, UfCobCli, ObservacaoCli, DtCadastroCli) values (@CnpjCpfCli, @InscEstadualCli, @OutrasInscCli, @NomeCli, @RazaoSocialCli, @EnderecoCli, @NumCli, @ComplementoCli, @CepCli, @BairroCli, @CidadeCli, @UfCli, @TelefoneCli, @CelularCli, @EmailCli, @SiteCli, @EnderecoCobCli, @NumCobCli, @ComplementoCobCli, @CepCobCli, @BairroCobCli, @CidadeCobCli, @UfCobCli, @ObservacaoCli, @DtCadastroCli)";

            //parametros
            cmd.Parameters.AddWithValue("CnpjCpfCli", TxtCnpjCpfCli);
            cmd.Parameters.AddWithValue("InscEstadualCli", TxtInscEstadualCli);
            cmd.Parameters.AddWithValue("OutrasInscCli", TxtOutrasInscCli);
            cmd.Parameters.AddWithValue("NomeCli", TxtNomeCli);
            cmd.Parameters.AddWithValue("RazaoSocialCli", TxtRazaoSocialCli);
            cmd.Parameters.AddWithValue("EnderecoCli", TxtEnderecoCli);
            cmd.Parameters.AddWithValue("NumCli", TxtNumCli);
            cmd.Parameters.AddWithValue("ComplementoCli", TxtComplementoCli);
            cmd.Parameters.AddWithValue("CepCli", TxtCepCli);
            cmd.Parameters.AddWithValue("BairroCli", TxtBairroCli);
            cmd.Parameters.AddWithValue("CidadeCli", TxtCidadeCli);
            cmd.Parameters.AddWithValue("UfCli", TxtUfCli);
            cmd.Parameters.AddWithValue("TelefoneCli", TxtTelefoneCli);
            cmd.Parameters.AddWithValue("CelularCli", TxtCelularCli);
            cmd.Parameters.AddWithValue("EmailCli", TxtEmailCli);
            cmd.Parameters.AddWithValue("SiteCli", TxtSiteCli);
            cmd.Parameters.AddWithValue("EnderecoCobCli", TxtEnderecoCobCli);
            cmd.Parameters.AddWithValue("NumCobCli", TxtNumCobCli);
            cmd.Parameters.AddWithValue("ComplementoCobCli", TxtComplementoCobCli);
            cmd.Parameters.AddWithValue("CepCobCli", TxtCepCobCli);
            cmd.Parameters.AddWithValue("BairroCobCli", TxtBairroCobCli);
            cmd.Parameters.AddWithValue("CidadeCobCli", TxtCidadeCobCli);
            cmd.Parameters.AddWithValue("UfCobCli", TxtUfCobCli);
            cmd.Parameters.AddWithValue("ObservacaoCli", TxtObservacaoCli);
            cmd.Parameters.AddWithValue("DtCadastroCli", TxtDtCadastroCli);
            
            //conectar banco dados --- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comandos
                cmd.ExecuteNonQuery();
                //desonetar
                conexao.desconectar();
                //mostrar mensagens de erros ou sucesso --- Variavel
                this.mensagem = "Cadastrado com Sucesso.";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar conectar com banco de dados.";
            }
        }
    }

    //------- exibir clientes
   

    //cadadstro de fornecedores
    public class CadastroFornecedores//faz as solicitações de inclusões no banco de dados cadastro fornecedores
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastroFornecedores(String TxtCnpjCpfForn, String TxtInscEstadualForn, String TxtOutrasInscForn, String TxtNomeForn, String TxtRazaoSocialForn, String TxtEnderecoForn, String TxtNumForn, String TxtComplementoForn, String TxtCepForn, String TxtBairroForn, String TxtCidadeForn, String TxtUfForn, String TxtTelefoneForn, String TxtCelularForn, String TxtEmailForn, String TxtSiteForn, String TxtEnderecoCobForn, String TxtNumCobForn, String TxtComplementoCobForn, String TxtCepCobForn, String TxtBairroCobForn, String TxtCidadeCobForn, String TxtUfCobForn, String TxtObservacaoForn, String TxtDtCadastroForn)
        {
            //1º- comando sql ---SqlCommand
            cmd.CommandText = "insert into Fornecedores (CnpjCpfForn, InscEstadualForn, OutrasInscForn, NomeForn, RazaoSocialForn, EnderecoForn, NumForn, ComplementoForn, CepForn, BairroForn, CidadeForn, UfForn, TelefoneForn, CelularForn, EmailForn, SiteForn, EnderecoCobForn, NumCobForn, ComplementoCobForn, CepCobForn, BairroCobForn, CidadeCobForn, UfCobForn, ObservacaoForn, DtCadastroForn) values (@CnpjCpfForn, @InscEstadualForn, @OutrasInscForn, @NomeForn, @RazaoSocialForn, @EnderecoForn, @NumForn, @ComplementoForn, @CepForn, @BairroForn, @CidadeForn, @UfForn, @TelefoneForn, @CelularForn, @EmailForn, @SiteForn, @EnderecoCobForn, @NumCobForn, @ComplementoCobForn, @CepCobForn, @BairroCobForn, @CidadeCobForn, @UfCobForn, @ObservacaoForn, @DtCadastroForn)";

            //parametros
            cmd.Parameters.AddWithValue("CnpjCpfForn", TxtCnpjCpfForn);
            cmd.Parameters.AddWithValue("InscEstadualForn", TxtInscEstadualForn);
            cmd.Parameters.AddWithValue("OutrasInscForn", TxtOutrasInscForn);
            cmd.Parameters.AddWithValue("NomeForn", TxtNomeForn);
            cmd.Parameters.AddWithValue("RazaoSocialForn", TxtRazaoSocialForn);
            cmd.Parameters.AddWithValue("EnderecoForn", TxtEnderecoForn);
            cmd.Parameters.AddWithValue("NumForn", TxtNumForn);
            cmd.Parameters.AddWithValue("ComplementoForn", TxtComplementoForn);
            cmd.Parameters.AddWithValue("CepForn", TxtCepForn);
            cmd.Parameters.AddWithValue("BairroForn", TxtBairroForn);
            cmd.Parameters.AddWithValue("CidadeForn", TxtCidadeForn);
            cmd.Parameters.AddWithValue("UfForn", TxtUfForn);
            cmd.Parameters.AddWithValue("TelefoneForn", TxtTelefoneForn);
            cmd.Parameters.AddWithValue("CelularForn", TxtCelularForn);
            cmd.Parameters.AddWithValue("EmailForn", TxtEmailForn);
            cmd.Parameters.AddWithValue("SiteForn", TxtSiteForn);
            cmd.Parameters.AddWithValue("EnderecoCobForn", TxtEnderecoCobForn);
            cmd.Parameters.AddWithValue("NumCobForn", TxtNumCobForn);
            cmd.Parameters.AddWithValue("ComplementoCobForn", TxtComplementoCobForn);
            cmd.Parameters.AddWithValue("CepCobForn", TxtCepCobForn);
            cmd.Parameters.AddWithValue("BairroCobForn", TxtBairroCobForn);
            cmd.Parameters.AddWithValue("CidadeCobForn", TxtCidadeCobForn);
            cmd.Parameters.AddWithValue("UfCobForn", TxtUfCobForn);
            cmd.Parameters.AddWithValue("ObservacaoForn", TxtObservacaoForn);
            cmd.Parameters.AddWithValue("DtCadastroForn", TxtDtCadastroForn);

            //conectar banco dados --- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comandos
                cmd.ExecuteNonQuery();
                //desonetar
                conexao.desconectar();
                //mostrar mensagens de erros ou sucesso --- Variavel
                this.mensagem = "Cadastrado com Sucesso.";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar conectar com banco de dados.";
            }
        }*/
    }
}
