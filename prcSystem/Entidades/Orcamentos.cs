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

        string prozoEntrega;
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
    }
}
