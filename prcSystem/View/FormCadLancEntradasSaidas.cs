using prcSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadLancEntradasSaidas : Form
    {
        Clientes obj = new Clientes();

        public FormCadLancEntradasSaidas()
        {
            InitializeComponent();
        }

        private void picBoxPesqCliForn_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormPesquisarCliForn formCadClientePesquisar = new FormPesquisarCliForn();
            formCadClientePesquisar.ShowDialog();
            
           
            
        }

    }
}
