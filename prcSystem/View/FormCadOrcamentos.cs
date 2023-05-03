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
    public partial class FormCadOrcamentos : Form
    {
        Pessoa pessoa = new Pessoa();
        Produtos produtos = new Produtos();
        Cdc cdc = new Cdc();

        public FormCadOrcamentos()
        {
            InitializeComponent();
            ListarCliForn();
        }

        private void FormCadOrcamentos_Load(object sender, EventArgs e)
        {

        }

        private void TxtIdCliForn_Click(object sender, EventArgs e)
        {
            AjustarDataGridAumentar();
            OcutarFormularioOrcamento();
        }

        public void AjustarDataGridAumentar()
        {
            DgExibirCliFornOrcamentos.Visible = true;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Width = 910;
            DgExibirCliFornOrcamentos.Location = new Point(14, 151);
        }

        public void AjustarDataGridDiminuir()
        {
            DgExibirCliFornOrcamentos.Visible = false;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Location = new Point(11, 260);
        }

        public void OcutarFormularioOrcamento() 
        {
            LblIdCodCliForn.Visible = false;
            idPessoa.Visible = false;
            lblStatusOrcamento.Visible = false;
            cbStatusOrcamento.Visible = false;
            lblDtLancOrcamento.Visible = false;
            dtLancOrcamento.Visible = false;
            lblNumOrcamento.Visible = false;
            txtNumOrcamento.Visible = true;

            txtCnpjCpf.Visible = false;
            txtRazaoNome.Visible = false;
            txtRazaoSocial.Visible = false;
            txtInscEstadual.Visible = false;
            lblOutrasInsc.Visible = false;
            txtOutrasInsc.Visible = false;
            txtEndereco.Visible = false;
            txtComplemento.Visible = false;
            txtBairro.Visible = false;
            txtNum.Visible = false;
            txtCep.Visible = false;
            txtCidade.Visible = false;
            txtUf.Visible = false;

            txtLinha06.Visible = false;

            lblTelefone.Visible = false;
            txtTelefone.Visible = false;
            txtEmail.Visible = false;
            txtSite.Visible = false;
            txtLinha07.Visible = false;
            lblSolicitante.Visible = false;
            txtSolicitante.Visible = false;
            lblVendedor.Visible = false;

            txtLinha08.Visible = false;

            lblFormaPgto.Visible = false;
            txtFormaPgto.Visible = false;
            lblPrazoPgto.Visible = false;
            txtPrazoPgto.Visible = false;

            txtLinha09.Visible = false;

            lblProzoEntrega.Visible = false;
            txtPrazoEntrega.Visible = false;
            lblValidadeOrcamento.Visible = false;
            txtValidadeOrcamento.Visible = false;

            txtLinha10.Visible = false;

            lblListaProdutos.Visible = false;
            lblItem.Visible = false;
            txtItem01.Visible = false;
            txtItem02.Visible = false;
            txtItem03.Visible = false;
            txtItem04.Visible = false;
            txtItem05.Visible = false;
            txtItem06.Visible = false;
            txtItem07.Visible = false;
            txtItem08.Visible = false;
            txtItem09.Visible = false;
            txtItem10.Visible = false;

            lblCodProd.Visible = false;
            txtCodProd01.Visible = false;
            txtCodProd02.Visible = false;
            txtCodProd03.Visible = false;
            txtCodProd04.Visible = false;
            txtCodProd05.Visible = false;
            txtCodProd06.Visible = false;
            txtCodProd07.Visible = false;
            txtCodProd08.Visible = false;
            txtCodProd09.Visible = false;
            txtCodProd10.Visible = false;

            txtDescProduto01.Visible = false;
            txtDescProduto02.Visible = false;
            txtDescProduto03.Visible = false;
            txtDescProduto04.Visible = false;
            txtDescProduto05.Visible = false;
            txtDescProduto06.Visible = false;
            txtDescProduto07.Visible = false;
            txtDescProduto08.Visible = false;
            txtDescProduto09.Visible = false;
            txtDescProduto10.Visible = false;

            txtQte01.Visible = false;
            txtQte02.Visible = false;
            txtQte03.Visible = false;
            txtQte04.Visible = false;
            txtQte05.Visible = false;
            txtQte06.Visible = false;
            txtQte07.Visible = false;
            txtQte08.Visible = false;
            txtQte09.Visible = false;
            txtQte10.Visible = false;

            lblValorUnProd.Visible = false;
            txtValorUnProd01.Visible = false;
            txtValorUnProd02.Visible = false;
            txtValorUnProd03.Visible = false;
            txtValorUnProd04.Visible = false;
            txtValorUnProd05.Visible = false;
            txtValorUnProd06.Visible = false;
            txtValorUnProd07.Visible = false;
            txtValorUnProd08.Visible = false;
            txtValorUnProd09.Visible = false;
            txtValorUnProd10.Visible = false;

            lblTotalItem.Visible = false; 
            txtTotalItem01.Visible = false;
            txtTotalItem02.Visible = false;
            txtTotalItem03.Visible = false;
            txtTotalItem04.Visible = false;
            txtTotalItem05.Visible = false;
            txtTotalItem06.Visible = false;
            txtTotalItem07.Visible = false;
            txtTotalItem08.Visible = false;
            txtTotalItem09.Visible = false;
            txtTotalItem10.Visible = false;

            lblObservacao.Visible = false;
            txtObservacao.Visible = false;

            lblValorTotalOrcamento.Visible = false;
            lblValorTT.Visible = false;
        }

        /// <summary>
        /// metodo de listas os CLientes/FOrnecedores cadastrado no DB para o datagrid do botao de pesquisar o fornecedor/cliente
        /// </summary>
        private void ListarCliForn()
        {
            try
            {
                List<Pessoa> lista = new List<Pessoa>();//datagrid
                lista = new PessoaModel().Listar();
                //dg.AutoGenerateColumns = false;

                DgExibirCliFornOrcamentos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                DgExibirCliFornOrcamentos.Columns[0].HeaderText = "Cod. Forn/Cli.";//determinaar o nome da coluna
                DgExibirCliFornOrcamentos.Columns[1].Visible = false;//HeaderText = "Tipo";
                DgExibirCliFornOrcamentos.Columns[2].Visible = false;//Visible= false;HeaderText = "Pessoa";
                DgExibirCliFornOrcamentos.Columns[3].HeaderText = "Cnpj/Cpf";
                DgExibirCliFornOrcamentos.Columns[4].HeaderText = "Razão/Nome.";
                DgExibirCliFornOrcamentos.Columns[5].HeaderText = "Fantasia";
                DgExibirCliFornOrcamentos.Columns[6].HeaderText = "IE";
                DgExibirCliFornOrcamentos.Columns[7].HeaderText = "Outras Insc.";
                DgExibirCliFornOrcamentos.Columns[8].HeaderText = "End.";
                DgExibirCliFornOrcamentos.Columns[9].HeaderText = "Comple.";
                DgExibirCliFornOrcamentos.Columns[10].HeaderText = "Num.";
                DgExibirCliFornOrcamentos.Columns[11].HeaderText = "Comple.";
                DgExibirCliFornOrcamentos.Columns[12].HeaderText = "Cep";
                DgExibirCliFornOrcamentos.Columns[13].HeaderText = "Bairro";
                DgExibirCliFornOrcamentos.Columns[14].HeaderText = "Cidade";
                DgExibirCliFornOrcamentos.Columns[15].HeaderText = "UF";
                DgExibirCliFornOrcamentos.Columns[16].HeaderText = "Telefone";
                DgExibirCliFornOrcamentos.Columns[17].HeaderText = "Celular.";
                DgExibirCliFornOrcamentos.Columns[18].HeaderText = "Email";
                DgExibirCliFornOrcamentos.Columns[19].HeaderText = "Site";
                DgExibirCliFornOrcamentos.Columns[20].HeaderText = "End Cob.";
                DgExibirCliFornOrcamentos.Columns[21].HeaderText = "Num Cob.";
                DgExibirCliFornOrcamentos.Columns[22].HeaderText = "Compl Cob.";
                DgExibirCliFornOrcamentos.Columns[23].HeaderText = "Cep Cob";
                DgExibirCliFornOrcamentos.Columns[24].HeaderText = "Bairro Cob.";
                DgExibirCliFornOrcamentos.Columns[25].HeaderText = "Cidade Cob.";
                DgExibirCliFornOrcamentos.Columns[26].HeaderText = "UF Cob";
                DgExibirCliFornOrcamentos.Columns[26].HeaderText = "Observação";
                DgExibirCliFornOrcamentos.Columns[26].HeaderText = "DT Cad.";

                DgExibirCliFornOrcamentos.Columns[0].Width = 60;//determinar a largura das colunas
                DgExibirCliFornOrcamentos.Columns[3].Width = 130;
                DgExibirCliFornOrcamentos.Columns[6].Width = 100;
                DgExibirCliFornOrcamentos.Columns[7].Width = 110;
                DgExibirCliFornOrcamentos.Columns[4].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL LISTAR OS DADOS. CHAME O SUPORTE PARA VERIFICAR O ERRO." + ex);
            }
        }


        private void DgExibirCliFornOrcamentos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
