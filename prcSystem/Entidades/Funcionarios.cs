using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Funcionarios
    {
        int idFuncionario;
        string nomeFuncionario;
        string cpfFuncionario;
        string rgFuncionario;
        DateTime dtAniversarioFuncionario;
        string nomeMaeFuncionario;
        string nomePaiFuncionario;
        string endFuncionario;
        string numFuncionario;
        string compleFuncionario;
        string cepFuncionario;
        string bairroFuncionario;
        string cidadeFuncionario;
        string ufFuncionario;
        string telefoneFuncionario;
        string celularFuncionario;
        string cargoFuncionario;
        decimal salarioFuncionario;
        string entradaTrabFuncionario;
        string saidaTrabFuncionario;
        string entradaIntervaloTrabFuncionario;
        string saidaIntervaloTrabFuncionario;
        string entradaSabadoTrabFuncionario;
        string saidaSabadoTrabFuncionario;
        DateTime dtAdmissaoFuncionario;
        DateTime dtDemissaoFuncionario;
        DateTime dtCadastroFuncionario;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public string CpfFuncionario { get => cpfFuncionario; set => cpfFuncionario = value; }
        public string RgFuncionario { get => rgFuncionario; set => rgFuncionario = value; }
        public DateTime DtAniversarioFuncionario { get => dtAniversarioFuncionario; set => dtAniversarioFuncionario = value; }
        public string NomeMaeFuncionario { get => nomeMaeFuncionario; set => nomeMaeFuncionario = value; }
        public string NomePaiFuncionario { get => nomePaiFuncionario; set => nomePaiFuncionario = value; }
        public string EndFuncionario { get => endFuncionario; set => endFuncionario = value; }
        public string NumFuncionario { get => numFuncionario; set => numFuncionario = value; }
        public string CompleFuncionario { get => compleFuncionario; set => compleFuncionario = value; }
        public string CepFuncionario { get => cepFuncionario; set => cepFuncionario = value; }
        public string BairroFuncionario { get => bairroFuncionario; set => bairroFuncionario = value; }
        public string CidadeFuncionario { get => cidadeFuncionario; set => cidadeFuncionario = value; }
        public string UfFuncionario { get => ufFuncionario; set => ufFuncionario = value; }
        public string TelefoneFuncionario { get => telefoneFuncionario; set => telefoneFuncionario = value; }
        public string CelularFuncionario { get => celularFuncionario; set => celularFuncionario = value; }
        public string CargoFuncionario { get => cargoFuncionario; set => cargoFuncionario = value; }
        public decimal SalarioFuncionario { get => salarioFuncionario; set => salarioFuncionario = value; }
        public string EntradaTrabFuncionario { get => entradaTrabFuncionario; set => entradaTrabFuncionario = value; }
        public string SaidaTrabFuncionario { get => saidaTrabFuncionario; set => saidaTrabFuncionario = value; }
        public string EntradaIntervaloTrabFuncionario { get => entradaIntervaloTrabFuncionario; set => entradaIntervaloTrabFuncionario = value; }
        public string SaidaIntervaloTrabFuncionario { get => saidaIntervaloTrabFuncionario; set => saidaIntervaloTrabFuncionario = value; }
        public string EntradaSabadoTrabFuncionario { get => entradaSabadoTrabFuncionario; set => entradaSabadoTrabFuncionario = value; }
        public string? SaidaSabadoTrabFuncionario { get => saidaSabadoTrabFuncionario; set => saidaSabadoTrabFuncionario = value; }
        public DateTime DtAdmissaoFuncionario { get => dtAdmissaoFuncionario; set => dtAdmissaoFuncionario = value; }
        public DateTime DtDemissaoFuncionario { get => dtDemissaoFuncionario; set => dtDemissaoFuncionario = value; }
        public DateTime DtCadastroFuncionario { get => dtCadastroFuncionario; set => dtCadastroFuncionario = value; }
        
        //fotos
        public string? CaminhoFoto { get; set; }

        public Image PbxFotoFuncionario { get; set; }
        
        public byte[]? Foto { get; set; }
    }
}
