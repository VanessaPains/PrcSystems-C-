using prcSystem.Entidades;
using prcSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            ListarProdutos();
            
        }

        private void TxtIdCliForn_Click(object sender, EventArgs e)
        {
            AjustarDataGridCliFornAumentar();
            OcultarFormularioOrcamento();
            dgExibirOrcamentos.Visible = false;
            btnPesquisarProd.Visible = false;
        }

        public void AjustarDataGridCliFornAumentar()
        {
            DgExibirCliFornOrcamentos.Visible = true;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Width = 910;
            DgExibirCliFornOrcamentos.Location = new Point(14, 151);
        }

        public void AjustarDataGridCliFornDiminuir()
        {
            DgExibirCliFornOrcamentos.Visible = false;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Location = new Point(11, 260);
        }


        public void AjustarDataGridProdutosAumentar()
        {
            dgExibirProdutosOrcamentos.Visible = true;
            dgExibirProdutosOrcamentos.Height = 350;
            dgExibirProdutosOrcamentos.Width = 910;
            dgExibirProdutosOrcamentos.Location = new Point(14, 151);
        }

        public void AjustarDataGridProdutosDiminuir()
        {
            dgExibirProdutosOrcamentos.Visible = false;
            dgExibirProdutosOrcamentos.Height = 350;
            dgExibirProdutosOrcamentos.Location = new Point(11, 260);
        }


        public void OcultarFormularioOrcamento() 
        {
            LblIdCodCliForn.Visible = false;
            idPessoa.Visible = false;
            lblStatusOrcamento.Visible = false;
            cbStatusOrcamento.Visible = false;
            lblDtLancOrcamento.Visible = false;
            dtLancOrcamento.Visible = false;
            lblNumOrcamento.Visible = false;
            txtNumOrcamento.Visible = false;

            txtCnpjCpf.Visible = false;
            txtRazaoNome.Visible = false;
            txtFantasia.Visible = false;
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
 
            lblObservacao.Visible = false;
            txtObservacao.Visible = false;

            lblValorTotalOrcamento.Visible = false;
            txtValorTT.Visible = false;
        }

        public void DesocultarFormularioOrcamento()
        {
            LblIdCodCliForn.Visible = true;
            idPessoa.Visible = true;
            lblStatusOrcamento.Visible = true;
            cbStatusOrcamento.Visible = true;
            lblDtLancOrcamento.Visible = true;
            dtLancOrcamento.Visible = true;
            lblNumOrcamento.Visible = true;
            txtNumOrcamento.Visible = true;

            txtCnpjCpf.Visible = true;
            txtRazaoNome.Visible = true;
            txtFantasia.Visible = true;
            txtInscEstadual.Visible = true;
            lblOutrasInsc.Visible = true;
            txtOutrasInsc.Visible = true;
            txtEndereco.Visible = true;
            txtComplemento.Visible = true;
            txtBairro.Visible = true;
            txtNum.Visible = true;
            txtCep.Visible = true;
            txtCidade.Visible = true;
            txtUf.Visible = true;

            txtLinha06.Visible = true;

            lblTelefone.Visible = true;
            txtTelefone.Visible = true;
            txtEmail.Visible = true;
            txtSite.Visible = true;
            txtLinha07.Visible = true;
            lblSolicitante.Visible = true;
            txtSolicitante.Visible = true;
            lblVendedor.Visible = true;

            txtLinha08.Visible = true;

            lblFormaPgto.Visible = true;
            txtFormaPgto.Visible = true;
            lblPrazoPgto.Visible = true;
            txtPrazoPgto.Visible = true;

            txtLinha09.Visible = true;

            lblProzoEntrega.Visible = true;
            txtPrazoEntrega.Visible = true;
            lblValidadeOrcamento.Visible = true;
            txtValidadeOrcamento.Visible = true;

            txtLinha10.Visible = true;

            lblObservacao.Visible = true;
            txtObservacao.Visible = true;

            lblValorTotalOrcamento.Visible = true;
            txtValorTT.Visible = true;
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
                DgExibirCliFornOrcamentos.Columns[1].HeaderText = "Tipo";
                DgExibirCliFornOrcamentos.Columns[2].HeaderText = "Pessoa";
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

        private void ListarProdutos()
        {
            try
            {
                List<Produtos> lista = new List<Produtos>();//datagrid
                lista = new ProdutoModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgExibirProdutosOrcamentos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                dgExibirProdutosOrcamentos.Columns[0].HeaderText = "Cod.";
                dgExibirProdutosOrcamentos.Columns[1].HeaderText = "Descrição";
                dgExibirProdutosOrcamentos.Columns[2].HeaderText = "Marca";
                dgExibirProdutosOrcamentos.Columns[3].HeaderText = "Unidade";
                dgExibirProdutosOrcamentos.Columns[4].HeaderText = "Valor";
                dgExibirProdutosOrcamentos.Columns[5].HeaderText = "Data";

                dgExibirProdutosOrcamentos.Columns[0].Width = 60;//determinar a largura das colunas
                dgExibirProdutosOrcamentos.Columns[1].Width = 367;
                dgExibirProdutosOrcamentos.Columns[2].Width = 150;
                dgExibirProdutosOrcamentos.Columns[3].Width = 70;
                dgExibirProdutosOrcamentos.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL LISTAR OS DADOS. " + ex);
            }
        }

        /// <summary>
        /// metodo para puxar dados do datagrid dos clientes/fornecedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgExibirCliFornOrcamentos_Click(object sender, EventArgs e)
        {
            DesocultarFormularioOrcamento();
            AjustarDataGridCliFornDiminuir();
            dgExibirOrcamentos.Visible = true;


            idPessoa.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[0].Value.ToString();
            txtCnpjCpf.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[3].Value.ToString();
            txtRazaoNome.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[4].Value.ToString();
            txtFantasia.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[5].Value.ToString();
            txtInscEstadual.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[6].Value.ToString();
            txtOutrasInsc.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[8].Value.ToString();
            txtNum.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[10].Value.ToString();
            txtCep.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[11].Value.ToString();
            txtBairro.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[12].Value.ToString();
            txtCidade.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[13].Value.ToString();
            txtUf.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[14].Value.ToString();
            txtTelefone.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[15].Value.ToString();
            txtCelular.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[16].Value.ToString();
            txtEmail.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[17].Value.ToString();
            txtSite.Text = DgExibirCliFornOrcamentos.CurrentRow.Cells[18].Value.ToString();

            dgExibirOrcamentos.Visible = true;
            btnPesquisarProd.Visible = true;
        }


        /// <summary>
        /// metodo para puxar dados do datagrid dos produtos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            AjustarDataGridProdutosAumentar();
            OcultarFormularioOrcamento();
            dgExibirOrcamentos.Visible = false;
            btnPesquisarProd.Visible = false;   
            
        }


        private DataGridViewRow Adicionar(DataGridViewRow row)
        {
            DataGridViewRow newRow = (DataGridViewRow)row.Clone();
            newRow.Cells[0].Value = row.Cells[0].Value.ToString(); 
            newRow.Cells[1].Value = row.Cells[1].Value.ToString(); 
            newRow.Cells[2].Value = row.Cells[2].Value.ToString(); 
            newRow.Cells[3].Value = row.Cells[3].Value.ToString(); 
            newRow.Cells[4].Value = row.Cells[4].Value.ToString(); 
            newRow.Cells[5].Value = row.Cells[5].Value.ToString();
            //newRow.Cells.Remove(newRow.Cells[0]);
            return newRow;
        }

        private void dgExibirProdutosOrcamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DesocultarFormularioOrcamento();
            AjustarDataGridProdutosDiminuir();
            //dgExibirProdutosOrcamentos.Refresh();

            foreach (DataGridViewRow selectedRow in dgExibirProdutosOrcamentos.SelectedRows)
            {
                dgExibirOrcamentos.ColumnCount = 8;
                dgExibirOrcamentos.Columns[0].HeaderText = "Cod.";
                dgExibirOrcamentos.Columns[1].HeaderText = "Descrição";
                dgExibirOrcamentos.Columns[2].HeaderText = "Marca";
                dgExibirOrcamentos.Columns[3].HeaderText = "Unidade";
                dgExibirOrcamentos.Columns[4].HeaderText = "Valor";
                dgExibirOrcamentos.Columns[5].HeaderText = "Data";
                dgExibirOrcamentos.Columns[6].HeaderText = "Qte";
                dgExibirOrcamentos.Columns[7].HeaderText = "Vr Total";
                dgExibirOrcamentos.Rows.Add(Adicionar(selectedRow));

                dgExibirOrcamentos.Columns[2].Visible = false;//colunas datagrid
                dgExibirOrcamentos.Columns[5].Visible = false;//colunas datagrid
               
                dgExibirOrcamentos.Columns[0].Width = 60;//determinar a largura das colunas
                dgExibirOrcamentos.Columns[1].Width = 450;
                dgExibirOrcamentos.Columns[3].Width = 70;
                dgExibirOrcamentos.Columns[4].Width = 120;
                dgExibirOrcamentos.Columns[6].Width = 60;
                dgExibirOrcamentos.Columns[7].Width = 100;

                //dgExibirOrcamentos.Rows.Clear();
                //dgExibirOrcamentos.Refresh();
                dgExibirOrcamentos.Visible = true;
                btnPesquisarProd.Visible = true;          
            }
        }

        /// <summary>
        /// metodo para fazer o calculo entre a quantidade e valor e jogar no campo valor total de produto. 
        /// faz tambem a soma total do orçamento.
        /// </summary>
        private void SomaLinhaProtutos()
        {
            try
            {
                decimal cell1 = Convert.ToDecimal(dgExibirOrcamentos.CurrentRow.Cells[4].Value);
                decimal cell2 = Convert.ToDecimal(dgExibirOrcamentos.CurrentRow.Cells[6].Value);
                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    dgExibirOrcamentos.CurrentRow.Cells[7].Value = cell1 * cell2;
                }
                
                decimal valorTotal = 0;//valor se inicia com 0.
                string valor = "";//string valor se inicia vazia.
                if (dgExibirOrcamentos.CurrentRow.Cells[7].Value != null)
                {
                    valor = dgExibirOrcamentos.CurrentRow.Cells[7].Value.ToString();
                    if (!valor.Equals(""))
                    {
                        for (int i = 0; i <= dgExibirOrcamentos.RowCount - 1; i++)
                        {
                            if (dgExibirOrcamentos.Rows[i].Cells[7].Value != null)
                                valorTotal += Convert.ToDecimal(dgExibirOrcamentos.Rows[i].Cells[7].Value);
                        }
                        txtValorTT.Text = valorTotal.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgExibirOrcamentos_Enter(object sender, EventArgs e)
        {
            dgExibirOrcamentos.ReadOnly = false;
            dgExibirOrcamentos.Columns[6].ReadOnly = true;

            foreach (DataGridViewColumn dc in dgExibirOrcamentos.Columns)
            {
                if (dc.Index.Equals(6))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
            SomaLinhaProtutos();          
        }

        private void dgExibirOrcamentos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SomaLinhaProtutos();
        }
    }
}
