using prcSystem.Entidades;
using prcSystem.Models;
using prcSystem.Controllers;
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
    public partial class FormPesquisarCliForn : Form
    {
        Clientes obj = new Clientes();
        Fornecedores objForn = new Fornecedores();

        public FormPesquisarCliForn()
        {
            InitializeComponent();
            ListarForn();//chama a função de ListarForn para inicializar
            ListarCli();//chama a função de ListarCli para inicializar
        }

        /// <summary>
        /// botao de incluir novo cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de clientes.
            FormCadClientes formCadClientes = new FormCadClientes();
            formCadClientes.ShowDialog();
        }

        /// <summary>
        /// botao de incluir novo fornecedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNovoFornecedor_Click(object sender, EventArgs e)
        {
            //criando link para outra pagina de cadastro de forncedores.
            FormCadFornecedoores formCadFornecedoores = new FormCadFornecedoores();
            formCadFornecedoores.ShowDialog();
        }

        /// <summary>
        /// função de listar clientes no datagrid da tela de pesquisar.
        /// </summary>
        private void ListarCli()
        {
            try
            {
                List<Clientes> lista = new List<Clientes>();//datagrid
                lista = new PesquisarModel().ListarCli();
                //dg.AutoGenerateColumns = false;
                 
                //dgPesquisarCliForn.DataSource = listaForn;

                dgPesquisarCli.DataSource = lista;
                dgPesquisarCli.Columns[0].HeaderText = "Cod.";
                dgPesquisarCli.Columns[1].HeaderText = "CPF/CNPJ";
                dgPesquisarCli.Columns[2].HeaderText = "Insc. Est.";
                dgPesquisarCli.Columns[3].HeaderText = "Outras Insc.";
                dgPesquisarCli.Columns[4].HeaderText = "Nome";
                dgPesquisarCli.Columns[5].HeaderText = "Razão Social";
                dgPesquisarCli.Columns[6].HeaderText = "End.";
                dgPesquisarCli.Columns[7].HeaderText = "Nº";
                dgPesquisarCli.Columns[8].HeaderText = "Comple.";
                dgPesquisarCli.Columns[9].HeaderText = "CEP";
                dgPesquisarCli.Columns[10].HeaderText = "Barirro";
                dgPesquisarCli.Columns[11].HeaderText = "Cidade";
                dgPesquisarCli.Columns[12].HeaderText = "UF";
                dgPesquisarCli.Columns[13].HeaderText = "Tel.";
                dgPesquisarCli.Columns[14].HeaderText = "Cel.";
                dgPesquisarCli.Columns[15].HeaderText = "E-mail";
                dgPesquisarCli.Columns[16].HeaderText = "Site";
                dgPesquisarCli.Columns[17].HeaderText = "End. Cob.";
                dgPesquisarCli.Columns[18].HeaderText = "Nº Cob.";
                dgPesquisarCli.Columns[19].HeaderText = "Comple. Cob.";
                dgPesquisarCli.Columns[20].HeaderText = "CEP Cob.";
                dgPesquisarCli.Columns[21].HeaderText = "Bairro Cob.";
                dgPesquisarCli.Columns[22].HeaderText = "Cidade Cob.";
                dgPesquisarCli.Columns[23].HeaderText = "UF Cob.";
                dgPesquisarCli.Columns[24].HeaderText = "Obs.";
                dgPesquisarCli.Columns[25].HeaderText = "Dt Cadastro";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        /// <summary>
        /// função de listar fornecedores no datagrid da tela de pesquisar.
        /// </summary>
        private void ListarForn()
        {
            try
            {
                List<Fornecedores> listaForn = new List<Fornecedores>();//datagrid
                listaForn = new PesquisarModel().ListarForn();
                //dg.AutoGenerateColumns = false;         

                dgPesquisarForn.DataSource = listaForn;
                dgPesquisarForn.Columns[0].HeaderText = "Cod.";
                dgPesquisarForn.Columns[1].HeaderText = "CPF/CNPJ";
                dgPesquisarForn.Columns[2].HeaderText = "Insc. Est.";
                dgPesquisarForn.Columns[3].HeaderText = "Outras Insc.";
                dgPesquisarForn.Columns[4].HeaderText = "Nome";
                dgPesquisarForn.Columns[5].HeaderText = "Razão Social";
                dgPesquisarForn.Columns[6].HeaderText = "End.";
                dgPesquisarForn.Columns[7].HeaderText = "Nº";
                dgPesquisarForn.Columns[8].HeaderText = "Comple.";
                dgPesquisarForn.Columns[9].HeaderText = "CEP";
                dgPesquisarForn.Columns[10].HeaderText = "Barirro";
                dgPesquisarForn.Columns[11].HeaderText = "Cidade";
                dgPesquisarForn.Columns[12].HeaderText = "UF";
                dgPesquisarForn.Columns[13].HeaderText = "Tel.";
                dgPesquisarForn.Columns[14].HeaderText = "Cel.";
                dgPesquisarForn.Columns[15].HeaderText = "E-mail";
                dgPesquisarForn.Columns[16].HeaderText = "Site";
                dgPesquisarForn.Columns[17].HeaderText = "End. Cob.";
                dgPesquisarForn.Columns[18].HeaderText = "Nº Cob.";
                dgPesquisarForn.Columns[19].HeaderText = "Comple. Cob.";
                dgPesquisarForn.Columns[20].HeaderText = "CEP Cob.";
                dgPesquisarForn.Columns[21].HeaderText = "Bairro Cob.";
                dgPesquisarForn.Columns[22].HeaderText = "Cidade Cob.";
                dgPesquisarForn.Columns[23].HeaderText = "UF Cob.";
                dgPesquisarForn.Columns[24].HeaderText = "Obs.";
                dgPesquisarForn.Columns[25].HeaderText = "Dt Cadastro";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        /// <summary>
        /// função de linpar dados da caixa de pesquisa
        /// </summary>
        private void limpar()
        {
            txtPesquisarNomeCliForn.Text = "";//limpa os textbox depois verificados


            txtPesquisarNomeCliForn.Select();////onde o cursor fica inicializada depois de incluir
        }

        /// <summary>
        /// txt pesquisar clientes ou fornecedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesquisarNomeCliForn_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarNomeCliForn.Text == "")
            {
                ListarCli();
                ListarForn();
                limpar();
                return;
            }
            else
            {
                obj.IdCliente = Convert.ToInt32(txtPesquisarNomeCliForn.Text);
                List<Clientes> lista = new List<Clientes>();
                lista = new PesquisarModel().BuscarCli(obj);
                dgPesquisarCli.AutoGenerateColumns = false;
                dgPesquisarCli.DataSource = lista;
            

                objForn.IdFornecedores = Convert.ToInt32(txtPesquisarNomeCliForn.Text);
                List<Fornecedores> listaForn = new List<Fornecedores>();
                listaForn = new PesquisarModel().BuscarForn(objForn);
                dgPesquisarForn.AutoGenerateColumns = false;
                dgPesquisarForn.DataSource = listaForn;
                return;
            }   

        }

    }
}
