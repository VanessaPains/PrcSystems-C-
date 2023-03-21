using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Pessoa
    {
        int idPessoa;
        string tipoCadastro;
        string tipoPessoa;

        string cnpjCpf;
        string razaoNome;
        string fantasia;
        string inscEstadual;
        string outrasInsc;

        string endereco;
        string num;
        string complemento;
        string cep;
        string bairro;
        string cidade;
        string uf;
        string celular;
        string email;
        string site;

        string enderecoCob;
        string numCob;
        string complementoCob;
        string cepCob;
        string bairroCob;
        string cidadeCob;
        string ufCob;
        string observacao;
        DateTime dtCadPessoa;
        Byte foto;

        public static object DgExibirCliForn { get; internal set; }

        public int IdPessoa { get => idPessoa; set => idPessoa = value; }
        public string TipoCadastro { get => tipoCadastro; set => tipoCadastro = value; }
        public string TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }

        public string CnpjCpf { get => cnpjCpf; set => cnpjCpf = value; }
        public string RazaoNome { get => razaoNome; set => razaoNome = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }


        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }
        public string OutrasInsc { get => outrasInsc; set => outrasInsc = value; }


        public string Endereco { get => endereco; set => endereco = value; }
        public string Num { get => num; set => num = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }

       
        public string Telefone { get; set; } = "";
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }


        public string EnderecoCob { get => enderecoCob; set => enderecoCob = value; }
        public string? NumCob { get; set; }
        public string ComplementoCob { get => complementoCob; set => complementoCob = value; }
        public string CepCob { get => cepCob; set => cepCob = value; }
        public string BairroCob { get => bairroCob; set => bairroCob = value; }
        public string CidadeCob { get => cidadeCob; set => cidadeCob = value; }
        public string UfCob { get => ufCob; set => ufCob = value; }
        public string Observacao { get => observacao; set => observacao = value; }


        public DateTime DtCadPessoa { get => dtCadPessoa; set => dtCadPessoa = value; }

        public byte[] Foto { get; set; }
        //public byte Foto { get => foto; set => foto = value; }
    }
}
