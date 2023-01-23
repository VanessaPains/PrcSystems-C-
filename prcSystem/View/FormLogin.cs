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

namespace prcSystem.View
{
    public partial class FormLogin : Form
    {
        //referencia da conexão cm db
        SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PrcSystems;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");    


        public FormLogin()
        {
            InitializeComponent();
            TxtTelaLogin.Select();
        }

        private void BtnTelaLoginSair_Click(object sender, EventArgs e)
        {   //ao clicar em sair, sair do programa
            Application.Exit();
        }

        //verifica se todos os campos estao preenchidos
        void verificar()
        {
            if (TxtTelaLogin.Text == "" || TxtTelaLoginSenha.Text == "") 
            {
                MessageBox.Show("Preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelaLogin.Select();//colocar curso em login por padrao
            }
        }

       
        //otao entrar sistema com verificação de login e senha no DB
        private void BtnTelaLoginEntrar_Click(object sender, EventArgs e)
        {
            Conexao.Open();//abrir a conexão com db
            verificar();
            string query = "SELECT * FROM Usuarios WHERE Login = '" + TxtTelaLogin.Text + "' AND Senha = '" + TxtTelaLoginSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            try
            {
                if (dt.Rows.Count == 1)
                {
                    FormMenu menu = new FormMenu();
                    this.Hide();
                    menu.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Usuario ou Senha incorretos."+erro);
                TxtTelaLogin.Text = "";//limpa os textbox depois verificados
                TxtTelaLoginSenha.Text = "";
                TxtTelaLogin.Select();//cursor fica selecionada
            }
            Conexao.Close();//fechar a onexao om db
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
