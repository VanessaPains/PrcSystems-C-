using prcSystem.Entidades;
using prcSystem.Functions;
using prcSystem.Models;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Collections.Immutable;

namespace prcSystem.View
{
    public partial class FormCadFuncionarios : Form
    {
        public string caminhoFoto = "";
        Funcionarios obj = new Funcionarios();

        public FormCadFuncionarios()
        {
            InitializeComponent();
            DtCadastroFuncionario.Value = DateTime.Now;
            Listar();
            BtnEditarFuncionarios.Enabled = false;
            BtnExcluirFuncionarios.Enabled = false;
        }

        private void salvar()
        {
            try
            {
                obj.NomeFuncionario = Convert.ToString(TxtNomeFuncionario.Text);
                obj.CpfFuncionario = Convert.ToString(TxtCpfFuncionario.Text);
                obj.RgFuncionario = Convert.ToString(TxtRgFuncionario.Text);             
                obj.DtAniversarioFuncionario = Convert.ToDateTime(DtAniversarioFuncionario.Text);
                obj.NomeMaeFuncionario = Convert.ToString(TxtNomeMaeFuncionario.Text);
                obj.NomePaiFuncionario = Convert.ToString(TxtNomePaiFuncionario.Text);
                obj.EndFuncionario = Convert.ToString(TxtEndFuncionario.Text);
                obj.NumFuncionario = Convert.ToString(TxtNumFuncionario.Text);
                obj.CompleFuncionario = Convert.ToString(TxtCompleFuncionario.Text);
                obj.CepFuncionario = Convert.ToString(TxtCepFuncionario.Text);
                obj.BairroFuncionario = Convert.ToString(TxtBairroFuncionario.Text);
                obj.CidadeFuncionario = Convert.ToString(TxtCidadeFuncionario.Text);
                obj.UfFuncionario = Convert.ToString(TxtUfFuncionario.Text);
                obj.TelefoneFuncionario = Convert.ToString(TxtTelefoneFuncionario.Text);
                obj.CelularFuncionario = Convert.ToString(TxtCelularFuncionario.Text);
                obj.CargoFuncionario = Convert.ToString(TxtCargoFuncionario.Text);
                obj.SalarioFuncionario = Convert.ToDecimal(TxtSalarioFuncionario.Text);
                obj.EntradaTrabFuncionario = CbEntradaTrabFuncionario.Text;
                obj.SaidaTrabFuncionario = CbSaidaTrabFuncionario.Text;
                obj.EntradaIntervaloTrabFuncionario = CbEntradaIntervaloTrabFuncionario.Text;
                obj.SaidaIntervaloTrabFuncionario = CbSaidaIntervaloTrabFuncionario.Text;
                obj.EntradaSabadoTrabFuncionario = CbEntradaSabadoTrabFuncionario.Text;
                obj.SaidaSabadoTrabFuncionario = CbSaidaSabadoTrabFuncionario.Text;
                obj.DtAdmissaoFuncionario = Convert.ToDateTime(DtAdmissaoFuncionario.Text);
                obj.DtDemissaoFuncionario = Convert.ToDateTime(DtDemissaoFuncionario.Text);
                obj.DtCadastroFuncionario = Convert.ToDateTime(DtCadastroFuncionario.Text);
                //obj.CaminhoFoto = caminhoFoto;
             

                int x = FuncionariosModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao inserir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir." + ex);
            }
        }

        /// <summary>
        /// editar formulario
        /// </summary>
        private void editar()
        {
            try
            {
                obj.IdFuncionario = Convert.ToInt32(TxtIdFuncionario.Text);
                obj.NomeFuncionario = Convert.ToString(TxtNomeFuncionario.Text);
                obj.CpfFuncionario = Convert.ToString(TxtCpfFuncionario.Text);
                obj.RgFuncionario = Convert.ToString(TxtRgFuncionario.Text);
                obj.DtAniversarioFuncionario = Convert.ToDateTime(DtAniversarioFuncionario.Text);
                obj.NomeMaeFuncionario = Convert.ToString(TxtNomeMaeFuncionario.Text);
                obj.NomePaiFuncionario = Convert.ToString(TxtNomePaiFuncionario.Text);
                obj.EndFuncionario = Convert.ToString(TxtEndFuncionario.Text);
                obj.NumFuncionario = Convert.ToString(TxtNumFuncionario.Text);
                obj.CompleFuncionario = Convert.ToString(TxtCompleFuncionario.Text);
                obj.CepFuncionario = Convert.ToString(TxtCepFuncionario.Text);
                obj.BairroFuncionario = Convert.ToString(TxtBairroFuncionario.Text);
                obj.CidadeFuncionario = Convert.ToString(TxtCidadeFuncionario.Text);
                obj.UfFuncionario = Convert.ToString(TxtUfFuncionario.Text);
                obj.TelefoneFuncionario = Convert.ToString(TxtTelefoneFuncionario.Text);
                obj.CelularFuncionario = Convert.ToString(TxtCelularFuncionario.Text);
                obj.CargoFuncionario = Convert.ToString(TxtCargoFuncionario.Text);
                obj.SalarioFuncionario = Convert.ToDecimal(TxtSalarioFuncionario.Text);
                obj.EntradaTrabFuncionario = CbEntradaTrabFuncionario.Text;
                obj.SaidaTrabFuncionario = CbSaidaTrabFuncionario.Text;
                obj.EntradaIntervaloTrabFuncionario = CbEntradaIntervaloTrabFuncionario.Text;
                obj.SaidaIntervaloTrabFuncionario = CbSaidaIntervaloTrabFuncionario.Text;
                obj.EntradaSabadoTrabFuncionario = CbEntradaSabadoTrabFuncionario.Text;
                obj.SaidaSabadoTrabFuncionario = CbSaidaSabadoTrabFuncionario.Text;
                obj.DtAdmissaoFuncionario = Convert.ToDateTime(DtAdmissaoFuncionario.Text);
                obj.DtDemissaoFuncionario = Convert.ToDateTime(DtDemissaoFuncionario.Text);
                obj.DtCadastroFuncionario = Convert.ToDateTime(DtCadastroFuncionario.Text);
                //obj.PbxFotoFuncionario = Convert.ToString(PbxFotoFuncionario.Image);
                //obj.CaminhoFoto = caminhoFoto;

                int x = FuncionariosModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao editarrr.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar." + ex);
            }
        }

        /// <summary>
        /// excluir
        /// </summary>
        private void excluir()
        {
            try
            {
                obj.IdFuncionario = Convert.ToInt32(TxtIdFuncionario.Text);
                int x = FuncionariosModel.Deletar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir." + ex);
            }
        }

        /// <summary>
        /// limpar campos
        /// </summary>
        private void limpar()
        {
            TxtNomeFuncionario.Select();////onde o cursor fica inicializada depois de incluir

            TxtIdFuncionario.Text = "";
            TxtNomeFuncionario.Text = "";
            TxtCpfFuncionario.Text = "";
            TxtRgFuncionario.Text = "";
            DtAniversarioFuncionario.Text = "";
            DtAniversarioFuncionario.Text = "";
            TxtNomeMaeFuncionario.Text = "";
            TxtNomePaiFuncionario.Text = "";
            TxtEndFuncionario.Text = "";
            TxtNumFuncionario.Text = "";
            TxtCompleFuncionario.Text = "";
            TxtCepFuncionario.Text = "";
            TxtBairroFuncionario.Text = "";
            TxtCidadeFuncionario.Text = "";
            TxtUfFuncionario.Text = "";
            TxtTelefoneFuncionario.Text = "";
            TxtCelularFuncionario.Text = ""; 
            TxtCargoFuncionario.Text = "";
            TxtSalarioFuncionario.Text = "";
            CbEntradaTrabFuncionario.Text = "";
            CbSaidaTrabFuncionario.Text = "";
            CbEntradaIntervaloTrabFuncionario.Text = "";
            CbSaidaIntervaloTrabFuncionario.Text = "";
            CbEntradaSabadoTrabFuncionario.Text = "";
            CbSaidaSabadoTrabFuncionario.Text = "";
            //PbxFotoFuncionario.Image = PbxFotoFuncionario.Image; 

            BtnEditarFuncionarios.Enabled = false;
            BtnExcluirFuncionarios.Enabled = false;
            BtnSalvarFuncionarios.Enabled = true;
            DtCadastroFuncionario.Enabled = true;
            DtCadastroFuncionario.Value = DateTime.Now;
        }


        private void Listar()
        {
            try
            {
                List<Funcionarios> lista = new List<Funcionarios>();//datagrid
                lista = new FuncionariosModel().Listar();
                //DgExibirFuncionarios.AutoGenerateColumns = false;

                DgExibirFuncionarios.AllowUserToAddRows = false;

                DgExibirFuncionarios.DataSource = lista;

                DgExibirFuncionarios.Columns[27].Visible = false;//colunas datagrid

                DgExibirFuncionarios.Columns[0].HeaderText = "Cod. Func.";
                DgExibirFuncionarios.Columns[1].HeaderText = "Nome Func.";
                DgExibirFuncionarios.Columns[2].HeaderText = "CPF";
                DgExibirFuncionarios.Columns[3].HeaderText = "RG";
                DgExibirFuncionarios.Columns[4].HeaderText = "Dt. Aniver.";
                DgExibirFuncionarios.Columns[5].HeaderText = "Nm Mãe";
                DgExibirFuncionarios.Columns[6].HeaderText = "Nm Pai";
                DgExibirFuncionarios.Columns[7].HeaderText = "Endereço";
                DgExibirFuncionarios.Columns[8].HeaderText = "Nº.";
                DgExibirFuncionarios.Columns[9].HeaderText = "Comple.";
                DgExibirFuncionarios.Columns[10].HeaderText = "CEP";
                DgExibirFuncionarios.Columns[11].HeaderText = "Bairro";
                DgExibirFuncionarios.Columns[12].HeaderText = "Cidade";
                DgExibirFuncionarios.Columns[13].HeaderText = "UF";
                DgExibirFuncionarios.Columns[14].HeaderText = "Tel.";
                DgExibirFuncionarios.Columns[15].HeaderText = "Cel.";
                DgExibirFuncionarios.Columns[16].HeaderText = "Cargo";
                DgExibirFuncionarios.Columns[17].HeaderText = "Sal.";
                DgExibirFuncionarios.Columns[18].HeaderText = "Ent. Trab";
                DgExibirFuncionarios.Columns[19].HeaderText = "Sai. Trab";
                DgExibirFuncionarios.Columns[20].HeaderText = "Ent. Interv.";
                DgExibirFuncionarios.Columns[21].HeaderText = "Sai. Interv.";
                DgExibirFuncionarios.Columns[22].HeaderText = "Ent. Sab.";
                DgExibirFuncionarios.Columns[23].HeaderText = "Sai. Sab";
                DgExibirFuncionarios.Columns[24].HeaderText = "Dt Admissão";
                DgExibirFuncionarios.Columns[25].HeaderText = "Dt Demissão";
                DgExibirFuncionarios.Columns[26].HeaderText = "Dt Cadastro.";
                DgExibirFuncionarios.Columns[28].HeaderText = "Foto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void BtnSalvarFuncionarios_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtNomeFuncionario.Text == "" || TxtCpfFuncionario.Text == "" || TxtCelularFuncionario.Text == "")
            {
                MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomeFuncionario.Select();//colocar curso em login por padrao

                return;
            }
            else
            {
                salvar();
                limpar();
                Listar();
            }
        }

        private void BtnEditarFuncionarios_Click(object sender, EventArgs e)
        {
            editar();
            Listar();
        }

        private void BtnExcluirFuncionarios_Click(object sender, EventArgs e)
        {
            excluir();
            Listar();
        }

        private void BtnLimparFuncionarios_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void DgExibirFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            DtCadastroFuncionario.Enabled = false;
            TxtIdFuncionario.Enabled = false;
            BtnSalvarFuncionarios.Enabled = false;
            BtnEditarFuncionarios.Enabled = true;
            BtnExcluirFuncionarios.Enabled = true;

            TxtIdFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[0].Value.ToString();
            TxtNomeFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[1].Value.ToString();
            TxtCpfFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[2].Value.ToString();
            TxtRgFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[3].Value.ToString();
            DtAniversarioFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[4].Value.ToString();
            TxtNomeMaeFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[5].Value.ToString();
            TxtNomePaiFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[6].Value.ToString();
            TxtEndFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[7].Value.ToString();
            TxtNumFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[8].Value.ToString();
            TxtCompleFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[9].Value.ToString();
            TxtCepFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[10].Value.ToString();
            TxtBairroFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[11].Value.ToString();
            TxtCidadeFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[12].Value.ToString();
            TxtUfFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[13].Value.ToString();
            TxtTelefoneFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[14].Value.ToString();
            TxtCelularFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[15].Value.ToString();
            TxtCargoFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[16].Value.ToString();
            TxtSalarioFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[17].Value.ToString();
            CbEntradaTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[18].Value.ToString();
            CbSaidaTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[19].Value.ToString();
            CbEntradaIntervaloTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[20].Value.ToString();
            CbSaidaIntervaloTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[21].Value.ToString();
            CbEntradaSabadoTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[22].Value.ToString();
            CbSaidaSabadoTrabFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[23].Value.ToString();
            DtAdmissaoFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[24].Value.ToString();
            DtDemissaoFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[25].Value.ToString();
            DtCadastroFuncionario.Text = DgExibirFuncionarios.CurrentRow.Cells[26].Value.ToString();
            DgExibirFuncionarios.Columns[27].Visible = false;//colunas datagrid

            //PbxFotoFuncionario.Load(caminhoFoto); 
            //PbxFotoFuncionario.Text = (byte[])DgExibirFuncionarios.CurrentRow.Cells[28].Value.ToString();
            //byte[]? bytes = DgExibirFuncionarios.CurrentRow.Cells[28].Value as byte[];
         
            
            //byte[] picture = (Byte[])DgExibirFuncionarios.CurrentRow.Cells[28].Value;  //my program always stopped here

            

            
            // configuração que marca a linha completa.
            DgExibirFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgExibirFuncionarios.Update();
            DgExibirFuncionarios.Select();
            // configuração do estilo da linha
            DgExibirFuncionarios.CurrentRow.DefaultCellStyle.BackColor = Color.Azure;
        }


        private void BtnUpFotoFun_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }

        private void CarregarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagem jpg e png|*.jpg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = openFile.FileName;
            }

            if (caminhoFoto != "")
            {
                PbxFotoFuncionario.Load(caminhoFoto);
            }
        }





    }
}
