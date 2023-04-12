namespace prcSystem.View
{
    partial class FormCadPagamentos
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFormCadCliForn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgPagamentos = new System.Windows.Forms.DataGridView();
            this.idLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCdcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCdcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPesquisarPor = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnAberto = new System.Windows.Forms.Button();
            this.btnPagas = new System.Windows.Forms.Button();
            this.lblDtLancPesq = new System.Windows.Forms.Label();
            this.DtDeLanc = new System.Windows.Forms.DateTimePicker();
            this.DtAteLanc = new System.Windows.Forms.DateTimePicker();
            this.lblDe01 = new System.Windows.Forms.Label();
            this.lblAte01 = new System.Windows.Forms.Label();
            this.lblAte02 = new System.Windows.Forms.Label();
            this.lblDe02 = new System.Windows.Forms.Label();
            this.DtAteEmis = new System.Windows.Forms.DateTimePicker();
            this.DtDeEmis = new System.Windows.Forms.DateTimePicker();
            this.lblDtEmisPesq = new System.Windows.Forms.Label();
            this.lblAte03 = new System.Windows.Forms.Label();
            this.lblDe03 = new System.Windows.Forms.Label();
            this.DtAteVenc = new System.Windows.Forms.DateTimePicker();
            this.DtDeVenc = new System.Windows.Forms.DateTimePicker();
            this.lblDtVencPesq = new System.Windows.Forms.Label();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.lblNumDocumento = new System.Windows.Forms.Label();
            this.lblIdCdc = new System.Windows.Forms.Label();
            this.lblAte04 = new System.Windows.Forms.Label();
            this.lblDe04 = new System.Windows.Forms.Label();
            this.DtAtePgto = new System.Windows.Forms.DateTimePicker();
            this.DtDePgto = new System.Windows.Forms.DateTimePicker();
            this.lblDtPgtoPesq = new System.Windows.Forms.Label();
            this.txtlinha05 = new System.Windows.Forms.TextBox();
            this.txtlinha03 = new System.Windows.Forms.TextBox();
            this.txtlinha04 = new System.Windows.Forms.TextBox();
            this.txtlinha02 = new System.Windows.Forms.TextBox();
            this.txtlinha01 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodCliForn = new System.Windows.Forms.TextBox();
            this.lblCodCliForn = new System.Windows.Forms.Label();
            this.lblRazaoNome = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.cbPagoEm = new System.Windows.Forms.ComboBox();
            this.lblPagoEm = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTotalPagoPagto = new System.Windows.Forms.Label();
            this.txtTotalPagoPagto = new System.Windows.Forms.TextBox();
            this.lblJurosPagto = new System.Windows.Forms.Label();
            this.txtJurosPagto = new System.Windows.Forms.TextBox();
            this.txtIdLancamento = new System.Windows.Forms.TextBox();
            this.lblDtEmisPgto = new System.Windows.Forms.Label();
            this.txtRazaoNomeDescricao = new System.Windows.Forms.TextBox();
            this.cbSituacaoAbertaPaga = new System.Windows.Forms.ComboBox();
            this.lblNumDocPgto = new System.Windows.Forms.Label();
            this.lblSituacaoAbertaPagaPgto = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtIdCdc = new System.Windows.Forms.TextBox();
            this.lblIdCdcCodPgto = new System.Windows.Forms.Label();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.lblCodCliFornPgto = new System.Windows.Forms.Label();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.txtCodCliFornPgto = new System.Windows.Forms.TextBox();
            this.lblIdLancPgto = new System.Windows.Forms.Label();
            this.lblComentariosPgto = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblDtVencPgto = new System.Windows.Forms.Label();
            this.lblDtProgramacaoPgto = new System.Windows.Forms.Label();
            this.txtDescricaoCdc = new System.Windows.Forms.TextBox();
            this.lblValorTotalPgto = new System.Windows.Forms.Label();
            this.lblLancamentoPgto = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dtLancamento = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblTipoLancPgto = new System.Windows.Forms.Label();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(439, 540);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 123;
            this.label3.Text = "PRC Systems @";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // LblFormCadCliForn
            // 
            this.LblFormCadCliForn.AutoSize = true;
            this.LblFormCadCliForn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadCliForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadCliForn.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadCliForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFormCadCliForn.Name = "LblFormCadCliForn";
            this.LblFormCadCliForn.Size = new System.Drawing.Size(146, 22);
            this.LblFormCadCliForn.TabIndex = 130;
            this.LblFormCadCliForn.Text = "PAGAMENTOS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(14, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(912, 2);
            this.textBox1.TabIndex = 129;
            // 
            // dgPagamentos
            // 
            this.dgPagamentos.AllowUserToAddRows = false;
            this.dgPagamentos.AllowUserToDeleteRows = false;
            this.dgPagamentos.AutoGenerateColumns = false;
            this.dgPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLancamentoDataGridViewTextBoxColumn,
            this.Situacao,
            this.tipoLancamentoDataGridViewTextBoxColumn,
            this.idPessoaDataGridViewTextBoxColumn,
            this.razaoNomeDataGridViewTextBoxColumn,
            this.cnpjCpfDataGridViewTextBoxColumn,
            this.codCdcDataGridViewTextBoxColumn,
            this.descricaoCdcDataGridViewTextBoxColumn,
            this.numDocumentoDataGridViewTextBoxColumn,
            this.dtLancamentoDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.dtVencimentoDataGridViewTextBoxColumn,
            this.dtPagamentoDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn});
            this.dgPagamentos.DataSource = this.lancamentosBindingSource1;
            this.dgPagamentos.Location = new System.Drawing.Point(14, 206);
            this.dgPagamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgPagamentos.Name = "dgPagamentos";
            this.dgPagamentos.ReadOnly = true;
            this.dgPagamentos.RowTemplate.Height = 25;
            this.dgPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagamentos.Size = new System.Drawing.Size(912, 308);
            this.dgPagamentos.TabIndex = 132;
            this.dgPagamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagamentos_CellClick);
            // 
            // idLancamentoDataGridViewTextBoxColumn
            // 
            this.idLancamentoDataGridViewTextBoxColumn.DataPropertyName = "IdLancamento";
            this.idLancamentoDataGridViewTextBoxColumn.HeaderText = "IdLancamento";
            this.idLancamentoDataGridViewTextBoxColumn.Name = "idLancamentoDataGridViewTextBoxColumn";
            this.idLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
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
            // cnpjCpfDataGridViewTextBoxColumn
            // 
            this.cnpjCpfDataGridViewTextBoxColumn.DataPropertyName = "CnpjCpf";
            this.cnpjCpfDataGridViewTextBoxColumn.HeaderText = "CnpjCpf";
            this.cnpjCpfDataGridViewTextBoxColumn.Name = "cnpjCpfDataGridViewTextBoxColumn";
            this.cnpjCpfDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lancamentosBindingSource1
            // 
            this.lancamentosBindingSource1.DataSource = typeof(prcSystem.Entidades.Lancamentos);
            // 
            // lancamentosBindingSource
            // 
            this.lancamentosBindingSource.DataSource = typeof(prcSystem.Entidades.Lancamentos);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(132, 78);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 12);
            this.lblTipo.TabIndex = 136;
            this.lblTipo.Text = "TIPO:";
            // 
            // lblPesquisarPor
            // 
            this.lblPesquisarPor.AutoSize = true;
            this.lblPesquisarPor.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisarPor.Location = new System.Drawing.Point(16, 78);
            this.lblPesquisarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisarPor.Name = "lblPesquisarPor";
            this.lblPesquisarPor.Size = new System.Drawing.Size(83, 12);
            this.lblPesquisarPor.TabIndex = 139;
            this.lblPesquisarPor.Text = "PESQUISAR POR:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(106, 105);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(56, 12);
            this.lblSituacao.TabIndex = 140;
            this.lblSituacao.Text = "SITUAÇÃO:";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEntrada.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrada.Location = new System.Drawing.Point(164, 72);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(70, 22);
            this.btnEntrada.TabIndex = 141;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaida.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaida.Location = new System.Drawing.Point(241, 72);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(70, 22);
            this.btnSaida.TabIndex = 142;
            this.btnSaida.Text = "SAÍDA";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTodos.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTodos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTodos.Location = new System.Drawing.Point(317, 72);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(70, 22);
            this.btnTodos.TabIndex = 143;
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnAberto
            // 
            this.btnAberto.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAberto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAberto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAberto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAberto.Location = new System.Drawing.Point(164, 101);
            this.btnAberto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAberto.Name = "btnAberto";
            this.btnAberto.Size = new System.Drawing.Size(70, 22);
            this.btnAberto.TabIndex = 144;
            this.btnAberto.Text = "EM ABERTO";
            this.btnAberto.UseVisualStyleBackColor = false;
            this.btnAberto.Click += new System.EventHandler(this.btnAberto_Click);
            // 
            // btnPagas
            // 
            this.btnPagas.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPagas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPagas.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPagas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPagas.Location = new System.Drawing.Point(241, 101);
            this.btnPagas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagas.Name = "btnPagas";
            this.btnPagas.Size = new System.Drawing.Size(70, 22);
            this.btnPagas.TabIndex = 145;
            this.btnPagas.Text = "PAGAS";
            this.btnPagas.UseVisualStyleBackColor = false;
            this.btnPagas.Click += new System.EventHandler(this.btnPagas_Click);
            // 
            // lblDtLancPesq
            // 
            this.lblDtLancPesq.AutoSize = true;
            this.lblDtLancPesq.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtLancPesq.Location = new System.Drawing.Point(461, 70);
            this.lblDtLancPesq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtLancPesq.Name = "lblDtLancPesq";
            this.lblDtLancPesq.Size = new System.Drawing.Size(76, 13);
            this.lblDtLancPesq.TabIndex = 146;
            this.lblDtLancPesq.Text = "DATA LANÇ.:";
            // 
            // DtDeLanc
            // 
            this.DtDeLanc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtDeLanc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDeLanc.Location = new System.Drawing.Point(445, 86);
            this.DtDeLanc.Margin = new System.Windows.Forms.Padding(2);
            this.DtDeLanc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtDeLanc.Name = "DtDeLanc";
            this.DtDeLanc.Size = new System.Drawing.Size(88, 18);
            this.DtDeLanc.TabIndex = 261;
            this.DtDeLanc.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // DtAteLanc
            // 
            this.DtAteLanc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtAteLanc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAteLanc.Location = new System.Drawing.Point(445, 107);
            this.DtAteLanc.Margin = new System.Windows.Forms.Padding(2);
            this.DtAteLanc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtAteLanc.Name = "DtAteLanc";
            this.DtAteLanc.Size = new System.Drawing.Size(88, 18);
            this.DtAteLanc.TabIndex = 262;
            this.DtAteLanc.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDe01
            // 
            this.lblDe01.AutoSize = true;
            this.lblDe01.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDe01.Location = new System.Drawing.Point(425, 88);
            this.lblDe01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe01.Name = "lblDe01";
            this.lblDe01.Size = new System.Drawing.Size(18, 12);
            this.lblDe01.TabIndex = 263;
            this.lblDe01.Text = "De:";
            // 
            // lblAte01
            // 
            this.lblAte01.AutoSize = true;
            this.lblAte01.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAte01.Location = new System.Drawing.Point(421, 109);
            this.lblAte01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAte01.Name = "lblAte01";
            this.lblAte01.Size = new System.Drawing.Size(22, 12);
            this.lblAte01.TabIndex = 264;
            this.lblAte01.Text = "Até:";
            // 
            // lblAte02
            // 
            this.lblAte02.AutoSize = true;
            this.lblAte02.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAte02.Location = new System.Drawing.Point(552, 109);
            this.lblAte02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAte02.Name = "lblAte02";
            this.lblAte02.Size = new System.Drawing.Size(22, 12);
            this.lblAte02.TabIndex = 269;
            this.lblAte02.Text = "Até:";
            // 
            // lblDe02
            // 
            this.lblDe02.AutoSize = true;
            this.lblDe02.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDe02.Location = new System.Drawing.Point(557, 88);
            this.lblDe02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe02.Name = "lblDe02";
            this.lblDe02.Size = new System.Drawing.Size(18, 12);
            this.lblDe02.TabIndex = 268;
            this.lblDe02.Text = "De:";
            // 
            // DtAteEmis
            // 
            this.DtAteEmis.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtAteEmis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAteEmis.Location = new System.Drawing.Point(577, 107);
            this.DtAteEmis.Margin = new System.Windows.Forms.Padding(2);
            this.DtAteEmis.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtAteEmis.Name = "DtAteEmis";
            this.DtAteEmis.Size = new System.Drawing.Size(88, 18);
            this.DtAteEmis.TabIndex = 267;
            this.DtAteEmis.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // DtDeEmis
            // 
            this.DtDeEmis.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtDeEmis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDeEmis.Location = new System.Drawing.Point(577, 86);
            this.DtDeEmis.Margin = new System.Windows.Forms.Padding(2);
            this.DtDeEmis.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtDeEmis.Name = "DtDeEmis";
            this.DtDeEmis.Size = new System.Drawing.Size(88, 18);
            this.DtDeEmis.TabIndex = 266;
            this.DtDeEmis.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDtEmisPesq
            // 
            this.lblDtEmisPesq.AutoSize = true;
            this.lblDtEmisPesq.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtEmisPesq.Location = new System.Drawing.Point(577, 70);
            this.lblDtEmisPesq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtEmisPesq.Name = "lblDtEmisPesq";
            this.lblDtEmisPesq.Size = new System.Drawing.Size(93, 13);
            this.lblDtEmisPesq.TabIndex = 265;
            this.lblDtEmisPesq.Text = "DATA EMISSÃO:";
            // 
            // lblAte03
            // 
            this.lblAte03.AutoSize = true;
            this.lblAte03.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAte03.Location = new System.Drawing.Point(682, 109);
            this.lblAte03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAte03.Name = "lblAte03";
            this.lblAte03.Size = new System.Drawing.Size(22, 12);
            this.lblAte03.TabIndex = 274;
            this.lblAte03.Text = "Até:";
            // 
            // lblDe03
            // 
            this.lblDe03.AutoSize = true;
            this.lblDe03.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDe03.Location = new System.Drawing.Point(686, 88);
            this.lblDe03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe03.Name = "lblDe03";
            this.lblDe03.Size = new System.Drawing.Size(18, 12);
            this.lblDe03.TabIndex = 273;
            this.lblDe03.Text = "De:";
            // 
            // DtAteVenc
            // 
            this.DtAteVenc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtAteVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAteVenc.Location = new System.Drawing.Point(706, 107);
            this.DtAteVenc.Margin = new System.Windows.Forms.Padding(2);
            this.DtAteVenc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtAteVenc.Name = "DtAteVenc";
            this.DtAteVenc.Size = new System.Drawing.Size(88, 18);
            this.DtAteVenc.TabIndex = 272;
            this.DtAteVenc.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // DtDeVenc
            // 
            this.DtDeVenc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtDeVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDeVenc.Location = new System.Drawing.Point(706, 86);
            this.DtDeVenc.Margin = new System.Windows.Forms.Padding(2);
            this.DtDeVenc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtDeVenc.Name = "DtDeVenc";
            this.DtDeVenc.Size = new System.Drawing.Size(88, 18);
            this.DtDeVenc.TabIndex = 271;
            this.DtDeVenc.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDtVencPesq
            // 
            this.lblDtVencPesq.AutoSize = true;
            this.lblDtVencPesq.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtVencPesq.Location = new System.Drawing.Point(724, 70);
            this.lblDtVencPesq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtVencPesq.Name = "lblDtVencPesq";
            this.lblDtVencPesq.Size = new System.Drawing.Size(75, 13);
            this.lblDtVencPesq.TabIndex = 270;
            this.lblDtVencPesq.Text = "DATA VENC.:";
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumDocumento.Location = new System.Drawing.Point(14, 176);
            this.txtNumDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(407, 18);
            this.txtNumDocumento.TabIndex = 276;
            this.txtNumDocumento.TextChanged += new System.EventHandler(this.txtNumDocumento_TextChanged);
            // 
            // lblNumDocumento
            // 
            this.lblNumDocumento.AutoSize = true;
            this.lblNumDocumento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumDocumento.Location = new System.Drawing.Point(14, 162);
            this.lblNumDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumDocumento.Name = "lblNumDocumento";
            this.lblNumDocumento.Size = new System.Drawing.Size(56, 12);
            this.lblNumDocumento.TabIndex = 275;
            this.lblNumDocumento.Text = "Nº TITULO:";
            // 
            // lblIdCdc
            // 
            this.lblIdCdc.AutoSize = true;
            this.lblIdCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCdc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIdCdc.Location = new System.Drawing.Point(74, 162);
            this.lblIdCdc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCdc.Name = "lblIdCdc";
            this.lblIdCdc.Size = new System.Drawing.Size(28, 12);
            this.lblIdCdc.TabIndex = 277;
            this.lblIdCdc.Text = "CDC:";
            // 
            // lblAte04
            // 
            this.lblAte04.AutoSize = true;
            this.lblAte04.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAte04.Location = new System.Drawing.Point(810, 110);
            this.lblAte04.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAte04.Name = "lblAte04";
            this.lblAte04.Size = new System.Drawing.Size(22, 12);
            this.lblAte04.TabIndex = 284;
            this.lblAte04.Text = "Até:";
            // 
            // lblDe04
            // 
            this.lblDe04.AutoSize = true;
            this.lblDe04.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDe04.Location = new System.Drawing.Point(814, 89);
            this.lblDe04.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe04.Name = "lblDe04";
            this.lblDe04.Size = new System.Drawing.Size(18, 12);
            this.lblDe04.TabIndex = 283;
            this.lblDe04.Text = "De:";
            // 
            // DtAtePgto
            // 
            this.DtAtePgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtAtePgto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtAtePgto.Location = new System.Drawing.Point(833, 108);
            this.DtAtePgto.Margin = new System.Windows.Forms.Padding(2);
            this.DtAtePgto.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtAtePgto.Name = "DtAtePgto";
            this.DtAtePgto.Size = new System.Drawing.Size(88, 18);
            this.DtAtePgto.TabIndex = 282;
            this.DtAtePgto.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // DtDePgto
            // 
            this.DtDePgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DtDePgto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtDePgto.Location = new System.Drawing.Point(833, 87);
            this.DtDePgto.Margin = new System.Windows.Forms.Padding(2);
            this.DtDePgto.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtDePgto.Name = "DtDePgto";
            this.DtDePgto.Size = new System.Drawing.Size(88, 18);
            this.DtDePgto.TabIndex = 281;
            this.DtDePgto.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDtPgtoPesq
            // 
            this.lblDtPgtoPesq.AutoSize = true;
            this.lblDtPgtoPesq.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtPgtoPesq.Location = new System.Drawing.Point(849, 71);
            this.lblDtPgtoPesq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtPgtoPesq.Name = "lblDtPgtoPesq";
            this.lblDtPgtoPesq.Size = new System.Drawing.Size(76, 13);
            this.lblDtPgtoPesq.TabIndex = 280;
            this.lblDtPgtoPesq.Text = "DATA PGTO.:";
            // 
            // txtlinha05
            // 
            this.txtlinha05.BackColor = System.Drawing.Color.DarkGray;
            this.txtlinha05.Location = new System.Drawing.Point(100, 97);
            this.txtlinha05.Margin = new System.Windows.Forms.Padding(2);
            this.txtlinha05.Multiline = true;
            this.txtlinha05.Name = "txtlinha05";
            this.txtlinha05.Size = new System.Drawing.Size(300, 1);
            this.txtlinha05.TabIndex = 285;
            // 
            // txtlinha03
            // 
            this.txtlinha03.BackColor = System.Drawing.Color.DarkGray;
            this.txtlinha03.Location = new System.Drawing.Point(100, 127);
            this.txtlinha03.Margin = new System.Windows.Forms.Padding(2);
            this.txtlinha03.Multiline = true;
            this.txtlinha03.Name = "txtlinha03";
            this.txtlinha03.Size = new System.Drawing.Size(300, 1);
            this.txtlinha03.TabIndex = 286;
            // 
            // txtlinha04
            // 
            this.txtlinha04.BackColor = System.Drawing.Color.DarkGray;
            this.txtlinha04.Location = new System.Drawing.Point(100, 67);
            this.txtlinha04.Margin = new System.Windows.Forms.Padding(2);
            this.txtlinha04.Multiline = true;
            this.txtlinha04.Name = "txtlinha04";
            this.txtlinha04.Size = new System.Drawing.Size(300, 1);
            this.txtlinha04.TabIndex = 287;
            // 
            // txtlinha02
            // 
            this.txtlinha02.BackColor = System.Drawing.Color.DarkGray;
            this.txtlinha02.Location = new System.Drawing.Point(399, 67);
            this.txtlinha02.Margin = new System.Windows.Forms.Padding(2);
            this.txtlinha02.Multiline = true;
            this.txtlinha02.Name = "txtlinha02";
            this.txtlinha02.Size = new System.Drawing.Size(1, 61);
            this.txtlinha02.TabIndex = 288;
            // 
            // txtlinha01
            // 
            this.txtlinha01.BackColor = System.Drawing.Color.DarkGray;
            this.txtlinha01.Location = new System.Drawing.Point(100, 67);
            this.txtlinha01.Margin = new System.Windows.Forms.Padding(2);
            this.txtlinha01.Multiline = true;
            this.txtlinha01.Name = "txtlinha01";
            this.txtlinha01.Size = new System.Drawing.Size(1, 61);
            this.txtlinha01.TabIndex = 289;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(718, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 294;
            this.button5.Text = "PESQUISAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(825, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 293;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodCliForn
            // 
            this.txtCodCliForn.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodCliForn.Location = new System.Drawing.Point(425, 176);
            this.txtCodCliForn.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCliForn.Name = "txtCodCliForn";
            this.txtCodCliForn.Size = new System.Drawing.Size(128, 18);
            this.txtCodCliForn.TabIndex = 296;
            this.txtCodCliForn.TextChanged += new System.EventHandler(this.txtCodCliForn_TextChanged);
            // 
            // lblCodCliForn
            // 
            this.lblCodCliForn.AutoSize = true;
            this.lblCodCliForn.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodCliForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodCliForn.Location = new System.Drawing.Point(425, 162);
            this.lblCodCliForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodCliForn.Name = "lblCodCliForn";
            this.lblCodCliForn.Size = new System.Drawing.Size(79, 12);
            this.lblCodCliForn.TabIndex = 295;
            this.lblCodCliForn.Text = "COD. CLI./FORN.";
            // 
            // lblRazaoNome
            // 
            this.lblRazaoNome.AutoSize = true;
            this.lblRazaoNome.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRazaoNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRazaoNome.Location = new System.Drawing.Point(166, 162);
            this.lblRazaoNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazaoNome.Name = "lblRazaoNome";
            this.lblRazaoNome.Size = new System.Drawing.Size(75, 12);
            this.lblRazaoNome.TabIndex = 297;
            this.lblRazaoNome.Text = "RAZÃO / NOME:";
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCnpjCpf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCnpjCpf.Location = new System.Drawing.Point(106, 162);
            this.lblCnpjCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(56, 12);
            this.lblCnpjCpf.TabIndex = 298;
            this.lblCnpjCpf.Text = "CNPJ / CPF:";
            // 
            // cbPagoEm
            // 
            this.cbPagoEm.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPagoEm.FormattingEnabled = true;
            this.cbPagoEm.Location = new System.Drawing.Point(709, 436);
            this.cbPagoEm.Name = "cbPagoEm";
            this.cbPagoEm.Size = new System.Drawing.Size(117, 20);
            this.cbPagoEm.TabIndex = 460;
            // 
            // lblPagoEm
            // 
            this.lblPagoEm.AutoSize = true;
            this.lblPagoEm.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPagoEm.Location = new System.Drawing.Point(653, 439);
            this.lblPagoEm.Name = "lblPagoEm";
            this.lblPagoEm.Size = new System.Drawing.Size(50, 12);
            this.lblPagoEm.TabIndex = 459;
            this.lblPagoEm.Text = "PAGO EM:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkGray;
            this.textBox4.Location = new System.Drawing.Point(595, 300);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(2, 160);
            this.textBox4.TabIndex = 458;
            // 
            // lblTotalPagoPagto
            // 
            this.lblTotalPagoPagto.AutoSize = true;
            this.lblTotalPagoPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPagoPagto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalPagoPagto.Location = new System.Drawing.Point(636, 415);
            this.lblTotalPagoPagto.Name = "lblTotalPagoPagto";
            this.lblTotalPagoPagto.Size = new System.Drawing.Size(67, 12);
            this.lblTotalPagoPagto.TabIndex = 457;
            this.lblTotalPagoPagto.Text = "TOTAL PAGO:";
            // 
            // txtTotalPagoPagto
            // 
            this.txtTotalPagoPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPagoPagto.Location = new System.Drawing.Point(709, 412);
            this.txtTotalPagoPagto.Name = "txtTotalPagoPagto";
            this.txtTotalPagoPagto.Size = new System.Drawing.Size(117, 18);
            this.txtTotalPagoPagto.TabIndex = 456;
            // 
            // lblJurosPagto
            // 
            this.lblJurosPagto.AutoSize = true;
            this.lblJurosPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJurosPagto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblJurosPagto.Location = new System.Drawing.Point(664, 391);
            this.lblJurosPagto.Name = "lblJurosPagto";
            this.lblJurosPagto.Size = new System.Drawing.Size(39, 12);
            this.lblJurosPagto.TabIndex = 455;
            this.lblJurosPagto.Text = "JUROS:";
            // 
            // txtJurosPagto
            // 
            this.txtJurosPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJurosPagto.Location = new System.Drawing.Point(709, 388);
            this.txtJurosPagto.Name = "txtJurosPagto";
            this.txtJurosPagto.Size = new System.Drawing.Size(117, 18);
            this.txtJurosPagto.TabIndex = 454;
            // 
            // txtIdLancamento
            // 
            this.txtIdLancamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdLancamento.Location = new System.Drawing.Point(454, 270);
            this.txtIdLancamento.Name = "txtIdLancamento";
            this.txtIdLancamento.Size = new System.Drawing.Size(100, 18);
            this.txtIdLancamento.TabIndex = 446;
            // 
            // lblDtEmisPgto
            // 
            this.lblDtEmisPgto.AutoSize = true;
            this.lblDtEmisPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtEmisPgto.Location = new System.Drawing.Point(53, 340);
            this.lblDtEmisPgto.Name = "lblDtEmisPgto";
            this.lblDtEmisPgto.Size = new System.Drawing.Size(63, 12);
            this.lblDtEmisPgto.TabIndex = 453;
            this.lblDtEmisPgto.Text = "DT EMISSÃO:";
            // 
            // txtRazaoNomeDescricao
            // 
            this.txtRazaoNomeDescricao.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazaoNomeDescricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtRazaoNomeDescricao.Location = new System.Drawing.Point(184, 362);
            this.txtRazaoNomeDescricao.Name = "txtRazaoNomeDescricao";
            this.txtRazaoNomeDescricao.PlaceholderText = "Descrição";
            this.txtRazaoNomeDescricao.Size = new System.Drawing.Size(375, 18);
            this.txtRazaoNomeDescricao.TabIndex = 426;
            // 
            // cbSituacaoAbertaPaga
            // 
            this.cbSituacaoAbertaPaga.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSituacaoAbertaPaga.FormattingEnabled = true;
            this.cbSituacaoAbertaPaga.Items.AddRange(new object[] {
            "EM ABERTO"});
            this.cbSituacaoAbertaPaga.Location = new System.Drawing.Point(709, 338);
            this.cbSituacaoAbertaPaga.Name = "cbSituacaoAbertaPaga";
            this.cbSituacaoAbertaPaga.Size = new System.Drawing.Size(117, 20);
            this.cbSituacaoAbertaPaga.TabIndex = 452;
            // 
            // lblNumDocPgto
            // 
            this.lblNumDocPgto.AutoSize = true;
            this.lblNumDocPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocPgto.Location = new System.Drawing.Point(661, 317);
            this.lblNumDocPgto.Name = "lblNumDocPgto";
            this.lblNumDocPgto.Size = new System.Drawing.Size(42, 12);
            this.lblNumDocPgto.TabIndex = 427;
            this.lblNumDocPgto.Text = "Nº. DOC:";
            // 
            // lblSituacaoAbertaPagaPgto
            // 
            this.lblSituacaoAbertaPagaPgto.AutoSize = true;
            this.lblSituacaoAbertaPagaPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacaoAbertaPagaPgto.Location = new System.Drawing.Point(647, 341);
            this.lblSituacaoAbertaPagaPgto.Name = "lblSituacaoAbertaPagaPgto";
            this.lblSituacaoAbertaPagaPgto.Size = new System.Drawing.Size(56, 12);
            this.lblSituacaoAbertaPagaPgto.TabIndex = 451;
            this.lblSituacaoAbertaPagaPgto.Text = "SITUAÇÃO:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumDoc.Location = new System.Drawing.Point(709, 314);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(117, 18);
            this.txtNumDoc.TabIndex = 428;
            // 
            // txtIdCdc
            // 
            this.txtIdCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdCdc.Location = new System.Drawing.Point(124, 386);
            this.txtIdCdc.Name = "txtIdCdc";
            this.txtIdCdc.Size = new System.Drawing.Size(60, 18);
            this.txtIdCdc.TabIndex = 450;
            // 
            // lblIdCdcCodPgto
            // 
            this.lblIdCdcCodPgto.AutoSize = true;
            this.lblIdCdcCodPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCdcCodPgto.Location = new System.Drawing.Point(90, 389);
            this.lblIdCdcCodPgto.Name = "lblIdCdcCodPgto";
            this.lblIdCdcCodPgto.Size = new System.Drawing.Size(28, 12);
            this.lblIdCdcCodPgto.TabIndex = 429;
            this.lblIdCdcCodPgto.Text = "CDC:";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEntrada.Location = new System.Drawing.Point(198, 254);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(82, 19);
            this.rbEntrada.TabIndex = 449;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "ENTRADA";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.Visible = false;
            // 
            // lblCodCliFornPgto
            // 
            this.lblCodCliFornPgto.AutoSize = true;
            this.lblCodCliFornPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodCliFornPgto.Location = new System.Drawing.Point(59, 364);
            this.lblCodCliFornPgto.Name = "lblCodCliFornPgto";
            this.lblCodCliFornPgto.Size = new System.Drawing.Size(58, 12);
            this.lblCodCliFornPgto.TabIndex = 430;
            this.lblCodCliFornPgto.Text = "CLI / FORN:";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbSaida.Location = new System.Drawing.Point(286, 254);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(62, 19);
            this.rbSaida.TabIndex = 448;
            this.rbSaida.Text = "SAIDA";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.Visible = false;
            // 
            // txtCodCliFornPgto
            // 
            this.txtCodCliFornPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodCliFornPgto.Location = new System.Drawing.Point(123, 362);
            this.txtCodCliFornPgto.Name = "txtCodCliFornPgto";
            this.txtCodCliFornPgto.Size = new System.Drawing.Size(60, 18);
            this.txtCodCliFornPgto.TabIndex = 431;
            // 
            // lblIdLancPgto
            // 
            this.lblIdLancPgto.AutoSize = true;
            this.lblIdLancPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdLancPgto.Location = new System.Drawing.Point(457, 255);
            this.lblIdLancPgto.Name = "lblIdLancPgto";
            this.lblIdLancPgto.Size = new System.Drawing.Size(96, 12);
            this.lblIdLancPgto.TabIndex = 447;
            this.lblIdLancPgto.Text = "COD. LANÇAMENTO";
            // 
            // lblComentariosPgto
            // 
            this.lblComentariosPgto.AutoSize = true;
            this.lblComentariosPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComentariosPgto.Location = new System.Drawing.Point(40, 413);
            this.lblComentariosPgto.Name = "lblComentariosPgto";
            this.lblComentariosPgto.Size = new System.Drawing.Size(78, 12);
            this.lblComentariosPgto.TabIndex = 432;
            this.lblComentariosPgto.Text = "COMENTARIOS:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComentarios.Location = new System.Drawing.Point(124, 410);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(436, 44);
            this.txtComentarios.TabIndex = 433;
            // 
            // dtPagamento
            // 
            this.dtPagamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPagamento.Location = new System.Drawing.Point(432, 337);
            this.dtPagamento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(127, 18);
            this.dtPagamento.TabIndex = 445;
            this.dtPagamento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDtVencPgto
            // 
            this.lblDtVencPgto.AutoSize = true;
            this.lblDtVencPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtVencPgto.Location = new System.Drawing.Point(378, 315);
            this.lblDtVencPgto.Name = "lblDtVencPgto";
            this.lblDtVencPgto.Size = new System.Drawing.Size(48, 12);
            this.lblDtVencPgto.TabIndex = 434;
            this.lblDtVencPgto.Text = "DT VENC:";
            // 
            // lblDtProgramacaoPgto
            // 
            this.lblDtProgramacaoPgto.AutoSize = true;
            this.lblDtProgramacaoPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtProgramacaoPgto.Location = new System.Drawing.Point(288, 340);
            this.lblDtProgramacaoPgto.Name = "lblDtProgramacaoPgto";
            this.lblDtProgramacaoPgto.Size = new System.Drawing.Size(139, 12);
            this.lblDtProgramacaoPgto.TabIndex = 444;
            this.lblDtProgramacaoPgto.Text = "DT DE PROGRAMAÇÃO PGTO:";
            // 
            // txtDescricaoCdc
            // 
            this.txtDescricaoCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoCdc.Location = new System.Drawing.Point(185, 386);
            this.txtDescricaoCdc.Name = "txtDescricaoCdc";
            this.txtDescricaoCdc.PlaceholderText = "Descrição";
            this.txtDescricaoCdc.Size = new System.Drawing.Size(375, 18);
            this.txtDescricaoCdc.TabIndex = 435;
            // 
            // lblValorTotalPgto
            // 
            this.lblValorTotalPgto.AutoSize = true;
            this.lblValorTotalPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotalPgto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblValorTotalPgto.Location = new System.Drawing.Point(625, 367);
            this.lblValorTotalPgto.Name = "lblValorTotalPgto";
            this.lblValorTotalPgto.Size = new System.Drawing.Size(78, 12);
            this.lblValorTotalPgto.TabIndex = 443;
            this.lblValorTotalPgto.Text = "VALOR TITULO:";
            // 
            // lblLancamentoPgto
            // 
            this.lblLancamentoPgto.AutoSize = true;
            this.lblLancamentoPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLancamentoPgto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLancamentoPgto.Location = new System.Drawing.Point(55, 316);
            this.lblLancamentoPgto.Name = "lblLancamentoPgto";
            this.lblLancamentoPgto.Size = new System.Drawing.Size(62, 12);
            this.lblLancamentoPgto.TabIndex = 436;
            this.lblLancamentoPgto.Text = "DATA LANÇ.:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorTotal.Location = new System.Drawing.Point(709, 364);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(117, 18);
            this.txtValorTotal.TabIndex = 442;
            // 
            // dtLancamento
            // 
            this.dtLancamento.CalendarFont = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtLancamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLancamento.Location = new System.Drawing.Point(123, 313);
            this.dtLancamento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtLancamento.Name = "dtLancamento";
            this.dtLancamento.Size = new System.Drawing.Size(127, 18);
            this.dtLancamento.TabIndex = 437;
            this.dtLancamento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(15, 466);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(910, 2);
            this.textBox3.TabIndex = 441;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVencimento.Location = new System.Drawing.Point(432, 313);
            this.dtVencimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(127, 18);
            this.dtVencimento.TabIndex = 438;
            this.dtVencimento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblTipoLancPgto
            // 
            this.lblTipoLancPgto.AutoSize = true;
            this.lblTipoLancPgto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoLancPgto.Location = new System.Drawing.Point(26, 255);
            this.lblTipoLancPgto.Name = "lblTipoLancPgto";
            this.lblTipoLancPgto.Size = new System.Drawing.Size(166, 17);
            this.lblTipoLancPgto.TabIndex = 440;
            this.lblTipoLancPgto.Text = "TIPO LANÇAMENTO:";
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmissao.Location = new System.Drawing.Point(123, 337);
            this.dtEmissao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(127, 18);
            this.dtEmissao.TabIndex = 439;
            this.dtEmissao.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // FormCadPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 561);
            this.Controls.Add(this.cbPagoEm);
            this.Controls.Add(this.lblPagoEm);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotalPagoPagto);
            this.Controls.Add(this.txtTotalPagoPagto);
            this.Controls.Add(this.lblJurosPagto);
            this.Controls.Add(this.txtJurosPagto);
            this.Controls.Add(this.txtIdLancamento);
            this.Controls.Add(this.lblDtEmisPgto);
            this.Controls.Add(this.txtRazaoNomeDescricao);
            this.Controls.Add(this.cbSituacaoAbertaPaga);
            this.Controls.Add(this.lblNumDocPgto);
            this.Controls.Add(this.lblSituacaoAbertaPagaPgto);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtIdCdc);
            this.Controls.Add(this.lblIdCdcCodPgto);
            this.Controls.Add(this.rbEntrada);
            this.Controls.Add(this.lblCodCliFornPgto);
            this.Controls.Add(this.rbSaida);
            this.Controls.Add(this.txtCodCliFornPgto);
            this.Controls.Add(this.lblIdLancPgto);
            this.Controls.Add(this.lblComentariosPgto);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.dtPagamento);
            this.Controls.Add(this.lblDtVencPgto);
            this.Controls.Add(this.lblDtProgramacaoPgto);
            this.Controls.Add(this.txtDescricaoCdc);
            this.Controls.Add(this.lblValorTotalPgto);
            this.Controls.Add(this.lblLancamentoPgto);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dtLancamento);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(this.lblTipoLancPgto);
            this.Controls.Add(this.dtEmissao);
            this.Controls.Add(this.lblCnpjCpf);
            this.Controls.Add(this.lblRazaoNome);
            this.Controls.Add(this.txtCodCliForn);
            this.Controls.Add(this.lblCodCliForn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtlinha01);
            this.Controls.Add(this.txtlinha02);
            this.Controls.Add(this.txtlinha04);
            this.Controls.Add(this.txtlinha03);
            this.Controls.Add(this.txtlinha05);
            this.Controls.Add(this.lblAte04);
            this.Controls.Add(this.lblDe04);
            this.Controls.Add(this.DtAtePgto);
            this.Controls.Add(this.DtDePgto);
            this.Controls.Add(this.lblDtPgtoPesq);
            this.Controls.Add(this.lblIdCdc);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.lblNumDocumento);
            this.Controls.Add(this.lblAte03);
            this.Controls.Add(this.lblDe03);
            this.Controls.Add(this.DtAteVenc);
            this.Controls.Add(this.DtDeVenc);
            this.Controls.Add(this.lblDtVencPesq);
            this.Controls.Add(this.lblAte02);
            this.Controls.Add(this.lblDe02);
            this.Controls.Add(this.DtAteEmis);
            this.Controls.Add(this.DtDeEmis);
            this.Controls.Add(this.lblDtEmisPesq);
            this.Controls.Add(this.lblAte01);
            this.Controls.Add(this.lblDe01);
            this.Controls.Add(this.DtAteLanc);
            this.Controls.Add(this.DtDeLanc);
            this.Controls.Add(this.lblDtLancPesq);
            this.Controls.Add(this.btnPagas);
            this.Controls.Add(this.btnAberto);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblPesquisarPor);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.dgPagamentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblFormCadCliForn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
        private Label LblFormCadCliForn;
        private TextBox textBox1;
        private DataGridView dgPagamentos;
        private Label lblTipo;
        private Label lblPesquisarPor;
        private Label lblSituacao;
        private Button btnEntrada;
        private Button btnSaida;
        private Button btnTodos;
        private Button btnAberto;
        private Button btnPagas;
        private Label lblDtLancPesq;
        private DateTimePicker DtDeLanc;
        private DateTimePicker DtAteLanc;
        private Label lblDe01;
        private Label lblAte01;
        private Label lblAte02;
        private Label lblDe02;
        private DateTimePicker DtAteEmis;
        private DateTimePicker DtDeEmis;
        private Label lblDtEmisPesq;
        private Label lblAte03;
        private Label lblDe03;
        private DateTimePicker DtAteVenc;
        private DateTimePicker DtDeVenc;
        private Label lblDtVencPesq;
        private TextBox txtNumDocumento;
        private Label lblNumDocumento;
        private Label lblIdCdc;
        private Label lblAte04;
        private Label lblDe04;
        private DateTimePicker DtAtePgto;
        private DateTimePicker DtDePgto;
        private Label lblDtPgtoPesq;
        private TextBox txtlinha05;
        private TextBox txtlinha03;
        private TextBox txtlinha04;
        private TextBox txtlinha02;
        private TextBox txtlinha01;
        private Button button5;
        private Button btnLimpar;
        private TextBox txtCodCliForn;
        private Label lblCodCliForn;
        private Label lblRazaoNome;
        private BindingSource lancamentosBindingSource;
        private DataGridViewTextBoxColumn idLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn tipoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razaoNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnpjCpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCdcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoCdcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private BindingSource lancamentosBindingSource1;
        private Label lblCnpjCpf;
        private Label lblSituacaoAbertaPaga;
        private Label lblIdLancamento;
        private Label lblValorTotal;
        private Label lblTipoLancamento;
        private Label lblLancamento;
        private Label lblDtVenc;
        private Label lblComentarios;
        private Label lblCodCliForne;
        private Label lblCodCdc;
        private Label lblNumDoc;
        private Label lblDtEmis;
        private ComboBox cbPagoEm;
        private Label lblPagoEm;
        private TextBox textBox4;
        private Label lblTotalPagoPagto;
        private TextBox txtTotalPagoPagto;
        private Label lblJurosPagto;
        private TextBox txtJurosPagto;
        private TextBox txtIdLancamento;
        private Label lblDtEmisPgto;
        private TextBox txtRazaoNomeDescricao;
        private ComboBox cbSituacaoAbertaPaga;
        private Label lblNumDocPgto;
        private Label lblSituacaoAbertaPagaPgto;
        private TextBox txtNumDoc;
        private TextBox txtIdCdc;
        private Label lblIdCdcCodPgto;
        private RadioButton rbEntrada;
        private Label lblCodCliFornPgto;
        private RadioButton rbSaida;
        private TextBox txtCodCliFornPgto;
        private Label lblIdLancPgto;
        private Label lblComentariosPgto;
        private TextBox txtComentarios;
        private DateTimePicker dtPagamento;
        private Label lblDtVencPgto;
        private Label lblDtProgramacaoPgto;
        private TextBox txtDescricaoCdc;
        private Label lblValorTotalPgto;
        private Label lblLancamentoPgto;
        private TextBox txtValorTotal;
        private DateTimePicker dtLancamento;
        private TextBox textBox3;
        private DateTimePicker dtVencimento;
        private Label lblTipoLancPgto;
        private DateTimePicker dtEmissao;
    }
}