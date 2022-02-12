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

namespace Cinema
{
    public partial class frmSessoes : UserControl
    {
        public frmSessoes()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=HUNTER1;integrated security=SSPI;initial Catalog=db_cinema");

        SqlCommand cmd = new SqlCommand();

        SqlDataReader rdr;

        private void lblFilme1_Click(object sender, EventArgs e)
        {

        }

        private void frmSessoes_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id_Titulo,id_Duracao FROM tbl_Sessoes WHERE id_Titulo = @titulo";
            string titulo = cbFilme.Text;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = titulo;
            cn.Open();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {     
            if (txtValor.Text == "")
            {
                MessageBox.Show("Obritatório o preenchimento do campo Valor do ingresso!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtValor.Focus();
            }
            else if (cbAnimacao.SelectedIndex== 0)
            {
                MessageBox.Show("Obritatório o preenchimento do campo Animação!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbAudio.SelectedIndex == 0)
            {
                MessageBox.Show("Obritatório o preenchimento do campo Áudio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbFilme.SelectedIndex == 0)
            {
                MessageBox.Show("Obritatório o preenchimento do campo Filme!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbSala.SelectedIndex == 0)
            {
                MessageBox.Show("Obritatório o preenchimento do campo Sala!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime hrInicial = dtHrInicio.Value;
                    DateTime hrFim = dtHrFim.Value;
                    string audio = cbAudio.SelectedItem.ToString();
                    string animacao = cbAnimacao.SelectedItem.ToString();
                    string ingresso = txtValor.Text;
                    DateTime data = dtDataSessao.Value;
                    string nome = txtNome.Text;

                    string sql = "insert into tbl_Sessoes(hr_Inicio,hr_Fim,ds_Audio,tp_Animacao,vl_Ingresso,vl_data,nm_Sessao)values(@hrInicial,@hrFim,@audio,@animacao,@ingresso,@data,@nome)";
                    
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.Add("@hr_inicio", SqlDbType.Time).Value = hrInicial;
                    cmd.Parameters.Add("@hr_Fim", SqlDbType.Time).Value = hrFim;
                    cmd.Parameters.Add("@ds_Audio", SqlDbType.VarChar).Value = audio;
                    cmd.Parameters.Add("@tp_Animacao", SqlDbType.VarChar).Value = animacao;
                    cmd.Parameters.Add("@vl_Ingresso", SqlDbType.VarChar).Value = ingresso;
                    cmd.Parameters.Add("@vl_data", SqlDbType.VarChar).Value = data;
                    cmd.Parameters.Add("@nm_Sessao", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sessão criada com sucesso!","Criação de sessão.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                
            }
        }

        private void cbAnimacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from tbl_Sessoes where nm_Sessao like ('" + txtBusca.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPesquisa.DataSource = dt;
                    cn.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }else
            {
                dgvPesquisa.DataSource=null;
            }
        }

        private void dtHrInicio_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void cbFilme_SelectedValueChanged(object sender, EventArgs e)
        {
            
            dtHrFim.Value = dtHrInicio.Value;
            dtHrFim.Value = dtHrFim.Value.AddHours(2);
            dtHrFim.Value = dtHrFim.Value.AddMinutes(20);

        }
        private void cbFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
            
    }
}
