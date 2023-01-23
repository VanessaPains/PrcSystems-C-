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

namespace prcSystem.View
{
    public partial class FormCadCliFornPesquisar : Form
    {
        Pessoa obj = new Pessoa();
        

        public FormCadCliFornPesquisar()
        {
          

            InitializeComponent();
            

           
        }

        private void Listar()
        {
            try
            {
                List<Pessoa> lista = new List<Pessoa>();//datagrid
                lista = new PessoaModel().Listar();
                //dg.AutoGenerateColumns = false;

                DgExibirCliForn.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid

                DgExibirCliForn.Columns[0].HeaderText = "Cod. Forn/Cli.";
                DgExibirCliForn.Columns[1].HeaderText = "Tipo";
                DgExibirCliForn.Columns[2].HeaderText = "Pessoa";
                DgExibirCliForn.Columns[3].HeaderText = "Cnpj/Cpf";
                DgExibirCliForn.Columns[4].HeaderText = "Razão/Nome.";
                DgExibirCliForn.Columns[5].HeaderText = "Fantasia";
                DgExibirCliForn.Columns[6].HeaderText = "IE";
                DgExibirCliForn.Columns[7].HeaderText = "Outras Insc.";
                DgExibirCliForn.Columns[8].HeaderText = "End.";
                DgExibirCliForn.Columns[9].HeaderText = "Comple.";
                DgExibirCliForn.Columns[10].HeaderText = "Num.";
                DgExibirCliForn.Columns[11].HeaderText = "Comple.";
                DgExibirCliForn.Columns[12].HeaderText = "Cep";
                DgExibirCliForn.Columns[13].HeaderText = "Bairro";
                DgExibirCliForn.Columns[14].HeaderText = "Cidade";
                DgExibirCliForn.Columns[15].HeaderText = "UF";
                DgExibirCliForn.Columns[16].HeaderText = "Telefone";
                DgExibirCliForn.Columns[17].HeaderText = "Celular.";
                DgExibirCliForn.Columns[18].HeaderText = "Email";
                DgExibirCliForn.Columns[19].HeaderText = "Site";
                DgExibirCliForn.Columns[20].HeaderText = "End Cob.";
                DgExibirCliForn.Columns[21].HeaderText = "Num Cob.";
                DgExibirCliForn.Columns[22].HeaderText = "Compl Cob.";
                DgExibirCliForn.Columns[23].HeaderText = "Cep Cob";
                DgExibirCliForn.Columns[24].HeaderText = "Bairro Cob.";
                DgExibirCliForn.Columns[25].HeaderText = "Cidade Cob.";
                DgExibirCliForn.Columns[26].HeaderText = "UF Cob";
                DgExibirCliForn.Columns[26].HeaderText = "Observação";
                DgExibirCliForn.Columns[26].HeaderText = "DT Cad.";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        
        private void DgExibirCliForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
