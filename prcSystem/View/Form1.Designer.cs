namespace prcSystem.View
{
    partial class Form1
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
            this.lblJurosPagto = new System.Windows.Forms.Label();
            this.txtJurosPagto = new System.Windows.Forms.TextBox();
            this.lblTotaPagoPagto = new System.Windows.Forms.Label();
            this.txtTotaPagoPagto = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbPagoEm = new System.Windows.Forms.ComboBox();
            this.lblPagoEm = new System.Windows.Forms.Label();
            this.cdcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFormCadCliForn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cdcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdLancamento
            // 
            this.txtIdLancamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdLancamento.Location = new System.Drawing.Point(452, 78);
            this.txtIdLancamento.Name = "txtIdLancamento";
            this.txtIdLancamento.Size = new System.Drawing.Size(100, 18);
            this.txtIdLancamento.TabIndex = 411;
            // 
            // lblDtEmisPgto
            // 
            this.lblDtEmisPgto.AutoSize = true;
            this.lblDtEmisPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtEmisPgto.Location = new System.Drawing.Point(51, 148);
            this.lblDtEmisPgto.Name = "lblDtEmisPgto";
            this.lblDtEmisPgto.Size = new System.Drawing.Size(63, 12);
            this.lblDtEmisPgto.TabIndex = 418;
            this.lblDtEmisPgto.Text = "DT EMISSÃO:";
            // 
            // txtRazaoNomeDescricao
            // 
            this.txtRazaoNomeDescricao.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazaoNomeDescricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtRazaoNomeDescricao.Location = new System.Drawing.Point(182, 170);
            this.txtRazaoNomeDescricao.Name = "txtRazaoNomeDescricao";
            this.txtRazaoNomeDescricao.PlaceholderText = "Descrição";
            this.txtRazaoNomeDescricao.Size = new System.Drawing.Size(375, 18);
            this.txtRazaoNomeDescricao.TabIndex = 391;
            // 
            // cbSituacaoAbertaPaga
            // 
            this.cbSituacaoAbertaPaga.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSituacaoAbertaPaga.FormattingEnabled = true;
            this.cbSituacaoAbertaPaga.Items.AddRange(new object[] {
            "EM ABERTO"});
            this.cbSituacaoAbertaPaga.Location = new System.Drawing.Point(707, 146);
            this.cbSituacaoAbertaPaga.Name = "cbSituacaoAbertaPaga";
            this.cbSituacaoAbertaPaga.Size = new System.Drawing.Size(117, 20);
            this.cbSituacaoAbertaPaga.TabIndex = 417;
            // 
            // lblNumDocPgto
            // 
            this.lblNumDocPgto.AutoSize = true;
            this.lblNumDocPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocPgto.Location = new System.Drawing.Point(659, 125);
            this.lblNumDocPgto.Name = "lblNumDocPgto";
            this.lblNumDocPgto.Size = new System.Drawing.Size(42, 12);
            this.lblNumDocPgto.TabIndex = 392;
            this.lblNumDocPgto.Text = "Nº. DOC:";
            // 
            // lblSituacaoAbertaPagaPgto
            // 
            this.lblSituacaoAbertaPagaPgto.AutoSize = true;
            this.lblSituacaoAbertaPagaPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacaoAbertaPagaPgto.Location = new System.Drawing.Point(645, 149);
            this.lblSituacaoAbertaPagaPgto.Name = "lblSituacaoAbertaPagaPgto";
            this.lblSituacaoAbertaPagaPgto.Size = new System.Drawing.Size(56, 12);
            this.lblSituacaoAbertaPagaPgto.TabIndex = 416;
            this.lblSituacaoAbertaPagaPgto.Text = "SITUAÇÃO:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumDoc.Location = new System.Drawing.Point(707, 122);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(117, 18);
            this.txtNumDoc.TabIndex = 393;
            // 
            // txtIdCdc
            // 
            this.txtIdCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdCdc.Location = new System.Drawing.Point(122, 194);
            this.txtIdCdc.Name = "txtIdCdc";
            this.txtIdCdc.Size = new System.Drawing.Size(60, 18);
            this.txtIdCdc.TabIndex = 415;
            // 
            // lblIdCdcCodPgto
            // 
            this.lblIdCdcCodPgto.AutoSize = true;
            this.lblIdCdcCodPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCdcCodPgto.Location = new System.Drawing.Point(88, 197);
            this.lblIdCdcCodPgto.Name = "lblIdCdcCodPgto";
            this.lblIdCdcCodPgto.Size = new System.Drawing.Size(28, 12);
            this.lblIdCdcCodPgto.TabIndex = 394;
            this.lblIdCdcCodPgto.Text = "CDC:";
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEntrada.Location = new System.Drawing.Point(196, 62);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(82, 19);
            this.rbEntrada.TabIndex = 414;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "ENTRADA";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.Visible = false;
            // 
            // lblCodCliFornPgto
            // 
            this.lblCodCliFornPgto.AutoSize = true;
            this.lblCodCliFornPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodCliFornPgto.Location = new System.Drawing.Point(57, 172);
            this.lblCodCliFornPgto.Name = "lblCodCliFornPgto";
            this.lblCodCliFornPgto.Size = new System.Drawing.Size(58, 12);
            this.lblCodCliFornPgto.TabIndex = 395;
            this.lblCodCliFornPgto.Text = "CLI / FORN:";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbSaida.Location = new System.Drawing.Point(284, 62);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(62, 19);
            this.rbSaida.TabIndex = 413;
            this.rbSaida.Text = "SAIDA";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.Visible = false;
            // 
            // txtCodCliFornPgto
            // 
            this.txtCodCliFornPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodCliFornPgto.Location = new System.Drawing.Point(121, 170);
            this.txtCodCliFornPgto.Name = "txtCodCliFornPgto";
            this.txtCodCliFornPgto.Size = new System.Drawing.Size(60, 18);
            this.txtCodCliFornPgto.TabIndex = 396;
            // 
            // lblIdLancPgto
            // 
            this.lblIdLancPgto.AutoSize = true;
            this.lblIdLancPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdLancPgto.Location = new System.Drawing.Point(455, 63);
            this.lblIdLancPgto.Name = "lblIdLancPgto";
            this.lblIdLancPgto.Size = new System.Drawing.Size(96, 12);
            this.lblIdLancPgto.TabIndex = 412;
            this.lblIdLancPgto.Text = "COD. LANÇAMENTO";
            // 
            // lblComentariosPgto
            // 
            this.lblComentariosPgto.AutoSize = true;
            this.lblComentariosPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComentariosPgto.Location = new System.Drawing.Point(38, 221);
            this.lblComentariosPgto.Name = "lblComentariosPgto";
            this.lblComentariosPgto.Size = new System.Drawing.Size(78, 12);
            this.lblComentariosPgto.TabIndex = 397;
            this.lblComentariosPgto.Text = "COMENTARIOS:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComentarios.Location = new System.Drawing.Point(122, 218);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(436, 44);
            this.txtComentarios.TabIndex = 398;
            // 
            // dtPagamento
            // 
            this.dtPagamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPagamento.Location = new System.Drawing.Point(430, 145);
            this.dtPagamento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(127, 18);
            this.dtPagamento.TabIndex = 410;
            this.dtPagamento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblDtVencPgto
            // 
            this.lblDtVencPgto.AutoSize = true;
            this.lblDtVencPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtVencPgto.Location = new System.Drawing.Point(376, 123);
            this.lblDtVencPgto.Name = "lblDtVencPgto";
            this.lblDtVencPgto.Size = new System.Drawing.Size(48, 12);
            this.lblDtVencPgto.TabIndex = 399;
            this.lblDtVencPgto.Text = "DT VENC:";
            // 
            // lblDtProgramacaoPgto
            // 
            this.lblDtProgramacaoPgto.AutoSize = true;
            this.lblDtProgramacaoPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDtProgramacaoPgto.Location = new System.Drawing.Point(286, 148);
            this.lblDtProgramacaoPgto.Name = "lblDtProgramacaoPgto";
            this.lblDtProgramacaoPgto.Size = new System.Drawing.Size(139, 12);
            this.lblDtProgramacaoPgto.TabIndex = 409;
            this.lblDtProgramacaoPgto.Text = "DT DE PROGRAMAÇÃO PGTO:";
            // 
            // txtDescricaoCdc
            // 
            this.txtDescricaoCdc.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoCdc.Location = new System.Drawing.Point(183, 194);
            this.txtDescricaoCdc.Name = "txtDescricaoCdc";
            this.txtDescricaoCdc.PlaceholderText = "Descrição";
            this.txtDescricaoCdc.Size = new System.Drawing.Size(375, 18);
            this.txtDescricaoCdc.TabIndex = 400;
            // 
            // lblValorTotalPgto
            // 
            this.lblValorTotalPgto.AutoSize = true;
            this.lblValorTotalPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotalPgto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblValorTotalPgto.Location = new System.Drawing.Point(623, 175);
            this.lblValorTotalPgto.Name = "lblValorTotalPgto";
            this.lblValorTotalPgto.Size = new System.Drawing.Size(78, 12);
            this.lblValorTotalPgto.TabIndex = 408;
            this.lblValorTotalPgto.Text = "VALOR TITULO:";
            // 
            // lblLancamentoPgto
            // 
            this.lblLancamentoPgto.AutoSize = true;
            this.lblLancamentoPgto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLancamentoPgto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLancamentoPgto.Location = new System.Drawing.Point(53, 124);
            this.lblLancamentoPgto.Name = "lblLancamentoPgto";
            this.lblLancamentoPgto.Size = new System.Drawing.Size(62, 12);
            this.lblLancamentoPgto.TabIndex = 401;
            this.lblLancamentoPgto.Text = "DATA LANÇ.:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorTotal.Location = new System.Drawing.Point(707, 172);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(117, 18);
            this.txtValorTotal.TabIndex = 407;
            // 
            // dtLancamento
            // 
            this.dtLancamento.CalendarFont = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtLancamento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLancamento.Location = new System.Drawing.Point(121, 121);
            this.dtLancamento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtLancamento.Name = "dtLancamento";
            this.dtLancamento.Size = new System.Drawing.Size(127, 18);
            this.dtLancamento.TabIndex = 402;
            this.dtLancamento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(13, 274);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(910, 2);
            this.textBox3.TabIndex = 406;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVencimento.Location = new System.Drawing.Point(430, 121);
            this.dtVencimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(127, 18);
            this.dtVencimento.TabIndex = 403;
            this.dtVencimento.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblTipoLancPgto
            // 
            this.lblTipoLancPgto.AutoSize = true;
            this.lblTipoLancPgto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoLancPgto.Location = new System.Drawing.Point(24, 63);
            this.lblTipoLancPgto.Name = "lblTipoLancPgto";
            this.lblTipoLancPgto.Size = new System.Drawing.Size(166, 17);
            this.lblTipoLancPgto.TabIndex = 405;
            this.lblTipoLancPgto.Text = "TIPO LANÇAMENTO:";
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmissao.Location = new System.Drawing.Point(121, 145);
            this.dtEmissao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(127, 18);
            this.dtEmissao.TabIndex = 404;
            this.dtEmissao.Value = new System.DateTime(2022, 11, 14, 0, 0, 0, 0);
            // 
            // lblJurosPagto
            // 
            this.lblJurosPagto.AutoSize = true;
            this.lblJurosPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJurosPagto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblJurosPagto.Location = new System.Drawing.Point(662, 199);
            this.lblJurosPagto.Name = "lblJurosPagto";
            this.lblJurosPagto.Size = new System.Drawing.Size(39, 12);
            this.lblJurosPagto.TabIndex = 420;
            this.lblJurosPagto.Text = "JUROS:";
            // 
            // txtJurosPagto
            // 
            this.txtJurosPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJurosPagto.Location = new System.Drawing.Point(707, 196);
            this.txtJurosPagto.Name = "txtJurosPagto";
            this.txtJurosPagto.Size = new System.Drawing.Size(117, 18);
            this.txtJurosPagto.TabIndex = 419;
            // 
            // lblTotaPagoPagto
            // 
            this.lblTotaPagoPagto.AutoSize = true;
            this.lblTotaPagoPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotaPagoPagto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotaPagoPagto.Location = new System.Drawing.Point(634, 223);
            this.lblTotaPagoPagto.Name = "lblTotaPagoPagto";
            this.lblTotaPagoPagto.Size = new System.Drawing.Size(67, 12);
            this.lblTotaPagoPagto.TabIndex = 422;
            this.lblTotaPagoPagto.Text = "TOTAL PAGO:";
            // 
            // txtTotaPagoPagto
            // 
            this.txtTotaPagoPagto.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotaPagoPagto.Location = new System.Drawing.Point(707, 220);
            this.txtTotaPagoPagto.Name = "txtTotaPagoPagto";
            this.txtTotaPagoPagto.Size = new System.Drawing.Size(117, 18);
            this.txtTotaPagoPagto.TabIndex = 421;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkGray;
            this.textBox4.Location = new System.Drawing.Point(593, 108);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(2, 160);
            this.textBox4.TabIndex = 423;
            // 
            // cbPagoEm
            // 
            this.cbPagoEm.DataSource = this.cdcBindingSource;
            this.cbPagoEm.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPagoEm.FormattingEnabled = true;
            this.cbPagoEm.Location = new System.Drawing.Point(707, 244);
            this.cbPagoEm.Name = "cbPagoEm";
            this.cbPagoEm.Size = new System.Drawing.Size(117, 20);
            this.cbPagoEm.TabIndex = 425;
            // 
            // lblPagoEm
            // 
            this.lblPagoEm.AutoSize = true;
            this.lblPagoEm.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPagoEm.Location = new System.Drawing.Point(651, 247);
            this.lblPagoEm.Name = "lblPagoEm";
            this.lblPagoEm.Size = new System.Drawing.Size(50, 12);
            this.lblPagoEm.TabIndex = 424;
            this.lblPagoEm.Text = "PAGO EM:";
            // 
            // cdcBindingSource
            // 
            this.cdcBindingSource.DataSource = typeof(prcSystem.Entidades.Cdc);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(719, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 430;
            this.button5.Text = "PESQUISAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(826, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 429;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(15, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 428;
            this.pictureBox1.TabStop = false;
            // 
            // LblFormCadCliForn
            // 
            this.LblFormCadCliForn.AutoSize = true;
            this.LblFormCadCliForn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadCliForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadCliForn.Location = new System.Drawing.Point(100, 9);
            this.LblFormCadCliForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFormCadCliForn.Name = "LblFormCadCliForn";
            this.LblFormCadCliForn.Size = new System.Drawing.Size(146, 22);
            this.LblFormCadCliForn.TabIndex = 427;
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
            this.textBox1.TabIndex = 426;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblFormCadCliForn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbPagoEm);
            this.Controls.Add(this.lblPagoEm);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotaPagoPagto);
            this.Controls.Add(this.txtTotaPagoPagto);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cdcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Label lblJurosPagto;
        private TextBox txtJurosPagto;
        private Label lblTotaPagoPagto;
        private TextBox txtTotaPagoPagto;
        private TextBox textBox4;
        private ComboBox cbPagoEm;
        private BindingSource cdcBindingSource;
        private Label lblPagoEm;
        private Button button5;
        private Button btnLimpar;
        private PictureBox pictureBox1;
        private Label LblFormCadCliForn;
        private TextBox textBox1;
    }
}