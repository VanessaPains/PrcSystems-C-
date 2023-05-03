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
        /// <returns>lista dos clientes e fornecedores na tela de lançamentos de entradas e saidas</returns>
        public List<Pessoa> ListarCliForn()
        {
            return new PessoaController().Listar();
        }

    }
}
