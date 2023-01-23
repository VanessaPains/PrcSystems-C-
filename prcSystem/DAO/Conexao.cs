using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.DAO//faz a cnexão com banco de dados
{
    public class Conexao
    {
        SqlConnection conexao = new SqlConnection();


        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PrcSystems;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlConnection conectar()
        {//verifica se ja existe conexao,
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao; //e estiver fechada, abrir conexao
        }

        public void desconectar()
        {//verifica se ja existe conexao aberta
            if (conexao.State == System.Data.ConnectionState.Open)
            {//e estiver aberta e pra fechar
                conexao.Close();
            }
        }
    }
}
