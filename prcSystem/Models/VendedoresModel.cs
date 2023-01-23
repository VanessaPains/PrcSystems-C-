using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class VendedoresModel
    {
        public static int Inserir(Vendedores obj)
        {
            return new VendedoresController().Inserir(obj);
        }

        public static int Editar(Vendedores obj)
        {
            return new VendedoresController().Editar(obj);
        }

        public static int Deletar(Vendedores obj)
        {
            return new VendedoresController().Deletar(obj);
        }

        public List<Vendedores> Listar()
        {
            return new VendedoresController().Listar();
        }
    }
}
