using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Vendedores
    {
        int idVendedores;
        string nomeVendedor;
        DateTime dtCadastroVendedor;

        public int IdVendedores { get => idVendedores; set => idVendedores = value; }
        public string NomeVendedor { get => nomeVendedor; set => nomeVendedor = value; }
        public DateTime DtCadastroVendedor { get => dtCadastroVendedor; set => dtCadastroVendedor = value; }
    }
}
