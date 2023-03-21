using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.Controllers
{
    public class CdcController
    {
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Cdc obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Cdc ([CodCdc],[DescricaoCdc], [DtCadastroCdc]) VALUES (@CodCdc, @DescricaoCdc, @DtCadastroCdc)";

                cn.Parameters.Add("CodCdc", SqlDbType.VarChar).Value = obj.CodCdc;
                cn.Parameters.Add("DescricaoCdc", SqlDbType.VarChar).Value = obj.DescricaoCdc;
                cn.Parameters.Add("DtCadastroCdc", SqlDbType.DateTime2).Value = obj.DtCadastroCdc;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }


        /// <summary>
        /// metodo editar dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Cdc obj)
        {   //conexão com banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//conexão banco
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Cdc SET CodCdc = @CodCdc, DescricaoCdc = @DescricaoCdc, DtCadastroCdc = @DtCadastroCdc";

                cn.Parameters.Add("CodCdc", SqlDbType.VarChar).Value = obj.CodCdc;
                cn.Parameters.Add("DescricaoCdc", SqlDbType.VarChar).Value = obj.DescricaoCdc;               
                cn.Parameters.Add("DtCadastroCdc", SqlDbType.DateTime).Value = obj.DtCadastroCdc;

                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.IdCdc;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }


        //buscar dos dados do db
        public List<Cdc> Buscar(Cdc obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Cdc WHERE IdCdc = @IdCdc";
                cn.Parameters.Add("Id", SqlDbType.Int).Value = obj.IdCdc;
                cn.Connection = con;

                SqlDataReader dr;
                List<Cdc> lista = new List<Cdc>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cdc dados = new Cdc();

                        dados.IdCdc = Convert.ToInt32(dr["IdCdc"]);
                        dados.CodCdc = Convert.ToString(dr["CodCdc"]);
                        dados.DescricaoCdc = Convert.ToString(dr["DescricaoCdc"]);
                        dados.DtCadastroCdc = Convert.ToDateTime(dr["DtCadastroCdc"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }


        
        //metodo de listar dos do db
        public List<Cdc> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Cdc";

                cn.Connection = con;

                SqlDataReader dr;
                List<Cdc> lista = new List<Cdc>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cdc dados = new Cdc();

                        dados.IdCdc = Convert.ToInt32(dr["IdCdc"]);
                        dados.CodCdc = Convert.ToString(dr["CodCdc"]);
                        dados.DescricaoCdc = Convert.ToString(dr["DescricaoCdc"]);          
                        dados.DtCadastroCdc = Convert.ToDateTime(dr["DtCadastroCdc"]);

                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }

    }
}
