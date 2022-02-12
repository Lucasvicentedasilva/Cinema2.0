using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema
{
    public partial class frmFilme : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=HUNTER1;integrated security=SSPI;initial Catalog=db_cinema");




        public frmFilme()
        {
            InitializeComponent();

            string sql = "SELECT ds_Titulo,ds_Descricao,ds_Duracao FROM tbl_Filme";




            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(rdr["ds_Titulo"].ToString());
                    lvi.SubItems.Add(rdr["ds_Descricao"].ToString());
                    lvi.SubItems.Add(rdr["ds_Duracao"].ToString());

                    lvFilmes.Items.Add(lvi);
                }
            }
        }

        private void frmFilme_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovFilme_Click(object sender, EventArgs e)
        {
            NovoFilme menu = new NovoFilme();
            menu.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void lvFilmes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
