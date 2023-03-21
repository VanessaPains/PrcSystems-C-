using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace prcSystem.Controllers
{
    public class PessoaController
    {
        /// <summary>
        /// funcao para inserir dados de Pessoa dos clientes e fornecededores
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>cliente/fornecedores cadastrados</returns>
        public int Inserir(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Pessoa " +
                    "               ([TipoCadastro], [TipoPessoa], [CnpjCpf], [RazaoNome], " +
                    "               [Fantasia], [InscEstadual], [OutrasInsc], [Endereco], [Num], " +
                    "               [Complemento], [Cep],[Bairro],[Cidade],[Uf],[Telefone],[Celular]," +
                    "               [Email],[Site],[EnderecoCob],[NumCob],[ComplementoCob],[CepCob]," +
                    "               [BairroCob],[CidadeCob],[UfCob],[Observacao],[DtCadPessoa]) " +
                    "               VALUES " +
                    "               (@TipoCadastro, @TipoPessoa, @CnpjCpf, @RazaoNome, @Fantasia, " +
                    "               @InscEstadual, @OutrasInsc, @Endereco, @Num, @Complemento, @Cep, " +
                    "               @Bairro, @Cidade, @Uf, @Telefone, @Celular, @Email, @Site, @EnderecoCob, " +
                    "               @NumCob, @ComplementoCob, @CepCob, @BairroCob, @CidadeCob, @UfCob, " +
                    "               @Observacao, @DtCadPessoa)";

                cn.Parameters.Add("TipoCadastro", SqlDbType.VarChar).Value = obj.TipoCadastro;
                cn.Parameters.Add("TipoPessoa", SqlDbType.VarChar).Value = obj.TipoPessoa;

                cn.Parameters.Add("CnpjCpf", SqlDbType.VarChar).Value = obj.CnpjCpf;
                cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;
                cn.Parameters.Add("Fantasia", SqlDbType.VarChar).Value = obj.Fantasia;
                cn.Parameters.Add("InscEstadual", SqlDbType.VarChar).Value = obj.InscEstadual;
                cn.Parameters.Add("OutrasInsc", SqlDbType.VarChar).Value = obj.OutrasInsc;
                
                cn.Parameters.Add("Endereco", SqlDbType.VarChar).Value = obj.Endereco;
                cn.Parameters.Add("Num", SqlDbType.VarChar).Value = obj.Num;
                cn.Parameters.Add("Complemento", SqlDbType.VarChar).Value = obj.Complemento;
                cn.Parameters.Add("Cep", SqlDbType.VarChar).Value = obj.Cep;
                cn.Parameters.Add("Bairro", SqlDbType.VarChar).Value = obj.Bairro;
                cn.Parameters.Add("Cidade", SqlDbType.VarChar).Value = obj.Cidade;
                cn.Parameters.Add("Uf", SqlDbType.VarChar).Value = obj.Uf;

                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = obj.Telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = obj.Celular;
                cn.Parameters.Add("Email", SqlDbType.VarChar).Value = obj.Email;
                cn.Parameters.Add("Site", SqlDbType.VarChar).Value = obj.Site;

                //cn.Parameters.Add("Foto", SqlDbType.Image).Value = obj.Foto;
                cn.Parameters.Add("EnderecoCob", SqlDbType.VarChar).Value = obj.EnderecoCob;
                cn.Parameters.Add("NumCob", SqlDbType.VarChar).Value = obj.NumCob;
                cn.Parameters.Add("ComplementoCob", SqlDbType.VarChar).Value = obj.ComplementoCob;
                cn.Parameters.Add("CepCob", SqlDbType.VarChar).Value = obj.CepCob;
                cn.Parameters.Add("BairroCob", SqlDbType.VarChar).Value = obj.BairroCob;
                cn.Parameters.Add("CidadeCob", SqlDbType.VarChar).Value = obj.CidadeCob;
                cn.Parameters.Add("UfCob", SqlDbType.VarChar).Value = obj.UfCob;
                cn.Parameters.Add("Observacao", SqlDbType.VarChar).Value = obj.Observacao;

                cn.Parameters.Add("DtCadPessoa", SqlDbType.DateTime2).Value = obj.DtCadPessoa;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        /// <summary>
        /// metodo de editar dados do formulario de cad. fornecedores/clientes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//confuracao do appconfig- aponta sua conexao
                SqlCommand cn = new SqlCommand();//comando 
                cn.CommandType = CommandType.Text;//comando do tipo texto
                con.Open();//abrir conexao
                cn.CommandText = "UPDATE Pessoa SET TipoCadastro = @TipoCadastro, TipoPessoa = @TipoPessoa, " +
                    "               CnpjCpf = @CnpjCpf, RazaoNome = @RazaoNome, Fantasia = @Fantasia, " +
                    "               InscEstadual = @InscEstadual, OutrasInsc = @OutrasInsc, Endereco = @Endereco, " +
                    "               Num = @Num, Complemento = @Complemento, Cep = @Cep, Bairro = @Bairro, " +
                    "               Cidade = @Cidade, Uf = @Uf, Telefone = @Telefone, Celular = @Celular, " +
                    "               Email = @Email, Site = @Site, EnderecoCob = @EnderecoCob, NumCob = @NumCob, " +
                    "               ComplementoCob = @ComplementoCob, CepCob = @CepCob, BairroCob = @BairroCob, " +
                    "               CidadeCob = @CidadeCob, UfCob = @UfCob, Observacao = @Observacao, " +
                    "               DtCadPessoa = @DtCadPessoa" +
                    "               WHERE IdPessoa = @IdPessoa";

                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                cn.Parameters.Add("TipoCadastro", SqlDbType.VarChar).Value = obj.TipoCadastro;
                cn.Parameters.Add("TipoPessoa", SqlDbType.VarChar).Value = obj.TipoPessoa;

                cn.Parameters.Add("CnpjCpf", SqlDbType.VarChar).Value = obj.CnpjCpf;
                cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;
                cn.Parameters.Add("Fantasia", SqlDbType.VarChar).Value = obj.Fantasia;
                cn.Parameters.Add("InscEstadual", SqlDbType.VarChar).Value = obj.InscEstadual;
                cn.Parameters.Add("OutrasInsc", SqlDbType.VarChar).Value = obj.OutrasInsc;

                cn.Parameters.Add("Endereco", SqlDbType.VarChar).Value = obj.Endereco;
                cn.Parameters.Add("Num", SqlDbType.VarChar).Value = obj.Num;
                cn.Parameters.Add("Complemento", SqlDbType.VarChar).Value = obj.Complemento;
                cn.Parameters.Add("Cep", SqlDbType.VarChar).Value = obj.Cep;
                cn.Parameters.Add("Bairro", SqlDbType.VarChar).Value = obj.Bairro;
                cn.Parameters.Add("Cidade", SqlDbType.VarChar).Value = obj.Cidade;
                cn.Parameters.Add("Uf", SqlDbType.VarChar).Value = obj.Uf;

                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = obj.Telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = obj.Celular;
                cn.Parameters.Add("Email", SqlDbType.VarChar).Value = obj.Email;
                cn.Parameters.Add("Site", SqlDbType.VarChar).Value = obj.Site;

                //cn.Parameters.Add("Foto", SqlDbType.Image).Value = obj.Foto;
                cn.Parameters.Add("EnderecoCob", SqlDbType.VarChar).Value = obj.EnderecoCob;
                cn.Parameters.Add("NumCob", SqlDbType.VarChar).Value = obj.NumCob;
                cn.Parameters.Add("ComplementoCob", SqlDbType.VarChar).Value = obj.ComplementoCob;
                cn.Parameters.Add("CepCob", SqlDbType.VarChar).Value = obj.CepCob;
                cn.Parameters.Add("BairroCob", SqlDbType.VarChar).Value = obj.BairroCob;
                cn.Parameters.Add("CidadeCob", SqlDbType.VarChar).Value = obj.CidadeCob;
                cn.Parameters.Add("UfCob", SqlDbType.VarChar).Value = obj.UfCob;
                cn.Parameters.Add("Observacao", SqlDbType.VarChar).Value = obj.Observacao;

                cn.Parameters.Add("DtCadPessoa", SqlDbType.DateTime2).Value = obj.DtCadPessoa;

                cn.Connection = con;//solicita a conexao        

                int qte = cn.ExecuteNonQuery();//
                return qte;
            }
        }

        //metodo de deletar/exclir dados db fornecedore/clientes
        public int Deletar(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Pessoa WHERE IdPessoa = @IdPessoa";

                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        /// <summary>
        /// metodo de listar dos do db dos clientes e forncedores cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa";

                cn.Connection = con;

                SqlDataReader dr;
                List<Pessoa> lista = new List<Pessoa>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pessoa dados = new Pessoa();

                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.TipoCadastro = Convert.ToString(dr["TipoCadastro"]);

                        dados.TipoPessoa = Convert.ToString(dr["TipoPessoa"]);
                        dados.CnpjCpf = Convert.ToString(dr["CnpjCpf"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.Fantasia = Convert.ToString(dr["Fantasia"]);
                        dados.InscEstadual = Convert.ToString(dr["InscEstadual"]);
                        dados.OutrasInsc = Convert.ToString(dr["OutrasInsc"]);
                        dados.Endereco = Convert.ToString(dr["Endereco"]);
                        dados.Num = Convert.ToString(dr["Num"]);
                        dados.Complemento = Convert.ToString(dr["Complemento"]);
                        dados.Cep = Convert.ToString(dr["Cep"]);
                        dados.Bairro = Convert.ToString(dr["Bairro"]);
                        dados.Cidade = Convert.ToString(dr["Cidade"]);

                        dados.Uf = Convert.ToString(dr["Uf"]);
                        dados.Telefone = Convert.ToString(dr["Telefone"]);
                        dados.Celular = Convert.ToString(dr["Celular"]);
                        dados.Email = Convert.ToString(dr["Email"]);
                        dados.Site = Convert.ToString(dr["Site"]);

                        dados.EnderecoCob = Convert.ToString(dr["EnderecoCob"]);
                        dados.NumCob = Convert.ToString(dr["NumCob"]);
                        dados.ComplementoCob = Convert.ToString(dr["ComplementoCob"]);
                        dados.CepCob = Convert.ToString(dr["CepCob"]);
                        dados.BairroCob = Convert.ToString(dr["BairroCob"]);
                        dados.CidadeCob = Convert.ToString(dr["CidadeCob"]);
                        dados.UfCob = Convert.ToString(dr["UfCob"]);

                        dados.Observacao = Convert.ToString(dr["Observacao"]);
                        dados.DtCadPessoa = Convert.ToDateTime(dr["DtCadPessoa"]);
                        //dados.PbFotoFuncionario = Convert(dr["PbFotoFuncionario"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        //pesquisar dos dados do db por codigo do cliente ou fornecedor
        public List<Pessoa> PesquisarCodCliForn(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa WHERE IdPessoa = @IdPessoa";

                cn.Parameters.Add("IdPessoa", SqlDbType.Int).Value = obj.IdPessoa;
                //cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;
                cn.Connection = con;

                SqlDataReader dr;
                List<Pessoa> lista = new List<Pessoa>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pessoa dados = new Pessoa();

                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.TipoCadastro = Convert.ToString(dr["TipoCadastro"]);

                        dados.TipoPessoa = Convert.ToString(dr["TipoPessoa"]);
                        dados.CnpjCpf = Convert.ToString(dr["CnpjCpf"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.Fantasia = Convert.ToString(dr["Fantasia"]);
                        dados.InscEstadual = Convert.ToString(dr["InscEstadual"]);
                        dados.OutrasInsc = Convert.ToString(dr["OutrasInsc"]);
                        dados.Endereco = Convert.ToString(dr["Endereco"]);
                        dados.Num = Convert.ToString(dr["Num"]);
                        dados.Complemento = Convert.ToString(dr["Complemento"]);
                        dados.Cep = Convert.ToString(dr["Cep"]);
                        dados.Bairro = Convert.ToString(dr["Bairro"]);
                        dados.Cidade = Convert.ToString(dr["Cidade"]);
                        dados.Uf = Convert.ToString(dr["Uf"]);

                        dados.Telefone = Convert.ToString(dr["Telefone"]);
                        dados.Celular = Convert.ToString(dr["Celular"]);
                        dados.Email = Convert.ToString(dr["Email"]);
                        dados.Site = Convert.ToString(dr["Site"]);

                        dados.EnderecoCob = Convert.ToString(dr["EnderecoCob"]);
                        dados.NumCob = Convert.ToString(dr["NumCob"]);
                        dados.ComplementoCob = Convert.ToString(dr["ComplementoCob"]);
                        dados.CepCob = Convert.ToString(dr["CepCob"]);
                        dados.BairroCob = Convert.ToString(dr["BairroCob"]);
                        dados.CidadeCob = Convert.ToString(dr["CidadeCob"]);
                        dados.UfCob = Convert.ToString(dr["UfCob"]);

                        dados.Observacao = Convert.ToString(dr["Observacao"]);
                        dados.DtCadPessoa = Convert.ToDateTime(dr["DtCadPessoa"]);
                        //dados.PbFotoFuncionario = Convert(dr["PbFotoFuncionario"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

        //pesquisar dos dados do db por codigo do cliente ou fornecedor
        public List<Pessoa> PesquisaRazaoNomeCliForn(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa WHERE RazaoNome = @RazaoNome OR CnpjCpf = @CnpjCpf";

                cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;
                cn.Parameters.Add("CnpjCpf", SqlDbType.VarChar).Value = obj.CnpjCpf;
                cn.Connection = con;

                SqlDataReader dr;
                List<Pessoa> lista = new List<Pessoa>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pessoa dados = new Pessoa();

                        dados.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                        dados.TipoCadastro = Convert.ToString(dr["TipoCadastro"]);
                        dados.TipoPessoa = Convert.ToString(dr["TipoPessoa"]);

                        dados.CnpjCpf = Convert.ToString(dr["CnpjCpf"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.Fantasia = Convert.ToString(dr["Fantasia"]);
                        dados.InscEstadual = Convert.ToString(dr["InscEstadual"]);
                        dados.OutrasInsc = Convert.ToString(dr["OutrasInsc"]);
                        dados.Endereco = Convert.ToString(dr["Endereco"]);
                        dados.Num = Convert.ToString(dr["Num"]);
                        dados.Complemento = Convert.ToString(dr["Complemento"]);
                        dados.Cep = Convert.ToString(dr["Cep"]);
                        dados.Bairro = Convert.ToString(dr["Bairro"]);
                        dados.Cidade = Convert.ToString(dr["Cidade"]);
                        dados.Uf = Convert.ToString(dr["Uf"]);

                        dados.Telefone = Convert.ToString(dr["Telefone"]);
                        dados.Celular = Convert.ToString(dr["Celular"]);
                        dados.Email = Convert.ToString(dr["Email"]);
                        dados.Site = Convert.ToString(dr["Site"]);

                        dados.EnderecoCob = Convert.ToString(dr["EnderecoCob"]);
                        dados.NumCob = Convert.ToString(dr["NumCob"]);
                        dados.ComplementoCob = Convert.ToString(dr["ComplementoCob"]);
                        dados.CepCob = Convert.ToString(dr["CepCob"]);
                        dados.BairroCob = Convert.ToString(dr["BairroCob"]);
                        dados.CidadeCob = Convert.ToString(dr["CidadeCob"]);
                        dados.UfCob = Convert.ToString(dr["UfCob"]);

                        dados.Observacao = Convert.ToString(dr["Observacao"]);
                        dados.DtCadPessoa = Convert.ToDateTime(dr["DtCadPessoa"]);
                        //dados.PbFotoFuncionario = Convert(dr["PbFotoFuncionario"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }
    }
}
