using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class PagamentoModel
    {
        public static int Inserir(Pagamentos obj)
        {
            return new PagamentosController().Inserir(obj);
        }

        public List<Pagamentos> ListarTodos()
        {
            return new PagamentosController().ListarTodos();
        }
    }
}
