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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormCadProdutos formCadProdutos = new FormCadProdutos();
            formCadProdutos.ShowDialog();
        }

        private void btnSairMenu_Click(object sender, EventArgs e)
        {
            //ao clicar em sair, sair do programa
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnPesquisarCliForn_Click(object sender, EventArgs e)
        {
            FormCadCliFornPesquisar formCadCliFornPesquisar = new FormCadCliFornPesquisar();
            formCadCliFornPesquisar.ShowDialog();
        }

        private void btnCadastrarCdc_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro cdc.
            FormCadCDC formCadcdc = new FormCadCDC();
            formCadcdc.ShowDialog();
        }

        private void eNTRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro lançamento de entrada ou saidas.
            FormCadLancEntradasSaidas formCadLancEntradasSaidas = new FormCadLancEntradasSaidas();
            formCadLancEntradasSaidas.ShowDialog();
        }

        private void pESQUISARToolStripMenuItem_Click(object sender, EventArgs e)
        {   //criando link para outra pagina de cadastro de usuarios
            FormCadLancPesquisar formCadLancPesquisa = new FormCadLancPesquisar();
            formCadLancPesquisa.ShowDialog();
        }

        private void cLIENTESFORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes ou forncedores.
            FormCadCliForn formCadCliForn = new FormCadCliForn();
            formCadCliForn.ShowDialog();
        }

        private void nOVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de orçamentos.
            FormCadOrcamentos formCadOrcamentos = new FormCadOrcamentos();
            formCadOrcamentos.ShowDialog();
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {   //criando link para outra pagina de cadastro de pagamentos.
            FormCadPagamentos formCadPagamentos = new FormCadPagamentos();
            formCadPagamentos.ShowDialog();

        }

        private void lISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {   //criando link para outra pagina de pesquisar os orçamentos.
            FormCadOrcamentosPesquisar formCadOrcamentosPesquisar = new FormCadOrcamentosPesquisar();
            formCadOrcamentosPesquisar.ShowDialog();

        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {   //criando link para outra pagina de cadastro de funcionarios
            FormCadFuncionarios formCadFuncionarios = new FormCadFuncionarios();
            formCadFuncionarios.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {   //criando link para outra pagina de cadastro de usuarios
            FormCadUsuarios formCadUsuarios = new FormCadUsuarios();
            formCadUsuarios.ShowDialog();

        }
    }
}
