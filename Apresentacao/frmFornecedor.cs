using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {

        private readonly FornecedorService _fornecedorService;
        private DataTable tblFornecedor = new DataTable();

        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento
        public frmFornecedor()
        {
            InitializeComponent();
            _fornecedorService = new FornecedorService();

            dgFornecedor.Columns.Add("Id", "ID");
            dgFornecedor.Columns.Add("Nome", "NOME");
            dgFornecedor.Columns.Add("tipoPessoa", "TIPO PESSOA");
            dgFornecedor.Columns.Add("Email", "EMAIL");
            dgFornecedor.Columns.Add("cpf_cnpj", "CPF_CNPJ");
            dgFornecedor.Columns.Add("rua", "RUA");
            dgFornecedor.Columns.Add("numero", "NUMERO");
            dgFornecedor.Columns.Add("bairro", "BAIRRO");
            dgFornecedor.Columns.Add("cidade", "CIDADE");
            dgFornecedor.Columns.Add("complemento", "COMPLEMENTO");
            dgFornecedor.Columns.Add("cep", "CEP");
            dgFornecedor.Columns.Add("telefone", "TELEFONE");
            dgFornecedor.Columns.Add("celular", "CELULAR");




            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.AllowUserToOrderColumns = true;
            dgFornecedor.ReadOnly = true;

            tblFornecedor = _fornecedorService.getAll();
        }

        private void Habilita()
        {
            switch (modo)
            {
                case 0: //neutro
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    grpDados.Enabled = false;
                    dgFornecedor.Enabled = true;
                    break;
                case 1: //inclusão
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    grpDados.Enabled = true;
                    dgFornecedor.Enabled = false;
                    break;
                case 2:
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    grpDados.Enabled = true;
                    dgFornecedor.Enabled = false;
                    break;
            }

        }

        public void LimpaForm()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtId.Clear();
            pessoaFisica.Checked = false;
            pessoaJuridica.Checked = false;

            txtNome.Focus();
        }


        private void frmFornecedor_Load(object sender, System.EventArgs e)
        {
            pessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            pessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            // NOVO ====================
            dgFornecedor.ColumnCount = 13;
            dgFornecedor.AutoGenerateColumns = false;
            dgFornecedor.Columns[0].Width = 20;
            dgFornecedor.Columns[0].HeaderText = "ID";
            dgFornecedor.Columns[0].DataPropertyName = "Id";
            //dgCliente.Columns[0].Visible = false;
            dgFornecedor.Columns[1].Width = 275;
            dgFornecedor.Columns[1].HeaderText = "NOME";
            dgFornecedor.Columns[1].DataPropertyName = "Nome";

            dgFornecedor.Columns[2].Width = 300;
            dgFornecedor.Columns[2].HeaderText = "EMAIL";
            dgFornecedor.Columns[2].DataPropertyName = "email";

            dgFornecedor.Columns[3].Width = 100;
            dgFornecedor.Columns[3].HeaderText = "TIPO";
            dgFornecedor.Columns[3].DataPropertyName = "tipoPessoa";

            dgFornecedor.Columns[4].Width = 100;
            dgFornecedor.Columns[4].HeaderText = "CPF_CNPJ";
            dgFornecedor.Columns[4].DataPropertyName = "cpf_cnpj";

            dgFornecedor.Columns[5].Width = 100;
            dgFornecedor.Columns[5].HeaderText = "RUA";
            dgFornecedor.Columns[5].DataPropertyName = "rua";

            dgFornecedor.Columns[6].Width = 100;
            dgFornecedor.Columns[6].HeaderText = "NUMERO";
            dgFornecedor.Columns[6].DataPropertyName = "numero";

            dgFornecedor.Columns[7].Width = 100;
            dgFornecedor.Columns[7].HeaderText = "BAIRRO";
            dgFornecedor.Columns[7].DataPropertyName = "bairro";

            dgFornecedor.Columns[8].Width = 100;
            dgFornecedor.Columns[8].HeaderText = "CIDADE";
            dgFornecedor.Columns[8].DataPropertyName = "cidade";

            dgFornecedor.Columns[8].Width = 100;
            dgFornecedor.Columns[8].HeaderText = "COMPLEMENTO";
            dgFornecedor.Columns[8].DataPropertyName = "complemento";

            dgFornecedor.Columns[8].Width = 100;
            dgFornecedor.Columns[8].HeaderText = "CEP";
            dgFornecedor.Columns[8].DataPropertyName = "cep";

            dgFornecedor.Columns[9].Width = 100;
            dgFornecedor.Columns[9].HeaderText = "TELEFONE";
            dgFornecedor.Columns[9].DataPropertyName = "tipo";

            dgFornecedor.Columns[10].Width = 100;
            dgFornecedor.Columns[10].HeaderText = "TIPO";
            dgFornecedor.Columns[10].DataPropertyName = "tipoPessoa";

            dgFornecedor.Columns[11].Width = 100;
            dgFornecedor.Columns[11].HeaderText = "TIPO";
            dgFornecedor.Columns[11].DataPropertyName = "tipoPessoa";


            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.MultiSelect = false;
            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridView();

        }

        private void carregaGridView()
        {
            dgCliente.DataSource = _clienteService.getAll();
            dgCliente.Refresh();
        }

        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView row = (DataGridView)sender;
            if (row.CurrentRow == null)
                return;

            //limpa os TextBoxes
            txtId.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            if (dgCliente.CurrentRow.Cells[3].Value.ToString() == ((int)TipoPessoa.PESSOA_FISICA).ToString())
                radioPessoaFisica.Checked = true;
            else
                radioPessoaJuridica.Checked = true;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            modo = 2;
            Habilita();
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
            LimpaForm();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            int id = 0;
            string nome;
            string email;
            string resultado;
            string msg;
            int regAtual = 0;

            if (String.IsNullOrEmpty(txtId.Text))
                id = -1;
            else
                id = Convert.ToInt32(txtId.Text);

            nome = txtNome.Text;
            email = txtEmail.Text;

            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;

            if (modo == 1)
            {
                resultado = _clienteService.Update(null, tp, nome, email);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE cadastrado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao cadastrar PRODUTO!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2)
            {
                resultado = _clienteService.Update(id, tp, nome, email);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE atualizado com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao atualizar CLIENTE!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            modo = 0;
            Habilita();

        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            string resultado;
            String msg;
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                int idCliente = Convert.ToInt32(txtId.Text);
                resultado = _clienteService.Remove(idCliente);
                if (resultado == "SUCESSO")
                {
                    msg = "CLIENTE excluido com sucesso!";
                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir CLIENTE!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            modo = 0;
            Habilita();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            frmPrompt f = new frmPrompt();
            string txtBusca = "";
            f.ShowDialog();
            txtBusca = f.Texto;
            DataTable tbClientes = _clienteService.filterByName(txtBusca);
            if (tbClientes != null)
            {
                dgCliente.DataSource = tbClientes;
                dgCliente.Refresh();
            }
        }

        private void grpDados_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void pessoaFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
