namespace prcSystem.View
{
    partial class FormCadCDC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtCadastroCdc = new System.Windows.Forms.DateTimePicker();
            this.LblDtCdc = new System.Windows.Forms.Label();
            this.TxtCodCdc = new System.Windows.Forms.TextBox();
            this.LblCodCdc = new System.Windows.Forms.Label();
            this.BtnSalvarCdc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblFormCadCdc = new System.Windows.Forms.Label();
            this.TxtDescricaoCdc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCadCdc = new System.Windows.Forms.DataGridView();
            this.BtnLimparCdc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadCdc)).BeginInit();
            this.SuspendLayout();
            // 
            // DtCadastroCdc
            // 
            this.DtCadastroCdc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCadastroCdc.Location = new System.Drawing.Point(722, 60);
            this.DtCadastroCdc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtCadastroCdc.Name = "DtCadastroCdc";
            this.DtCadastroCdc.Size = new System.Drawing.Size(127, 23);
            this.DtCadastroCdc.TabIndex = 67;
            this.DtCadastroCdc.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // LblDtCdc
            // 
            this.LblDtCdc.AutoSize = true;
            this.LblDtCdc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDtCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDtCdc.Location = new System.Drawing.Point(676, 65);
            this.LblDtCdc.Name = "LblDtCdc";
            this.LblDtCdc.Size = new System.Drawing.Size(42, 14);
            this.LblDtCdc.TabIndex = 66;
            this.LblDtCdc.Text = "DATA:";
            // 
            // TxtCodCdc
            // 
            this.TxtCodCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodCdc.Location = new System.Drawing.Point(84, 82);
            this.TxtCodCdc.Name = "TxtCodCdc";
            this.TxtCodCdc.Size = new System.Drawing.Size(100, 18);
            this.TxtCodCdc.TabIndex = 65;
            // 
            // LblCodCdc
            // 
            this.LblCodCdc.AutoSize = true;
            this.LblCodCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCodCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCodCdc.Location = new System.Drawing.Point(12, 85);
            this.LblCodCdc.Name = "LblCodCdc";
            this.LblCodCdc.Size = new System.Drawing.Size(69, 12);
            this.LblCodCdc.TabIndex = 64;
            this.LblCodCdc.Text = "CODIGO CDC:";
            // 
            // BtnSalvarCdc
            // 
            this.BtnSalvarCdc.BackColor = System.Drawing.SystemColors.Menu;
            this.BtnSalvarCdc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvarCdc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSalvarCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSalvarCdc.Location = new System.Drawing.Point(854, 12);
            this.BtnSalvarCdc.Name = "BtnSalvarCdc";
            this.BtnSalvarCdc.Size = new System.Drawing.Size(68, 23);
            this.BtnSalvarCdc.TabIndex = 63;
            this.BtnSalvarCdc.Text = "SALVAR";
            this.BtnSalvarCdc.UseVisualStyleBackColor = false;
            this.BtnSalvarCdc.Click += new System.EventHandler(this.BtnSalvarCdc_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 61;
            // 
            // LblFormCadCdc
            // 
            this.LblFormCadCdc.AutoSize = true;
            this.LblFormCadCdc.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadCdc.Location = new System.Drawing.Point(12, 9);
            this.LblFormCadCdc.Name = "LblFormCadCdc";
            this.LblFormCadCdc.Size = new System.Drawing.Size(179, 23);
            this.LblFormCadCdc.TabIndex = 69;
            this.LblFormCadCdc.Text = "CADASTRO CDC";
            // 
            // TxtDescricaoCdc
            // 
            this.TxtDescricaoCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescricaoCdc.Location = new System.Drawing.Point(84, 105);
            this.TxtDescricaoCdc.Name = "TxtDescricaoCdc";
            this.TxtDescricaoCdc.Size = new System.Drawing.Size(358, 18);
            this.TxtDescricaoCdc.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "DESCRIÇÃO:";
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
            this.label3.TabIndex = 72;
            this.label3.Text = "PRC Systems @";
            // 
            // dgCadCdc
            // 
            this.dgCadCdc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCadCdc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCadCdc.Location = new System.Drawing.Point(12, 172);
            this.dgCadCdc.Name = "dgCadCdc";
            this.dgCadCdc.RowTemplate.Height = 25;
            this.dgCadCdc.Size = new System.Drawing.Size(910, 309);
            this.dgCadCdc.TabIndex = 76;
            this.dgCadCdc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadCdc_CellClick);
            this.dgCadCdc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgCadCdc_MouseDoubleClick);
            // 
            // BtnLimparCdc
            // 
            this.BtnLimparCdc.BackColor = System.Drawing.SystemColors.Menu;
            this.BtnLimparCdc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparCdc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimparCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimparCdc.Location = new System.Drawing.Point(780, 12);
            this.BtnLimparCdc.Name = "BtnLimparCdc";
            this.BtnLimparCdc.Size = new System.Drawing.Size(68, 23);
            this.BtnLimparCdc.TabIndex = 292;
            this.BtnLimparCdc.Text = "LIMPAR";
            this.BtnLimparCdc.UseVisualStyleBackColor = false;
            this.BtnLimparCdc.Click += new System.EventHandler(this.BtnLimparCdc_Click);
            // 
            // FormCadCDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.BtnLimparCdc);
            this.Controls.Add(this.dgCadCdc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescricaoCdc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFormCadCdc);
            this.Controls.Add(this.DtCadastroCdc);
            this.Controls.Add(this.LblDtCdc);
            this.Controls.Add(this.TxtCodCdc);
            this.Controls.Add(this.LblCodCdc);
            this.Controls.Add(this.BtnSalvarCdc);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadCDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systms";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadCdc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker DtCadastroCdc;
        private Label LblDtCdc;
        private TextBox TxtIdCdc;
        private Label LblIdCodCli;
        private Button BtnSalvarCdc;
        private TextBox textBox1;
        private Label LblFormCadCdc;
        private TextBox TxtDescricaoCdc;
        private Label label1;
        private Label label3;
        private TextBox TxtCodCdc;
        private Label LblCodCdc;
        private DataGridView dgCadCdc;
        private Button BtnLimparCdc;
    }
}