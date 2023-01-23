namespace prcSystem.View
{
    partial class FormCadVendedores
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
            this.label3 = new System.Windows.Forms.Label();
            this.DgExibirVendedores = new System.Windows.Forms.DataGridView();
            this.BtnEditarVendedor = new System.Windows.Forms.Button();
            this.BtnSalvarVendedor = new System.Windows.Forms.Button();
            this.BtnExcluirVendedor = new System.Windows.Forms.Button();
            this.BtnLimparVendedor = new System.Windows.Forms.Button();
            this.DtCadastroVendedor = new System.Windows.Forms.DateTimePicker();
            this.TxtIdVendedores = new System.Windows.Forms.TextBox();
            this.LblIdCodVendedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFormCadVendedor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblDtVendedor = new System.Windows.Forms.Label();
            this.LblNomeVendedor = new System.Windows.Forms.Label();
            this.TxtNomeVendedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgExibirVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(439, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 123;
            this.label3.Text = "PRC Systems @";
            // 
            // DgExibirVendedores
            // 
            this.DgExibirVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgExibirVendedores.Location = new System.Drawing.Point(396, 98);
            this.DgExibirVendedores.Name = "DgExibirVendedores";
            this.DgExibirVendedores.RowTemplate.Height = 25;
            this.DgExibirVendedores.Size = new System.Drawing.Size(528, 423);
            this.DgExibirVendedores.TabIndex = 281;
            this.DgExibirVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgExibirVendedores_CellContentClick);
            // 
            // BtnEditarVendedor
            // 
            this.BtnEditarVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditarVendedor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditarVendedor.Location = new System.Drawing.Point(641, 9);
            this.BtnEditarVendedor.Name = "BtnEditarVendedor";
            this.BtnEditarVendedor.Size = new System.Drawing.Size(89, 25);
            this.BtnEditarVendedor.TabIndex = 325;
            this.BtnEditarVendedor.Text = "EDITAR";
            this.BtnEditarVendedor.UseVisualStyleBackColor = false;
            this.BtnEditarVendedor.Click += new System.EventHandler(this.BtnEditarVendedor_Click);
            // 
            // BtnSalvarVendedor
            // 
            this.BtnSalvarVendedor.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalvarVendedor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvarVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalvarVendedor.Location = new System.Drawing.Point(546, 9);
            this.BtnSalvarVendedor.Name = "BtnSalvarVendedor";
            this.BtnSalvarVendedor.Size = new System.Drawing.Size(89, 25);
            this.BtnSalvarVendedor.TabIndex = 324;
            this.BtnSalvarVendedor.Text = "SALVAR";
            this.BtnSalvarVendedor.UseVisualStyleBackColor = false;
            this.BtnSalvarVendedor.Click += new System.EventHandler(this.BtnSalvarVendedor_Click);
            // 
            // BtnExcluirVendedor
            // 
            this.BtnExcluirVendedor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluirVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluirVendedor.Location = new System.Drawing.Point(736, 9);
            this.BtnExcluirVendedor.Name = "BtnExcluirVendedor";
            this.BtnExcluirVendedor.Size = new System.Drawing.Size(89, 25);
            this.BtnExcluirVendedor.TabIndex = 323;
            this.BtnExcluirVendedor.Text = "EXCLUIR";
            this.BtnExcluirVendedor.UseVisualStyleBackColor = false;
            this.BtnExcluirVendedor.Click += new System.EventHandler(this.BtnExcluirVendedor_Click);
            // 
            // BtnLimparVendedor
            // 
            this.BtnLimparVendedor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparVendedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimparVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimparVendedor.Location = new System.Drawing.Point(831, 9);
            this.BtnLimparVendedor.Name = "BtnLimparVendedor";
            this.BtnLimparVendedor.Size = new System.Drawing.Size(89, 25);
            this.BtnLimparVendedor.TabIndex = 322;
            this.BtnLimparVendedor.Text = "LIMPAR";
            this.BtnLimparVendedor.UseVisualStyleBackColor = false;
            this.BtnLimparVendedor.Click += new System.EventHandler(this.BtnLimparVendedor_Click);
            // 
            // DtCadastroVendedor
            // 
            this.DtCadastroVendedor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtCadastroVendedor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCadastroVendedor.Location = new System.Drawing.Point(778, 65);
            this.DtCadastroVendedor.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtCadastroVendedor.Name = "DtCadastroVendedor";
            this.DtCadastroVendedor.Size = new System.Drawing.Size(127, 18);
            this.DtCadastroVendedor.TabIndex = 321;
            this.DtCadastroVendedor.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // TxtIdVendedores
            // 
            this.TxtIdVendedores.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtIdVendedores.Location = new System.Drawing.Point(97, 60);
            this.TxtIdVendedores.Name = "TxtIdVendedores";
            this.TxtIdVendedores.Size = new System.Drawing.Size(100, 18);
            this.TxtIdVendedores.TabIndex = 320;
            // 
            // LblIdCodVendedor
            // 
            this.LblIdCodVendedor.AutoSize = true;
            this.LblIdCodVendedor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdCodVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblIdCodVendedor.Location = new System.Drawing.Point(14, 63);
            this.LblIdCodVendedor.Name = "LblIdCodVendedor";
            this.LblIdCodVendedor.Size = new System.Drawing.Size(83, 12);
            this.LblIdCodVendedor.TabIndex = 319;
            this.LblIdCodVendedor.Text = "COD VENDEDOR.:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 318;
            this.pictureBox1.TabStop = false;
            // 
            // LblFormCadVendedor
            // 
            this.LblFormCadVendedor.AutoSize = true;
            this.LblFormCadVendedor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadVendedor.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadVendedor.Name = "LblFormCadVendedor";
            this.LblFormCadVendedor.Size = new System.Drawing.Size(288, 22);
            this.LblFormCadVendedor.TabIndex = 317;
            this.LblFormCadVendedor.Text = "CADASTRO DE VENDEDORES";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(14, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 316;
            // 
            // LblDtVendedor
            // 
            this.LblDtVendedor.AutoSize = true;
            this.LblDtVendedor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDtVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDtVendedor.Location = new System.Drawing.Point(744, 68);
            this.LblDtVendedor.Name = "LblDtVendedor";
            this.LblDtVendedor.Size = new System.Drawing.Size(32, 12);
            this.LblDtVendedor.TabIndex = 326;
            this.LblDtVendedor.Text = "DATA:";
            // 
            // LblNomeVendedor
            // 
            this.LblNomeVendedor.AutoSize = true;
            this.LblNomeVendedor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomeVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNomeVendedor.Location = new System.Drawing.Point(16, 101);
            this.LblNomeVendedor.Name = "LblNomeVendedor";
            this.LblNomeVendedor.Size = new System.Drawing.Size(89, 12);
            this.LblNomeVendedor.TabIndex = 327;
            this.LblNomeVendedor.Text = "NOME VENDEDOR:";
            // 
            // TxtNomeVendedor
            // 
            this.TxtNomeVendedor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNomeVendedor.Location = new System.Drawing.Point(16, 119);
            this.TxtNomeVendedor.Name = "TxtNomeVendedor";
            this.TxtNomeVendedor.Size = new System.Drawing.Size(270, 18);
            this.TxtNomeVendedor.TabIndex = 328;
            // 
            // FormCadVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.TxtNomeVendedor);
            this.Controls.Add(this.LblNomeVendedor);
            this.Controls.Add(this.LblDtVendedor);
            this.Controls.Add(this.BtnEditarVendedor);
            this.Controls.Add(this.BtnSalvarVendedor);
            this.Controls.Add(this.BtnExcluirVendedor);
            this.Controls.Add(this.BtnLimparVendedor);
            this.Controls.Add(this.DtCadastroVendedor);
            this.Controls.Add(this.TxtIdVendedores);
            this.Controls.Add(this.LblIdCodVendedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblFormCadVendedor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DgExibirVendedores);
            this.Controls.Add(this.label3);
            this.Name = "FormCadVendedores";
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.DgExibirVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DataGridView DgExibirVendedores;
        private Button BtnEditarVendedor;
        private Button BtnSalvarVendedor;
        private Button BtnExcluirVendedor;
        private Button BtnLimparVendedor;
        private DateTimePicker DtCadastroVendedor;
        private TextBox TxtIdVendedores;
        private Label LblIdCodVendedor;
        private PictureBox pictureBox1;
        private Label LblFormCadVendedor;
        private TextBox textBox1;
        private Label LblDtVendedor;
        private Label label1;
        private Label LblNomeVendedor;
        private TextBox TxtNomeVendedor;
    }
}