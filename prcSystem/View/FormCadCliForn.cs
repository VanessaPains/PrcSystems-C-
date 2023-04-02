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
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Globalization;

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

                obj.CnpjCpf = Convert.ToString(TxtCnpjCpf.Text);
                obj.RazaoNome = Convert.ToString(TxtRazaoNome.Text);
                obj.Fantasia = Convert.ToString(TxtFantasia.Text);
                obj.InscEstadual = Convert.ToString(TxtInscEstadual.Text);
                obj.OutrasInsc = Convert.ToString(TxtOutrasInsc.Text);

                obj.Endereco = Convert.ToString(TxtEndereco.Text);
                obj.Num = Convert.ToString(TxtNum.Text);
                obj.Complemento = Convert.ToString(TxtComplemento.Text);
                obj.Cep = Convert.ToString(TxtCep.Text);
                obj.Bairro = Convert.ToString(TxtBairro.Text);
                obj.Cidade = Convert.ToString(TxtCidade.Text);
                obj.Uf = Convert.ToString(TxtUf.Text);

                obj.Telefone = Convert.ToString(TxtTelefone.Text);
                obj.Celular = Convert.ToString(TxtCelular.Text);
                obj.Email = Convert.ToString(TxtEmail.Text);
                obj.Site = Convert.ToString(TxtSite.Text);

                obj.EnderecoCob = Convert.ToString(TxtEnderecoCob.Text);
                obj.NumCob = Convert.ToString(TxtNumCob.Text);
                obj.ComplementoCob = Convert.ToString(TxtComplementoCob.Text);
                obj.CepCob = Convert.ToString(TxtCepCob.Text);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA MESMO EDITAR O CADASTRO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                editar();
                limpar();
            }
        }

        /// <summary>
        /// editar formulario
        /// </summary>
        private void editar()
        {
            try
            {
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

                obj.IdPessoa = Convert.ToInt32(TxtIdPessoa.Text);
                obj.CnpjCpf = Convert.ToString(TxtCnpjCpf.Text);
                obj.RazaoNome = Convert.ToString(TxtRazaoNome.Text);
                obj.Fantasia = Convert.ToString(TxtFantasia.Text);
                obj.InscEstadual = Convert.ToString(TxtInscEstadual.Text);
                obj.OutrasInsc = Convert.ToString(TxtOutrasInsc.Text);

                obj.Endereco = Convert.ToString(TxtEndereco.Text);
                obj.Num = Convert.ToString(TxtNum.Text);
                obj.Complemento = Convert.ToString(TxtComplemento.Text);
                obj.Cep = Convert.ToString(TxtCep.Text);
                obj.Bairro = Convert.ToString(TxtBairro.Text);
                obj.Cidade = Convert.ToString(TxtCidade.Text);
                obj.Uf = Convert.ToString(TxtUf.Text);

                obj.Telefone = Convert.ToString(TxtTelefone.Text);
                obj.Celular = Convert.ToString(TxtCelular.Text);
                obj.Email = Convert.ToString(TxtEmail.Text);
                obj.Site = Convert.ToString(TxtSite.Text);

                obj.EnderecoCob = Convert.ToString(TxtEnderecoCob.Text);
                obj.NumCob = Convert.ToString(TxtNumCob.Text);
                obj.ComplementoCob = Convert.ToString(TxtComplementoCob.Text);
                obj.CepCob = Convert.ToString(TxtCepCob.Text);
                obj.BairroCob = Convert.ToString(TxtBairroCob.Text);
                obj.CidadeCob = Convert.ToString(TxtCidadeCob.Text);
                obj.UfCob = Convert.ToString(TxtUfCob.Text);

                obj.Observacao = Convert.ToString(TxtObservacao.Text);
                obj.DtCadPessoa = Convert.ToDateTime(DtCadPessoa.Text);

                int x = PessoaModel.Editar(obj);

                if (x > 0)
                {
                    MessageBox.Show("CADASTRO EDITADO COM SUCESSO.");
                }
                else         
                {
                    MessageBox.Show("ERRO AO EDITAR CADASTRO." + ErrorEventArgs.Equals);
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EDITAR CADASTRO." + ex);
            }
        }

        /// <summary>
        /// metodo de listar os fornecedores e clientes listados
        /// </summary>
        private void Listar()
        {
            try
            {
                List<Pessoa> lista = new List<Pessoa>();//datagrid
                lista = new PessoaModel().Listar();
                //dg.AutoGenerateColumns = false;

                DgExibirCliForn.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                DgExibirCliForn.Columns[0].HeaderText = "Cod. Forn/Cli.";
                DgExibirCliForn.Columns[1].HeaderText = "Tipo";
                DgExibirCliForn.Columns[2].HeaderText = "Pessoa";
                DgExibirCliForn.Columns[3].HeaderText = "Cnpj/Cpf";
                DgExibirCliForn.Columns[4].HeaderText = "Razão/Nome.";
                DgExibirCliForn.Columns[5].HeaderText = "Fantasia";
                DgExibirCliForn.Columns[6].HeaderText = "IE";
                DgExibirCliForn.Columns[7].HeaderText = "Outras Insc.";
                DgExibirCliForn.Columns[8].HeaderText = "End.";
                DgExibirCliForn.Columns[9].HeaderText = "Num.";
                DgExibirCliForn.Columns[10].HeaderText = "Comple.";
                DgExibirCliForn.Columns[11].HeaderText = "Cep";
                DgExibirCliForn.Columns[12].HeaderText = "Bairro";
                DgExibirCliForn.Columns[13].HeaderText = "Cidade";
                DgExibirCliForn.Columns[14].HeaderText = "UF";
                DgExibirCliForn.Columns[15].HeaderText = "Telefone";
                DgExibirCliForn.Columns[16].HeaderText = "Celular.";
                DgExibirCliForn.Columns[17].HeaderText = "Email";
                DgExibirCliForn.Columns[18].HeaderText = "Site";
                DgExibirCliForn.Columns[19].HeaderText = "End Cob.";
                DgExibirCliForn.Columns[20].HeaderText = "Num Cob.";
                DgExibirCliForn.Columns[21].HeaderText = "Compl Cob.";
                DgExibirCliForn.Columns[22].HeaderText = "Cep Cob";
                DgExibirCliForn.Columns[23].HeaderText = "Bairro Cob.";
                DgExibirCliForn.Columns[24].HeaderText = "Cidade Cob.";
                DgExibirCliForn.Columns[25].HeaderText = "UF Cob";
                DgExibirCliForn.Columns[26].HeaderText = "Observação";
                DgExibirCliForn.Columns[27].HeaderText = "DT Cad.";

                DgExibirCliForn.Columns[0].Width = 60;//determinar a largura das colunas
                DgExibirCliForn.Columns[4].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
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

            BtnSalvar.Visible = true;
            btnEditar.Visible = false;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtCnpjCpf.Text == "" || TxtRazaoNome.Text == "" || TxtFantasia.Text == "" || TxtEndereco.Text == "" || TxtNum.Text == "" || TxtCep.Text == "" || TxtBairro.Text == "" || TxtCidade.Text == "" || TxtUf.Text == "" || TxtTelefone.Text == "")
            {
                MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtRazaoNome.Select();//colocar curso em login por padrao
                return;
            }
            else
            {
                if(MessageBox.Show("DESEJA MESMO SALVAR O CADASTRO?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                else{ 
                    salvar();
                    limpar();
                }
            }
        }

        /// <summary>
        /// metodo de aumentar tamanho datagrid e desabilitar os formularios
        /// </summary>
        public void AjustarDataGridAumentar()
        {
            DgExibirCliForn.Visible = true;
            DgExibirCliForn.Height = 370;
            DgExibirCliForn.Location = new Point(12, 151);
        }

        public void desabilitarFormularioCliForn()
        {
            picBoxLogo.Visible = false;
            gpBox1.Visible = false;
            gpBox2.Visible = false;
            rbCliente.Visible = false;
            rbFornecedor.Visible = false;   
            rbAmbos.Visible = false;
            rbPessoaFis.Visible = false;
            rbPessoaJur.Visible = false;
            LblDtCadastroCli.Visible = false;
            DtCadPessoa.Visible = false;
            textBox2.Visible = false;

        }

        public void habilitarFormularioCliForn()
        {
            picBoxLogo.Visible = true;
            gpBox1.Visible = true;
            gpBox2.Visible = true;
            rbCliente.Visible = true;
            rbFornecedor.Visible = true;
            rbAmbos.Visible = true;
            rbPessoaFis.Visible = true;
            rbPessoaJur.Visible = true;
            LblDtCadastroCli.Visible = true;
            DtCadPessoa.Visible = true;
            textBox2.Visible = true;

        }

        private void btnPesquisarEditar_Click(object sender, EventArgs e)
        {
            Listar();
            LblPesquisarCliForn.Visible = true;
            TxtPesquisaCodCliForn.Visible = true;
            TxtPesquisarNomeRazaoCpfCnpj.Visible = true;
            BtnPesquisarRazaoNomeCliForn.Visible = true;
            BtnPesquisarCliForn.Visible = true;

            AjustarDataGridAumentar();
            desabilitarFormularioCliForn();
        }

        private void DgExibirCliForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarFormularioCliForn();
            DgExibirCliForn.Visible = false;
            LblPesquisarCliForn.Visible = false;
            TxtPesquisaCodCliForn.Visible = false;
            TxtPesquisarNomeRazaoCpfCnpj.Visible = false;
            BtnPesquisarRazaoNomeCliForn.Visible = false;
            BtnPesquisarCliForn.Visible = false;
            BtnSalvar.Visible = false;
            btnEditar.Visible = true;

            string rbCliFornAmb = DgExibirCliForn.CurrentRow.Cells[1].Value.ToString();
            string rbPessJurFis = DgExibirCliForn.CurrentRow.Cells[2].Value.ToString();

            if (rbCliFornAmb == "FORNECEDOR")
            {
                rbFornecedor.Checked = true;
            }
            else if (rbCliFornAmb == "CLIENTE")
            {
                rbCliente.Checked =  true;
            }
            else if (rbCliFornAmb == "AMBOS")
            {
                rbAmbos.Checked = true;
            }
            
            if (rbPessJurFis == "PESSOA FISICA")
            {
                rbPessoaFis.Checked = true;
            }
            else if (rbPessJurFis == "PESSOA JURIDICA")
            {
                rbPessoaJur.Checked = true;
            }

            TxtIdPessoa.Text = DgExibirCliForn.CurrentRow.Cells[0].Value.ToString();
            TxtCnpjCpf.Text = DgExibirCliForn.CurrentRow.Cells[3].Value.ToString();
            TxtRazaoNome.Text = DgExibirCliForn.CurrentRow.Cells[4].Value.ToString();
            TxtFantasia.Text = DgExibirCliForn.CurrentRow.Cells[5].Value.ToString();
            TxtInscEstadual.Text = DgExibirCliForn.CurrentRow.Cells[6].Value.ToString();
            TxtOutrasInsc.Text = DgExibirCliForn.CurrentRow.Cells[7].Value.ToString();
            TxtEndereco.Text = DgExibirCliForn.CurrentRow.Cells[8].Value.ToString();
            TxtNum.Text = DgExibirCliForn.CurrentRow.Cells[9].Value.ToString();
            TxtComplemento.Text = DgExibirCliForn.CurrentRow.Cells[10].Value.ToString();
            TxtCep.Text = DgExibirCliForn.CurrentRow.Cells[11].Value.ToString();
            TxtBairro.Text = DgExibirCliForn.CurrentRow.Cells[12].Value.ToString();
            TxtCidade.Text = DgExibirCliForn.CurrentRow.Cells[13].Value.ToString();
            TxtUf.Text = DgExibirCliForn.CurrentRow.Cells[14].Value.ToString();
            TxtTelefone.Text = DgExibirCliForn.CurrentRow.Cells[15].Value.ToString();
            TxtCelular.Text = DgExibirCliForn.CurrentRow.Cells[16].Value.ToString();
            TxtEmail.Text = DgExibirCliForn.CurrentRow.Cells[17].Value.ToString();
            TxtSite.Text = DgExibirCliForn.CurrentRow.Cells[18].Value.ToString();
            TxtEnderecoCob.Text = DgExibirCliForn.CurrentRow.Cells[19].Value.ToString();
            TxtNumCob.Text = DgExibirCliForn.CurrentRow.Cells[20].Value.ToString();
            TxtComplementoCob.Text = DgExibirCliForn.CurrentRow.Cells[21].Value.ToString();
            TxtCepCob.Text = DgExibirCliForn.CurrentRow.Cells[22].Value.ToString();
            TxtBairroCob.Text = DgExibirCliForn.CurrentRow.Cells[23].Value.ToString();
            TxtCidadeCob.Text = DgExibirCliForn.CurrentRow.Cells[24].Value.ToString();
            TxtUfCob.Text = DgExibirCliForn.CurrentRow.Cells[25].Value.ToString();
            TxtObservacao.Text = DgExibirCliForn.CurrentRow.Cells[26].Value.ToString();
            DtCadPessoa.Text = DgExibirCliForn.CurrentRow.Cells[27].Value.ToString();
        }

        private string TitleCase(string text)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(text);
        }
        private void FormataUpper(object sender, EventArgs e)
        {
            TxtRazaoNome.Text = TitleCase(TxtRazaoNome.Text);
        }

    }
}
