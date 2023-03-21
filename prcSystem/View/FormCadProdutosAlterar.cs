using prcSystem.Entidades;
using prcSystem.Models;
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

namespace prcSystem.View
{
    public partial class FormCadProdutosAlterar : Form
    {

        Produtos obj = new Produtos();
        public FormCadProdutosAlterar()
        {
            InitializeComponent();
            trocaTela();
        }

        public string Propriedade { get; set; }

        public void trocaTela()
        {

            if (!this.Propriedade.Equals(""))
                TxtIdProduto.Text = this.Propriedade;
        }
        private void editar()
        {


        





            try
            {
                obj.IdProduto = Convert.ToInt32(TxtIdProduto.Text);
                obj.DescProduto = Convert.ToString(TxtDescProduto.Text);
                obj.MarcaProduto = Convert.ToString(TxtMarcaProduto.Text);
                obj.UnidadeProduto = Convert.ToString(TxtUnidadeProduto.Text);
                obj.ValorProduto = Convert.ToDecimal(TxtValorProduto.Text);
                //obj.DtCadastroProduto = Convert.ToDateTime(DtCadastroProduto.Text);

                int x = ProdutoModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar." + ex);
            }
        }

        private void BtnSalvarProduto_Click(object sender, EventArgs e)
        {
            editar();

            //DtCadastroProduto.Text = dgExibirProdutos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
