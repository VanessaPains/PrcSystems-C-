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


        public List<Lancamentos> ListarLancamentos()
        {
            return new LancamentoController().Listar();
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
    }
}
