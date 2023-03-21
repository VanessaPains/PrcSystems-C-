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
    class PesquisarController
    {
/*
        //buscar dos dados do db
        
        public List<Clientes> BuscarCli(Clientes obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Clientes, Fornecedores WHERE IdCliente = @IdFornecedores";
                cn.Parameters.Add("IdCliente", SqlDbType.Int).Value = obj.IdCliente;
                cn.Connection = con;

                SqlDataReader dr;
                List<Clientes> lista = new List<Clientes>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Clientes dados = new Clientes();
                        
                        dados.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                        dados.CnpjCpfCli = Convert.ToString(dr["CnpjCpfCli"]);
                        dados.InscEstadualCli = Convert.ToString(dr["InscEstadualCli"]);
                        dados.OutrasInscCli = Convert.ToString(dr["TxtOutrasInscCli"]);
                        dados.NomeCli = Convert.ToString(dr["NomeCli"]);
                        dados.RazaoSocialCli = Convert.ToString(dr["RazaoSocialCli"]);
                        dados.EnderecoCli = Convert.ToString(dr["EnderecoCli"]);
                        dados.NumCli = Convert.ToString(dr["ComplementoCli"]);
                        dados.ComplementoCli = Convert.ToString(dr["ComplementoCli"]);
                        dados.CepCli = Convert.ToString(dr["CepCli"]);
                        dados.BairroCli = Convert.ToString(dr["BairroCli"]);
                        dados.CidadeCli = Convert.ToString(dr["CidadeCli"]);
                        dados.UfCli = Convert.ToString(dr["UfCli"]);
                        dados.TelefoneCli = Convert.ToString(dr["TelefoneCli"]);
                        dados.CelularCli = Convert.ToString(dr["CelularCli"]);
                        dados.EmailCli = Convert.ToString(dr["EmailCli"]);
                        dados.SiteCli = Convert.ToString(dr["SiteCli"]);
                        dados.EnderecoCobCli = Convert.ToString(dr["EnderecoCobCli"]);
                        dados.NumCobCli = Convert.ToString(dr["NumCobCli"]);
                        dados.ComplementoCobCli = Convert.ToString(dr["ComplementoCobCli"]);
                        dados.CepCobCli = Convert.ToString(dr["CepCobCli"]);
                        dados.BairroCobCli = Convert.ToString(dr["BairroCobCli"]);
                        dados.CidadeCobCli = Convert.ToString(dr["CidadeCobCli"]);
                        dados.UfCobCli = Convert.ToString(dr["UfCobCli"]);
                        dados.ObservacaoCli = Convert.ToString(dr["ObservacaoCli"]);
                        dados.DtCadastroCli = Convert.ToDateTime(dr["DtCadastroCli"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }



        //metodo de listar dos do db
        public List<Clientes> ListarCli()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Clientes";
                

                cn.Connection = con;

                SqlDataReader dr;
                List<Clientes> lista = new List<Clientes>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Clientes dados = new Clientes();
                        
                        dados.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                        dados.CnpjCpfCli = Convert.ToString(dr["CnpjCpfCli"]);
                        dados.InscEstadualCli = Convert.ToString(dr["InscEstadualCli"]);
                        dados.OutrasInscCli = Convert.ToString(dr["OutrasInscCli"]);
                        dados.NomeCli = Convert.ToString(dr["NomeCli"]);
                        dados.RazaoSocialCli = Convert.ToString(dr["RazaoSocialCli"]);
                        dados.EnderecoCli = Convert.ToString(dr["EnderecoCli"]);
                        dados.NumCli = Convert.ToString(dr["ComplementoCli"]);
                        dados.ComplementoCli = Convert.ToString(dr["ComplementoCli"]);
                        dados.CepCli = Convert.ToString(dr["CepCli"]);
                        dados.BairroCli = Convert.ToString(dr["BairroCli"]);
                        dados.CidadeCli = Convert.ToString(dr["CidadeCli"]);
                        dados.UfCli = Convert.ToString(dr["UfCli"]);
                        dados.TelefoneCli = Convert.ToString(dr["TelefoneCli"]);
                        dados.CelularCli = Convert.ToString(dr["CelularCli"]);
                        dados.EmailCli = Convert.ToString(dr["EmailCli"]);
                        dados.SiteCli = Convert.ToString(dr["SiteCli"]);
                        dados.EnderecoCobCli = Convert.ToString(dr["EnderecoCobCli"]);
                        dados.NumCobCli = Convert.ToString(dr["NumCobCli"]);
                        dados.ComplementoCobCli = Convert.ToString(dr["ComplementoCobCli"]);
                        dados.CepCobCli = Convert.ToString(dr["CepCobCli"]);
                        dados.BairroCobCli = Convert.ToString(dr["BairroCobCli"]);
                        dados.CidadeCobCli = Convert.ToString(dr["CidadeCobCli"]);
                        dados.UfCobCli = Convert.ToString(dr["UfCobCli"]);
                        dados.ObservacaoCli = Convert.ToString(dr["ObservacaoCli"]);
                        dados.DtCadastroCli = Convert.ToDateTime(dr["DtCadastroCli"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        //------------------------------------------------------------------
        //buscar dos dados do db fornecedores
        public List<Fornecedores> BuscarForn(Fornecedores objForn)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Fornecedores WHERE IdFornecedores = @IdFornecedores";
                cn.Parameters.Add("IdFornecedores", SqlDbType.Int).Value = objForn.IdFornecedores;
                cn.Connection = con;

                SqlDataReader dr;
                List<Fornecedores> listaForn = new List<Fornecedores>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Fornecedores dados = new Fornecedores();


                        dados.IdFornecedores = Convert.ToInt32(dr["IdFornecedores"]);
                        dados.CnpjCpfForn = Convert.ToString(dr["CnpjCpfForn"]);
                        dados.InscEstadualForn = Convert.ToString(dr["InscEstadualForn"]);
                        dados.OutrasInscForn = Convert.ToString(dr["OutrasInscForn"]);
                        dados.NomeForn = Convert.ToString(dr["NomeForn"]);
                        dados.RazaoSocialForn = Convert.ToString(dr["RazaoSocialForn"]);
                        dados.EnderecoForn = Convert.ToString(dr["EnderecoForn"]);
                        dados.NumForn = Convert.ToString(dr["ComplementoForn"]);
                        dados.ComplementoForn = Convert.ToString(dr["ComplementoForn"]);
                        dados.CepForn = Convert.ToString(dr["CepForn"]);
                        dados.BairroForn = Convert.ToString(dr["BairroForn"]);
                        dados.CidadeForn = Convert.ToString(dr["CidadeForn"]);
                        dados.UfForn = Convert.ToString(dr["UfForn"]);
                        dados.TelefoneForn = Convert.ToString(dr["TelefoneForn"]);
                        dados.CelularForn = Convert.ToString(dr["CelularForn"]);
                        dados.EmailForn = Convert.ToString(dr["EmailForn"]);
                        dados.SiteForn = Convert.ToString(dr["SiteForn"]);
                        dados.EnderecoCobForn = Convert.ToString(dr["EnderecoCobForn"]);
                        dados.NumCobForn = Convert.ToString(dr["NumCobForn"]);
                        dados.ComplementoCobForn = Convert.ToString(dr["ComplementoCobForn"]);
                        dados.CepCobForn = Convert.ToString(dr["CepCobForn"]);
                        dados.BairroCobForn = Convert.ToString(dr["BairroCobForn"]);
                        dados.CidadeCobForn = Convert.ToString(dr["CidadeCobForn"]);
                        dados.UfCobForn = Convert.ToString(dr["UfCobForn"]);
                        dados.ObservacaoForn = Convert.ToString(dr["ObservacaoForn"]);
                        dados.DtCadastroForn = Convert.ToDateTime(dr["DtCadastroForn"]);

                        listaForn.Add(dados);
                    }
                }
                return listaForn;
            }
        }



        //metodo de listar dos do db
        public List<Fornecedores> ListarForn()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Fornecedores";


                cn.Connection = con;

                SqlDataReader dr;
                List<Fornecedores> listaForn = new List<Fornecedores>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Fornecedores dados = new Fornecedores();

                        dados.IdFornecedores = Convert.ToInt32(dr["IdFornecedores"]);
                        dados.CnpjCpfForn = Convert.ToString(dr["CnpjCpfForn"]);
                        dados.InscEstadualForn = Convert.ToString(dr["InscEstadualForn"]);
                        dados.OutrasInscForn = Convert.ToString(dr["OutrasInscForn"]);
                        dados.NomeForn = Convert.ToString(dr["NomeForn"]);
                        dados.RazaoSocialForn = Convert.ToString(dr["RazaoSocialForn"]);
                        dados.EnderecoForn = Convert.ToString(dr["EnderecoForn"]);
                        dados.NumForn = Convert.ToString(dr["ComplementoForn"]);
                        dados.ComplementoForn = Convert.ToString(dr["ComplementoForn"]);
                        dados.CepForn = Convert.ToString(dr["CepForn"]);
                        dados.BairroForn = Convert.ToString(dr["BairroForn"]);
                        dados.CidadeForn = Convert.ToString(dr["CidadeForn"]);
                        dados.UfForn = Convert.ToString(dr["UfForn"]);
                        dados.TelefoneForn = Convert.ToString(dr["TelefoneForn"]);
                        dados.CelularForn = Convert.ToString(dr["CelularForn"]);
                        dados.EmailForn = Convert.ToString(dr["EmailForn"]);
                        dados.SiteForn = Convert.ToString(dr["SiteForn"]);
                        dados.EnderecoCobForn = Convert.ToString(dr["EnderecoCobForn"]);
                        dados.NumCobForn = Convert.ToString(dr["NumCobForn"]);
                        dados.ComplementoCobForn = Convert.ToString(dr["ComplementoCobForn"]);
                        dados.CepCobForn = Convert.ToString(dr["CepCobForn"]);
                        dados.BairroCobForn = Convert.ToString(dr["BairroCobForn"]);
                        dados.CidadeCobForn = Convert.ToString(dr["CidadeCobForn"]);
                        dados.UfCobForn = Convert.ToString(dr["UfCobForn"]);
                        dados.ObservacaoForn = Convert.ToString(dr["ObservacaoForn"]);
                        dados.DtCadastroForn = Convert.ToDateTime(dr["DtCadastroForn"]);

                        listaForn.Add(dados);
                    }
                }
                return listaForn;
            }
        }
 */       

    }
}
