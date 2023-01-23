using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class UsuariosModel
    {
        public static int Inserir(Usuarios obj)
        {
            return new UsuariosController().Inserir(obj);
        }

        public static int Editar(Usuarios obj)
        {
            return new UsuariosController().Editar(obj);
        }

        public static int Deletar(Usuarios obj)
        {
            return new UsuariosController().Deletar(obj);
        }

        public List<Usuarios> Listar()
        {
            return new UsuariosController().Listar();
        }
    }
}
