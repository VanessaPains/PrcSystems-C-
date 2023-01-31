using prcSystem.Entidades;
using prcSystem.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prcSystem.Functions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace prcSystem.View
{
    public partial class FormCadCliForn : Form
    {
        Pessoa obj = new Pessoa();

        public FormCadCliForn()
        {
            InitializeComponent();
            DtCadPessoa.Value = DateTime.Now;
        }

        private void FormCadCliForn_Load(object sender, EventArgs e)
        {

        }


  
        /// <summary>
        /// função Clientes de salvar dados do formulario na tabela de clientes
        /// </summary>
        private void salvar()
        {            
            try
            {
                //System.Windows.Forms.RadioButton rb = null;

                if (rbFornecedor.Checked == true)
                {
                    obj.TipoCadastro = Convert.ToString(rbFornecedor.Text = "FORNECEDOR");
                }
                else if (rbCliente.Checked == true)
                {
                    obj.TipoCadastro = Convert.ToString(rbCliente.Text = "CLIENTE");
                }
                else if (rbAmbos.Checked == true)
                {
                    obj.TipoCadastro = Convert.ToString(rbAmbos.Text = "AMBOS");
                }

                if (rbPessoaFis.Checked == true)
                {
                    obj.TipoPessoa = Convert.ToString(rbPessoaFis.Text = "PESSOA FISICA");
                }
                else if (rbPessoaJur.Checked == true)
                {
                    obj.TipoPessoa = Convert.ToString(rbPessoaJur.Text = "PESSOA JURIDICA");
                }

                obj.CnpjCpf = Convert.ToInt32(TxtCnpjCpf.Text);
                obj.RazaoNome = Convert.ToString(TxtRazaoNome.Text);
                obj.Fantasia = Convert.ToString(TxtFantasia.Text);
                obj.InscEstadual = Convert.ToInt32(TxtInscEstadual.Text);
                obj.OutrasInsc = Convert.ToInt32(TxtOutrasInsc.Text);

                obj.Endereco = Convert.ToString(TxtEndereco.Text);
                obj.Num = Convert.ToInt32(TxtNum.Text);
                obj.Complemento = Convert.ToString(TxtComplemento.Text);
                obj.Cep = Convert.ToInt32(TxtCep.Text);
                obj.Bairro = Convert.ToString(TxtBairro.Text);
                obj.Cidade = Convert.ToString(TxtCidade.Text);
                obj.Uf = Convert.ToString(TxtUf.Text);

                obj.Telefone = Convert.ToString(TxtTelefone.Text);
                obj.Celular = Convert.ToString(TxtCelular.Text);
                obj.Email = Convert.ToString(TxtEmail.Text);
                obj.Site = Convert.ToString(TxtSite.Text);

                obj.EnderecoCob = Convert.ToString(TxtEnderecoCob.Text);
                obj.NumCob = Convert.ToInt32(TxtNumCob.Text);
                obj.ComplementoCob = Convert.ToString(TxtComplementoCob.Text);
                obj.CepCob = Convert.ToInt32(TxtCepCob.Text);
                obj.BairroCob = Convert.ToString(TxtBairroCob.Text);
                obj.CidadeCob = Convert.ToString(TxtCidadeCob.Text);
                obj.UfCob = Convert.ToString(TxtUfCob.Text);
                obj.Observacao = Convert.ToString(TxtObservacao.Text);
                obj.DtCadPessoa = Convert.ToDateTime(DtCadPessoa.Text);

                       
                   
              int x = PessoaModel.Inserir(obj);
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
            TxtCnpjCpf.Select();////onde o cursor fica inicializada depois de incluir

            rbFornecedor.Checked = false;
            rbCliente.Checked = false;
            rbAmbos.Checked = false;

            rbPessoaFis.Checked = false;
            rbPessoaJur.Checked = false;

            TxtCnpjCpf.Text = "";
            TxtIdPessoa.Text = "";
            TxtRazaoNome.Text = "";
            TxtFantasia.Text = "";
            TxtInscEstadual.Text = "";
            TxtOutrasInsc.Text = "";
            TxtEndereco.Text = "";
            TxtNum.Text = "";
            TxtComplemento.Text = "";
            TxtCep.Text = "";
            TxtBairro.Text = "";
            TxtCidade.Text = "";
            TxtUf.Text = "";
            TxtEnderecoCob.Text = "";
            TxtNumCob.Text = "";
            TxtComplementoCob.Text = "";
            TxtCepCob.Text = "";
            TxtBairroCob.Text = "";
            TxtCidadeCob.Text = "";
            TxtUfCob.Text = "";
            TxtTelefone.Text = "";
            TxtCelular.Text = "";
            TxtEmail.Text = "";
            TxtSite.Text = "";
            TxtObservacao.Text = "";
            //PicBoxLogo.Image = ""; 

        }

        private void picBoxLogo_DoubleClick(object sender, EventArgs e)
        {
            // abre a caixa de diálogo do arquivo   
            OpenFileDialog aberto = new OpenFileDialog();
            // filtros de imagem  
            aberto.Filter = "Arquivos de imagem(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (aberto.ShowDialog() == DialogResult.OK)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    // exibe a imagem na caixa de imagem
                    picBoxLogo.Image = new Bitmap(aberto.FileName);

                    //obj.Foto = ExternalFunctions.ImageToBase64().
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtCnpjCpf.Text == "" || TxtRazaoNome.Text == "" || TxtFantasia.Text == "" || TxtEndereco.Text == "" || TxtNum.Text == "" || TxtComplemento.Text == "" || TxtCep.Text == "" || TxtBairro.Text == "" || TxtCidade.Text == "" || TxtUf.Text == "" || TxtTelefone.Text == "")
            {
                MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRazaoNome.Select();//colocar curso em login por padrao
                return;
            }
            else
            {
                salvar();
                limpar();
            }
        }
    }
}
