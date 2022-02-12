namespace Cinema
{
    partial class NovoFilme
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuração = new System.Windows.Forms.Label();
            this.lblImagem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.ritxtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbCaminhoImagem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(55, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblDuração
            // 
            this.lblDuração.AutoSize = true;
            this.lblDuração.Location = new System.Drawing.Point(42, 109);
            this.lblDuração.Name = "lblDuração";
            this.lblDuração.Size = new System.Drawing.Size(51, 13);
            this.lblDuração.TabIndex = 1;
            this.lblDuração.Text = "Duração:";
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(15, 152);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(78, 13);
            this.lblImagem.TabIndex = 2;
            this.lblImagem.Text = "Inserir Imagem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(99, 62);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(381, 20);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // ritxtDescricao
            // 
            this.ritxtDescricao.Location = new System.Drawing.Point(99, 232);
            this.ritxtDescricao.MaxLength = 500;
            this.ritxtDescricao.Name = "ritxtDescricao";
            this.ritxtDescricao.Size = new System.Drawing.Size(400, 96);
            this.ritxtDescricao.TabIndex = 6;
            this.ritxtDescricao.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(424, 317);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(406, 152);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(93, 23);
            this.btnImagem.TabIndex = 8;
            this.btnImagem.Text = "Inserir imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(99, 106);
            this.txtDuracao.MaxLength = 100;
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(381, 20);
            this.txtDuracao.TabIndex = 9;
            this.txtDuracao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(99, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 58);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbCaminhoImagem
            // 
            this.tbCaminhoImagem.Location = new System.Drawing.Point(99, 196);
            this.tbCaminhoImagem.MaxLength = 100;
            this.tbCaminhoImagem.Name = "tbCaminhoImagem";
            this.tbCaminhoImagem.ReadOnly = true;
            this.tbCaminhoImagem.Size = new System.Drawing.Size(381, 20);
            this.tbCaminhoImagem.TabIndex = 11;
            // 
            // NovoFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 417);
            this.Controls.Add(this.tbCaminhoImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ritxtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.lblDuração);
            this.Controls.Add(this.lblTitulo);
            this.Name = "NovoFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar novo filme";
            this.Load += new System.EventHandler(this.NovoFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuração;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox ritxtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbCaminhoImagem;
    }
}