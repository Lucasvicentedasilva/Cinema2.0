using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cinema
{
    public partial class NovoFilme : Form
    {
        public NovoFilme()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=HUNTER1;integrated security=SSPI;initial Catalog=db_cinema");


        SqlDataReader rdr;
        /*private Boolean filmeJaExiste()
        {

            string sql = "SELECT ds_Titulo,ds_Descricao,ds_Duracao FROM tbl_Filme WHERE ds_Titulo = @titulo";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.HasRows)
                {
                    MessageBox.Show("Filme ja existe", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulo.Focus();
                }
            }
                
        }*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtTitulo.Text== "")
            {
                MessageBox.Show("Obrigatório preencher o campo Título","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTitulo.Focus();
            }
            /*else if (filmeJaExiste())
            {

            }*/
            else if (ritxtDescricao.Text== "")
            {
                MessageBox.Show("Obrigatório preencher o campo Descrição","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ritxtDescricao.Focus();
            }
            else
            {
                try
                {
                    string imagem = tbCaminhoImagem.Text;
                    FileInfo arqImagem = new FileInfo(imagem);
                    long tamanhoArquivoImagem = arqImagem.Length;
                    FileStream fs = new FileStream(imagem, FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] vetorImagens = new byte[Convert.ToInt32(tamanhoArquivoImagem)];
                    int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(tamanhoArquivoImagem));
                    fs.Close();

                    string titulo = txtTitulo.Text;
                    string descricao = ritxtDescricao.Text;
                    string duracao = txtDuracao.Text;
                    //string imagem = btnImagem.Text;

                    string sql = "insert into tbl_Filme(ds_Titulo,ds_Descricao,ds_Duracao, ds_Imagem)values(@titulo,@descricao,@duracao,@imagem)";
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
                    cmd.Parameters.Add("duracao", SqlDbType.Time).Value = duracao;
                    cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = vetorImagens;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                { 
                    cn.Close();
                }
            }
          
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagem = openFileDialog1.FileName;
                tbCaminhoImagem.Text = imagem;
                pictureBox1.Image = Image.FromFile(imagem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoFilme_Load(object sender, EventArgs e)
        {

        }
    }
}
