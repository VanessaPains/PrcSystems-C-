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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadUsuarios : Form
    {
        Usuarios obj = new Usuarios();

        public FormCadUsuarios()
        {
            InitializeComponent();
            DtCadastroUser.Value = DateTime.Now;
            Listar();
            BtnEditarCadUser.Enabled = false;
            BtnExcluirCadUser.Enabled = false;
        }


        private void salvar()
        {
            try
            {
                obj.NomeUser = Convert.ToString(TxtTelaCadUsuarioNomeUser.Text);
                obj.Login = Convert.ToString(TxtTelaCadUsuarioLogin.Text);
                obj.Senha = Convert.ToString(TxtTelaCadUsuarioSenha.Text);               
                obj.DtCadastroUser = Convert.ToDateTime(DtCadastroUser.Text);            

                int x = UsuariosModel.Inserir(obj);
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
                obj.IdUsuario = Convert.ToInt32(TxtTelaCadUsuarioCod.Text);
                obj.NomeUser = Convert.ToString(TxtTelaCadUsuarioNomeUser.Text);
                obj.Login = Convert.ToString(TxtTelaCadUsuarioLogin.Text);
                obj.Senha = Convert.ToString(TxtTelaCadUsuarioSenha.Text);
                obj.DtCadastroUser = Convert.ToDateTime(DtCadastroUser.Text);

                int x = UsuariosModel.Editar(obj);
                if (x > 0)
                {
                    MessageBox.Show("Editado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao editarrrrrrrrrr.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar." + ex);
            }
        }

        /// <summary>
        /// excluir
        /// </summary>
        private void excluir()
        {
            try
            {
                obj.IdUsuario = Convert.ToInt32(TxtTelaCadUsuarioCod.Text);
                int x = UsuariosModel.Deletar(obj);
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
            TxtTelaCadUsuarioCod.Text = "";
            TxtTelaCadUsuarioNomeUser.Text = "";
            TxtTelaCadUsuarioLogin.Text = "";//limpa os textbox depois verificados
            TxtTelaCadUsuarioSenha.Text = "";
           
            TxtTelaCadUsuarioNomeUser.Select();////onde o cursor fica inicializada depois de incluir

            BtnEditarCadUser.Enabled = false;
            BtnExcluirCadUser.Enabled = false;
            BtnTelaLoginSalvar.Enabled = true;
            DtCadastroUser.Enabled = true;
            DtCadastroUser.Value = DateTime.Now;

        }
        private void BtnLimparCadUser_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void BtnTelaLoginSalvar_Click(object sender, EventArgs e)
        {
             //verifica se todos os campos estao preenchidos
             if (TxtTelaCadUsuarioLogin.Text == "" || TxtTelaCadUsuarioSenha.Text == "" || TxtTelaCadUsuarioNomeUser.Text == "")
             {
                 MessageBox.Show("Preencher todos os campos obrigatorios (*).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 TxtTelaCadUsuarioNomeUser.Select();//colocar curso em login por padrao
                 return;
             }
             else
             {
                 salvar();
                 limpar();
                 Listar();
             }
         }

        private void Listar()
        {
            try
            {
                List<Usuarios> lista = new List<Usuarios>();//datagrid
                lista = new UsuariosModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgExibirUser.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                dgExibirUser.Columns[0].HeaderText = "Cod. Usuário";
                dgExibirUser.Columns[1].HeaderText = "Nome Usuário";
                dgExibirUser.Columns[2].HeaderText = "Login";
                dgExibirUser.Columns[3].HeaderText = "Senha";
                dgExibirUser.Columns[4].HeaderText = "Data";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void dgExibirUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DtCadastroUser.Enabled = false;
            TxtTelaCadUsuarioCod.Enabled = false;  
            BtnTelaLoginSalvar.Enabled = false; 
            BtnEditarCadUser.Enabled = true;
            BtnExcluirCadUser.Enabled = true;

            TxtTelaCadUsuarioCod.Text = dgExibirUser.CurrentRow.Cells[0].Value.ToString();
            TxtTelaCadUsuarioNomeUser.Text = dgExibirUser.CurrentRow.Cells[1].Value.ToString();
            TxtTelaCadUsuarioLogin.Text = dgExibirUser.CurrentRow.Cells[2].Value.ToString();
            TxtTelaCadUsuarioSenha.Text = dgExibirUser.CurrentRow.Cells[3].Value.ToString();
            DtCadastroUser.Text = dgExibirUser.CurrentRow.Cells[4].Value.ToString();

            // configuração que marca a linha completa.
            dgExibirUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExibirUser.Update();
            dgExibirUser.Select();
            // configuração do estilo da linha
            dgExibirUser.CurrentRow.DefaultCellStyle.BackColor = Color.Azure;
        }

        private void BtnEditarCadUser_Click(object sender, EventArgs e)
        {
            editar();
            Listar();
           
        }

        private void BtnExcluirCadUser_Click(object sender, EventArgs e)
        {
            excluir();
            Listar();
        }
    }
}
