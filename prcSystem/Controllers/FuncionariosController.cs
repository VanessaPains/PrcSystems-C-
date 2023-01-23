using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prcSystem.Functions;
using prcSystem.View;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace prcSystem.Controllers
{
    public class FuncionariosController
    {  
        /// <summary>
        /// metodo inserir dados no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Funcionarios obj)
        {
            //byte[] PbxFotoFuncionario = GetFoto(obj.CaminhoFoto);
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();//cn = conexao
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO Funcionarios ([NomeFuncionario],[CpfFuncionario],[RgFuncionario],[DtAniversarioFuncionario],[NomeMaeFuncionario],[NomePaiFuncionario],[EndFuncionario],[NumFuncionario],[CompleFuncionario],[CepFuncionario],[BairroFuncionario],[CidadeFuncionario],[UfFuncionario],[TelefoneFuncionario],[CelularFuncionario],[CargoFuncionario],[SalarioFuncionario],[EntradaTrabFuncionario],[SaidaTrabFuncionario],[EntradaIntervaloTrabFuncionario],[SaidaIntervaloTrabFuncionario],[EntradaSabadoTrabFuncionario],[SaidaSabadoTrabFuncionario],[DtAdmissaoFuncionario],[DtDemissaoFuncionario],[DtCadastroFuncionario])" +
                                 "VALUES " +
                                 "(@NomeFuncionario, @CpfFuncionario, @RgFuncionario, @DtAniversarioFuncionario, @NomeMaeFuncionario, @NomePaiFuncionario, @EndFuncionario, @NumFuncionario, @CompleFuncionario, @CepFuncionario, @BairroFuncionario, @CidadeFuncionario, @UfFuncionario, @TelefoneFuncionario, @CelularFuncionario, @CargoFuncionario, @SalarioFuncionario, @EntradaTrabFuncionario, @SaidaTrabFuncionario, @EntradaIntervaloTrabFuncionario, @SaidaIntervaloTrabFuncionario, @EntradaSabadoTrabFuncionario, @SaidaSabadoTrabFuncionario, @DtAdmissaoFuncionario, @DtDemissaoFuncionario, @DtCadastroFuncionario)"; 

                //cn.Parameters.Add("TxtIdFuncionario", SqlDbType.VarChar).Value = obj.TxtIdFuncionario;
                cn.Parameters.Add("NomeFuncionario", SqlDbType.VarChar).Value = obj.NomeFuncionario;
                cn.Parameters.Add("CpfFuncionario", SqlDbType.VarChar).Value = obj.CpfFuncionario;
                cn.Parameters.Add("RgFuncionario", SqlDbType.VarChar).Value = obj.RgFuncionario;
                cn.Parameters.Add("DtAniversarioFuncionario", SqlDbType.DateTime2).Value = obj.DtAniversarioFuncionario;
                cn.Parameters.Add("NomeMaeFuncionario", SqlDbType.VarChar).Value = obj.NomeMaeFuncionario;
                cn.Parameters.Add("NomePaiFuncionario", SqlDbType.VarChar).Value = obj.NomePaiFuncionario;
                cn.Parameters.Add("EndFuncionario", SqlDbType.VarChar).Value = obj.EndFuncionario;
                cn.Parameters.Add("NumFuncionario", SqlDbType.VarChar).Value = obj.NumFuncionario;
                cn.Parameters.Add("CompleFuncionario", SqlDbType.VarChar).Value = obj.CompleFuncionario;
                cn.Parameters.Add("CepFuncionario", SqlDbType.VarChar).Value = obj.CepFuncionario;
                cn.Parameters.Add("BairroFuncionario", SqlDbType.VarChar).Value = obj.BairroFuncionario;
                cn.Parameters.Add("CidadeFuncionario", SqlDbType.VarChar).Value = obj.CidadeFuncionario;
                cn.Parameters.Add("UfFuncionario", SqlDbType.VarChar).Value = obj.UfFuncionario;
                cn.Parameters.Add("TelefoneFuncionario", SqlDbType.VarChar).Value = obj.TelefoneFuncionario;
                cn.Parameters.Add("CelularFuncionario", SqlDbType.VarChar).Value = obj.CelularFuncionario;
                cn.Parameters.Add("CargoFuncionario", SqlDbType.VarChar).Value = obj.CargoFuncionario;
                cn.Parameters.Add("SalarioFuncionario", SqlDbType.Decimal).Value = obj.SalarioFuncionario;
                cn.Parameters.Add("EntradaTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaTrabFuncionario;
                cn.Parameters.Add("SaidaTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaTrabFuncionario;
                cn.Parameters.Add("EntradaIntervaloTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaIntervaloTrabFuncionario;
                cn.Parameters.Add("SaidaIntervaloTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaIntervaloTrabFuncionario;
                cn.Parameters.Add("EntradaSabadoTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaSabadoTrabFuncionario;
                cn.Parameters.Add("SaidaSabadoTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaSabadoTrabFuncionario;
                cn.Parameters.Add("DtAdmissaoFuncionario", SqlDbType.DateTime2).Value = obj.DtAdmissaoFuncionario;
                cn.Parameters.Add("DtDemissaoFuncionario", SqlDbType.DateTime2).Value = obj.DtDemissaoFuncionario;
                cn.Parameters.Add("DtCadastroFuncionario", SqlDbType.DateTime2).Value = obj.DtCadastroFuncionario;

                //foto
                //cn.Parameters.Add("@PbxFotoFuncionario", SqlDbType.Image).Value = obj.CaminhoFoto;

                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }

        //metodo de listar dos do db
        public List<Funcionarios> Listar()
        {            
            using (SqlConnection con = new SqlConnection())
            {                
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Funcionarios";

                cn.Connection = con;

                SqlDataReader dr;
                dr = cn.ExecuteReader();    
                List<Funcionarios> lista = new List<Funcionarios>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Funcionarios dados = new Funcionarios();

                        dados.IdFuncionario = Convert.ToInt32(dr["IdFuncionario"]);
                        dados.NomeFuncionario = Convert.ToString(dr["NomeFuncionario"]);
                        dados.CpfFuncionario = Convert.ToString(dr["CpfFuncionario"]);
                        dados.RgFuncionario = Convert.ToString(dr["RgFuncionario"]);
                        dados.DtAniversarioFuncionario = Convert.ToDateTime(dr["DtAniversarioFuncionario"]);
                        dados.NomeMaeFuncionario = Convert.ToString(dr["NomeMaeFuncionario"]);
                        dados.NomePaiFuncionario = Convert.ToString(dr["NomePaiFuncionario"]);
                        dados.EndFuncionario = Convert.ToString(dr["EndFuncionario"]);
                        dados.NumFuncionario = Convert.ToString(dr["NumFuncionario"]);
                        dados.CompleFuncionario = Convert.ToString(dr["CompleFuncionario"]);
                        dados.CepFuncionario = Convert.ToString(dr["CepFuncionario"]);
                        dados.BairroFuncionario = Convert.ToString(dr["BairroFuncionario"]);
                        dados.CidadeFuncionario = Convert.ToString(dr["CidadeFuncionario"]);
                        dados.UfFuncionario = Convert.ToString(dr["UfFuncionario"]);
                        dados.TelefoneFuncionario = Convert.ToString(dr["TelefoneFuncionario"]);
                        dados.CelularFuncionario = Convert.ToString(dr["CelularFuncionario"]);
                        dados.CargoFuncionario = Convert.ToString(dr["CargoFuncionario"]);
                        dados.SalarioFuncionario = Convert.ToDecimal(dr["SalarioFuncionario"]);
                        dados.EntradaTrabFuncionario = Convert.ToString(dr["EntradaTrabFuncionario"]);
                        dados.SaidaTrabFuncionario = Convert.ToString(dr["SaidaTrabFuncionario"]);
                        dados.EntradaIntervaloTrabFuncionario = Convert.ToString(dr["EntradaIntervaloTrabFuncionario"]);
                        dados.SaidaIntervaloTrabFuncionario = Convert.ToString(dr["SaidaIntervaloTrabFuncionario"]);
                        dados.EntradaSabadoTrabFuncionario = Convert.ToString(dr["EntradaSabadoTrabFuncionario"]);
                        dados.SaidaSabadoTrabFuncionario = Convert.ToString(dr["SaidaSabadoTrabFuncionario"]);
                        dados.DtAdmissaoFuncionario = Convert.ToDateTime(dr["DtAdmissaoFuncionario"]);
                        dados.DtDemissaoFuncionario = Convert.ToDateTime(dr["DtDemissaoFuncionario"]);
                        dados.DtCadastroFuncionario = Convert.ToDateTime(dr["DtCadastroFuncionario"]);

                        //foto                     
                        //dados.PbxFotoFuncionario = (byte[]?)dr["Foto"];
                        //dados.PbxFotoFuncionario = Convert.ToSByte(dr["PbxFotoFuncionario"]);



                        lista.Add(dados);
                    }
                }
                return lista;
            }
        }



        /// <summary>
        /// metodo de editar dados 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Editar(Funcionarios obj)
        {           
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;//confuracao do appconfig- aponta sua conexao
                SqlCommand cn = new SqlCommand();//comando 
                cn.CommandType = CommandType.Text;//comando do tipo texto
                con.Open();//abrir conexao
                cn.CommandText = "UPDATE Funcionarios SET NomeFuncionario  = @NomeFuncionario, CpfFuncionario  = @CpfFuncionario, RgFuncionario  = @RgFuncionario, DtAniversarioFuncionario = @DtAniversarioFuncionario, NomeMaeFuncionario = @NomeMaeFuncionario, NomePaiFuncionario = @NomePaiFuncionario, EndFuncionario = @EndFuncionario, NumFuncionario = @NumFuncionario, CompleFuncionario = @CompleFuncionario, CepFuncionario = @CepFuncionario, BairroFuncionario = @BairroFuncionario, CidadeFuncionario = @CidadeFuncionario, UfFuncionario = @UfFuncionario, TelefoneFuncionario  = @TelefoneFuncionario, CelularFuncionario = @CelularFuncionario, CargoFuncionario = @CargoFuncionario, SalarioFuncionario = @SalarioFuncionario, EntradaTrabFuncionario = @EntradaTrabFuncionario, SaidaTrabFuncionario = @SaidaTrabFuncionario, EntradaIntervaloTrabFuncionario = @EntradaIntervaloTrabFuncionario, SaidaIntervaloTrabFuncionario = @SaidaIntervaloTrabFuncionario, EntradaSabadoTrabFuncionario = @EntradaSabadoTrabFuncionario, SaidaSabadoTrabFuncionario = @SaidaSabadoTrabFuncionario, DtAdmissaoFuncionario = @DtAdmissaoFuncionario, DtDemissaoFuncionario = @DtDemissaoFuncionario, DtCadastroFuncionario = @DtCadastroFuncionario" +
                    " WHERE IdFuncionario = @IdFuncionario";

                cn.Parameters.Add("IdFuncionario", SqlDbType.VarChar).Value = obj.IdFuncionario;
                cn.Parameters.Add("NomeFuncionario", SqlDbType.VarChar).Value = obj.NomeFuncionario;
                cn.Parameters.Add("CpfFuncionario", SqlDbType.VarChar).Value = obj.CpfFuncionario;
                cn.Parameters.Add("RgFuncionario", SqlDbType.VarChar).Value = obj.RgFuncionario;
                cn.Parameters.Add("DtAniversarioFuncionario", SqlDbType.DateTime2).Value = obj.DtAniversarioFuncionario;
                cn.Parameters.Add("NomeMaeFuncionario", SqlDbType.VarChar).Value = obj.NomeMaeFuncionario;
                cn.Parameters.Add("NomePaiFuncionario", SqlDbType.VarChar).Value = obj.NomePaiFuncionario;
                cn.Parameters.Add("EndFuncionario", SqlDbType.VarChar).Value = obj.EndFuncionario;
                cn.Parameters.Add("NumFuncionario", SqlDbType.VarChar).Value = obj.NumFuncionario;
                cn.Parameters.Add("CompleFuncionario", SqlDbType.VarChar).Value = obj.CompleFuncionario;
                cn.Parameters.Add("CepFuncionario", SqlDbType.VarChar).Value = obj.CepFuncionario;
                cn.Parameters.Add("BairroFuncionario", SqlDbType.VarChar).Value = obj.BairroFuncionario;
                cn.Parameters.Add("CidadeFuncionario", SqlDbType.VarChar).Value = obj.CidadeFuncionario;
                cn.Parameters.Add("UfFuncionario", SqlDbType.VarChar).Value = obj.UfFuncionario;
                cn.Parameters.Add("TelefoneFuncionario", SqlDbType.VarChar).Value = obj.TelefoneFuncionario;
                cn.Parameters.Add("CelularFuncionario", SqlDbType.VarChar).Value = obj.CelularFuncionario;
                cn.Parameters.Add("CargoFuncionario", SqlDbType.VarChar).Value = obj.CargoFuncionario;
                cn.Parameters.Add("SalarioFuncionario", SqlDbType.Decimal).Value = obj.SalarioFuncionario;
                cn.Parameters.Add("EntradaTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaTrabFuncionario;
                cn.Parameters.Add("SaidaTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaTrabFuncionario;
                cn.Parameters.Add("EntradaIntervaloTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaIntervaloTrabFuncionario;
                cn.Parameters.Add("SaidaIntervaloTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaIntervaloTrabFuncionario;
                cn.Parameters.Add("EntradaSabadoTrabFuncionario", SqlDbType.VarChar).Value = obj.EntradaSabadoTrabFuncionario;
                cn.Parameters.Add("SaidaSabadoTrabFuncionario", SqlDbType.VarChar).Value = obj.SaidaSabadoTrabFuncionario;
                cn.Parameters.Add("DtAdmissaoFuncionario", SqlDbType.DateTime2).Value = obj.DtAdmissaoFuncionario;
                cn.Parameters.Add("DtDemissaoFuncionario", SqlDbType.DateTime2).Value = obj.DtDemissaoFuncionario;
                cn.Parameters.Add("DtCadastroFuncionario", SqlDbType.DateTime2).Value = obj.DtCadastroFuncionario;

                //cn.Parameters.Add("@PbxFotoFuncionario",SqlDbType.Image).Value = obj.CaminhoFoto;

                cn.Connection = con;//solicita a conexao        

                int qte = cn.ExecuteNonQuery();//
                return qte;
            }
        }

        //metodo de editar dados 
        public int Deletar(Funcionarios obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Funcionarios WHERE IdFuncionario = @IdFuncionario";

                cn.Parameters.Add("IdFuncionario", SqlDbType.Int).Value = obj.IdFuncionario;
                cn.Connection = con;

                int qte = cn.ExecuteNonQuery();
                return qte;
            }
        }


        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] Foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    Foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return Foto;
        }
    }
}
