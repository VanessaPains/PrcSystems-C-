using prcSystem.Entidades;
using prcSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadLancEntradasSaidas : Form
    {
        Lancamentos obj = new Lancamentos();
        Pessoa pessoa = new Pessoa();
        Produtos produtos= new Produtos();
        Cdc cdc= new Cdc();

        LancamentoModel modelL = new LancamentoModel(); 
        ProdutoModel modelP = new();
        PessoaModel modelCF = new PessoaModel();

        public FormCadLancEntradasSaidas()
        {
            InitializeComponent();
            ListarCdc();
            ListarCliForn();
            Listar();
            limpar();

            RbHabilitado();
            
            txtIdLancamento.Enabled= false;
            txtPesquisarLancamentos.Visible = false;
            lblPesquisarLancamentos.Visible = false;
        }


        /// <summary>
        /// metodos de habilitar os radio button
        /// </summary>
        public void RbHabilitado()
        {
            rbEntrada.Visible = true;
            rbSaida.Visible = true; 
        }

        /// <summary>
        /// metodos de desabilitar os radio button
        /// </summary>
        public void RbDesabilitado()
        {
            rbEntrada.Visible = false;
            rbSaida.Visible = false;
        }

        /// <summary>
        /// boao de salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalvarLanc_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (rbEntrada.Text == "" || rbSaida.Text == "" || txtCodCliForn.Text == "" || txtIdCdc.Text == "" || txtNumDocumento.Text == "" || dtEmissao.Text == "" || dtVencimento.Text == "" || txtComentarios.Text == "")
            {
                MessageBox.Show("Preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCliForn.Select();//colocar curso no codigo do cliente fornecedor
                return;
            }
            else
            {

                salvar();
                limpar();
                //Listar();

                this.Close();
                FormCadLancEntradasSaidas formCadLancEntradasSaidas = new FormCadLancEntradasSaidas();
                formCadLancEntradasSaidas.ShowDialog();
            }
        }
        /// <summary>
        /// botao de limpar dados
        /// </summary>
        /// <param name="sender">clica no botao de limpar dados</param>
        /// <param name="e">retorna os dados dos formulario em brancao sem dados</param>
        private void BtnLimparLanc_Click(object sender, EventArgs e)
        {
            limpar();
        }

        /// <summary>
        /// botao de editar
        /// </summary>
        /// <param name="sender">clica no botao de editar</param>
        /// <param name="e">e retorno motodo de salvar no banco de dados</param>
        private void BtnEditarLanc_Click(object sender, EventArgs e)
        {
            editar();
            limpar();
            BtnSalvarLanc.Enabled = false;  
        }

        /// <summary>
        /// botao pesquisar
        /// </summary>
        /// <param name="sender">clicar botao</param>
        /// <param name="e">retorna os ajustes do datagrid e ocultação dos formularios e botaos</param>
        private void btnPesquisarlancamentos_Click(object sender, EventArgs e)
        {
            Listar();
            AjustarDataGridAumentar();
            BtnSalvarLanc.Enabled = false;
        }

        /// <summary>
        /// metodo de salvar lançamentos
        /// </summary>
        private void salvar()
        {
            try
            { 
                if (rbEntrada.Checked == true)
                {
                    obj.TipoLancamento = Convert.ToString(rbEntrada.Text = "ENTRADA");
                }
                else if (rbSaida.Checked == true)
                {
                    obj.TipoLancamento = Convert.ToString(rbSaida.Text = "SAIDA");
                }

                obj.IdPessoa = Convert.ToInt32(txtCodCliForn.Text);
                obj.IdCdc = Convert.ToInt32(txtIdCdc.Text);
                obj.NumDocumento = Convert.ToString(txtNumDocumento.Text);
                obj.DtLancamento = Convert.ToDateTime(dtLancamento.Text);
                obj.DtEmissao = Convert.ToDateTime(dtEmissao.Text);
                obj.DtVencimento = Convert.ToDateTime(dtVencimento.Text);
                obj.DtPagamento = Convert.ToDateTime(dtPagamento.Text);
                obj.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                obj.Comentarios = Convert.ToString(txtComentarios.Text);
                obj.Situacao = Convert.ToString(cbSituacaoAbertaPaga.Text);               

                int x = LancamentoModel.Inserir(obj);
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
        /// metodo de listar os lancamento no datagrid
        /// </summary>
        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();//datagrid
                lista = new LancamentoModel().Listar();
                //dg.AutoGenerateColumns = false;

                DgExibirLacamentos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                DgExibirLacamentos.Columns[0].HeaderText = "Cod. Lanç.";
                DgExibirLacamentos.Columns[1].HeaderText = "Tipo Lanç.";
                DgExibirLacamentos.Columns[2].HeaderText = "Cod. Cli/Forn.";
                DgExibirLacamentos.Columns[3].HeaderText = "Razão/Nome ";
                DgExibirLacamentos.Columns[4].HeaderText = "Cod. CDC";
                DgExibirLacamentos.Columns[5].HeaderText = "Desc. CDC";
                DgExibirLacamentos.Columns[6].HeaderText = "Nº Doc.";
                DgExibirLacamentos.Columns[7].HeaderText = "Dt. Lanç.";
                DgExibirLacamentos.Columns[8].HeaderText = "Dt. Emissão";
                DgExibirLacamentos.Columns[9].HeaderText = "Dt. Venc.";
                DgExibirLacamentos.Columns[10].HeaderText = "Dt. Prog. de Pgto.";
                DgExibirLacamentos.Columns[11].HeaderText = "Valor.";
                DgExibirLacamentos.Columns[12].HeaderText = "Comentarios.";
                DgExibirLacamentos.Columns[13].HeaderText = "Situação.";

                DgExibirLacamentos.Columns[0].Width = 90;//determinar a largura das colunas
                DgExibirLacamentos.Columns[1].Width = 70;
                DgExibirLacamentos.Columns[2].Width = 70;
                DgExibirLacamentos.Columns[3].Width = 280;
                DgExibirLacamentos.Columns[4].Width = 60;
                DgExibirLacamentos.Columns[5].Width = 250;
                DgExibirLacamentos.Columns[12].Width = 290;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
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

                DgExibirCliForn.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                DgExibirCliForn.Columns[0].HeaderText = "Cod. Forn/Cli.";//determinaar o nome da coluna
                DgExibirCliForn.Columns[1].Visible = false;//HeaderText = "Tipo";
                DgExibirCliForn.Columns[2].Visible = false;//Visible= false;HeaderText = "Pessoa";
                DgExibirCliForn.Columns[3].HeaderText = "Cnpj/Cpf";
                DgExibirCliForn.Columns[4].HeaderText = "Razão/Nome.";
                DgExibirCliForn.Columns[5].HeaderText = "Fantasia";
                DgExibirCliForn.Columns[6].HeaderText = "IE";
                DgExibirCliForn.Columns[7].HeaderText = "Outras Insc.";
                DgExibirCliForn.Columns[8].HeaderText = "End.";
                DgExibirCliForn.Columns[9].HeaderText = "Comple.";
                DgExibirCliForn.Columns[10].HeaderText = "Num.";
                DgExibirCliForn.Columns[11].HeaderText = "Comple.";
                DgExibirCliForn.Columns[12].HeaderText = "Cep";
                DgExibirCliForn.Columns[13].HeaderText = "Bairro";
                DgExibirCliForn.Columns[14].HeaderText = "Cidade";
                DgExibirCliForn.Columns[15].HeaderText = "UF";
                DgExibirCliForn.Columns[16].HeaderText = "Telefone";
                DgExibirCliForn.Columns[17].HeaderText = "Celular.";
                DgExibirCliForn.Columns[18].HeaderText = "Email";
                DgExibirCliForn.Columns[19].HeaderText = "Site";
                DgExibirCliForn.Columns[20].HeaderText = "End Cob.";
                DgExibirCliForn.Columns[21].HeaderText = "Num Cob.";
                DgExibirCliForn.Columns[22].HeaderText = "Compl Cob.";
                DgExibirCliForn.Columns[23].HeaderText = "Cep Cob";
                DgExibirCliForn.Columns[24].HeaderText = "Bairro Cob.";
                DgExibirCliForn.Columns[25].HeaderText = "Cidade Cob.";
                DgExibirCliForn.Columns[26].HeaderText = "UF Cob";
                DgExibirCliForn.Columns[26].HeaderText = "Observação";
                DgExibirCliForn.Columns[26].HeaderText = "DT Cad.";

                DgExibirCliForn.Columns[0].Width = 60;//determinar a largura das colunas
                DgExibirCliForn.Columns[3].Width = 130;
                DgExibirCliForn.Columns[6].Width = 100;
                DgExibirCliForn.Columns[7].Width = 110;
                DgExibirCliForn.Columns[4].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }
    
        /// <summary>
        /// metodo de listas os CDC cadastrado no DB para o datagrid do botao de pesquisar CDC
        /// </summary>
        private void ListarCdc()
        {
            try
            {
                List<Cdc> lista = new List<Cdc>();//datagrid
                lista = new CdcModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgCadCdc.DataSource = lista;

                dgCadCdc.Columns[0].Visible = false;//HeaderText = "Item";
                dgCadCdc.Columns[1].Visible = false; //HeaderText = "Cod.";
                dgCadCdc.Columns[2].HeaderText = "Descrição";
                dgCadCdc.Columns[3].Visible = false; //HeaderText = "Data";

                dgCadCdc.Columns[2].Width = 865;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void PreencherDesc()
        {
            produtos.DescProduto = Convert.ToString(txtRazaoNome.Text);
            cdc.DescricaoCdc = Convert.ToString(txtDescricaoCdc.Text);
        }

        /// <summary>
        /// editar formulario
        /// </summary>
        private void editar()
        {
            try
            {
                if (rbEntrada.Checked == true)
                {
                    obj.TipoLancamento = Convert.ToString(rbEntrada.Text = "ENTRADA");
                }
                else if (rbSaida.Checked == true)
                {
                    obj.TipoLancamento = Convert.ToString(rbSaida.Text = "SAIDA");
                }

                PreencherDesc();    
                
                obj.IdLancamento = Convert.ToInt32(txtIdLancamento.Text);   
                obj.IdPessoa = Convert.ToInt32(txtCodCliForn.Text);              
                obj.IdCdc = Convert.ToInt32(txtIdCdc.Text);
                obj.NumDocumento = Convert.ToString(txtNumDocumento.Text);
                obj.DtLancamento = Convert.ToDateTime(dtLancamento.Text);
                obj.DtEmissao = Convert.ToDateTime(dtEmissao.Text);
                obj.DtVencimento = Convert.ToDateTime(dtVencimento.Text);
                obj.DtPagamento = Convert.ToDateTime(dtPagamento.Text);
                obj.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                obj.Comentarios = Convert.ToString(txtComentarios.Text);
                obj.Situacao = cbSituacaoAbertaPaga.Text;

                int x = LancamentoModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar." + ex);
            }
        }

        /// <summary>
        /// metodo para limpar os campos dos formuarios de lancamentos
        /// </summary>
        private void limpar()
        {
            txtIdLancamento.Text = "";
            txtCodCliForn.Text = "";
            txtIdCdc.Text = "";
            txtNumDocumento.Text = "";
            dtLancamento.Text = "";
            dtEmissao.Text = "";
            dtVencimento.Text = "";
            dtPagamento.Text = "";
            txtValorTotal.Text = "";
            txtComentarios.Text = "";
            txtDescricaoCdc.Text = "";
            txtRazaoNome.Text = "";
            cbSituacaoAbertaPaga.Text = "";
            txtCodCliForn.Select();////onde o cursor fica inicializada depois de incluir
        }

        /// <summary>
        /// mtodo para reezibir datagrid dos Clientes/Fornecedores
        /// </summary>
        /// <param name="sender">mostrar objeto datagrid</param>
        /// <param name="e">colocar datagrig como vsivel</param>
        private void txtCodCliForn_Click(object sender, EventArgs e)
        {
            DgExibirCliForn.Visible = true;           
        }

        /// <summary>
        /// mtodo para reezibir datagrid dos CDC
        /// </summary>
        /// <param name="sender">mostrar objeto datagrid</param>
        /// <param name="e">colocar datagrig como vsivel</param>
        private void txtIdCdc_Click(object sender, EventArgs e)
        {
            dgCadCdc.Visible = true;          
        }

        /// <summary>
        /// metodo de aumentar tamanho datagrid e desabilitar os formularios  de editar lanacamentos
        /// </summary>
        public void AjustarDataGridAumentar()
        {
            DgExibirLacamentos.Visible = true;
            DgExibirLacamentos.Height = 350;
            DgExibirLacamentos.Location = new Point(12, 151);

            txtIdLancamento.Visible = false;
            txtCodCliForn.Visible = false;
            txtIdCdc.Visible = false;
            txtNumDocumento.Visible = false;
            dtLancamento.Visible = false;
            dtEmissao.Visible = false;
            dtVencimento.Visible = false;
            dtPagamento.Visible = false;
            txtValorTotal.Visible = false;
            txtComentarios.Visible = false;
            txtRazaoNome.Visible = false;
            lblIdLancamento.Visible = false;
            lblValorTotal.Visible = false;
            lblLancamento.Visible = false;
            lblLancamento.Visible = false;
            lblCodCdc.Visible = false;
            lblNumLancamento.Visible = false;
            lblTipoLancamento.Visible = false;
            lblCodCliForn.Visible = false;
            lblCodCdc.Visible = false;
            lblTipoLancamento.Visible = false;
            lblSituacaoAbertaPaga.Visible = false;  

            dtLancamento.Visible = false;
            dtPagamento.Visible = false;
            dtPgto.Visible = false;
            dtVencimento.Visible = false;
            dtVenc.Visible = false;
            dtEmissao.Visible = false;
            dtEmis.Visible = false;

            cbSituacaoAbertaPaga.Visible = false;

            lblPesquisarLancamentos.Visible = true;
            txtPesquisarLancamentos.Visible = true;

            RbDesabilitado();
        }

        /// <summary>
        /// metodo de diminuir tamanho datagrid e habilitar os formularios de editar lanacamentos
        /// </summary>
        public void AjustarDataGridDiminuir()
        {
            DgExibirLacamentos.Visible = false;
            DgExibirLacamentos.Height = 350;
            DgExibirLacamentos.Location = new Point(11, 260);

            txtIdLancamento.Visible = true;
            txtCodCliForn.Visible = true;
            txtIdCdc.Visible = true;
            txtNumDocumento.Visible = true;
            dtLancamento.Visible = true;
            dtEmissao.Visible = true;
            dtVencimento.Visible = true;
            dtPagamento.Visible = true;
            txtValorTotal.Visible = true;
            txtComentarios.Visible = true;
            txtRazaoNome.Visible = true;
            lblIdLancamento.Visible = true;
            lblValorTotal.Visible = true;
            lblLancamento.Visible = true;
            lblLancamento.Visible = true;
            lblCodCdc.Visible = true;
            lblNumLancamento.Visible = true;
            lblTipoLancamento.Visible = true;
            lblCodCliForn.Visible = true;
            lblCodCdc.Visible = true;
            lblTipoLancamento.Visible = true;
            lblSituacaoAbertaPaga.Visible = true;       

            dtLancamento.Visible = true;
            dtPagamento.Visible = true;
            dtPgto.Visible = true;
            dtVencimento.Visible = true;
            dtVenc.Visible = true;
            dtEmissao.Visible = true;
            dtEmis.Visible = true;

            cbSituacaoAbertaPaga.Visible = true;    

            lblPesquisarLancamentos.Visible = false;
            txtPesquisarLancamentos.Visible = false;

            RbHabilitado();
        }

        /// <summary>
        /// metodo de verificar se os campos de tipo de lancamento é ENTRADA ou SAIDA
        /// </summary>
        public void RbDgExibirLancamentos()
        {            
            if (DgExibirLacamentos.CurrentRow.Cells[0].Value.ToString() == "ENTRADA")
            {
                rbEntrada.Checked = true;
            }
            else if (DgExibirLacamentos.CurrentRow.Cells[0].Value.ToString() == "SAIDA")
            {
                rbSaida.Checked = true;
            }
        }

        /// <summary>
        /// metodo de mostrar no textbox os dados selecionados do datagrid do CLIENTES E FORNECEDORES cadastrados
        /// </summary>
        /// <param name="sender">leva para os textbox dados do datagrid</param>
        /// <param name="e">retornas dados do datagrig</param>
        private void DgExibirLacamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RbDgExibirLancamentos();
            txtRazaoNome.Enabled = false;
            txtDescricaoCdc.Enabled = false;


            txtIdLancamento.Text = DgExibirLacamentos.CurrentRow.Cells[0].Value.ToString();
            txtCodCliForn.Text = DgExibirLacamentos.CurrentRow.Cells[2].Value.ToString();
            txtRazaoNome.Text = DgExibirLacamentos.CurrentRow.Cells[3].Value.ToString();
            txtIdCdc.Text = DgExibirLacamentos.CurrentRow.Cells[4].Value.ToString();
            txtDescricaoCdc.Text = DgExibirLacamentos.CurrentRow.Cells[5].Value.ToString();
            txtNumDocumento.Text = DgExibirLacamentos.CurrentRow.Cells[6].Value.ToString();
            dtLancamento.Text = DgExibirLacamentos.CurrentRow.Cells[7].Value.ToString();
            dtEmissao.Text = DgExibirLacamentos.CurrentRow.Cells[8].Value.ToString();
            dtVencimento.Text = DgExibirLacamentos.CurrentRow.Cells[9].Value.ToString();
            dtPagamento.Text = DgExibirLacamentos.CurrentRow.Cells[10].Value.ToString();
            txtValorTotal.Text = DgExibirLacamentos.CurrentRow.Cells[11].Value.ToString();
            txtComentarios.Text = DgExibirLacamentos.CurrentRow.Cells[12].Value.ToString();
            cbSituacaoAbertaPaga.SelectedItem = DgExibirLacamentos.CurrentRow.Cells[13].Value.ToString();

            DgExibirLacamentos.Visible = false;

            AjustarDataGridDiminuir();
        }

        /// <summary>
        /// metodo de mostrar no textbox os dados selecionados do datagrid do CDC cadastrados
        /// </summary>
        /// <param name="sender">leva para os textbox dados do datagrid</param>
        /// <param name="e">retornas dados do datagrig</param>
        private void dgCadCdc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCdc.Text = dgCadCdc.CurrentRow.Cells[1].Value.ToString();
            txtDescricaoCdc.Text = dgCadCdc.CurrentRow.Cells[2].Value.ToString();
            dgCadCdc.Visible = false;
        }

        /// <summary>
        /// metodo de mostrar no textbox os dados selecionados do datagrid do CDC cadastrados
        /// </summary>
        /// <param name="sender">leva para os textbox dados do datagrid</param>
        /// <param name="e">retornas dados do datagrig</param>
        private void DgExibirCliForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodCliForn.Text = DgExibirCliForn.CurrentRow.Cells[0].Value.ToString();
            txtRazaoNome.Text = DgExibirCliForn.CurrentRow.Cells[4].Value.ToString();
            DgExibirCliForn.Visible = false;
        }
    }
}