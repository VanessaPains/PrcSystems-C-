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
    public partial class FormCadPagamentos : Form
    {
        Lancamentos obj = new Lancamentos();

        public FormCadPagamentos()
        {
            InitializeComponent();
            Listar();
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


                dgPagamentos.Columns[0].Width = 90;//determinar a largura das colunas
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
        /// metodo de pesquisar os clientes/fornecedores cadastrados pela razão social
        /// </summary>
        public void PesquisarTipoEntrada()
        {

            obj.TipoLancamento = Convert.ToString(btnEntrada.Text = "ENTRADA");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoEntrada(obj);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        public void PesquisarTipoSaida()
        {
            obj.TipoLancamento = Convert.ToString(btnSaida.Text = "SAIDA");

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoSaida(obj);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        public void PesquisarTipoTodos()
        {

            obj.TipoLancamento = Convert.ToString(btnTodos.Text);

            
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarTipoTodos(obj);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
            Listar();
        }

        public void PesquisarSituacaoAberto()
        {

            obj.Situacao = Convert.ToString(btnAberto.Text = "EM ABERTO");


            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarSituacaoAberto(obj);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;          
        }

        public void PesquisarSituacaoPagas()
        {

            obj.Situacao = Convert.ToString(btnPagas.Text = "PAGAS");


            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarSituacaoPagas(obj);
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
            lista = new LancamentoModel().PesquisarNumDocCnpjCpfCodCdcRazaoNome(obj);
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
            lista = new LancamentoModel().PesquisarCodCliPagamento(obj);
            dgPagamentos.AutoGenerateColumns = false;
            dgPagamentos.DataSource = lista;
        }

        private void Limpar()
        {
            txtCodCliForn.Text = "";
            txtNumDocumento.Text = "";
        }

        private void dgPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtIdLancamento.Text = dgPagamentos.CurrentRow.Cells[1].Value.ToString();
            txtCodCliForn.Text = dgPagamentos.CurrentRow.Cells[2].Value.ToString();
            txtRazaoNome.Text = dgPagamentos.CurrentRow.Cells[3].Value.ToString();
            txtIdCdc.Text = dgPagamentos.CurrentRow.Cells[4].Value.ToString();
            txtDescricaoCdc.Text = dgPagamentos.CurrentRow.Cells[5].Value.ToString();
            txtNumDocumento.Text = dgPagamentos.CurrentRow.Cells[6].Value.ToString();
            dtLancamento.Text = dgPagamentos.CurrentRow.Cells[7].Value.ToString();
            dtEmissao.Text = dgPagamentos.CurrentRow.Cells[8].Value.ToString();
            dtVencimento.Text = dgPagamentos.CurrentRow.Cells[9].Value.ToString();
            dtPagamento.Text = dgPagamentos.CurrentRow.Cells[10].Value.ToString();
            txtValorTotal.Text = dgPagamentos.CurrentRow.Cells[11].Value.ToString();
            txtComentarios.Text = dgPagamentos.CurrentRow.Cells[12].Value.ToString();
            dgPagamentos.Visible = false;

            AjustarDataGridDiminuir();*/
        }

        private void txtNumDocumento_TextChanged(object sender, EventArgs e)
        {
            PesquisarNumDocCnpjCpfCodCdcRazaoNome();
        }


        private void txtCodCliForn_TextChanged(object sender, EventArgs e)
        {
            PesquisarCodCliPagamento();
        }

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            Listar();
        }
    }
}
