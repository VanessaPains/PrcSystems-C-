using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class ClientesModel  
    {

        public static int Inserir(Clientes obj)
        {
            return new ClientesController().Inserir(obj);
        }

        public static int Editar(Clientes obj)
        {
            return new ClientesController().Editar(obj);
        }


    }
}
