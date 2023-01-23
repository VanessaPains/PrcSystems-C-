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
    public partial class FormImagens : Form
    {
        public string caminhoFoto = "";
        private Produto produto = new Produto();

        public FormImagens()
        {
            InitializeComponent();
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }

        private void CarregarFoto()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagem jpg e png|*.jpg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = openFile.FileName;
            }

            if (caminhoFoto != "")
            {
                pictureBox11.Load(caminhoFoto);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarProduto();
        }

        private void SalvarProduto()
        {
            produto.Descricao = txtDescricao.Text; 
            produto.CaminhoFoto = caminhoFoto;

            produto.Salvar(produto);

            MessageBox.Show("Produto gravado.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            produto.Id = 0;
            produto.Descricao = "";
            produto.CaminhoFoto= "";
            produto.Foto = null;

            txtId.Focus();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarProduto(Convert.ToInt32("0"+txtId.Text));
        }

        private void CarregarProduto(int id)
        {
            produto.Get(id, produto);

            txtDescricao.Text = produto.Descricao;

            using (var foto =  new MemoryStream(produto.Foto))
            {
                pictureBox11.Image = Image.FromStream(foto);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
