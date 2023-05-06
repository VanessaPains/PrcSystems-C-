using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class OrcamentosModel
    {
        /// <summary>
        /// lista os clientes e fornecedores do PessoaController
        /// </summary>
        /// <returns>lista dos clientes e fornecedores na tela de orçamentos de entradas e saidas</returns>
        public List<Pessoa> ListarCliForn()
        {
            return new PessoaController().Listar();
        }

        /// <summary>
        /// lista os produtos do ProdutosController
        /// </summary>
        /// <returns>lista dos produtos na tela de orçamentos de entradas e saidas</returns>
        public List<Produtos> ListarProdutos()
        {
            return new ProdutosController().Listar();
        }

    }
}
