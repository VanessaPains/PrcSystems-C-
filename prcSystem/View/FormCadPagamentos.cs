using prcSystem.Entidades;
using prcSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadPagamentos : Form
    {
        Pagamentos obj = new Pagamentos();
        Lancamentos lanc = new Lancamentos();
        Produtos produtos = new Produtos();
        Cdc cdc = new Cdc();

        CdcModel amodelA = new CdcModel();

        public FormCadPagamentos()
        {
            InitializeComponent();
            Listar();
            DesabilitarTelaFormPagamento();
            PreencherCB();
        }

        /// <summary>
        /// preenche o combobox de escolher o ano
        /// </summary>
        private void PreencherCB()
        {
            cbPagoEm.DataSource = amodelA.Listar();
            cbPagoEm.ValueMember = "DescricaoCdc";
            cbPagoEm.DisplayMember = " ";
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

                obj.IdLancamento = Convert.ToInt32(txtIdCdc.Text);
                obj.NumDocumento = Convert.ToString(txtNumDocumento.Text);
                obj.DtLancamento = Convert.ToDateTime(dtLancamento.Text);
                obj.DtEmissao = Convert.ToDateTime(dtEmissao.Text);
                obj.DtVencimento = Convert.ToDateTime(dtVencimento.Text);
                obj.DtPagamento = Convert.ToDateTime(dtPagamento.Text);
                obj.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                obj.Comentarios = Convert.ToString(txtComentarios.Text);
                obj.Situacao = Convert.ToString(cbSituacaoAbertaPaga.Text);
                obj.JurosPagto = Convert.ToDecimal(txtJurosPagto.Text);
                obj.TotalPagoPagto = Convert.ToDecimal(txtTotalPagoPagto.Text);
                obj.PagoEm = Convert.ToString(cbPagoEm.Text);

                int x = PagamentoModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Pagamento feito com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao fazer pagamento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer pagamento." + ex);
            }
        }

        private void PreencherDesc()
        {
            produtos.DescProduto = Convert.ToString(txtRazaoNomeDescricao.Text);
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
                obj.IdPessoa = Convert.ToInt32(txtCodCliFornPgto.Text);
                obj.IdCdc = Convert.ToInt32(txtIdCdc.Text);
                obj.NumDocumento = Convert.ToString(txtNumDocumento.Text);
                obj.DtLancamento = Convert.ToDateTime(dtLancamento.Text);
                obj.DtEmissao = Convert.ToDateTime(dtEmissao.Text);
                obj.DtVencimento = Convert.ToDateTime(dtVencimento.Text);
                obj.DtPagamento = Convert.ToDateTime(dtPagamento.Text);
                obj.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);
                obj.Comentarios = Convert.ToString(txtComentarios.Text);
                obj.Situacao = cbSituacaoAbertaPaga.Text;

                int x = LancamentoModel.Editar(lanc);
                if (x > 0)
                {
                    MessageBox.Show("PAGAMENTO EDITADO COM SUCESSO.");
                }
                else
                {
                    MessageBox.Show("ERRO AO EDITAT PAGAMENTO.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EDITAR PAGEMENTO." + ex);
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

                dgPagamentos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                dgPagamentos.Columns[0].HeaderText = "Cod. Lanç.";
                dgPagamentos.Columns[1].HeaderText = "Situação";
                dgPagamentos.Columns[2].HeaderText = "Tipo Lanç.";
                dgPagamentos.Columns[3].HeaderText = "Cod. Cli/Forn.";
                dgPagamentos.Columns[4].HeaderText = "Razão/Nome ";
                dgPagamentos.Columns[5].HeaderText = "CNPJ/CPF ";
                dgPagamentos.Columns[6].HeaderText = "Cod. CDC";
                dgPagamentos.Columns[7].HeaderText = "Desc. CDC";
                dgPagamentos.Columns[8].HeaderText = "Nº Doc.";
                dgPagamentos.Columns[9].HeaderText = "Dt. Lanç.";
                dgPagamentos.Columns[10].HeaderText = "Dt. Emissão";
                dgPagamentos.Columns[11].HeaderText = "Dt. Venc.";
                dgPagamentos.Columns[12].HeaderText = "Dt. Prog. de Pgto.";
                dgPagamentos.Columns[13].HeaderText = "Valor";
                dgPagamentos.Columns[14].HeaderText = "Comentarios";


                dgPagamentos.Columns[0].Width = 50;//determinar a largura das colunas
                dgPagamentos.Columns[1].Width = 90;
                dgPagamentos.Columns[2].Width = 90;
                dgPagamentos.Columns[3].Width = 70;
                dgPagamentos.Columns[4].Width = 280;
                dgPagamentos.Columns[6].Width = 60;
                dgPagamentos.Columns[7].Width = 250;
                dgPagamentos.Columns[14].Width = 290;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados TIPO ENTRADA
        /// </summary>
        public void PesquisarTipoEntrada()
        {

            obj.TipoLancamento = Convert.ToString(btnEntrada.Text = "ENTRADA");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoEntrada(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados TIPO SAIDA
        /// </summary>
        public void PesquisarTipoSaida()
        {
            obj.TipoLancamento = Convert.ToString(btnSaida.Text = "SAIDA");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoSaida(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados TIPO TODOS
        /// </summary>
        public void PesquisarTipoTodos()
        {
            obj.TipoLancamento = Convert.ToString(btnTodos.Text);
          
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoTodos(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
            Listar();
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados TIPO EM ABERTO
        /// </summary>
        public void PesquisarSituacaoAberto()
        {
            obj.Situacao = Convert.ToString(btnAberto.Text = "EM ABERTO");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarSituacaoAberto(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;          
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados TIPO PAGAS
        /// </summary>
        public void PesquisarSituacaoPagas()
        {
            obj.Situacao = Convert.ToString(btnPagas.Text = "PAGAS");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarSituacaoPagas(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;          
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados pela razão social
        /// </summary>
        public void PesquisarNumDocCnpjCpfCodCdcRazaoNome()
        {
            if (txtNumDocumento.Text == "")
            {
                Listar();
                return;
            }
            obj.NumDocumento = Convert.ToString(txtNumDocumento.Text);
            obj.CodCdc = Convert.ToString(txtNumDocumento.Text);
            obj.RazaoNome = Convert.ToString(txtNumDocumento.Text);
            obj.CnpjCpf = Convert.ToString(txtNumDocumento.Text);

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarNumDocCnpjCpfCodCdcRazaoNome(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        /// <summary>
        /// metodo de pesquisar os clientes/fornecedores cadastrados pela razão social
        /// </summary>
        public void PesquisarCodCliPagamento()
        {
            if (txtCodCliForn.Text == "")
            {
                Listar();
                return;
            }
            obj.IdPessoa = Convert.ToInt32(txtCodCliForn.Text);

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarCodCliPagamento(lanc);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        private void Limpar()
        {
            txtCodCliForn.Text = "";
            txtNumDocumento.Text = "";
        }

        /// <summary>
        /// botão de limpar e listar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            HabilitarTelaFormPagamentosPesquisas();
            DesabilitarTelaFormPagamento();
            AjustarDataGridAumentar();
            Limpar();
            Listar();
        }

        //------------- INICIO: CAMPOS DATAGRID MOSTRAR NO FORMULARIO ----------------------------------------------------
        /// <summary>
        /// metodo de verificar se os campos de tipo de lancamento é ENTRADA ou SAIDA
        /// </summary>
        public void RbDgExibirPagamentos()
        {
            if (dgPagamentos.CurrentRow.Cells[2].Value.ToString() == "ENTRADA")
            {
                rbEntrada.Checked = true;
            }
            else if (dgPagamentos.CurrentRow.Cells[2].Value.ToString() == "SAIDA")
            {
                rbSaida.Checked = true;
            }
        }

        /// <summary>
        /// datagrid pagamentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPagamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RbDgExibirPagamentos();

            txtIdLancamento.Text = dgPagamentos.CurrentRow.Cells[0].Value.ToString();
            cbSituacaoAbertaPaga.SelectedItem = dgPagamentos.CurrentRow.Cells[1].Value.ToString();
            txtCodCliFornPgto.Text = dgPagamentos.CurrentRow.Cells[3].Value.ToString();
            txtRazaoNomeDescricao.Text = dgPagamentos.CurrentRow.Cells[4].Value.ToString();
            txtIdCdc.Text = dgPagamentos.CurrentRow.Cells[6].Value.ToString();
            txtDescricaoCdc.Text = dgPagamentos.CurrentRow.Cells[7].Value.ToString();
            txtNumDoc.Text = dgPagamentos.CurrentRow.Cells[8].Value.ToString();
            dtLancamento.Text = dgPagamentos.CurrentRow.Cells[9].Value.ToString();
            dtEmissao.Text = dgPagamentos.CurrentRow.Cells[10].Value.ToString();
            dtVencimento.Text = dgPagamentos.CurrentRow.Cells[11].Value.ToString();
            dtPagamento.Text = dgPagamentos.CurrentRow.Cells[12].Value.ToString();
            txtValorTotal.Text = dgPagamentos.CurrentRow.Cells[13].Value.ToString();
            txtComentarios.Text = dgPagamentos.CurrentRow.Cells[14].Value.ToString();

            dgPagamentos.Visible = true;
            AjustarTelaFormPagamento();
            HabilitarTelaFormPagamento();
            DesabilitarTelaFormPagamentosPesquisas();
        }
        //------------- FIM: CAMPOS DATAGRID MOSTRAR NO FORMULARIO ----------------------------------------------------


        //------------- INICIO: METODOS/FUNCOES DOS CAMPO DE PESQUISAR TEXTO ----------------------------------------------------
        /// <summary>
        /// Campo de texto para pesquisas
        /// </summary>
        /// <param name="sender">inseri informação que deseja pesquisar</param>
        /// <param name="e">tras resutados do que digitou</param>
        private void txtNumDocumento_TextChanged(object sender, EventArgs e)
        {
            PesquisarNumDocCnpjCpfCodCdcRazaoNome();
        }

        /// <summary>
        /// Campo de texto para pesquisas
        /// </summary>
        /// <param name="sender">inseri informação que deseja pesquisar</param>
        /// <param name="e">tras resutados do que digitou</param>
        private void txtCodCliForn_TextChanged(object sender, EventArgs e)
        {
            PesquisarCodCliPagamento();
        }
        //------------- FIM: CAMPO DE PESQUISAR TEXTO ----------------------------------------------------



        //------------- INICIO: CAMPO DE PESQUISAR BOTOES ----------------------------------------------------
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            PesquisarTipoEntrada();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            PesquisarTipoSaida();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            PesquisarTipoTodos();
        }

        private void btnAberto_Click(object sender, EventArgs e)
        {
            PesquisarSituacaoAberto();
        }

        private void btnPagas_Click(object sender, EventArgs e)
        {
            PesquisarSituacaoPagas();
        }
        //------------- FIN: CAMPO DE PESQUISAR BOTOES ----------------------------------------------------

        //------------- INICIO: DOS METODOS DE AJUSTAR AS POSIÇÕES DOS CAMPOS ----------------------------------------------------
        /// <summary>
        /// metodo de aumentar tamanho datagrid e desabilitar os formularios
        /// </summary>
        public void AjustarDataGridDiminuir()
        {
            dgPagamentos.Visible = true;
            dgPagamentos.Enabled = false;
            dgPagamentos.Height = 238;
            dgPagamentos.Location = new Point(12, 290);
        }

        public void AjustarDataGridAumentar()
        {
            dgPagamentos.Visible = true;
            dgPagamentos.Enabled = true;
            dgPagamentos.Height = 308;
            dgPagamentos.Location = new Point(14, 206);
        }

        /// <summary>
        /// ajustar localização do formulario de pagementos.
        /// </summary>
        private void AjustarTelaFormPagamento()
        {
            AjustarDataGridDiminuir();

            lblTipoLancPgto.Location = new Point(12, 65);
            lblIdLancPgto.Location = new Point(414, 65);
            lblLancamentoPgto.Location = new Point(53, 124);
            lblCodCliFornPgto.Location = new Point(57, 172);
            lblNumDocPgto.Location = new Point(659, 125);
            lblValorTotalPgto.Location = new Point(623, 175);
            lblDtEmisPgto.Location = new Point(51, 148);
            lblIdCdcCodPgto.Location = new Point(88, 197);
            lblSituacaoAbertaPagaPgto.Location = new Point(645, 149);
            lblDtVencPgto.Location = new Point(376, 123);
            lblComentariosPgto.Location = new Point(38, 221);
            lblDtProgramacaoPgto.Location = new Point(286, 148);
            lblJurosPagto.Location = new Point(662, 199);
            lblTotalPagoPagto.Location = new Point(634, 223);
            lblPagoEm.Location = new Point(651, 247);

            rbEntrada.Location = new Point(184, 64);
            rbSaida.Location = new Point(272, 64);

            txtCodCliFornPgto.Location = new Point(121, 170);
            txtRazaoNomeDescricao.Location = new Point(182, 170);
            txtNumDoc.Location = new Point(707, 122);
            txtValorTotal.Location = new Point(707, 172);
            txtIdCdc.Location = new Point(122, 194);
            txtDescricaoCdc.Location = new Point(183, 194);
            txtComentarios.Location = new Point(122, 218);
            txtIdLancamento.Location = new Point(414, 80);
            txtJurosPagto.Location = new Point(707, 196);
            txtTotalPagoPagto.Location = new Point(707, 220);
            textBox2.Location = new Point(13, 275);
            textBox4.Location = new Point(593, 108);

            dtLancamento.Location = new Point(121, 121);
            dtEmissao.Location = new Point(121, 145);
            dtVencimento.Location = new Point(430, 121);
            dtPagamento.Location = new Point(430, 145);

            cbSituacaoAbertaPaga.Location = new Point(707, 146);
            cbPagoEm.Location = new Point(707, 244);
        }
        //------------- FIM: DOS METODOS DE AJUSTAR AS POSIÇÕES DOS CAMPOS ----------------------------------------------------


        //------------- INICIO: DOS METODOS DE HABILITAR E DESABILITAR CAMPOS ----------------------------------------------------
        /// <summary>
        /// habilitar da campos de pesquisas dos pagamentos. (mostrar novamente).
        /// </summary>
        private void HabilitarTelaFormPagamentosPesquisas()
        {
            lblPesquisarPor.Visible = true;
            lblTipo.Visible = true;
            lblSituacao.Visible = true;
            btnEntrada.Visible = true;
            btnSaida.Visible = true;
            btnTodos.Visible = true;
            btnAberto.Visible = true;
            btnPagas.Visible = true;

            txtlinha01.Visible = true;
            txtlinha02.Visible = true;
            txtlinha03.Visible = true;
            txtlinha04.Visible = true;
            txtlinha05.Visible = true;

            lblDtLancPesq.Visible = true;
            lblDe01.Visible = true;
            DtDeLanc.Visible = true;
            lblAte01.Visible = true;
            DtAteLanc.Visible = true;

            lblDtEmisPesq.Visible = true;
            lblDe02.Visible = true;
            DtDeEmis.Visible = true;
            lblAte02.Visible = true;
            DtAteEmis.Visible = true;

            lblDtVencPesq.Visible = true;
            lblDe03.Visible = true;
            DtDeVenc.Visible = true;
            lblAte03.Visible = true;
            DtAteVenc.Visible = true;

            lblDtPgtoPesq.Visible = true;
            lblDe04.Visible = true;
            DtDePgto.Visible = true;
            lblAte04.Visible = true;
            DtAtePgto.Visible = true;

            lblNumDocumento.Visible = true;
            lblIdCdc.Visible = true;
            lblCnpjCpf.Visible = true;
            lblRazaoNome.Visible = true;
            txtNumDocumento.Visible = true;
            lblCodCliForn.Visible = true;
            txtCodCliForn.Visible = true;
        }

        /// <summary>
        /// desabilitar da campos de pesquisas dos pagamentos. (não mostrar na tela)
        /// </summary>
        private void DesabilitarTelaFormPagamentosPesquisas()
        {
            lblPesquisarPor.Visible = false;
            lblTipo.Visible = false;
            lblSituacao.Visible = false;
            btnEntrada.Visible = false;
            btnSaida.Visible = false;
            btnTodos.Visible = false;
            btnAberto.Visible = false;  
            btnPagas.Visible = false;

            txtlinha01.Visible = false;
            txtlinha02.Visible = false;
            txtlinha03.Visible = false;
            txtlinha04.Visible = false;
            txtlinha05.Visible = false;
          
            lblDtLancPesq.Visible = false;
            lblDe01.Visible = false;
            DtDeLanc.Visible = false;
            lblAte01.Visible = false;
            DtAteLanc.Visible = false;

            lblDtEmisPesq.Visible = false;
            lblDe02.Visible = false;
            DtDeEmis.Visible = false;
            lblAte02.Visible = false;
            DtAteEmis.Visible = false;

            lblDtVencPesq.Visible = false;
            lblDe03.Visible = false;
            DtDeVenc.Visible = false;
            lblAte03.Visible = false;
            DtAteVenc.Visible = false;

            lblDtPgtoPesq.Visible = false;
            lblDe04.Visible = false;
            DtDePgto.Visible = false;
            lblAte04.Visible = false;
            DtAtePgto.Visible = false;

            lblNumDocumento.Visible = false;
            lblIdCdc.Visible = false;
            lblCnpjCpf.Visible = false;
            lblRazaoNome.Visible = false;
            txtNumDocumento.Visible = false;
            lblCodCliForn.Visible = false;
            txtCodCliForn.Visible = false;
        }

        /// <summary>
        /// desabilitar formulario de lançamentos. (não mostrar na tela).
        /// </summary>
        private void DesabilitarTelaFormPagamento()
        {
            lblTipoLancPgto.Visible = false;
            lblIdLancPgto.Visible = false;
            lblLancamentoPgto.Visible = false;
            lblCodCliFornPgto.Visible = false;
            lblNumDocPgto.Visible = false;
            lblValorTotalPgto.Visible = false;
            lblDtEmisPgto.Visible = false;
            lblIdCdcCodPgto.Visible = false;
            lblSituacaoAbertaPagaPgto.Visible = false;
            lblDtVencPgto.Visible = false;
            lblComentariosPgto.Visible = false;
            lblDtProgramacaoPgto.Visible = false;
            lblJurosPagto.Visible = false;  
            lblTotalPagoPagto.Visible = false;
            lblPagoEm.Visible = false;

            rbEntrada.Visible = false;
            rbSaida.Visible = false;

            txtIdLancamento.Visible = false;
            txtCodCliFornPgto.Visible = false;
            txtRazaoNomeDescricao.Visible = false;
            txtNumDoc.Visible = false;
            txtValorTotal.Visible = false;
            txtIdCdc.Visible = false;
            txtDescricaoCdc.Visible = false;
            txtComentarios.Visible = false;
            txtJurosPagto.Visible = false;
            txtTotalPagoPagto.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;

            dtLancamento.Visible = false;
            dtEmissao.Visible = false;
            dtVencimento.Visible = false;
            dtPagamento.Visible = false;

            cbSituacaoAbertaPaga.Visible = false;
            cbPagoEm.Visible = false;

            txtIdLancamento.Enabled = false;
            txtCodCliFornPgto.Enabled = false;
            txtRazaoNomeDescricao.Enabled = false;
            txtNumDoc.Enabled = false;
            txtValorTotal.Enabled = false;
            txtIdCdc.Enabled = false;
            txtDescricaoCdc.Enabled = false;
            txtComentarios.Enabled = false;

            dtLancamento.Enabled = false;
            dtEmissao.Enabled = false;
            dtVencimento.Enabled = false;
            dtPagamento.Enabled = true;

            cbSituacaoAbertaPaga.Enabled = true;
        }

        /// <summary>
        /// habilitar formulario de lançamentos. (mostrar na tela novamente).
        /// </summary>
        private void HabilitarTelaFormPagamento()
        {
            lblTipoLancPgto.Visible = true;
            lblIdLancPgto.Visible = true;
            lblLancamentoPgto.Visible = true;
            lblCodCliFornPgto.Visible = true;
            lblNumDocPgto.Visible = true;
            lblValorTotalPgto.Visible = true;
            lblDtEmisPgto.Visible = true;
            lblIdCdcCodPgto.Visible = true;
            lblSituacaoAbertaPagaPgto.Visible = true;
            lblDtVencPgto.Visible = true;
            lblComentariosPgto.Visible = true;
            lblDtProgramacaoPgto.Visible = true;
            lblJurosPagto.Visible = true;
            lblTotalPagoPagto.Visible = true;
            lblPagoEm.Visible = true;

            rbEntrada.Visible = true;
            rbSaida.Visible = true;

            txtIdLancamento.Visible = true;
            txtCodCliFornPgto.Visible = true;
            txtRazaoNomeDescricao.Visible = true;
            txtNumDoc.Visible = true;
            txtValorTotal.Visible = true;
            txtIdCdc.Visible = true;
            txtDescricaoCdc.Visible = true;
            txtComentarios.Visible = true;
            txtJurosPagto.Visible = true;
            txtTotalPagoPagto.Visible = true;
            textBox2.Visible = true;
            textBox4.Visible = true;

            dtLancamento.Visible = true;
            dtEmissao.Visible = true;
            dtVencimento.Visible = true;
            dtPagamento.Visible = true;

            cbSituacaoAbertaPaga.Visible = true;
            cbPagoEm.Visible = true;    
        }

        private void btnSalvarPgto_Click(object sender, EventArgs e)
        {
            salvar();
            Limpar();
            editar();
        }
        //------------- FIM: DOS METODOS DE HABILITAR E DESABILITAR CAMPOS ----------------------------------------------------

    }
}
