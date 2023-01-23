using prcSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prcSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripFornecedor_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormCadFornecedoores formCadFornecedores = new FormCadFornecedoores();
            formCadFornecedores.ShowDialog();
        }

        private void toolStripProdutos_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormCadProdutos formCadProdutos = new FormCadProdutos();
            formCadProdutos.ShowDialog();
        }

        private void toolStripClientes_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormCadClientes formCadClientes = new FormCadClientes();
            formCadClientes.ShowDialog();
        }
    }
}
