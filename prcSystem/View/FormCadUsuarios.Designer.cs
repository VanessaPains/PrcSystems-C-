namespace prcSystem.View
{
    partial class FormCadUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTelaCadUsuarioLogin = new System.Windows.Forms.TextBox();
            this.TxtTelaCadUsuarioSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExcluirCadUser = new System.Windows.Forms.Button();
            this.BtnLimparCadUser = new System.Windows.Forms.Button();
            this.LblFormCadpRO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgExibirUser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelaCadUsuarioCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtCadastroUser = new System.Windows.Forms.DateTimePicker();
            this.LblDtCadastroCli = new System.Windows.Forms.Label();
            this.TxtTelaCadUsuarioNomeUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnTelaLoginSalvar = new System.Windows.Forms.Button();
            this.BtnEditarCadUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExibirUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // TxtTelaCadUsuarioLogin
            // 
            this.TxtTelaCadUsuarioLogin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelaCadUsuarioLogin.Location = new System.Drawing.Point(135, 157);
            this.TxtTelaCadUsuarioLogin.Name = "TxtTelaCadUsuarioLogin";
            this.TxtTelaCadUsuarioLogin.Size = new System.Drawing.Size(205, 20);
            this.TxtTelaCadUsuarioLogin.TabIndex = 1;
            // 
            // TxtTelaCadUsuarioSenha
            // 
            this.TxtTelaCadUsuarioSenha.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelaCadUsuarioSenha.Location = new System.Drawing.Point(135, 180);
            this.TxtTelaCadUsuarioSenha.Name = "TxtTelaCadUsuarioSenha";
            this.TxtTelaCadUsuarioSenha.Size = new System.Drawing.Size(205, 20);
            this.TxtTelaCadUsuarioSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA";
            // 
            // BtnExcluirCadUser
            // 
            this.BtnExcluirCadUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirCadUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluirCadUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluirCadUser.Location = new System.Drawing.Point(736, 9);
            this.BtnExcluirCadUser.Name = "BtnExcluirCadUser";
            this.BtnExcluirCadUser.Size = new System.Drawing.Size(89, 25);
            this.BtnExcluirCadUser.TabIndex = 102;
            this.BtnExcluirCadUser.Text = "EXCLUIR";
            this.BtnExcluirCadUser.UseVisualStyleBackColor = false;
            this.BtnExcluirCadUser.Click += new System.EventHandler(this.BtnExcluirCadUser_Click);
            // 
            // BtnLimparCadUser
            // 
            this.BtnLimparCadUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparCadUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimparCadUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimparCadUser.Location = new System.Drawing.Point(831, 9);
            this.BtnLimparCadUser.Name = "BtnLimparCadUser";
            this.BtnLimparCadUser.Size = new System.Drawing.Size(89, 25);
            this.BtnLimparCadUser.TabIndex = 99;
            this.BtnLimparCadUser.Text = "LIMPAR";
            this.BtnLimparCadUser.UseVisualStyleBackColor = false;
            this.BtnLimparCadUser.Click += new System.EventHandler(this.BtnLimparCadUser_Click);
            // 
            // LblFormCadpRO
            // 
            this.LblFormCadpRO.AutoSize = true;
            this.LblFormCadpRO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadpRO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadpRO.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadpRO.Name = "LblFormCadpRO";
            this.LblFormCadpRO.Size = new System.Drawing.Size(251, 22);
            this.LblFormCadpRO.TabIndex = 98;
            this.LblFormCadpRO.Text = "CADASTRO DE USUÁRIOS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(10, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 97;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // dgExibirUser
            // 
            this.dgExibirUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExibirUser.Location = new System.Drawing.Point(362, 134);
            this.dgExibirUser.Name = "dgExibirUser";
            this.dgExibirUser.RowTemplate.Height = 25;
            this.dgExibirUser.Size = new System.Drawing.Size(558, 378);
            this.dgExibirUser.TabIndex = 130;
            this.dgExibirUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExibirUser_CellClick);
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
            this.label3.TabIndex = 131;
            this.label3.Text = "PRC Systems @";
            // 
            // TxtTelaCadUsuarioCod
            // 
            this.TxtTelaCadUsuarioCod.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelaCadUsuarioCod.Location = new System.Drawing.Point(95, 82);
            this.TxtTelaCadUsuarioCod.Name = "TxtTelaCadUsuarioCod";
            this.TxtTelaCadUsuarioCod.Size = new System.Drawing.Size(57, 20);
            this.TxtTelaCadUsuarioCod.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "COD. USER.";
            // 
            // DtCadastroUser
            // 
            this.DtCadastroUser.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtCadastroUser.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtCadastroUser.Location = new System.Drawing.Point(778, 65);
            this.DtCadastroUser.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtCadastroUser.Name = "DtCadastroUser";
            this.DtCadastroUser.Size = new System.Drawing.Size(127, 18);
            this.DtCadastroUser.TabIndex = 262;
            this.DtCadastroUser.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // LblDtCadastroCli
            // 
            this.LblDtCadastroCli.AutoSize = true;
            this.LblDtCadastroCli.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDtCadastroCli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDtCadastroCli.Location = new System.Drawing.Point(744, 68);
            this.LblDtCadastroCli.Name = "LblDtCadastroCli";
            this.LblDtCadastroCli.Size = new System.Drawing.Size(32, 12);
            this.LblDtCadastroCli.TabIndex = 261;
            this.LblDtCadastroCli.Text = "DATA:";
            // 
            // TxtTelaCadUsuarioNomeUser
            // 
            this.TxtTelaCadUsuarioNomeUser.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTelaCadUsuarioNomeUser.Location = new System.Drawing.Point(135, 134);
            this.TxtTelaCadUsuarioNomeUser.Name = "TxtTelaCadUsuarioNomeUser";
            this.TxtTelaCadUsuarioNomeUser.Size = new System.Drawing.Size(205, 20);
            this.TxtTelaCadUsuarioNomeUser.TabIndex = 264;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 263;
            this.label5.Text = "NOME DO USUARIO";
            // 
            // BtnTelaLoginSalvar
            // 
            this.BtnTelaLoginSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnTelaLoginSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTelaLoginSalvar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTelaLoginSalvar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTelaLoginSalvar.Location = new System.Drawing.Point(546, 9);
            this.BtnTelaLoginSalvar.Name = "BtnTelaLoginSalvar";
            this.BtnTelaLoginSalvar.Size = new System.Drawing.Size(89, 25);
            this.BtnTelaLoginSalvar.TabIndex = 265;
            this.BtnTelaLoginSalvar.Text = "SALVAR";
            this.BtnTelaLoginSalvar.UseVisualStyleBackColor = false;
            this.BtnTelaLoginSalvar.Click += new System.EventHandler(this.BtnTelaLoginSalvar_Click);
            // 
            // BtnEditarCadUser
            // 
            this.BtnEditarCadUser.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditarCadUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditarCadUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarCadUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEditarCadUser.Location = new System.Drawing.Point(641, 9);
            this.BtnEditarCadUser.Name = "BtnEditarCadUser";
            this.BtnEditarCadUser.Size = new System.Drawing.Size(89, 25);
            this.BtnEditarCadUser.TabIndex = 267;
            this.BtnEditarCadUser.Text = "EDITAR";
            this.BtnEditarCadUser.UseVisualStyleBackColor = false;
            this.BtnEditarCadUser.Click += new System.EventHandler(this.BtnEditarCadUser_Click);
            // 
            // FormCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.BtnEditarCadUser);
            this.Controls.Add(this.BtnTelaLoginSalvar);
            this.Controls.Add(this.TxtTelaCadUsuarioNomeUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtCadastroUser);
            this.Controls.Add(this.LblDtCadastroCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTelaCadUsuarioCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgExibirUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnExcluirCadUser);
            this.Controls.Add(this.BtnLimparCadUser);
            this.Controls.Add(this.LblFormCadpRO);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtTelaCadUsuarioSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTelaCadUsuarioLogin);
            this.Controls.Add(this.label1);
            this.Name = "FormCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExibirUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtTelaCadUsuarioLogin;
        private TextBox TxtTelaCadUsuarioSenha;
        private Label label2;
        private Button BtnExcluirCadUser;
        private Button BtnLimparCadUser;
        private Label LblFormCadpRO;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridView dgExibirUser;
        private Label label3;
        private TextBox TxtTelaCadUsuarioCod;
        private Label label4;
        private DateTimePicker DtCadastroUser;
        private Label LblDtCadastroCli;
        private TextBox TxtTelaCadUsuarioNomeUser;
        private Label label5;
        private Button BtnTelaLoginSalvar;
        private Button BtnEditarCadUser;
    }
}