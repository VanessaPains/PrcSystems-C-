using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class LancamentoModel
    {
        public static int Inserir(Lancamentos obj)
        {
            return new LancamentoController().Inserir(obj);
        }

        public static int Editar(Lancamentos obj)
        {
            return new LancamentoController().Editar(obj);
        }

        public static int Deletar(Lancamentos obj)
        {
            return new LancamentoController().Deletar(obj);
        }

        public List<Lancamentos> Listar()
        {
            return new LancamentoController().Listar();
        }

        public List<Lancamentos> ListarPagamentos()
        {
            return new LancamentoController().ListarPagamentos();
        }

        /// <summary>
        /// lista os clientes e fornecedores do PessoaController
        /// </summary>
        /// <returns>lista dos clientes e fornecedores na tela de lançamentos de entradas e saidas</returns>
        public List<Pessoa> ListarCliForn()
        {
            return new PessoaController().Listar();
        }

        /// <summary>
        /// lista os cdc da CdcController
        /// </summary>
        /// <returns>lista cdc na tela de lançamentos de entradas e saidas</returns>
        public List<Cdc> ListarCdc()
        {
            return new CdcController().Listar();
        }

        public List<Lancamentos> PesquisarFornCLi(Lancamentos obj)
        {
            return new LancamentoController().PesquisarFornCLi(obj);
        }

        public List<Lancamentos> PesquisarCodCliPagamento(Lancamentos obj)
        {
            return new LancamentoController().PesquisarCodCliPagamento(obj);
        }

        /// <summary>
        /// pesquisar pagamentos em aberto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>lista </returns>
        public List<Lancamentos> PesquisarSituacaoAberto(Lancamentos obj)
        {
            return new LancamentoController().PesquisarTipoSituacao(obj);
        }

        public List<Lancamentos> PesquisarSituacaoPagas(Lancamentos obj)
        {
            return new LancamentoController().PesquisarTipoSituacao(obj);
        }

        public List<Lancamentos> PesquisarTipoEntrada(Lancamentos obj)
        {
            return new LancamentoController().PesquisarTipoSituacaoPagamentos(obj);
        }

        public List<Lancamentos> PesquisarTipoSaida(Lancamentos obj)
        {
            return new LancamentoController().PesquisarTipoSituacaoPagamentos(obj);
        }

        public List<Lancamentos> PesquisarTipoTodos(Lancamentos obj)
        {
            return new LancamentoController().PesquisarTipoSituacaoPagamentos(obj);
        }

        public List<Lancamentos> PesquisarNumDocCnpjCpfCodCdcRazaoNome(Lancamentos obj)
        {
            return new LancamentoController().PesquisarNumDocCnpjCpfCodCdcRazaoNome(obj);
        }
    }
}
