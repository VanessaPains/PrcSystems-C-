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
using static System.Net.Mime.MediaTypeNames;

namespace prcSystem.View
{
    public partial class FormCadLancPesquisar : Form
    {
        Lancamentos obj = new Lancamentos();   

        public FormCadLancPesquisar()
        {
            InitializeComponent();
            Listar();
        }

        /// <summary>
        /// metodo excluir lancamentos
        /// </summary>
        private void excluir()
        {
            try
            {
                obj.IdLancamento = Convert.ToInt32(txtIdLancamento.Text);
                int x = LancamentoModel.Deletar(obj);
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

        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();//datagrid
                lista = new LancamentoModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgPesquisarLanc.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                dgPesquisarLanc.Columns[0].HeaderText = "Cod. Lanç.";
                dgPesquisarLanc.Columns[1].HeaderText = "Tipo Lanç.";
                dgPesquisarLanc.Columns[2].HeaderText = "Cod. Cli/Forn.";
                dgPesquisarLanc.Columns[3].HeaderText = "Razão/Nome ";
                dgPesquisarLanc.Columns[4].HeaderText = "Cod. CDC";
                dgPesquisarLanc.Columns[5].HeaderText = "Desc. CDC";
                dgPesquisarLanc.Columns[6].HeaderText = "Nº Doc.";
                dgPesquisarLanc.Columns[7].HeaderText = "Dt. Lanç.";
                dgPesquisarLanc.Columns[8].HeaderText = "Dt. Emissão";
                dgPesquisarLanc.Columns[9].HeaderText = "Dt. Venc.";
                dgPesquisarLanc.Columns[10].HeaderText = "Dt. Prog. de Pgto.";
                dgPesquisarLanc.Columns[11].HeaderText = "Valor.";
                dgPesquisarLanc.Columns[12].HeaderText = "Comentarios.";

                dgPesquisarLanc.Columns[1].Width = 90;//determinar a largura das colunas
                dgPesquisarLanc.Columns[0].Width = 70;
                dgPesquisarLanc.Columns[2].Width = 70;
                dgPesquisarLanc.Columns[3].Width = 280;
                dgPesquisarLanc.Columns[4].Width = 60;
                dgPesquisarLanc.Columns[5].Width = 250;
                dgPesquisarLanc.Columns[12].Width = 290;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        /// <summary>
        /// metodo para limpar os campos dos formuarios de lancamentos
        /// </summary>
        private void limpar()
        {
            txtIdLancamento.Text = "";

            txtIdLancamento.Select();////onde o cursor fica inicializada depois de incluir
        }

        private void pesquisaCodCliFornLancamentos()
        {
            if (txtPesquisaLancmentos.Text == "")
            {
                Listar();
                return;

            }
            //obj.IdPessoa = Convert.ToInt32(txtPesquisaLancmentos.Text);
            obj.RazaoNome = Convert.ToString(txtPesquisaLancmentos.Text);

            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancamentoModel().PesquisarFornCLi(obj);
            dgPesquisarLanc.AutoGenerateColumns = false;
            dgPesquisarLanc.DataSource = lista;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisaCodCliFornLancamentos();    

        }

        private void BtnExcluirLanc_Click(object sender, EventArgs e)
        {
            excluir();
            limpar();
            Listar();
        }

        private void dgPesquisarLanc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLancamento.Text = dgPesquisarLanc.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
