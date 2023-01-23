using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class ProdutoModel
    {
        public static int Inserir(Produtos obj)
        {
            return new ProdutosController().Inserir(obj);
        }

        public static int Editar(Produtos obj)
        {
            return new ProdutosController().Editar(obj);
        }

        public static int Deletar(Produtos obj)
        {
            return new ProdutosController().Deletar(obj);
        }

        public List<Produtos> Buscar(Produtos Obj)
        {
            return new ProdutosController().Buscar(Obj);
        }

        public List<Produtos> Listar()
        {
            return new ProdutosController().Listar();
        }
    }
}
