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
    public partial class FormCadOrcamentos : Form
    {
        public FormCadOrcamentos()
        {
            InitializeComponent();
        }

        private void FormCadOrcamentos_Load(object sender, EventArgs e)
        {

        }

        private void TxtIdCliForn_Click(object sender, EventArgs e)
        {
            AjustarDataGridAumentar();
        }

        public void AjustarDataGridAumentar()
        {
            DgExibirCliFornOrcamentos.Visible = true;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Width = 910;
            DgExibirCliFornOrcamentos.Location = new Point(14, 151);
        }

        public void AjustarDataGridDiminuir()
        {
            DgExibirCliFornOrcamentos.Visible = false;
            DgExibirCliFornOrcamentos.Height = 350;
            DgExibirCliFornOrcamentos.Location = new Point(11, 260);
        }

        public void OcutarFormularioOrcamento() 
        {
            LblIdCodCliForn.Visible = false;
            TxtIdCliForn.Visible = false;
            lblStatusOrcamento.Visible = false;
            cbStatusOrcamento.Visible = false;
            lblDtLancOrcamento.Visible = false;
            dtLancOrcamento.Visible = false;
            lblNumOrcamento.Visible = false;
            txtCnpjCpf.Visible = false;
            txtNome.Visible = false;
            txtRazaoSocial.Visible = false;
            txtInscEstadual.Visible = false;
            lblOutrasInsc.Visible = false;
            txtOutrasInsc.Visible = false;
            txtEndereco.Visible = false;

        }


    }
}
