using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class FuncionariosModel
    {

        public static int Inserir(Funcionarios obj)
        {
            return new FuncionariosController().Inserir(obj);
        }

        public static int Editar(Funcionarios obj)
        {
            return new FuncionariosController().Editar(obj);
        }

        public static int Deletar(Funcionarios obj)
        {
            return new FuncionariosController().Deletar(obj);
        }

        public List<Funcionarios> Listar()
        {
            return new FuncionariosController().Listar();
        }
    }
}
