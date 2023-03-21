using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using prcSystem.Entidades;
using prcSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadProdutos : Form
    {

        Produtos obj = new Produtos();

        public FormCadProdutos()
        {
            InitializeComponent();
            TxtDescProduto.Select();//onde o cursor fica inicializada          

            DtCadastroProduto.Value = DateTime.Now;
            Listar();
            BtnEditarProduto.Enabled = false;
            BtnExcluirProduto.Enabled = false;
            TxtIdProduto.Enabled = false;
        }

        private void FormCadProdutos_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvarProduto_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtDescProduto.Text == "" || TxtMarcaProduto.Text == "" || TxtUnidadeProduto.Text == "" || TxtValorProduto.Text == "")
            {
                MessageBox.Show("Preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDescProduto.Select();//colocar curso em login por padrao
                return;
            }
            else
            {
                salvar();
                limpar();
                Listar();
            }
        }

        private void salvar()
        {
            try
            {
                obj.DescProduto = Convert.ToString(TxtDescProduto.Text);
                obj.MarcaProduto = Convert.ToString(TxtMarcaProduto.Text);
                obj.UnidadeProduto = Convert.ToString(TxtUnidadeProduto.Text);
                obj.ValorProduto = Convert.ToDecimal(TxtValorProduto.Text);
                obj.DtCadastroProduto = Convert.ToDateTime(DtCadastroProduto.Text);

                int x = ProdutoModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao inserir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir." + ex);
            }
        }

        /// <summary>
        /// editar formulario
        /// </summary>
        private void editar()
        {
            try
            {
                obj.IdProduto = Convert.ToInt32(TxtIdProduto.Text);
                obj.DescProduto = Convert.ToString(TxtDescProduto.Text);
                obj.MarcaProduto = Convert.ToString(TxtMarcaProduto.Text);
                obj.UnidadeProduto = Convert.ToString(TxtUnidadeProduto.Text);
                obj.ValorProduto = Convert.ToDecimal(TxtValorProduto.Text);
                obj.DtCadastroProduto = Convert.ToDateTime(DtCadastroProduto.Text);

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

        /// <summary>
        /// metodo excluir
        /// </summary>
        private void excluir()
        {
            try
            {
                obj.IdProduto = Convert.ToInt32(TxtIdProduto.Text);
                int x = ProdutoModel.Deletar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Excluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir." + ex);
            }
        }

        private void limpar()
        {
            TxtDescProduto.Text = "";
            TxtMarcaProduto.Text = "";//limpa os textbox depois verificados        
            TxtUnidadeProduto.Text = "";
            TxtValorProduto.Text = "";
            TxtIdProduto.Text = "";

            TxtDescProduto.Select();////onde o cursor fica inicializada depois de incluir

            BtnEditarProduto.Enabled = false;
            BtnExcluirProduto.Enabled = false;
            BtnSalvarProduto.Enabled = true;
            DtCadastroProduto.Enabled = true;
            DtCadastroProduto.Value = DateTime.Now;
        }

        private void Listar()
        {
            try
            {
                List<Produtos> lista = new List<Produtos>();//datagrid
                lista = new ProdutoModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgExibirProdutos.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid
               
                dgExibirProdutos.Columns[0].HeaderText = "Cod.";
                dgExibirProdutos.Columns[1].HeaderText = "Descrição";
                dgExibirProdutos.Columns[2].HeaderText = "Marca";
                dgExibirProdutos.Columns[3].HeaderText = "Unidade";
                dgExibirProdutos.Columns[4].HeaderText = "Valor";
                dgExibirProdutos.Columns[5].HeaderText = "Data";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void dgExibirProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DtCadastroProduto.Enabled = false;
            TxtIdProduto.Enabled = false;
            BtnSalvarProduto.Enabled = false;
            BtnEditarProduto.Enabled = true;
            BtnExcluirProduto.Enabled = true;

            TxtIdProduto.Text = dgExibirProdutos.CurrentRow.Cells[0].Value.ToString();
            TxtDescProduto.Text = dgExibirProdutos.CurrentRow.Cells[1].Value.ToString();
            TxtMarcaProduto.Text = dgExibirProdutos.CurrentRow.Cells[2].Value.ToString();
            TxtUnidadeProduto.Text = dgExibirProdutos.CurrentRow.Cells[3].Value.ToString();
            TxtValorProduto.Text = dgExibirProdutos.CurrentRow.Cells[4].Value.ToString();
            DtCadastroProduto.Text = dgExibirProdutos.CurrentRow.Cells[5].Value.ToString();

            // configuração que marca a linha completa.
            dgExibirProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExibirProdutos.Update();
            dgExibirProdutos.Select();
            // configuração do estilo da linha
            dgExibirProdutos.CurrentRow.DefaultCellStyle.BackColor = Color.Azure;
        }

        private void dgExibirProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {   //criando link para outra pagina de cadastro de
            //.
            FormCadProdutosAlterar formCadProdutosAlterar = new FormCadProdutosAlterar();
            formCadProdutosAlterar.ShowDialog();
        }

        private void BtnEditarProduto_Click(object sender, EventArgs e)
        {
            editar();
            Listar();
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            excluir();
            Listar();
            limpar();
        }

        private void BtnLimparProduto_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
