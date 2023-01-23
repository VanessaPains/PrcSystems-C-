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

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()
        {
            Label label1 = new Label()
            {
                
                Location = new Point(71, 339),//localização onde vai incluir novo itens formulario
                TabIndex = 10
            };

            TextBox field1 = new TextBox()
            {
                Location = new Point(label1.Location.X, label1.Bounds.Bottom + Padding.Top),
                TabIndex = 11
            };

            Controls.Add(TxtUnidadeProduto);
            Controls.Add(field1);

        }

        private void picBoxPesqCliForn_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormPesquisarCliForn formCadClientePesquisar = new FormPesquisarCliForn();
            formCadClientePesquisar.ShowDialog();
            
           
            
        }

        private void FormCadLancEntradasSaidas_Load(object sender, EventArgs e)
        {

        }
    }
}
