namespace Cinema
{
    partial class frmSessoes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSala1 = new System.Windows.Forms.Label();
            this.lblFilme1 = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblAnimacao = new System.Windows.Forms.Label();
            this.lblVrIng = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHrInicial = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtDataSessao = new System.Windows.Forms.DateTimePicker();
            this.cbAnimacao = new System.Windows.Forms.ComboBox();
            this.cbAudio = new System.Windows.Forms.ComboBox();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.dtHrInicio = new System.Windows.Forms.DateTimePicker();
            this.dtHrFim = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSessoes
            // 
            this.lblSessoes.AutoSize = true;
            this.lblSessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessoes.Location = new System.Drawing.Point(3, 1);
            this.lblSessoes.Name = "lblSessoes";
            this.lblSessoes.Size = new System.Drawing.Size(127, 33);
            this.lblSessoes.TabIndex = 0;
            this.lblSessoes.Text = "Sessões";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(183, 129);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblSala1
            // 
            this.lblSala1.AutoSize = true;
            this.lblSala1.Location = new System.Drawing.Point(413, 273);
            this.lblSala1.Name = "lblSala1";
            this.lblSala1.Size = new System.Drawing.Size(31, 13);
            this.lblSala1.TabIndex = 2;
            this.lblSala1.Text = "Sala:";
            // 
            // lblFilme1
            // 
            this.lblFilme1.AutoSize = true;
            this.lblFilme1.Location = new System.Drawing.Point(410, 226);
            this.lblFilme1.Name = "lblFilme1";
            this.lblFilme1.Size = new System.Drawing.Size(34, 13);
            this.lblFilme1.TabIndex = 3;
            this.lblFilme1.Text = "Filme:";
            this.lblFilme1.Click += new System.EventHandler(this.lblFilme1_Click);
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(407, 173);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(37, 13);
            this.lblAudio.TabIndex = 4;
            this.lblAudio.Text = "Áudio:";
            // 
            // lblAnimacao
            // 
            this.lblAnimacao.AutoSize = true;
            this.lblAnimacao.Location = new System.Drawing.Point(387, 129);
            this.lblAnimacao.Name = "lblAnimacao";
            this.lblAnimacao.Size = new System.Drawing.Size(57, 13);
            this.lblAnimacao.TabIndex = 5;
            this.lblAnimacao.Text = "Animação:";
            // 
            // lblVrIng
            // 
            this.lblVrIng.AutoSize = true;
            this.lblVrIng.Location = new System.Drawing.Point(128, 273);
            this.lblVrIng.Name = "lblVrIng";
            this.lblVrIng.Size = new System.Drawing.Size(92, 13);
            this.lblVrIng.TabIndex = 6;
            this.lblVrIng.Text = "Valor do Ingresso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Horário do fim:";
            // 
            // lblHrInicial
            // 
            this.lblHrInicial.AutoSize = true;
            this.lblHrInicial.Location = new System.Drawing.Point(128, 173);
            this.lblHrInicial.Name = "lblHrInicial";
            this.lblHrInicial.Size = new System.Drawing.Size(88, 13);
            this.lblHrInicial.TabIndex = 8;
            this.lblHrInicial.Text = "Horário de início:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(496, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtDataSessao
            // 
            this.dtDataSessao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataSessao.Location = new System.Drawing.Point(222, 127);
            this.dtDataSessao.Name = "dtDataSessao";
            this.dtDataSessao.Size = new System.Drawing.Size(84, 20);
            this.dtDataSessao.TabIndex = 11;
            // 
            // cbAnimacao
            // 
            this.cbAnimacao.AutoCompleteCustomSource.AddRange(new string[] {
            "SELECIONE",
            "2D",
            "3D"});
            this.cbAnimacao.FormattingEnabled = true;
            this.cbAnimacao.Items.AddRange(new object[] {
            "",
            "2D",
            "3D"});
            this.cbAnimacao.Location = new System.Drawing.Point(450, 126);
            this.cbAnimacao.Name = "cbAnimacao";
            this.cbAnimacao.Size = new System.Drawing.Size(121, 21);
            this.cbAnimacao.TabIndex = 12;
            this.cbAnimacao.SelectedIndexChanged += new System.EventHandler(this.cbAnimacao_SelectedIndexChanged);
            // 
            // cbAudio
            // 
            this.cbAudio.AutoCompleteCustomSource.AddRange(new string[] {
            "SELECIONE",
            "ORIGINAL",
            "DUBLADO"});
            this.cbAudio.FormattingEnabled = true;
            this.cbAudio.Items.AddRange(new object[] {
            "",
            "Original",
            "Dublado"});
            this.cbAudio.Location = new System.Drawing.Point(450, 170);
            this.cbAudio.Name = "cbAudio";
            this.cbAudio.Size = new System.Drawing.Size(121, 21);
            this.cbAudio.TabIndex = 13;
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Items.AddRange(new object[] {
            "",
            "A era do gelo",
            "Madagascar"});
            this.cbFilme.Location = new System.Drawing.Point(450, 223);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(121, 21);
            this.cbFilme.TabIndex = 14;
            this.cbFilme.SelectedIndexChanged += new System.EventHandler(this.cbFilme_SelectedIndexChanged);
            this.cbFilme.SelectedValueChanged += new System.EventHandler(this.cbFilme_SelectedValueChanged);
            // 
            // cbSala
            // 
            this.cbSala.AutoCompleteCustomSource.AddRange(new string[] {
            "SELECIONE",
            "SALA 01",
            "SALA 02",
            "SALA 03"});
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Items.AddRange(new object[] {
            "",
            "Sala 01",
            "Sala 02",
            "Sala 03"});
            this.cbSala.Location = new System.Drawing.Point(450, 270);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 15;
            // 
            // dtHrInicio
            // 
            this.dtHrInicio.CustomFormat = "HH:mm";
            this.dtHrInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrInicio.Location = new System.Drawing.Point(222, 170);
            this.dtHrInicio.Name = "dtHrInicio";
            this.dtHrInicio.ShowUpDown = true;
            this.dtHrInicio.Size = new System.Drawing.Size(66, 20);
            this.dtHrInicio.TabIndex = 16;
            this.dtHrInicio.ValueChanged += new System.EventHandler(this.dtHrInicio_ValueChanged);
            // 
            // dtHrFim
            // 
            this.dtHrFim.CustomFormat = "HH:mm";
            this.dtHrFim.Enabled = false;
            this.dtHrFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrFim.Location = new System.Drawing.Point(222, 223);
            this.dtHrFim.Name = "dtHrFim";
            this.dtHrFim.Size = new System.Drawing.Size(66, 20);
            this.dtHrFim.TabIndex = 17;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(222, 270);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 18;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(82, 377);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(489, 150);
            this.dgvPesquisa.TabIndex = 19;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.txtBusca);
            this.gbPesquisa.Location = new System.Drawing.Point(92, 349);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(321, 28);
            this.gbPesquisa.TabIndex = 20;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisar Sessões:";
            this.gbPesquisa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(112, 0);
            this.txtBusca.MaxLength = 20;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(203, 20);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(125, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 13);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome da Sessão:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(222, 97);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 20);
            this.txtNome.TabIndex = 22;
            // 
            // frmSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dtHrFim);
            this.Controls.Add(this.dtHrInicio);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.cbAudio);
            this.Controls.Add(this.cbAnimacao);
            this.Controls.Add(this.dtDataSessao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblHrInicial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVrIng);
            this.Controls.Add(this.lblAnimacao);
            this.Controls.Add(this.lblAudio);
            this.Controls.Add(this.lblFilme1);
            this.Controls.Add(this.lblSala1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSessoes);
            this.Name = "frmSessoes";
            this.Size = new System.Drawing.Size(848, 595);
            this.Load += new System.EventHandler(this.frmSessoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSala1;
        private System.Windows.Forms.Label lblFilme1;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.Label lblAnimacao;
        private System.Windows.Forms.Label lblVrIng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHrInicial;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtDataSessao;
        private System.Windows.Forms.ComboBox cbAnimacao;
        private System.Windows.Forms.ComboBox cbAudio;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.DateTimePicker dtHrInicio;
        private System.Windows.Forms.DateTimePicker dtHrFim;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
    }
}
