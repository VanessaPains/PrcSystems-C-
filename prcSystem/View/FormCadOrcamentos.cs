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
            txtComplemento.Visible = false;
            txtBairro.Visible = false;
            txtNum.Visible = false;
            txtCep.Visible = false;
            txtCidade.Visible = false;
            txtUf.Visible = false;

            txtLinha06.Visible = false;

            lblTelefone.Visible = false;
            txtTelefone.Visible = false;
            txtEmail.Visible = false;
            txtSite.Visible = false;
            txtLinha07.Visible = false;
            lblSolicitantea.Visible = false;
            txtSolicitante.Visible = false;
            lblVendedor.Visible = false;

            txtLinha08.Visible = false;

            lblFormaPgto.Visible = false;
            txtFormaPgto.Visible = false;
            lblPrazoPgto.Visible = false;
            txtPrazoPgto.Visible = false;

            txtLinha09.Visible = false;

            lblProzoEntrega.Visible = false;
            txtProzoEntrega.Visible = false;
            lblValidadeOrcamento.Visible = false;
            txtValidadeOrcamento.Visible = false;

            txtLinha10.Visible = false;

            lblListaProdutos.Visible = false;








        }


    }
}
