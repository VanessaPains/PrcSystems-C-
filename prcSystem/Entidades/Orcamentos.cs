using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Orcamentos
    {
        int idOrcamento;
        int idCliForn;
        string StatusOrcamento;
        DateTime dtLancOrcamento;
        int numOrcamento;

        string cnpjCpf;
        string nome;
        string razaoSocial;
        string inscEstadual;
        string outrasInsc;
        string endereco;
        string complemento;
        string bairro;
        string num;
        string cep;
        string cidade;
        string uf;

        string telefone;
        string email;
        string site;
        string solicitante;

        string formaPgto;
        string prazoPgto;

        string prazoEntrega;
        string validadeOrcamento;

        int item01;
        int item02;
        int item03;
        int item04;
        int item05;
        int item06;
        int item07;
        int item08;
        int item09;
        int item10;

        int codProd01;
        int codProd02;
        int codProd03;
        int codProd04;
        int codProd05;
        int codProd06;
        int codProd07;
        int codProd08;
        int codProd09;
        int codProd10;

        string descProduto01;
        string descProduto02;
        string descProduto03;
        string descProduto04;
        string descProduto05;
        string descProduto06;
        string descProduto07;
        string descProduto08;
        string descProduto09;
        string descProduto10;

        decimal qte01;
        decimal qte02;
        decimal qte03;
        decimal qte04;
        decimal qte05;
        decimal qte06;
        decimal qte07;
        decimal qte08;
        decimal qte09;
        decimal qte10;

        decimal valorUnProd01;
        decimal valorUnProd02;
        decimal valorUnProd03;
        decimal valorUnProd04;
        decimal valorUnProd05;
        decimal valorUnProd06;
        decimal valorUnProd07;
        decimal valorUnProd08;
        decimal valorUnProd09;
        decimal valorUnProd10;

        decimal totalItem01;
        decimal totalItem02;
        decimal totalItem03;
        decimal totalItem04;
        decimal totalItem05e;
        decimal totalItem06;
        decimal totalItem07;
        decimal totalItem08;
        decimal totalItem09;
        decimal totalItem10;

        string observacao;

        decimal valorTT;

        public int IdOrcamento { get => idOrcamento; set => idOrcamento = value; }
        public int IdCliForn { get => idCliForn; set => idCliForn = value; }
        public string StatusOrcamento1 { get => StatusOrcamento; set => StatusOrcamento = value; }
        public DateTime DtLancOrcamento { get => dtLancOrcamento; set => dtLancOrcamento = value; }
        public int NumOrcamento { get => numOrcamento; set => numOrcamento = value; }
        public string CnpjCpf { get => cnpjCpf; set => cnpjCpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string InscEstadual { get => inscEstadual; set => inscEstadual = value; }
        public string OutrasInsc { get => outrasInsc; set => outrasInsc = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Num { get => num; set => num = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }
        public string Solicitante { get => solicitante; set => solicitante = value; }
        public string FormaPgto { get => formaPgto; set => formaPgto = value; }
        public string PrazoPgto { get => prazoPgto; set => prazoPgto = value; }
        public string PrazoEntrega { get => prazoEntrega; set => prazoEntrega = value; }
        public string ValidadeOrcamento { get => validadeOrcamento; set => validadeOrcamento = value; }
        public int Item01 { get => item01; set => item01 = value; }
        public int Item02 { get => item02; set => item02 = value; }
        public int Item03 { get => item03; set => item03 = value; }
        public int Item04 { get => item04; set => item04 = value; }
        public int Item05 { get => item05; set => item05 = value; }
        public int Item06 { get => item06; set => item06 = value; }
        public int Item07 { get => item07; set => item07 = value; }
        public int Item08 { get => item08; set => item08 = value; }
        public int Item09 { get => item09; set => item09 = value; }
        public int Item10 { get => item10; set => item10 = value; }
        public int CodProd01 { get => codProd01; set => codProd01 = value; }
        public int CodProd02 { get => CodProd021; set => CodProd021 = value; }
        public int CodProd021 { get => codProd02; set => codProd02 = value; }
        public int CodProd03 { get => codProd03; set => codProd03 = value; }
        public int CodProd04 { get => codProd04; set => codProd04 = value; }
        public int CodProd05 { get => codProd05; set => codProd05 = value; }
        public int CodProd06 { get => codProd06; set => codProd06 = value; }
        public int CodProd07 { get => codProd07; set => codProd07 = value; }
        public int CodProd08 { get => codProd08; set => codProd08 = value; }
        public int CodProd09 { get => codProd09; set => codProd09 = value; }
        public int CodProd10 { get => codProd10; set => codProd10 = value; }
        public string DescProduto01 { get => descProduto01; set => descProduto01 = value; }
        public string DescProduto02 { get => descProduto02; set => descProduto02 = value; }
        public string DescProduto03 { get => descProduto03; set => descProduto03 = value; }
        public string DescProduto04 { get => descProduto04; set => descProduto04 = value; }
        public string DescProduto05 { get => descProduto05; set => descProduto05 = value; }
        public string DescProduto06 { get => descProduto06; set => descProduto06 = value; }
        public string DescProduto07 { get => descProduto07; set => descProduto07 = value; }
        public string DescProduto08 { get => descProduto08; set => descProduto08 = value; }
        public string DescProduto09 { get => descProduto09; set => descProduto09 = value; }
        public string DescProduto10 { get => descProduto10; set => descProduto10 = value; }
        public decimal Qte01 { get => qte01; set => qte01 = value; }
        public decimal Qte02 { get => qte02; set => qte02 = value; }
        public decimal Qte03 { get => qte03; set => qte03 = value; }
        public decimal Qte04 { get => qte04; set => qte04 = value; }
        public decimal Qte05 { get => qte05; set => qte05 = value; }
        public decimal Qte06 { get => qte06; set => qte06 = value; }
        public decimal Qte07 { get => qte07; set => qte07 = value; }
        public decimal Qte08 { get => qte08; set => qte08 = value; }
        public decimal Qte09 { get => qte09; set => qte09 = value; }
        public decimal Qte10 { get => qte10; set => qte10 = value; }
        public decimal ValorUnProd01 { get => valorUnProd01; set => valorUnProd01 = value; }
        public decimal ValorUnProd02 { get => valorUnProd02; set => valorUnProd02 = value; }
        public decimal ValorUnProd03 { get => valorUnProd03; set => valorUnProd03 = value; }
        public decimal ValorUnProd04 { get => valorUnProd04; set => valorUnProd04 = value; }
        public decimal ValorUnProd05 { get => valorUnProd05; set => valorUnProd05 = value; }
        public decimal ValorUnProd06 { get => valorUnProd06; set => valorUnProd06 = value; }
        public decimal ValorUnProd07 { get => valorUnProd07; set => valorUnProd07 = value; }
        public decimal ValorUnProd08 { get => valorUnProd08; set => valorUnProd08 = value; }
        public decimal ValorUnProd09 { get => valorUnProd09; set => valorUnProd09 = value; }
        public decimal ValorUnProd10 { get => valorUnProd10; set => valorUnProd10 = value; }
        public decimal TotalItem01 { get => totalItem01; set => totalItem01 = value; }
        public decimal TotalItem02 { get => totalItem02; set => totalItem02 = value; }
        public decimal TotalItem03 { get => totalItem03; set => totalItem03 = value; }
        public decimal TotalItem04 { get => totalItem04; set => totalItem04 = value; }
        public decimal TotalItem05e { get => totalItem05e; set => totalItem05e = value; }
        public decimal TotalItem06 { get => totalItem06; set => totalItem06 = value; }
        public decimal TotalItem07 { get => totalItem07; set => totalItem07 = value; }
        public decimal TotalItem08 { get => totalItem08; set => totalItem08 = value; }
        public decimal TotalItem09 { get => totalItem09; set => totalItem09 = value; }
        public decimal TotalItem10 { get => totalItem10; set => totalItem10 = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public decimal ValorTT { get => valorTT; set => valorTT = value; }
    }
}
