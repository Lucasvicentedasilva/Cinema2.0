using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            telaGerente1.BringToFront();
        }

        private void telaGerente1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            telaGerente1.BringToFront();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            frmSala1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFilme1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFilme_Click(object sender, EventArgs e)
        {
            frmFilme1.BringToFront();
        }

        private void btnSessoes_Click(object sender, EventArgs e)
        {
            frmSessoes1.BringToFront();
        }

        private void frmSessoes1_Load(object sender, EventArgs e)
        {

        }
    }
}
