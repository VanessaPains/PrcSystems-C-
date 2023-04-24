namespace prcSystem.View
{
    partial class FormCadLancExcluir
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
            this.txtPesquisaLancmentos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFormCadCliForn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgPesquisarLanc = new System.Windows.Forms.DataGridView();
            this.idLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCdcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCdcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.BtnExcluirLanc = new System.Windows.Forms.Button();
            this.txtIdLancamento = new System.Windows.Forms.TextBox();
            this.lblPesquisarLancamentos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarLanc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaLancmentos
            // 
            this.txtPesquisaLancmentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaLancmentos.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisaLancmentos.Location = new System.Drawing.Point(14, 115);
            this.txtPesquisaLancmentos.Name = "txtPesquisaLancmentos";
            this.txtPesquisaLancmentos.Size = new System.Drawing.Size(458, 18);
            this.txtPesquisaLancmentos.TabIndex = 0;
            this.txtPesquisaLancmentos.TextChanged += new System.EventHandler(this.txtPesquisaLancmentos_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 334;
            this.pictureBox1.TabStop = false;
            // 
            // LblFormCadCliForn
            // 
            this.LblFormCadCliForn.AutoSize = true;
            this.LblFormCadCliForn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadCliForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadCliForn.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadCliForn.Name = "LblFormCadCliForn";
            this.LblFormCadCliForn.Size = new System.Drawing.Size(274, 22);
            this.LblFormCadCliForn.TabIndex = 333;
            this.LblFormCadCliForn.Text = "PESQUISAR LANÇAMENTOS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 332;
            // 
            // dgPesquisarLanc
            // 
            this.dgPesquisarLanc.AllowUserToAddRows = false;
            this.dgPesquisarLanc.AutoGenerateColumns = false;
            this.dgPesquisarLanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisarLanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLancamentoDataGridViewTextBoxColumn,
            this.tipoLancamentoDataGridViewTextBoxColumn,
            this.idPessoaDataGridViewTextBoxColumn,
            this.razaoNomeDataGridViewTextBoxColumn,
            this.codCdcDataGridViewTextBoxColumn,
            this.descricaoCdcDataGridViewTextBoxColumn,
            this.numDocumentoDataGridViewTextBoxColumn,
            this.dtLancamentoDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.dtVencimentoDataGridViewTextBoxColumn,
            this.dtPagamentoDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.Situacao});
            this.dgPesquisarLanc.DataSource = this.lancamentosBindingSource;
            this.dgPesquisarLanc.Location = new System.Drawing.Point(14, 149);
            this.dgPesquisarLanc.Name = "dgPesquisarLanc";
            this.dgPesquisarLanc.ReadOnly = true;
            this.dgPesquisarLanc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisarLanc.Size = new System.Drawing.Size(910, 375);
            this.dgPesquisarLanc.TabIndex = 336;
            this.dgPesquisarLanc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisarLanc_CellClick);
            // 
            // idLancamentoDataGridViewTextBoxColumn
            // 
            this.idLancamentoDataGridViewTextBoxColumn.DataPropertyName = "IdLancamento";
            this.idLancamentoDataGridViewTextBoxColumn.HeaderText = "IdLancamento";
            this.idLancamentoDataGridViewTextBoxColumn.Name = "idLancamentoDataGridViewTextBoxColumn";
            this.idLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoLancamentoDataGridViewTextBoxColumn
            // 
            this.tipoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "TipoLancamento";
            this.tipoLancamentoDataGridViewTextBoxColumn.HeaderText = "TipoLancamento";
            this.tipoLancamentoDataGridViewTextBoxColumn.Name = "tipoLancamentoDataGridViewTextBoxColumn";
            this.tipoLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoNomeDataGridViewTextBoxColumn
            // 
            this.razaoNomeDataGridViewTextBoxColumn.DataPropertyName = "RazaoNome";
            this.razaoNomeDataGridViewTextBoxColumn.HeaderText = "RazaoNome";
            this.razaoNomeDataGridViewTextBoxColumn.Name = "razaoNomeDataGridViewTextBoxColumn";
            this.razaoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codCdcDataGridViewTextBoxColumn
            // 
            this.codCdcDataGridViewTextBoxColumn.DataPropertyName = "CodCdc";
            this.codCdcDataGridViewTextBoxColumn.HeaderText = "CodCdc";
            this.codCdcDataGridViewTextBoxColumn.Name = "codCdcDataGridViewTextBoxColumn";
            this.codCdcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoCdcDataGridViewTextBoxColumn
            // 
            this.descricaoCdcDataGridViewTextBoxColumn.DataPropertyName = "DescricaoCdc";
            this.descricaoCdcDataGridViewTextBoxColumn.HeaderText = "DescricaoCdc";
            this.descricaoCdcDataGridViewTextBoxColumn.Name = "descricaoCdcDataGridViewTextBoxColumn";
            this.descricaoCdcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDocumentoDataGridViewTextBoxColumn
            // 
            this.numDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.HeaderText = "NumDocumento";
            this.numDocumentoDataGridViewTextBoxColumn.Name = "numDocumentoDataGridViewTextBoxColumn";
            this.numDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtLancamentoDataGridViewTextBoxColumn
            // 
            this.dtLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DtLancamento";
            this.dtLancamentoDataGridViewTextBoxColumn.HeaderText = "DtLancamento";
            this.dtLancamentoDataGridViewTextBoxColumn.Name = "dtLancamentoDataGridViewTextBoxColumn";
            this.dtLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtEmissaoDataGridViewTextBoxColumn
            // 
            this.dtEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DtEmissao";
            this.dtEmissaoDataGridViewTextBoxColumn.HeaderText = "DtEmissao";
            this.dtEmissaoDataGridViewTextBoxColumn.Name = "dtEmissaoDataGridViewTextBoxColumn";
            this.dtEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtVencimentoDataGridViewTextBoxColumn
            // 
            this.dtVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DtVencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.HeaderText = "DtVencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.Name = "dtVencimentoDataGridViewTextBoxColumn";
            this.dtVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtPagamentoDataGridViewTextBoxColumn
            // 
            this.dtPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DtPagamento";
            this.dtPagamentoDataGridViewTextBoxColumn.HeaderText = "DtPagamento";
            this.dtPagamentoDataGridViewTextBoxColumn.Name = "dtPagamentoDataGridViewTextBoxColumn";
            this.dtPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // lancamentosBindingSource
            // 
            this.lancamentosBindingSource.DataSource = typeof(prcSystem.Entidades.Lancamentos);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(437, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 12);
            this.label12.TabIndex = 337;
            this.label12.Text = "PRC Systems @";
            // 
            // BtnExcluirLanc
            // 
            this.BtnExcluirLanc.BackColor = System.Drawing.SystemColors.Menu;
            this.BtnExcluirLanc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirLanc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluirLanc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluirLanc.Location = new System.Drawing.Point(831, 9);
            this.BtnExcluirLanc.Name = "BtnExcluirLanc";
            this.BtnExcluirLanc.Size = new System.Drawing.Size(89, 25);
            this.BtnExcluirLanc.TabIndex = 335;
            this.BtnExcluirLanc.Text = "EXCLUIR";
            this.BtnExcluirLanc.UseVisualStyleBackColor = false;
            this.BtnExcluirLanc.Click += new System.EventHandler(this.BtnExcluirLanc_Click);
            // 
            // txtIdLancamento
            // 
            this.txtIdLancamento.Enabled = false;
            this.txtIdLancamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdLancamento.Location = new System.Drawing.Point(14, 69);
            this.txtIdLancamento.Name = "txtIdLancamento";
            this.txtIdLancamento.Size = new System.Drawing.Size(52, 18);
            this.txtIdLancamento.TabIndex = 339;
            // 
            // lblPesquisarLancamentos
            // 
            this.lblPesquisarLancamentos.AutoSize = true;
            this.lblPesquisarLancamentos.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisarLancamentos.Location = new System.Drawing.Point(14, 100);
            this.lblPesquisarLancamentos.Name = "lblPesquisarLancamentos";
            this.lblPesquisarLancamentos.Size = new System.Drawing.Size(338, 12);
            this.lblPesquisarLancamentos.TabIndex = 470;
            this.lblPesquisarLancamentos.Text = "PESQUISAR LANÇAMENTOS -  Nº TITULO:  CDC:  CNPJ/CPF:  RAZÃO/NOME";
            // 
            // FormCadLancPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.lblPesquisarLancamentos);
            this.Controls.Add(this.txtIdLancamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgPesquisarLanc);
            this.Controls.Add(this.BtnExcluirLanc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblFormCadCliForn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPesquisaLancmentos);
            this.Name = "FormCadLancPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadLancPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisarLanc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPesquisaLancmentos;
        private PictureBox pictureBox1;
        private Label LblFormCadCliForn;
        private TextBox textBox1;
        private DataGridView dgPesquisarLanc;
        private BindingSource lancamentosBindingSource;
        private Label label12;
        private Button BtnExcluirLanc;
        private TextBox txtIdLancamento;
        private DataGridViewTextBoxColumn idLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razaoNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCdcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoCdcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Situacao;
        private Label lblPesquisarLancamentos;
    }
}