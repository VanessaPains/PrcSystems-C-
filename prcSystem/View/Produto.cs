using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prcSystem.View
{
    public class Produto
    {
        internal static object obj;

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CaminhoFoto { get; set; }
        public byte[] Foto { get; set; }

        public void Get(int id, Produto produto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT descricao, foto FROM Produto WHERE  id=" + id;

                cn.Connection = con;
                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {


                        produto.Id = id;
                        produto.Descricao = dr["Descricao"].ToString();
                        produto.CaminhoFoto = "";
                        produto.Foto = (byte[])dr["foto"];

                    }
                }
            }
        }
        
        public void Salvar(Produto produto)
        {
            byte[] foto = GetFoto(produto.CaminhoFoto);
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Produto ([descricao],[foto]) VALUES (@descricao, @foto)";

                cn.Parameters.AddWithValue("@descricao", produto.Descricao);
                cn.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                cn.Connection = con;

                cn.ExecuteNonQuery();
               
            }
        }
        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }
    }
}
