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

namespace prcSystem.View
{
    public partial class FormCadFornecedoores : Form
    {
        Fornecedores obj = new Fornecedores();

        public FormCadFornecedoores()
        {
            InitializeComponent();
            DtCadastroForn.Value = DateTime.Now;
        }

        public String mensagem = "";

        private void BtnSalvarForn_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtCnpjCpfForn.Text == "" || TxtNomeForn.Text == "" || TxtRazaoSocialForn.Text == "" || TxtEnderecoForn.Text == "" || TxtNumForn.Text == "" || TxtComplementoForn.Text == "" || TxtCepForn.Text == "" || TxtBairroForn.Text == "" || TxtCidadeForn.Text == "" || TxtUfForn.Text == "" || TxtTelefoneForn.Text == "")
            {
                MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomeForn.Select();//colocar curso em login por padrao
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
                obj.CnpjCpfForn = Convert.ToString(TxtCnpjCpfForn.Text);
                obj.InscEstadualForn = Convert.ToString(TxtInscEstadualForn.Text);
                obj.OutrasInscForn = Convert.ToString(TxtOutrasInscForn.Text);
                obj.NomeForn = Convert.ToString(TxtNomeForn.Text);
                obj.RazaoSocialForn = Convert.ToString(TxtRazaoSocialForn.Text);
                obj.EnderecoForn = Convert.ToString(TxtEnderecoForn.Text);
                obj.NumForn = Convert.ToString(TxtComplementoForn.Text);
                obj.ComplementoForn = Convert.ToString(TxtComplementoForn.Text);
                obj.CepForn = Convert.ToString(TxtCepForn.Text);
                obj.BairroForn = Convert.ToString(TxtBairroForn.Text);
                obj.CidadeForn = Convert.ToString(TxtCidadeForn.Text);
                obj.UfForn = Convert.ToString(TxtUfForn.Text);
                obj.TelefoneForn = Convert.ToString(TxtTelefoneForn.Text);
                obj.CelularForn = Convert.ToString(TxtCelularForn.Text);
                obj.EmailForn = Convert.ToString(TxtEmailForn.Text);
                obj.SiteForn = Convert.ToString(TxtSiteForn.Text);
                obj.EnderecoCobForn = Convert.ToString(TxtEnderecoCobForn.Text);
                obj.NumCobForn = Convert.ToString(TxtNumCobForn.Text);
                obj.ComplementoCobForn = Convert.ToString(TxtComplementoCobForn.Text);
                obj.CepCobForn = Convert.ToString(TxtCepCobForn.Text);
                obj.BairroCobForn = Convert.ToString(TxtBairroCobForn.Text);
                obj.CidadeCobForn = Convert.ToString(TxtCidadeCobForn.Text);
                obj.UfCobForn = Convert.ToString(TxtUfCobForn.Text);
                obj.ObservacaoForn = Convert.ToString(TxtObservacaoForn.Text);
                obj.DtCadastroForn = Convert.ToDateTime(DtCadastroForn.Text);

                int x = FornecedoresModel.Inserir(obj);
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
            TxtCnpjCpfForn.Text = "";//limpa os textbox depois verificados
            TxtInscEstadualForn.Text = "";
            TxtOutrasInscForn.Text = "";
            TxtNomeForn.Text = "";
            TxtRazaoSocialForn.Text = "";
            TxtEnderecoForn.Text = "";
            TxtNumForn.Text = "";
            TxtComplementoForn.Text = "";
            TxtCepForn.Text = "";
            TxtBairroForn.Text = "";
            TxtCidadeForn.Text = "";
            TxtUfForn.Text = "";
            TxtTelefoneForn.Text = "";
            TxtCelularForn.Text = "";
            TxtEmailForn.Text = "";
            TxtSiteForn.Text = "";
            TxtEnderecoCobForn.Text = "";
            TxtNumCobForn.Text = "";
            TxtComplementoCobForn.Text = "";
            TxtCepCobForn.Text = "";
            TxtBairroCobForn.Text = "";
            TxtCidadeCobForn.Text = "";
            TxtUfCobForn.Text = "";
            TxtObservacaoForn.Text = "";
            DtCadastroForn.Text = "";

            TxtCnpjCpfForn.Select();////onde o cursor fica inicializada depois de incluir
        }

        private void BtnCancelarForn_Click(object sender, EventArgs e)
        {
            limpar();
        }

        /*
private void BtnSalvarForn_Click(object sender, EventArgs e)
{
   {//verifica se todos os campos estao preenchidos
       if (TxtCnpjCpfForn.Text == "" || TxtNomeForn.Text == "" || TxtRazaoSocialForn.Text == "" || TxtEnderecoForn.Text == "" || TxtNumForn.Text == "" || TxtComplementoForn.Text == "" || TxtCepForn.Text == "" || TxtBairroForn.Text == "" || TxtCidadeForn.Text == "" || TxtUfForn.Text == "" || TxtTelefoneForn.Text == "")
       {
           MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           TxtNomeForn.Select();//colocar curso em login por padrao
       }
       else
       {
           CadastroFornecedores cad = new CadastroFornecedores(TxtCnpjCpfForn.Text, TxtInscEstadualForn.Text, TxtOutrasInscForn.Text, TxtNomeForn.Text, TxtRazaoSocialForn.Text, TxtEnderecoForn.Text, TxtNumForn.Text, TxtComplementoForn.Text, TxtCepForn.Text, TxtBairroForn.Text, TxtCidadeForn.Text, TxtUfForn.Text, TxtTelefoneForn.Text, TxtCelularForn.Text, TxtEmailForn.Text, TxtSiteForn.Text, TxtEnderecoCobForn.Text, TxtNumCobForn.Text, TxtComplementoCobForn.Text, TxtCepCobForn.Text, TxtBairroCobForn.Text, TxtCidadeCobForn.Text, TxtUfCobForn.Text, TxtObservacaoForn.Text, TxtDtCadastroForn.Text);
           MessageBox.Show(cad.mensagem);
           TxtCnpjCpfForn.Text = "";//limpa os textbox depois verificados
           TxtInscEstadualForn.Text = "";
           TxtOutrasInscForn.Text = "";
           TxtNomeForn.Text = "";
           TxtRazaoSocialForn.Text = "";
           TxtEnderecoForn.Text = "";
           TxtNumForn.Text = "";
           TxtComplementoForn.Text = "";
           TxtCepForn.Text = "";
           TxtBairroForn.Text = "";
           TxtCidadeForn.Text = "";
           TxtUfForn.Text = "";
           TxtTelefoneForn.Text = "";
           TxtCelularForn.Text = "";
           TxtEmailForn.Text = "";
           TxtSiteForn.Text = "";
           TxtEnderecoCobForn.Text = "";
           TxtNumCobForn.Text = "";
           TxtComplementoCobForn.Text = "";
           TxtCepCobForn.Text = "";
           TxtBairroCobForn.Text = "";
           TxtCidadeCobForn.Text = "";
           TxtUfCobForn.Text = "";
           TxtObservacaoForn.Text = "";
           TxtDtCadastroForn.Text = "";

           TxtCnpjCpfForn.Select();////onde o cursor fica inicializada depois de incluir
       }
   }
}*/
    }
}
