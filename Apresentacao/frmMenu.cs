using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmMenu : Form
    {
        frmFornecedor frm;

        public frmMenu()
        {
            frm = new frmFornecedor();
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedor>().Count() == 0)
            {
                frmFornecedor filho2 = new frmFornecedor();
                filho2.MdiParent = this;
                filho2.Show();
            }
        }

        private void gerarRelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedor>().Count() == 0)
            {
                Form1 filho3 = new Form1(frm.tblFornecedor);
                filho3.MdiParent = this;
                filho3.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja sair?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( resposta == DialogResult.Yes)
            {
                this.Close();
            }
          
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helena Petruz RA: 203253 \n Luana Fernanda de Napoli RA:203013", " Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
