using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class CdcModel
    {
        public static int Inserir(Cdc obj)
        {
            return new CdcController().Inserir(obj);
        }

        public static int Editar(Cdc obj)
        {
            return new CdcController().Editar(obj);
        }

        public List<Cdc> Listar()
        {
            return new CdcController().Listar();
        }
    }
}
