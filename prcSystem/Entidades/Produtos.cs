using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Produtos
    {
        int idProduto;
        string descProduto;
        string marcaProduto;
        string unidadeProduto;
        decimal valorProduto;
        DateTime dtCadastroProduto;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string DescProduto { get => descProduto; set => descProduto = value; }
        public string MarcaProduto { get => marcaProduto; set => marcaProduto = value; }
        public string UnidadeProduto { get => unidadeProduto; set => unidadeProduto = value; }
        public decimal ValorProduto { get => valorProduto; set => valorProduto = value; }
        public DateTime DtCadastroProduto { get => dtCadastroProduto; set => dtCadastroProduto = value; }
    }
}
