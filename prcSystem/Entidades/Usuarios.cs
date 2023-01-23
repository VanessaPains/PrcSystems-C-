using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.Entidades
{
    public class Usuarios
    {
        int idUsuario;
        string nomeUser;
        string login;
        string senha;
        DateTime dtCadastroUser;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUser { get => nomeUser; set => nomeUser = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public DateTime DtCadastroUser { get => dtCadastroUser; set => dtCadastroUser = value; }

    }
}
