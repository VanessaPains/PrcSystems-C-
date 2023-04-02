namespace prcSystem.View
{
    partial class FormCadCliFornPesquisar
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
            this.LblFormCadCliForn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgExibirCliForn = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outrasInscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufCobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblPesquisarCliForn = new System.Windows.Forms.Label();
            this.TxtPesquisaCodCliForn = new System.Windows.Forms.TextBox();
            this.TxtPesquisarNomeRazaoCpfCnpj = new System.Windows.Forms.TextBox();
            this.BtnPesquisarCliForn = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisarRazaoNomeCliForn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgExibirCliForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
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
            this.label3.TabIndex = 122;
            this.label3.Text = "PRC Systems @";
            // 
            // LblFormCadCliForn
            // 
            this.LblFormCadCliForn.AutoSize = true;
            this.LblFormCadCliForn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormCadCliForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFormCadCliForn.Location = new System.Drawing.Point(99, 9);
            this.LblFormCadCliForn.Name = "LblFormCadCliForn";
            this.LblFormCadCliForn.Size = new System.Drawing.Size(303, 22);
            this.LblFormCadCliForn.TabIndex = 125;
            this.LblFormCadCliForn.Text = "PESQUISA DE FORNECEDORES";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(14, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(910, 2);
            this.textBox1.TabIndex = 124;
            // 
            // DgExibirCliForn
            // 
            this.DgExibirCliForn.AllowUserToAddRows = false;
            this.DgExibirCliForn.AllowUserToDeleteRows = false;
            this.DgExibirCliForn.AllowUserToOrderColumns = true;
            this.DgExibirCliForn.AutoGenerateColumns = false;
            this.DgExibirCliForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgExibirCliForn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.tipoCadastroDataGridViewTextBoxColumn,
            this.tipoPessoaDataGridViewTextBoxColumn,
            this.cnpjCpfDataGridViewTextBoxColumn,
            this.razaoNomeDataGridViewTextBoxColumn,
            this.fantasiaDataGridViewTextBoxColumn,
            this.inscEstadualDataGridViewTextBoxColumn,
            this.outrasInscDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn,
            this.enderecoCobDataGridViewTextBoxColumn,
            this.numCobDataGridViewTextBoxColumn,
            this.complementoCobDataGridViewTextBoxColumn,
            this.cepCobDataGridViewTextBoxColumn,
            this.bairroCobDataGridViewTextBoxColumn,
            this.cidadeCobDataGridViewTextBoxColumn,
            this.ufCobDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dtCadPessoaDataGridViewTextBoxColumn});
            this.DgExibirCliForn.DataSource = this.pessoaBindingSource;
            this.DgExibirCliForn.Location = new System.Drawing.Point(14, 133);
            this.DgExibirCliForn.Name = "DgExibirCliForn";
            this.DgExibirCliForn.ReadOnly = true;
            this.DgExibirCliForn.RowTemplate.Height = 25;
            this.DgExibirCliForn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgExibirCliForn.Size = new System.Drawing.Size(910, 362);
            this.DgExibirCliForn.TabIndex = 128;
            this.DgExibirCliForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgExibirCliForn_CellContentClick);
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoCadastroDataGridViewTextBoxColumn
            // 
            this.tipoCadastroDataGridViewTextBoxColumn.DataPropertyName = "TipoCadastro";
            this.tipoCadastroDataGridViewTextBoxColumn.HeaderText = "TipoCadastro";
            this.tipoCadastroDataGridViewTextBoxColumn.Name = "tipoCadastroDataGridViewTextBoxColumn";
            this.tipoCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPessoaDataGridViewTextBoxColumn
            // 
            this.tipoPessoaDataGridViewTextBoxColumn.DataPropertyName = "TipoPessoa";
            this.tipoPessoaDataGridViewTextBoxColumn.HeaderText = "TipoPessoa";
            this.tipoPessoaDataGridViewTextBoxColumn.Name = "tipoPessoaDataGridViewTextBoxColumn";
            this.tipoPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjCpfDataGridViewTextBoxColumn
            // 
            this.cnpjCpfDataGridViewTextBoxColumn.DataPropertyName = "CnpjCpf";
            this.cnpjCpfDataGridViewTextBoxColumn.HeaderText = "CnpjCpf";
            this.cnpjCpfDataGridViewTextBoxColumn.Name = "cnpjCpfDataGridViewTextBoxColumn";
            this.cnpjCpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoNomeDataGridViewTextBoxColumn
            // 
            this.razaoNomeDataGridViewTextBoxColumn.DataPropertyName = "RazaoNome";
            this.razaoNomeDataGridViewTextBoxColumn.HeaderText = "RazaoNome";
            this.razaoNomeDataGridViewTextBoxColumn.Name = "razaoNomeDataGridViewTextBoxColumn";
            this.razaoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fantasiaDataGridViewTextBoxColumn
            // 
            this.fantasiaDataGridViewTextBoxColumn.DataPropertyName = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.HeaderText = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.Name = "fantasiaDataGridViewTextBoxColumn";
            this.fantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscEstadualDataGridViewTextBoxColumn
            // 
            this.inscEstadualDataGridViewTextBoxColumn.DataPropertyName = "InscEstadual";
            this.inscEstadualDataGridViewTextBoxColumn.HeaderText = "InscEstadual";
            this.inscEstadualDataGridViewTextBoxColumn.Name = "inscEstadualDataGridViewTextBoxColumn";
            this.inscEstadualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outrasInscDataGridViewTextBoxColumn
            // 
            this.outrasInscDataGridViewTextBoxColumn.DataPropertyName = "OutrasInsc";
            this.outrasInscDataGridViewTextBoxColumn.HeaderText = "OutrasInsc";
            this.outrasInscDataGridViewTextBoxColumn.Name = "outrasInscDataGridViewTextBoxColumn";
            this.outrasInscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoCobDataGridViewTextBoxColumn
            // 
            this.enderecoCobDataGridViewTextBoxColumn.DataPropertyName = "EnderecoCob";
            this.enderecoCobDataGridViewTextBoxColumn.HeaderText = "EnderecoCob";
            this.enderecoCobDataGridViewTextBoxColumn.Name = "enderecoCobDataGridViewTextBoxColumn";
            this.enderecoCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numCobDataGridViewTextBoxColumn
            // 
            this.numCobDataGridViewTextBoxColumn.DataPropertyName = "NumCob";
            this.numCobDataGridViewTextBoxColumn.HeaderText = "NumCob";
            this.numCobDataGridViewTextBoxColumn.Name = "numCobDataGridViewTextBoxColumn";
            this.numCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoCobDataGridViewTextBoxColumn
            // 
            this.complementoCobDataGridViewTextBoxColumn.DataPropertyName = "ComplementoCob";
            this.complementoCobDataGridViewTextBoxColumn.HeaderText = "ComplementoCob";
            this.complementoCobDataGridViewTextBoxColumn.Name = "complementoCobDataGridViewTextBoxColumn";
            this.complementoCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepCobDataGridViewTextBoxColumn
            // 
            this.cepCobDataGridViewTextBoxColumn.DataPropertyName = "CepCob";
            this.cepCobDataGridViewTextBoxColumn.HeaderText = "CepCob";
            this.cepCobDataGridViewTextBoxColumn.Name = "cepCobDataGridViewTextBoxColumn";
            this.cepCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroCobDataGridViewTextBoxColumn
            // 
            this.bairroCobDataGridViewTextBoxColumn.DataPropertyName = "BairroCob";
            this.bairroCobDataGridViewTextBoxColumn.HeaderText = "BairroCob";
            this.bairroCobDataGridViewTextBoxColumn.Name = "bairroCobDataGridViewTextBoxColumn";
            this.bairroCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeCobDataGridViewTextBoxColumn
            // 
            this.cidadeCobDataGridViewTextBoxColumn.DataPropertyName = "CidadeCob";
            this.cidadeCobDataGridViewTextBoxColumn.HeaderText = "CidadeCob";
            this.cidadeCobDataGridViewTextBoxColumn.Name = "cidadeCobDataGridViewTextBoxColumn";
            this.cidadeCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufCobDataGridViewTextBoxColumn
            // 
            this.ufCobDataGridViewTextBoxColumn.DataPropertyName = "UfCob";
            this.ufCobDataGridViewTextBoxColumn.HeaderText = "UfCob";
            this.ufCobDataGridViewTextBoxColumn.Name = "ufCobDataGridViewTextBoxColumn";
            this.ufCobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtCadPessoaDataGridViewTextBoxColumn
            // 
            this.dtCadPessoaDataGridViewTextBoxColumn.DataPropertyName = "DtCadPessoa";
            this.dtCadPessoaDataGridViewTextBoxColumn.HeaderText = "DtCadPessoa";
            this.dtCadPessoaDataGridViewTextBoxColumn.Name = "dtCadPessoaDataGridViewTextBoxColumn";
            this.dtCadPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(prcSystem.Entidades.Pessoa);
            // 
            // LblPesquisarCliForn
            // 
            this.LblPesquisarCliForn.AutoSize = true;
            this.LblPesquisarCliForn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPesquisarCliForn.Location = new System.Drawing.Point(12, 72);
            this.LblPesquisarCliForn.Name = "LblPesquisarCliForn";
            this.LblPesquisarCliForn.Size = new System.Drawing.Size(94, 12);
            this.LblPesquisarCliForn.TabIndex = 129;
            this.LblPesquisarCliForn.Text = "PESQUISAR POR:";
            // 
            // TxtPesquisaCodCliForn
            // 
            this.TxtPesquisaCodCliForn.Location = new System.Drawing.Point(14, 87);
            this.TxtPesquisaCodCliForn.Name = "TxtPesquisaCodCliForn";
            this.TxtPesquisaCodCliForn.PlaceholderText = "COD. DO CLIENTE";
            this.TxtPesquisaCodCliForn.Size = new System.Drawing.Size(119, 23);
            this.TxtPesquisaCodCliForn.TabIndex = 130;
            this.TxtPesquisaCodCliForn.TextChanged += new System.EventHandler(this.TxtPesquisaCodCliForn_TextChanged);
            // 
            // TxtPesquisarNomeRazaoCpfCnpj
            // 
            this.TxtPesquisarNomeRazaoCpfCnpj.Location = new System.Drawing.Point(139, 87);
            this.TxtPesquisarNomeRazaoCpfCnpj.Name = "TxtPesquisarNomeRazaoCpfCnpj";
            this.TxtPesquisarNomeRazaoCpfCnpj.PlaceholderText = "RAZÃO / NOME ";
            this.TxtPesquisarNomeRazaoCpfCnpj.Size = new System.Drawing.Size(309, 23);
            this.TxtPesquisarNomeRazaoCpfCnpj.TabIndex = 131;
            this.TxtPesquisarNomeRazaoCpfCnpj.TextChanged += new System.EventHandler(this.TxtPesquisarNomeRazaoCpfCnpj_TextChanged);
            // 
            // BtnPesquisarCliForn
            // 
            this.BtnPesquisarCliForn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPesquisarCliForn.Location = new System.Drawing.Point(458, 87);
            this.BtnPesquisarCliForn.Name = "BtnPesquisarCliForn";
            this.BtnPesquisarCliForn.Size = new System.Drawing.Size(100, 23);
            this.BtnPesquisarCliForn.TabIndex = 132;
            this.BtnPesquisarCliForn.Text = "PESQUISAR";
            this.BtnPesquisarCliForn.UseVisualStyleBackColor = true;
            this.BtnPesquisarCliForn.Click += new System.EventHandler(this.BtnPesquisarCliForn_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimpar.Location = new System.Drawing.Point(835, 9);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(89, 25);
            this.BtnLimpar.TabIndex = 317;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnPesquisarRazaoNomeCliForn
            // 
            this.BtnPesquisarRazaoNomeCliForn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPesquisarRazaoNomeCliForn.Location = new System.Drawing.Point(458, 87);
            this.BtnPesquisarRazaoNomeCliForn.Name = "BtnPesquisarRazaoNomeCliForn";
            this.BtnPesquisarRazaoNomeCliForn.Size = new System.Drawing.Size(100, 23);
            this.BtnPesquisarRazaoNomeCliForn.TabIndex = 318;
            this.BtnPesquisarRazaoNomeCliForn.Text = "PESQUISAR";
            this.BtnPesquisarRazaoNomeCliForn.UseVisualStyleBackColor = true;
            this.BtnPesquisarRazaoNomeCliForn.Click += new System.EventHandler(this.BtnPesquisarRazaoNomeCliForn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prcSystem.Properties.Resources.logoComunicacaoVisual2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 319;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(740, 9);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(89, 25);
            this.BtnExcluir.TabIndex = 320;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(822, 87);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(100, 23);
            this.txtIdPessoa.TabIndex = 321;
            this.txtIdPessoa.Visible = false;
            // 
            // FormCadCliFornPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.txtIdPessoa);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPesquisarRazaoNomeCliForn);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisarCliForn);
            this.Controls.Add(this.TxtPesquisarNomeRazaoCpfCnpj);
            this.Controls.Add(this.TxtPesquisaCodCliForn);
            this.Controls.Add(this.LblPesquisarCliForn);
            this.Controls.Add(this.DgExibirCliForn);
            this.Controls.Add(this.LblFormCadCliForn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "FormCadCliFornPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRC Systems";
            ((System.ComponentModel.ISupportInitialize)(this.DgExibirCliForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label LblFormCadCliForn;
        private TextBox textBox1;
        private DataGridView DgExibirCliForn;
        private BindingSource pessoaBindingSource;
        private Label LblPesquisarCliForn;
        private TextBox TxtPesquisaCodCliForn;
        private TextBox TxtPesquisarNomeRazaoCpfCnpj;
        private Button BtnPesquisarCliForn;
        private Button BtnLimpar;
        private Button BtnPesquisarRazaoNomeCliForn;
        private PictureBox pictureBox1;
        private Button BtnExcluir;
        private TextBox txtIdPessoa;
        private DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoCadastroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPessoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cnpjCpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razaoNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fantasiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inscEstadualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outrasInscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn complementoCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ufCobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dtCadPessoaDataGridViewTextBoxColumn;
    }
}