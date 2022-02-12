namespace Cinema
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSessoes = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.frmSessoes1 = new Cinema.frmSessoes();
            this.frmSala1 = new Cinema.frmSala();
            this.frmFilme1 = new Cinema.frmFilme();
            this.telaGerente1 = new Cinema.telaGerente();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnSessoes);
            this.pnlMenu.Controls.Add(this.btnFilme);
            this.pnlMenu.Controls.Add(this.btnSalas);
            this.pnlMenu.Controls.Add(this.btnAdm);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 556);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Image = global::Cinema.Properties.Resources.power;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(0, 504);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(220, 50);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = " Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSessoes
            // 
            this.btnSessoes.FlatAppearance.BorderSize = 0;
            this.btnSessoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessoes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSessoes.Image = global::Cinema.Properties.Resources.play_alt_1_;
            this.btnSessoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessoes.Location = new System.Drawing.Point(0, 153);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.Size = new System.Drawing.Size(220, 50);
            this.btnSessoes.TabIndex = 4;
            this.btnSessoes.Text = " Sessões";
            this.btnSessoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSessoes.UseVisualStyleBackColor = true;
            this.btnSessoes.Click += new System.EventHandler(this.btnSessoes_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.FlatAppearance.BorderSize = 0;
            this.btnFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFilme.Image = global::Cinema.Properties.Resources.film;
            this.btnFilme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilme.Location = new System.Drawing.Point(0, 102);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(220, 50);
            this.btnFilme.TabIndex = 3;
            this.btnFilme.Text = " Filmes";
            this.btnFilme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalas.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalas.Image = global::Cinema.Properties.Resources.video_camera;
            this.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.Location = new System.Drawing.Point(0, 51);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(220, 50);
            this.btnSalas.TabIndex = 2;
            this.btnSalas.Text = " Salas";
            this.btnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdm.Image = global::Cinema.Properties.Resources.user;
            this.btnAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.Location = new System.Drawing.Point(0, 0);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(220, 50);
            this.btnAdm.TabIndex = 1;
            this.btnAdm.Text = " Administrador";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // frmSessoes1
            // 
            this.frmSessoes1.BackColor = System.Drawing.Color.White;
            this.frmSessoes1.Location = new System.Drawing.Point(216, 0);
            this.frmSessoes1.Name = "frmSessoes1";
            this.frmSessoes1.Size = new System.Drawing.Size(848, 595);
            this.frmSessoes1.TabIndex = 4;
            this.frmSessoes1.Load += new System.EventHandler(this.frmSessoes1_Load);
            // 
            // frmSala1
            // 
            this.frmSala1.Location = new System.Drawing.Point(216, 0);
            this.frmSala1.Name = "frmSala1";
            this.frmSala1.Size = new System.Drawing.Size(848, 595);
            this.frmSala1.TabIndex = 3;
            // 
            // frmFilme1
            // 
            this.frmFilme1.Location = new System.Drawing.Point(216, 0);
            this.frmFilme1.Name = "frmFilme1";
            this.frmFilme1.Size = new System.Drawing.Size(848, 595);
            this.frmFilme1.TabIndex = 2;
            // 
            // telaGerente1
            // 
            this.telaGerente1.Location = new System.Drawing.Point(216, 0);
            this.telaGerente1.Name = "telaGerente1";
            this.telaGerente1.Size = new System.Drawing.Size(840, 595);
            this.telaGerente1.TabIndex = 1;
            this.telaGerente1.Load += new System.EventHandler(this.telaGerente1_Load);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 556);
            this.Controls.Add(this.frmSessoes1);
            this.Controls.Add(this.frmSala1);
            this.Controls.Add(this.frmFilme1);
            this.Controls.Add(this.telaGerente1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSessoes;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Button btnAdm;
        private telaGerente telaGerente1;
        private System.Windows.Forms.Button btnSair;
        private frmFilme frmFilme1;
        private frmSala frmSala1;
        private frmSessoes frmSessoes1;
    }
}