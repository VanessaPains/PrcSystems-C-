using prcSystem.Entidades;
using prcSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace prcSystem.View
{
    public partial class FormCadCDC : Form
    {
        Cdc obj = new Cdc();

        public FormCadCDC()
        {
            InitializeComponent();
            DtCadastroCdc.Value = DateTime.Now;
            Listar();

        }

        private void BtnSalvarCdc_Click(object sender, EventArgs e)
        {
            //verifica se todos os campos estao preenchidos
            if (TxtDescricaoCdc.Text == "" || TxtCodCdc.Text == "")
            {
                MessageBox.Show("Preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDescricaoCdc.Select();//colocar curso em login por padrao
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
                obj.CodCdc = Convert.ToString(TxtCodCdc.Text);
                obj.DescricaoCdc = Convert.ToString(TxtDescricaoCdc.Text);
                obj.DtCadastroCdc = Convert.ToDateTime(DtCadastroCdc.Text);

                int x = CdcModel.Inserir(obj);
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

        private void limpar()
        {
            TxtCodCdc.Text = "";
            TxtDescricaoCdc.Text = "";//limpa os textbox depois verificados        
            DtCadastroCdc.Text = "";

            TxtDescricaoCdc.Select();////onde o cursor fica inicializada depois de incluir
        }

        private void BtnCancelarCdc_Click(object sender, EventArgs e)
        {
            limpar();
        }


        private void Listar()
        {
            try
            {
                List<Cdc> lista = new List<Cdc>();//datagrid
                lista = new CdcModel().Listar();
                //dg.AutoGenerateColumns = false;

                dgCadCdc.DataSource = lista;
                // dg.Columns[0].Visible = false;//colunas datagrid
                dgCadCdc.Columns[0].HeaderText = "Item";
                dgCadCdc.Columns[1].HeaderText = "Cod.";
                dgCadCdc.Columns[2].HeaderText = "Descrição";
                dgCadCdc.Columns[3].HeaderText = "Data";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel listar os dados" + ex);
            }
        }

        private void HabibilitarCampos()
        {
            TxtCodCdc.Enabled = true;
            TxtDescricaoCdc.Enabled = true;
            DtCadastroCdc.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            TxtCodCdc.Enabled = false;
            TxtDescricaoCdc.Enabled = false;
            DtCadastroCdc.Enabled = false;
        }

        

        private void dgCadCdc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgCadCdc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //criando link para outra pagina de cadastro de
            //.
            FormCadCDCAlterar formCadCDCAlterar = new FormCadCDCAlterar();
            formCadCDCAlterar.ShowDialog();
            HabibilitarCampos();
            
        }

        private void dgCadCdc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabibilitarCampos();
          
        }

        private void BtnLimparCdc_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
