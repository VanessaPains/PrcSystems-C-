using prcSystem.Controllers;
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
    public partial class FormCadPagaPesquisar : Form
    {
        Pagamentos obj = new Pagamentos();

        public FormCadPagaPesquisar()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Pagamentos> lista = new List<Pagamentos>();//datagrid
                lista = new PagamentosController().ListarTodos();
                //dg.AutoGenerateColumns = false;

                dgPagamentos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                dgPagamentos.Columns[0].HeaderText = "Cod. Pgto.";
                dgPagamentos.Columns[18].HeaderText = "Cod. Lanç.";
                dgPagamentos.Columns[1].HeaderText = "Tipo Lanç.";
                dgPagamentos.Columns[2].HeaderText = "Cod. Cli/Forn.";
                dgPagamentos.Columns[3].HeaderText = "Razão/Nome ";
                dgPagamentos.Columns[4].HeaderText = "Cod. CDC";
                dgPagamentos.Columns[5].HeaderText = "Desc. CDC";
                dgPagamentos.Columns[6].HeaderText = "Nº Doc.";
                dgPagamentos.Columns[7].HeaderText = "CPF/CNPJ.";
                dgPagamentos.Columns[8].HeaderText = "Dt. Lanç.";
                dgPagamentos.Columns[9].HeaderText = "Dt. Emissão";
                dgPagamentos.Columns[10].HeaderText = "Dt. Venc.";
                dgPagamentos.Columns[11].HeaderText = "Dt. Prog. de Pgto.";
                dgPagamentos.Columns[12].HeaderText = "Valor.";
                dgPagamentos.Columns[13].HeaderText = "Comentarios.";
                dgPagamentos.Columns[14].HeaderText = "Situação.";
                dgPagamentos.Columns[15].HeaderText = "Juros.";
                dgPagamentos.Columns[16].HeaderText = "TT Pgto.";
                dgPagamentos.Columns[17].HeaderText = "Pago pelo?";

                dgPagamentos.Columns[1].Width = 90;//determinar a largura das colunas
                dgPagamentos.Columns[17].Width = 70;
                dgPagamentos.Columns[2].Width = 70;
                dgPagamentos.Columns[3].Width = 280;
                dgPagamentos.Columns[4].Width = 60;
                dgPagamentos.Columns[5].Width = 250;
                dgPagamentos.Columns[13].Width = 290;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL LISTAR OS DADOS. CHAME O SUPORTE PARA VERIFICAR O ERRO." + ex);
            }
        }

    }
}
