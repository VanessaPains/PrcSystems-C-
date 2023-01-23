namespace prcSystem.View
{
    partial class FormCadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnLimparProduto = new System.Windows.Forms.Button();
            this.BtnSalvarProduto = new System.Windows.Forms.Button();
            this.BtnEditarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIdProduto = new System.Windows.Forms.Label();
            this.LblDescProduto = new System.Windows.Forms.Label();
            this.LblUnidadeProduto = new System.Windows.Forms.Label();
            this.LblValorProduto = new System.Windows.Forms.Label();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.TxtDescProduto = new System.Windows.Forms.TextBox();
            this.TxtUnidadeProduto = new System.Windows.Forms.TextBox();
            this.TxtValorProduto = new System.Windows.Forms.TextBox();
            this.LblMarcaProduto = new System.Windows.Forms.Label();
            this.TxtMarcaProduto = new System.Windows.Forms.TextBox();
            this.dgExibirProdutos = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblFormCadpRO = new System.Windows.Forms.Label();
            this.BtnExcluirProduto = new System.Windows.Forms.Button();
            this.DtCadastroProduto = new System.Windows.Forms.DateTimePicker();
            this.LblDtCadastroCli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgExibirProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimparProduto
            // 
            this.BtnLimparProduto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimparProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimparProduto.Location = new System.Drawing.Point(831, 9);
            this.BtnLimparProduto.Name = "BtnLimparProduto";
            this.BtnLimparProduto.Size = new System.Drawing.Size(89, 25);
            this.BtnLimparProduto.TabIndex = 92;
            this.BtnLimparProduto.Text = "LIMPAR";
            this.BtnLimparProduto.UseVisualStyleBackColor = false;
            this.BtnLimparProduto.Click += new System.EventHandler(this.BtnLimparProduto_Click);
            // 
            // BtnSalvarProduto
            // 
            this.BtnSalvarProduto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvarProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalvarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSalvarProduto.Location = new System.Drawing.Point(546, 9);
            this.BtnSalvarProduto.Name = "BtnSalvarProduto";
            this.BtnSalvarProduto.Size = new System.Drawing.Size(89, 25);
            this.BtnSalvarProduto.TabIndex = 93;
            this.BtnSalvarProduto.Text = "SALVAR";
            this.BtnSalvarProduto.UseVisualStyleBackColor = false;
            this.BtnSalvarProduto.Click += new System.EventHandler(this.BtnSalvarProduto_Click);
            // 
            // BtnEditarProduto
            // 
            this.BtnEditarProduto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEditarProduto.Location = new System.Drawing.Point(641, 9);
            this.BtnEditarProduto.Name = "BtnEditarProduto";
            this.BtnEditarProduto.Size = new System.Drawing.Size(89, 25);
            this.BtnEditarProduto.TabIndex = 95;
            this.BtnEditarProduto.Text = "EDITAR";
            this.BtnEditarProduto.UseVisualStyleBackColor = false;
            this.BtnEditarProduto.Click += new System.EventHandler(this.BtnEditarProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(437, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 91;
            this.label3.Text = "PRC Systems @";
            // 
            // LblIdProduto
            // 
            this.LblIdProduto.AutoSize = true;
            this.LblIdProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdProduto.Location = new System.Drawing.Point(28, 68);
            this.LblIdProduto.Name = "LblIdProduto";
            this.LblIdProduto.Size = new System.Drawing.Size(77, 12);
            this.LblIdProduto.TabIndex = 80;
            this.LblIdProduto.Text = "COD. PRODUTO:";
            // 
            // LblDescProduto
            // 
            this.LblDescProduto.AutoSize = true;
            this.LblDescProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDescProduto.Location = new System.Drawing.Point(28, 103);
            this.LblDescProduto.Name = "LblDescProduto";
            this.LblDescProduto.Size = new System.Drawing.Size(124, 12);
            this.LblDescProduto.TabIndex = 81;
            this.LblDescProduto.Text = "DESCRIÇÃO DO PRODUTO:";
            // 
            // LblUnidadeProduto
            // 
            this.LblUnidadeProduto.AutoSize = true;
            this.LblUnidadeProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUnidadeProduto.Location = new System.Drawing.Point(349, 124);
            this.LblUnidadeProduto.Name = "LblUnidadeProduto";
            this.LblUnidadeProduto.Size = new System.Drawing.Size(98, 12);
            this.LblUnidadeProduto.TabIndex = 82;
            this.LblUnidadeProduto.Text = "UNIDADE PRODUTO:";
            // 
            // LblValorProduto
            // 
            this.LblValorProduto.AutoSize = true;
            this.LblValorProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblValorProduto.Location = new System.Drawing.Point(65, 146);
            this.LblValorProduto.Name = "LblValorProduto";
            this.LblValorProduto.Size = new System.Drawing.Size(87, 12);
            this.LblValorProduto.TabIndex = 83;
            this.LblValorProduto.Text = "VALOR PRODUTO:";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIdProduto.Location = new System.Drawing.Point(108, 65);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(111, 18);
            this.TxtIdProduto.TabIndex = 84;
            // 
            // TxtDescProduto
            // 
            this.TxtDescProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescProduto.Location = new System.Drawing.Point(153, 101);
            this.TxtDescProduto.Name = "TxtDescProduto";
            this.TxtDescProduto.Size = new System.Drawing.Size(615, 18);
            this.TxtDescProduto.TabIndex = 85;
            // 
            // TxtUnidadeProduto
            // 
            this.TxtUnidadeProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUnidadeProduto.Location = new System.Drawing.Point(450, 121);
            this.TxtUnidadeProduto.Name = "TxtUnidadeProduto";
            this.TxtUnidadeProduto.Size = new System.Drawing.Size(111, 18);
            this.TxtUnidadeProduto.TabIndex = 86;
            // 
            // TxtValorProduto
            // 
            this.TxtValorProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValorProduto.Location = new System.Drawing.Point(153, 141);
            this.TxtValorProduto.Name = "TxtValorProduto";
            this.TxtValorProduto.Size = new System.Drawing.Size(111, 18);
            this.TxtValorProduto.TabIndex = 87;
            // 
            // LblMarcaProduto
            // 
            this.LblMarcaProduto.AutoSize = true;
            this.LblMarcaProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMarcaProduto.Location = new System.Drawing.Point(109, 124);
            this.LblMarcaProduto.Name = "LblMarcaProduto";
            this.LblMarcaProduto.Size = new System.Drawing.Size(44, 12);
            this.LblMarcaProduto.TabIndex = 88;
            this.LblMarcaProduto.Text = "MARCA:";
            // 
            // TxtMarcaProduto
            // 
            this.TxtMarcaProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMarcaProduto.Location = new System.Drawing.Point(153, 121);
            this.TxtMarcaProduto.Name = "TxtMarcaProduto";
            this.TxtMarcaProduto.Size = new System.Drawing.Size(181, 18);
            this.TxtMarcaProduto.TabIndex = 89;
            // 
            // dgExibirProdutos
            // 
            this.dgExibirProdutos.AllowUserToAddRows = false;
            this.dgExibirProdutos.AllowUserToDeleteRows = false;
            this.dgExibirProdutos.AutoGenerateColumns = false;
            this.dgExibirProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExibirProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.descProdutoDataGridViewTextBoxColumn,
            this.marcaProdutoDataGridViewTextBoxColumn,
            this.unidadeProdutoDataGridViewTextBoxColumn,
            this.valorProdutoDataGridViewTextBoxColumn,
            this.dtCadastroProdutoDataGridViewTextBoxColumn});
            this.dgExibirProdutos.DataSource = this.produtosBindingSource;
            this.dgExibirProdutos.Location = new System.Drawing.Point(28, 186);
            this.dgExibirProdutos.Name = "dgExibirProdutos";
            this.dgExibirProdutos.ReadOnly = true;
            this.dgExibirProdutos.RowTemplate.Height = 25;
            this.dgExibirProdutos.Size = new System.Drawing.Size(877, 296);
            this.dgExibirProdutos.TabIndex = 90;
            this.dgExibirProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExibirProdutos_CellClick);
            this.dgExibirProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgExibirProdutos_MouseDoubleClick);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 45;
            // 
            // descProdutoDataGridViewTextBoxColumn
            // 
            this.descProdutoDataGridViewTextBoxColumn.DataPropertyName = "DescProduto";
            this.descProdutoDataGridViewTextBoxColumn.HeaderText = "DescProduto";
            this.descProdutoDataGridViewTextBoxColumn.Name = "descProdutoDataGridViewTextBoxColumn";
            this.descProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descProdutoDataGridViewTextBoxColumn.Width = 380;
            // 
            // marcaProdutoDataGridViewTextBoxColumn
            // 
            this.marcaProdutoDataGridViewTextBoxColumn.DataPropertyName = "MarcaProduto";
            this.marcaProdutoDataGridViewTextBoxColumn.HeaderText = "MarcaProduto";
            this.marcaProdutoDataGridViewTextBoxColumn.Name = "marcaProdutoDataGridViewTextBoxColumn";
            this.marcaProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaProdutoDataGridViewTextBoxColumn.Width = 149;
            // 
            // unidadeProdutoDataGridViewTextBoxColumn
            // 
            this.unidadeProdutoDataGridViewTextBoxColumn.DataPropertyName = "UnidadeProduto";
            this.unidadeProdutoDataGridViewTextBoxColumn.HeaderText = "UnidadeProduto";
            this.unidadeProdutoDataGridViewTextBoxColumn.Name = "unidadeProdutoDataGridViewTextBoxColumn";
            this.unidadeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeProdutoDataGridViewTextBoxColumn.Width = 60;
            // 
            // valorProdutoDataGridViewTextBoxColumn
            // 
            this.valorProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorProduto";
            this.valorProdutoDataGridViewTextBoxColumn.HeaderText = "ValorProduto";
            this.valorProdutoDataGridViewTextBoxColumn.Name = "valorProdutoDataGridViewTextBoxColumn";
            this.valorProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtCadastroProdutoDataGridViewTextBoxColumn
            // 
            this.dtCadastroProdutoDataGridViewTextBoxColumn.DataPropertyName = "DtCadastroProduto";
            this.dtCadastroProdutoDataGridViewTextBoxColumn.HeaderText = "DtCadastroProduto";
            this.dtCadastroProdutoDataGridViewTextBoxColumn.Name = "dtCadastroProdutoDataGridViewTextBoxColumn";
            this.dtCadastroProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(prcSystem.Entidades.Produtos);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 60;
            // 
            // LblFormCadpRO
            // 
            this.LblFormCadpRO.AutoSize = true;
            this.LblFormCadpRO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadpRO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadpRO.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadpRO.Name = "LblFormCadpRO";
            this.LblFormCadpRO.Size = new System.Drawing.Size(261, 22);
            this.LblFormCadpRO.TabIndex = 61;
            this.LblFormCadpRO.Text = "CADASTRO DE PRODUTOS";
            // 
            // BtnExcluirProduto
            // 
            this.BtnExcluirProduto.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluirProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluirProduto.Location = new System.Drawing.Point(736, 9);
            this.BtnExcluirProduto.Name = "BtnExcluirProduto";
            this.BtnExcluirProduto.Size = new System.Drawing.Size(89, 25);
            this.BtnExcluirProduto.TabIndex = 96;
            this.BtnExcluirProduto.Text = "EXCLUIR";
            this.BtnExcluirProduto.UseVisualStyleBackColor = false;
            this.BtnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // DtCadastroProduto
            // 
            this.DtCadastroProduto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtCadastroProduto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCadastroProduto.Location = new System.Drawing.Point(778, 65);
            this.DtCadastroProduto.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtCadastroProduto.Name = "DtCadastroProduto";
            this.DtCadastroProduto.Size = new System.Drawing.Size(127, 18);
            this.DtCadastroProduto.TabIndex = 264;
            this.DtCadastroProduto.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // LblDtCadastroCli
            // 
            this.LblDtCadastroCli.AutoSize = true;
            this.LblDtCadastroCli.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDtCadastroCli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDtCadastroCli.Location = new System.Drawing.Point(744, 68);
            this.LblDtCadastroCli.Name = "LblDtCadastroCli";
            this.LblDtCadastroCli.Size = new System.Drawing.Size(32, 12);
            this.LblDtCadastroCli.TabIndex = 263;
            this.LblDtCadastroCli.Text = "DATA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 265;
            this.pictureBox1.TabStop = false;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(prcSystem.Entidades.Funcionarios);
            // 
            // FormCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtCadastroProduto);
            this.Controls.Add(this.LblDtCadastroCli);
            this.Controls.Add(this.BtnExcluirProduto);
            this.Controls.Add(this.BtnEditarProduto);
            this.Controls.Add(this.BtnSalvarProduto);
            this.Controls.Add(this.BtnLimparProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgExibirProdutos);
            this.Controls.Add(this.TxtMarcaProduto);
            this.Controls.Add(this.LblMarcaProduto);
            this.Controls.Add(this.TxtValorProduto);
            this.Controls.Add(this.TxtUnidadeProduto);
            this.Controls.Add(this.TxtDescProduto);
            this.Controls.Add(this.TxtIdProduto);
            this.Controls.Add(this.LblValorProduto);
            this.Controls.Add(this.LblUnidadeProduto);
            this.Controls.Add(this.LblDescProduto);
            this.Controls.Add(this.LblIdProduto);
            this.Controls.Add(this.LblFormCadpRO);
            this.Controls.Add(this.textBox1);
            this.Name = "FormCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systens";
            this.Load += new System.EventHandler(this.FormCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgExibirProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnLimparProduto;
        private Button BtnSalvarProduto;
        private Button BtnEditarProduto;
        private Label label3;
        private Label LblIdProduto;
        private Label LblDescProduto;
        private Label LblUnidadeProduto;
        private Label LblValorProduto;
        private TextBox TxtIdProduto;
        private TextBox TxtDescProduto;
        private TextBox TxtUnidadeProduto;
        private TextBox TxtValorProduto;
        private Label LblMarcaProduto;
        private TextBox TxtMarcaProduto;
        private DataGridView dgExibirProdutos;
        private TextBox textBox1;
        private Label LblFormCadpRO;
        private Button BtnExcluirProduto;
        private DateTimePicker DtCadastroProduto;
        private Label LblDtCadastroCli;
        private PictureBox pictureBox1;
        private BindingSource produtosBindingSource;
        private BindingSource funcionariosBindingSource;
        private DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtCadastroProdutoDataGridViewTextBoxColumn;
    }
}