using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Cdc
    {
        int idCdc;
        string codCdc;
        string descricaoCdc;
        DateTime dtCadastroCdc;
        

        public int IdCdc { get => idCdc; set => idCdc = value; }
        public string CodCdc { get => codCdc; set => codCdc = value; }
        public string DescricaoCdc { get => descricaoCdc; set => descricaoCdc = value; }
        public DateTime DtCadastroCdc { get => dtCadastroCdc; set => dtCadastroCdc = value; }
        
    }
}
