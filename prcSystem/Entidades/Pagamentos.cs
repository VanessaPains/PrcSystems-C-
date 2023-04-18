using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Pagamentos
    {
        int idLancamento;
        string tipoLancamento;
        int idPessoa;
        string razaoNome;
        string cnpjCpf;
        int idCdc;

        string descricaoCdc;
        string codCdc;

        string? numDocumento;
        DateTime dtLancamento;
        DateTime dtEmissao;
        DateTime dtVencimento;
        DateTime dtPagamento;
        decimal valorTotal;
        string comentarios;
        decimal jurosPagto;
        decimal totalPagoPagto;

        string pagoEm;
        string situacao;


        public string? TipoLancamento { get => tipoLancamento; set => tipoLancamento = value; }
        public int IdLancamento { get => idLancamento; set => idLancamento = value; }
        public int IdPessoa { get => idPessoa; set => idPessoa = value; }
        public int IdCdc { get => idCdc; set => idCdc = value; }
        public string NumDocumento { get => numDocumento; set => numDocumento = value; }
        public DateTime DtLancamento { get => dtLancamento; set => dtLancamento = value; }
        public DateTime DtEmissao { get => DtEmissao1; set => DtEmissao1 = value; }
        public DateTime DtEmissao1 { get => dtEmissao; set => dtEmissao = value; }
        public DateTime DtVencimento { get => dtVencimento; set => dtVencimento = value; }
        public DateTime DtPagamento { get => dtPagamento; set => dtPagamento = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string RazaoNome { get => razaoNome; set => razaoNome = value; }
        public string DescricaoCdc { get => descricaoCdc; set => descricaoCdc = value; }
        public string CodCdc { get => codCdc; set => codCdc = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string CnpjCpf { get => cnpjCpf; set => cnpjCpf = value; }
        public decimal JurosPagto { get => jurosPagto; set => jurosPagto = value; }
        public decimal TotalPagoPagto { get => totalPagoPagto; set => totalPagoPagto = value; }
        public string PagoEm { get => pagoEm; set => pagoEm = value; }
    }
}
