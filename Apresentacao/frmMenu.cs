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
        public frmMenu()
        {
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
                Form1 filho3 = new Form1();
                filho3.MdiParent = this;
                filho3.Show();
            }
        }
    }
}
