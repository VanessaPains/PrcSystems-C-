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
    public class PessoaController
    {

        public int Inserir(Pessoa obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Pessoa ([TipoCadastro], [TipoPessoa], [CnpjCpf], [RazaoNome], [Fantasia], [InscEstadual], [OutrasInsc], [Endereco], [Num], [Complemento], [Cep],[Bairro],[Cidade],[Uf],[Telefone],[Celular],[Email],[Site],[EnderecoCob],[NumCob],[ComplementoCob],[CepCob],[BairroCob],[CidadeCob],[UfCob],[Observacao],[DtCadPessoa],[Foto]) VALUES " +
                "(@TipoCadastro, @TipoPessoa, @CnpjCpf, @RazaoNome, @Fantasia, @InscEstadual, @OutrasInsc, @Endereco, @Num, @Complemento, @Cep, @Bairro, @Cidade, @Uf, @Telefone, @Celular, @Email, @Site, @EnderecoCob, @NumCob, @ComplementoCob, @CepCob, @BairroCob, @CidadeCob, @UfCob, @Observacao, @DtCadPessoa, @Foto)";

                cn.Parameters.Add("TipoCadastro", SqlDbType.VarChar).Value = obj.TipoCadastro;
                cn.Parameters.Add("TipoPessoa", SqlDbType.VarChar).Value = obj.TipoPessoa;

                cn.Parameters.Add("CnpjCpf", SqlDbType.Int).Value = obj.CnpjCpf;
                cn.Parameters.Add("RazaoNome", SqlDbType.VarChar).Value = obj.RazaoNome;
                cn.Parameters.Add("Fantasia", SqlDbType.VarChar).Value = obj.Fantasia;
                cn.Parameters.Add("InscEstadual", SqlDbType.Int).Value = obj.InscEstadual;
                cn.Parameters.Add("OutrasInsc", SqlDbType.Int).Value = obj.OutrasInsc;
                
                cn.Parameters.Add("Endereco", SqlDbType.VarChar).Value = obj.Endereco;
                cn.Parameters.Add("Num", SqlDbType.Int).Value = obj.Num;
                cn.Parameters.Add("Complemento", SqlDbType.VarChar).Value = obj.Complemento;
                cn.Parameters.Add("Cep", SqlDbType.Int).Value = obj.Cep;
                cn.Parameters.Add("Bairro", SqlDbType.VarChar).Value = obj.Bairro;
                cn.Parameters.Add("Cidade", SqlDbType.VarChar).Value = obj.Cidade;
                cn.Parameters.Add("Uf", SqlDbType.VarChar).Value = obj.Uf;

                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = obj.Telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = obj.Celular;
                cn.Parameters.Add("Email", SqlDbType.VarChar).Value = obj.Email;
                cn.Parameters.Add("Site", SqlDbType.VarChar).Value = obj.Site;

                cn.Parameters.Add("Foto", SqlDbType.Image).Value = obj.Foto;
                cn.Parameters.Add("EnderecoCob", SqlDbType.VarChar).Value = obj.EnderecoCob;
                cn.Parameters.Add("NumCob", SqlDbType.Int).Value = obj.NumCob;
                cn.Parameters.Add("ComplementoCob", SqlDbType.VarChar).Value = obj.ComplementoCob;
                cn.Parameters.Add("CepCob", SqlDbType.Int).Value = obj.CepCob;
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

        //metodo de listar dos do db
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
                        dados.CnpjCpf = Convert.ToInt32(dr["CnpjCpf"]);
                        dados.RazaoNome = Convert.ToString(dr["RazaoNome"]);
                        dados.Fantasia = Convert.ToString(dr["Fantasia"]);
                        dados.InscEstadual = Convert.ToInt32(dr["InscEstadual"]);
                        dados.OutrasInsc = Convert.ToInt32(dr["OutrasInsc"]);
                        dados.Endereco = Convert.ToString(dr["Endereco"]);
                        dados.Num = Convert.ToInt32(dr["Num"]);
                        dados.Complemento = Convert.ToString(dr["Complemento"]);
                        dados.Cep = Convert.ToInt32(dr["Cep"]);
                        dados.Bairro = Convert.ToString(dr["Bairro"]);
                        dados.Cidade = Convert.ToString(dr["Cidade"]);
                        dados.Uf = Convert.ToString(dr["Uf"]);
                        dados.Telefone = Convert.ToString(dr["Telefone"]);
                        dados.Celular = Convert.ToString(dr["Celular"]);
                        dados.Email = Convert.ToString(dr["Email"]);
                        dados.Site = Convert.ToString(dr["Site"]);
                        dados.EnderecoCob = Convert.ToString(dr["EnderecoCob"]);
                        dados.NumCob = Convert.ToInt32(dr["NumCob"]);
                        dados.ComplementoCob = Convert.ToString(dr["ComplementoCob"]);
                        dados.CepCob = Convert.ToInt32(dr["CepCob"]);
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
