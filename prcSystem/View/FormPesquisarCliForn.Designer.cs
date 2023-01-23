namespace prcSystem.View
{
    partial class FormPesquisarCliForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarCliForn));
            this.BtnNovoCliente = new System.Windows.Forms.Button();
            this.BtnCancelarProduto = new System.Windows.Forms.Button();
            this.LblFormCadpRO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExibirProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarNomeCliForn = new System.Windows.Forms.TextBox();
            this.dgPesquisarCli = new System.Windows.Forms.DataGridView();
            this.dgPesquisarForn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNovoFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoCliente
            // 
            this.BtnNovoCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNovoCliente.Location = new System.Drawing.Point(9, 490);
            this.BtnNovoCliente.Name = "BtnNovoCliente";
            this.BtnNovoCliente.Size = new System.Drawing.Size(54, 25);
            this.BtnNovoCliente.TabIndex = 84;
            this.BtnNovoCliente.Text = " NOVO";
            this.BtnNovoCliente.UseVisualStyleBackColor = true;
            this.BtnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // BtnCancelarProduto
            // 
            this.BtnCancelarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancelarProduto.Location = new System.Drawing.Point(842, 12);
            this.BtnCancelarProduto.Name = "BtnCancelarProduto";
            this.BtnCancelarProduto.Size = new System.Drawing.Size(80, 25);
            this.BtnCancelarProduto.TabIndex = 82;
            this.BtnCancelarProduto.Text = "LIMPAR";
            this.BtnCancelarProduto.UseVisualStyleBackColor = true;
            // 
            // LblFormCadpRO
            // 
            this.LblFormCadpRO.AutoSize = true;
            this.LblFormCadpRO.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadpRO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadpRO.Location = new System.Drawing.Point(10, 10);
            this.LblFormCadpRO.Name = "LblFormCadpRO";
            this.LblFormCadpRO.Size = new System.Drawing.Size(455, 23);
            this.LblFormCadpRO.TabIndex = 81;
            this.LblFormCadpRO.Text = "PESQUISA DE CLIENTES/FORNECEDORES";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 80;
            // 
            // BtnExibirProduto
            // 
            this.BtnExibirProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExibirProduto.Location = new System.Drawing.Point(407, 63);
            this.BtnExibirProduto.Name = "BtnExibirProduto";
            this.BtnExibirProduto.Size = new System.Drawing.Size(89, 25);
            this.BtnExibirProduto.TabIndex = 88;
            this.BtnExibirProduto.Text = "PESQUISAR";
            this.BtnExibirProduto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Nome:";
            // 
            // txtPesquisarNomeCliForn
            // 
            this.txtPesquisarNomeCliForn.Location = new System.Drawing.Point(70, 64);
            this.txtPesquisarNomeCliForn.Name = "txtPesquisarNomeCliForn";
            this.txtPesquisarNomeCliForn.Size = new System.Drawing.Size(300, 23);
            this.txtPesquisarNomeCliForn.TabIndex = 90;
            this.txtPesquisarNomeCliForn.TextChanged += new System.EventHandler(this.txtPesquisarNomeCliForn_TextChanged);
            // 
            // dgPesquisarCli
            // 
            this.dgPesquisarCli.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgPesquisarCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisarCli.Location = new System.Drawing.Point(10, 141);
            this.dgPesquisarCli.Name = "dgPesquisarCli";
            this.dgPesquisarCli.RowTemplate.Height = 25;
            this.dgPesquisarCli.Size = new System.Drawing.Size(444, 343);
            this.dgPesquisarCli.TabIndex = 93;
            // 
            // dgPesquisarForn
            // 
            this.dgPesquisarForn.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgPesquisarForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisarForn.Location = new System.Drawing.Point(479, 141);
            this.dgPesquisarForn.Name = "dgPesquisarForn";
            this.dgPesquisarForn.RowTemplate.Height = 25;
            this.dgPesquisarForn.Size = new System.Drawing.Size(444, 343);
            this.dgPesquisarForn.TabIndex = 94;
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
            this.label3.TabIndex = 95;
            this.label3.Text = "PRC Systems @";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(479, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Fornecedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // BtnNovoFornecedor
            // 
            this.BtnNovoFornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNovoFornecedor.Location = new System.Drawing.Point(479, 490);
            this.BtnNovoFornecedor.Name = "BtnNovoFornecedor";
            this.BtnNovoFornecedor.Size = new System.Drawing.Size(54, 25);
            this.BtnNovoFornecedor.TabIndex = 99;
            this.BtnNovoFornecedor.Text = " NOVO";
            this.BtnNovoFornecedor.UseVisualStyleBackColor = true;
            this.BtnNovoFornecedor.Click += new System.EventHandler(this.BtnNovoFornecedor_Click);
            // 
            // FormPesquisarCliForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.BtnNovoFornecedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgPesquisarForn);
            this.Controls.Add(this.dgPesquisarCli);
            this.Controls.Add(this.txtPesquisarNomeCliForn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExibirProduto);
            this.Controls.Add(this.BtnNovoCliente);
            this.Controls.Add(this.BtnCancelarProduto);
            this.Controls.Add(this.LblFormCadpRO);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPesquisarCliForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnNovoCliente;
        private Button BtnCancelarProduto;
        private Label LblFormCadpRO;
        private TextBox textBox1;
        private Button BtnExibirProduto;
        private Label label1;
        private TextBox txtPesquisarNomeCliForn;
        private DataGridView dgPesquisarCli;
        private DataGridView dgPesquisarForn;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Button BtnNovoFornecedor;
    }
}