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

namespace prcSystem.View
{
    public partial class FormCadVendedores : Form
    {
        Vendedores obj = new Vendedores();
        public FormCadVendedores()
        {
            InitializeComponent();
            DtCadastroVendedor.Value = DateTime.Now;
            Listar();
            BtnEditarVendedor.Enabled = false;
            BtnExcluirVendedor.Enabled = false;
        }

        private void salvar()
        {
            try
            {        
                obj.NomeVendedor = Convert.ToString(TxtNomeVendedor.Text);
                obj.DtCadastroVendedor = Convert.ToDateTime(DtCadastroVendedor.Text);

                int x = VendedoresModel.Inserir(obj);
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

        private void editar()
        {
            try
            {
                obj.IdVendedores = Convert.ToInt32(TxtIdVendedores.Text);               
                obj.NomeVendedor = Convert.ToString(TxtNomeVendedor.Text);
                obj.DtCadastroVendedor = Convert.ToDateTime(DtCadastroVendedor.Text);

                int x = VendedoresModel.Editar(obj);
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

        private void excluir()
        {
            try
            {
                obj.IdVendedores = Convert.ToInt32(TxtIdVendedores.Text);
                int x = VendedoresModel.Deletar(obj);
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

        /// <summary>
        /// limpar campos
        /// </summary>
        private void limpar()
        {
            TxtIdVendedores.Text = "";
            TxtNomeVendedor.Text = "";//limpa os textbox depois verificados
            DtCadastroVendedor.Text = "";

            TxtNomeVendedor.Select();////onde o cursor fica inicializada depois de incluir

            BtnEditarVendedor.Enabled = false;
            BtnExcluirVendedor.Enabled = false;
            BtnSalvarVendedor.Enabled = true;
            DtCadastroVendedor.Enabled = true;
            DtCadastroVendedor.Value = DateTime.Now;
        }

        private void Listar()
        {
            try
            {
                List<Vendedores> lista = new List<Vendedores>();//datagrid
                lista = new VendedoresModel().Listar();

                DgExibirVendedores.DataSource = lista;

                DgExibirVendedores.Columns[0].HeaderText = "Cod. Vendedor";
                DgExibirVendedores.Columns[1].HeaderText = "Nome";
                DgExibirVendedores.Columns[2].HeaderText = "Data";              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void BtnSalvarVendedor_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtNomeVendedor.Text == "")
            {
                MessageBox.Show("Digite nome do vendedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomeVendedor.Select();//colocar curso em login por padrao
                return;
            }
            else
            {
                salvar();
                limpar();
                Listar();
            }
        }

        private void BtnEditarVendedor_Click(object sender, EventArgs e)
        {
            editar();
            limpar();
            Listar();
        }

        private void BtnExcluirVendedor_Click(object sender, EventArgs e)
        {
            excluir();
            limpar();
            Listar();
        }

        private void BtnLimparVendedor_Click(object sender, EventArgs e)
        {
            limpar();
            Listar();
        }

        private void DgExibirVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DtCadastroVendedor.Enabled = false;
            TxtIdVendedores.Enabled = false;
            BtnSalvarVendedor.Enabled = false;
            BtnEditarVendedor.Enabled = true;
            BtnExcluirVendedor.Enabled = true;

            TxtIdVendedores.Text = DgExibirVendedores.CurrentRow.Cells[0].Value.ToString();
            TxtNomeVendedor.Text = DgExibirVendedores.CurrentRow.Cells[1].Value.ToString();
            DtCadastroVendedor.Text = DgExibirVendedores.CurrentRow.Cells[2].Value.ToString();

            // configuração que marca a linha completa.
            DgExibirVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgExibirVendedores.Update();
            DgExibirVendedores.Select();
            // configuração do estilo da linha
            DgExibirVendedores.CurrentRow.DefaultCellStyle.BackColor = Color.Azure;
        }
    }
}
