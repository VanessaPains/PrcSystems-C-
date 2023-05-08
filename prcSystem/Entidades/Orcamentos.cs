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
        int idPessoa;
        int idProduto;
        string StatusOrcamento;
        DateTime dtLancOrcamento;
        int numOrcamento;

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
        decimal totalItem05;
        decimal totalItem06;
        decimal totalItem07;
        decimal totalItem08;
        decimal totalItem09;
        decimal totalItem10;

        string observacao;

        decimal valorTT;

        public int IdOrcamento { get => idOrcamento; set => idOrcamento = value; }
        public int IdPessoa { get => idPessoa; set => idPessoa = value; }
        public string StatusOrcamento1 { get => StatusOrcamento; set => StatusOrcamento = value; }
        public DateTime DtLancOrcamento { get => dtLancOrcamento; set => dtLancOrcamento = value; }
        public int NumOrcamento { get => numOrcamento; set => numOrcamento = value; }
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
        public int CodProd02 { get => codProd02; set => codProd02 = value; }
        public int CodProd03 { get => codProd03; set => codProd03 = value; }
        public int CodProd04 { get => codProd04; set => codProd04 = value; }
        public int CodProd05 { get => codProd05; set => codProd05 = value; }
        public int CodProd06 { get => codProd06; set => codProd06 = value; }
        public int CodProd07 { get => codProd07; set => codProd07 = value; }
        public int CodProd08 { get => codProd08; set => codProd08 = value; }
        public int CodProd09 { get => codProd09; set => codProd09 = value; }
        public int CodProd10 { get => codProd10; set => codProd10 = value; }

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
        public decimal TotalItem05 { get => totalItem05; set => totalItem05 = value; }
        public decimal TotalItem06 { get => totalItem06; set => totalItem06 = value; }
        public decimal TotalItem07 { get => totalItem07; set => totalItem07 = value; }
        public decimal TotalItem08 { get => totalItem08; set => totalItem08 = value; }
        public decimal TotalItem09 { get => totalItem09; set => totalItem09 = value; }
        public decimal TotalItem10 { get => totalItem10; set => totalItem10 = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public decimal ValorTT { get => valorTT; set => valorTT = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
    }
}
