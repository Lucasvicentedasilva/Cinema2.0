namespace Cinema
{
    partial class frmFilme
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
            this.lblFilme = new System.Windows.Forms.Label();
            this.btnNovFilme = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            this.lvFilmes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilme.Location = new System.Drawing.Point(1, 2);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(103, 33);
            this.lblFilme.TabIndex = 0;
            this.lblFilme.Text = "Filmes";
            this.lblFilme.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNovFilme
            // 
            this.btnNovFilme.FlatAppearance.BorderSize = 0;
            this.btnNovFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovFilme.Image = global::Cinema.Properties.Resources.adicionar;
            this.btnNovFilme.Location = new System.Drawing.Point(22, 64);
            this.btnNovFilme.Name = "btnNovFilme";
            this.btnNovFilme.Size = new System.Drawing.Size(40, 40);
            this.btnNovFilme.TabIndex = 4;
            this.btnNovFilme.UseVisualStyleBackColor = true;
            this.btnNovFilme.Click += new System.EventHandler(this.btnNovFilme_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            // 
            // lvFilmes
            // 
            this.lvFilmes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFilmes.HideSelection = false;
            this.lvFilmes.Location = new System.Drawing.Point(22, 110);
            this.lvFilmes.Name = "lvFilmes";
            this.lvFilmes.Size = new System.Drawing.Size(774, 243);
            this.lvFilmes.TabIndex = 5;
            this.lvFilmes.UseCompatibleStateImageBehavior = false;
            this.lvFilmes.View = System.Windows.Forms.View.Details;
            this.lvFilmes.SelectedIndexChanged += new System.EventHandler(this.lvFilmes_SelectedIndexChanged_1);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Título";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duração";
            this.columnHeader3.Width = 100;
            // 
            // frmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lvFilmes);
            this.Controls.Add(this.btnNovFilme);
            this.Controls.Add(this.lblFilme);
            this.Name = "frmFilme";
            this.Size = new System.Drawing.Size(846, 593);
            this.Load += new System.EventHandler(this.frmFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.Button btnNovFilme;
        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
        private System.Windows.Forms.ListView lvFilmes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
