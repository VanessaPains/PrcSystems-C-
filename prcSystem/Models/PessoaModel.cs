using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    public class PessoaModel
    {
        public static int Inserir(Pessoa obj)
        {
            return new PessoaController().Inserir(obj);
        }

        //public static int Editar(Pessoa obj)
        //{
            //return new PessoaController().Editar(obj);
        //}

        //public static int Deletar(Pessoa obj)
        //{
            //return new PessoaController().Deletar(obj);
        //}

        public List<Pessoa> Listar()
        {
            return new PessoaController().Listar();
        }
    }
}
