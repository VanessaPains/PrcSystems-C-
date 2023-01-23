using prcSystem.Controllers;
using prcSystem.DAO;
using prcSystem.Entidades;
using prcSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadClientes : Form
    {

        Clientes obj = new Clientes();
        
        public FormCadClientes()
        {
            InitializeComponent();
            DtCadastroCli.Value = DateTime.Now;
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblRazaoSocial_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormCadClientes_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        public String mensagem = "";

        private void BtnSalvarCli_Click(object sender, EventArgs e)
        { 
            //verifica se todos os campos estao preenchidos
            if (TxtCnpjCpfCli.Text == "" || TxtNomeCli.Text == "" || TxtRazaoSocialCli.Text == "" || TxtEnderecoCli.Text == "" || TxtNumCli.Text == "" || TxtComplementoCli.Text == "" || TxtCepCli.Text == "" || TxtBairroCli.Text == "" || TxtCidadeCli.Text == "" || TxtUfCli.Text == "" || TxtTelefoneCli.Text == "")
            {
                MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomeCli.Select();//colocar curso em login por padrao
                return;
            }
            else
            {
                salvar();
                limpar();
            }         
        }

        private void salvar()
        {

            try
            {                              
                obj.CnpjCpfCli = Convert.ToString(TxtCnpjCpfCli.Text);
                obj.InscEstadualCli = Convert.ToString(TxtInscEstadualCli.Text);
                obj.OutrasInscCli = Convert.ToString(TxtOutrasInscCli.Text);
                obj.NomeCli = Convert.ToString(TxtNomeCli.Text);
                obj.RazaoSocialCli = Convert.ToString(TxtRazaoSocialCli.Text);
                obj.EnderecoCli = Convert.ToString(TxtEnderecoCli.Text);
                obj.NumCli = Convert.ToString(TxtComplementoCli.Text);
                obj.ComplementoCli = Convert.ToString(TxtComplementoCli.Text);
                obj.CepCli = Convert.ToString(TxtCepCli.Text);
                obj.BairroCli = Convert.ToString(TxtBairroCli.Text);
                obj.CidadeCli = Convert.ToString(TxtCidadeCli.Text);
                obj.UfCli = Convert.ToString(TxtUfCli.Text);
                obj.TelefoneCli = Convert.ToString(TxtTelefoneCli.Text);
                obj.CelularCli = Convert.ToString(TxtCelularCli.Text);
                obj.EmailCli = Convert.ToString(TxtEmailCli.Text);
                obj.SiteCli = Convert.ToString(TxtSiteCli.Text);
                obj.EnderecoCobCli = Convert.ToString(TxtEnderecoCobCli.Text);
                obj.NumCobCli = Convert.ToString(TxtNumCobCli.Text);
                obj.ComplementoCobCli = Convert.ToString(TxtComplementoCobCli.Text);
                obj.CepCobCli = Convert.ToString(TxtCepCobCli.Text);
                obj.BairroCobCli = Convert.ToString(TxtBairroCobCli.Text);
                obj.CidadeCobCli = Convert.ToString(TxtCidadeCobCli.Text);
                obj.UfCobCli = Convert.ToString(TxtUfCobCli.Text);
                obj.ObservacaoCli = Convert.ToString(TxtObservacaoCli.Text);
                obj.DtCadastroCli = Convert.ToDateTime(DtCadastroCli.Text);

                int x = ClientesModel.Inserir(obj);
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

        private void limpar()
        {
            TxtCnpjCpfCli.Text = "";//limpa os textbox depois verificados
            TxtInscEstadualCli.Text = "";
            TxtOutrasInscCli.Text = "";
            TxtNomeCli.Text = "";
            TxtRazaoSocialCli.Text = "";
            TxtEnderecoCli.Text = "";
            TxtNumCli.Text = "";
            TxtComplementoCli.Text = "";
            TxtCepCli.Text = "";
            TxtBairroCli.Text = "";
            TxtCidadeCli.Text = "";
            TxtUfCli.Text = "";
            TxtTelefoneCli.Text = "";
            TxtCelularCli.Text = "";
            TxtEmailCli.Text = "";
            TxtSiteCli.Text = "";
            TxtEnderecoCobCli.Text = "";
            TxtNumCobCli.Text = "";
            TxtComplementoCobCli.Text = "";
            TxtCepCobCli.Text = "";
            TxtBairroCobCli.Text = "";
            TxtCidadeCobCli.Text = "";
            TxtUfCobCli.Text = "";
            TxtObservacaoCli.Text = "";
            DtCadastroCli.Text = "";

            TxtCnpjCpfCli.Select();////onde o cursor fica inicializada depois de incluir
        }

        private void BtnCancelarCli_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
