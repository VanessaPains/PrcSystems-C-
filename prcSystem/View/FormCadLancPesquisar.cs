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

        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();//datagrid
                lista = new LancamentoModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgPesquisarLanc.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                /*DgExibirLacamentos.Columns[1].HeaderText = "Cod. Lanç.";
                DgExibirLacamentos.Columns[0].HeaderText = "Tipo Lanç.";
                DgExibirLacamentos.Columns[2].HeaderText = "Cod. Cli/Forn.";
                DgExibirLacamentos.Columns[2].HeaderText = "Razão/Nome. ";
                DgExibirLacamentos.Columns[4].HeaderText = "Cod. CDC";
                DgExibirLacamentos.Columns[4].HeaderText = "Desc. CDC";
                DgExibirLacamentos.Columns[6].HeaderText = "Nº Doc.";
                DgExibirLacamentos.Columns[7].HeaderText = "Dt. Lanç.";
                DgExibirLacamentos.Columns[8].HeaderText = "Dt. Emissão.";
                DgExibirLacamentos.Columns[9].HeaderText = "Dt. Venc.";
                DgExibirLacamentos.Columns[10].HeaderText = "Dt. Pgto.";
                DgExibirLacamentos.Columns[11].HeaderText = "Valor.";
                DgExibirLacamentos.Columns[12].HeaderText = "Comentarios.";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
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
    }
}
