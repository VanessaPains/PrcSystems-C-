using prcSystem.Controllers;
using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Models
{
    internal class FornecedoresModel
    {
        public static int Inserir(Fornecedores objForn)//botão inserir que pega referencias campos do arquivo model que tem campos
        {
            return new FornecedoresController().Inserir(objForn);//puxa controles do arquivo
        }

        public static int Editar(Fornecedores objForn)
        {
            return new FornecedoresController().Editar(objForn);
        }
    }
}
