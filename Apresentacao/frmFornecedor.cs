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
using FluentValidation.Results;
using Negocio;

namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {
      

        private readonly FornecedorService _fornecedorService;
        public DataTable tblFornecedor = new DataTable();

        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento
        public frmFornecedor()
        {
            InitializeComponent();
        
            Texto = "";

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
                    txtId.Visible = false;
                    label1.Visible = false;

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
            txtCpf.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            textBox6.Clear();

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
            dgFornecedor.Columns[2].DataPropertyName = "Email";

            dgFornecedor.Columns[3].Width = 100;
            dgFornecedor.Columns[3].HeaderText = "TIPO PESSOA";
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

            dgFornecedor.Columns[9].Width = 100;
            dgFornecedor.Columns[9].HeaderText = "COMPLEMENTO";
            dgFornecedor.Columns[9].DataPropertyName = "complemento";

            dgFornecedor.Columns[10].Width = 100;
            dgFornecedor.Columns[10].HeaderText = "CEP";
            dgFornecedor.Columns[10].DataPropertyName = "cep";

            dgFornecedor.Columns[11].Width = 100;
            dgFornecedor.Columns[11].HeaderText = "TELEFONE";
            dgFornecedor.Columns[11].DataPropertyName = "telefone";

            dgFornecedor.Columns[12].Width = 100;
            dgFornecedor.Columns[12].HeaderText = "CELULAR";
            dgFornecedor.Columns[12].DataPropertyName = "celular";

         



            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.MultiSelect = false;
            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridView();

        }

        private void carregaGridView()
        {
            dgFornecedor.DataSource = _fornecedorService.getAll();
            dgFornecedor.Refresh();
        }

        private void dgFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView row = (DataGridView)sender;
            if (row.CurrentRow == null)
                return;

            //limpa os TextBoxes
            txtId.Text = dgFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = dgFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtComplemento.Text = dgFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtRua.Text = dgFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtNumero.Text = dgFornecedor.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dgFornecedor.CurrentRow.Cells[12].Value.ToString();
            txtTelefone.Text = dgFornecedor.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtCep.Text = dgFornecedor.CurrentRow.Cells[10].Value.ToString();
    

            if (dgFornecedor.CurrentRow.Cells[3].Value.ToString() == ((int)TipoPessoa.PESSOA_FISICA).ToString())
                pessoaFisica.Checked = true;
            else
                pessoaJuridica.Checked = true;
        }



        

        private void grpDados_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void pessoaFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            int Id;
            Fornecedor fornecedor = new Fornecedor();
            TipoPessoa tipoPessoa;
            string cpf_cnpj;
            string razaoSocial;
            string Nome;
            string rua;
            string numero;
            string bairro;
            string cidade;
            string complemento;
            string cep;
            string telefone;
            string Email;
            string celular;

            string resultado;
            string msg;
            int regAtual = 0;

            if (String.IsNullOrEmpty(txtId.Text))
                Id = -1;
            else
                fornecedor.Id = Convert.ToInt32(txtId.Text);

            fornecedor.Nome = txtNome.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.tipoPessoa = pessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
            fornecedor.cpf_cnpj = txtCpf.Text;
            fornecedor.rua= txtRua.Text;
            fornecedor.numero = txtNumero.Text;
            fornecedor.bairro = txtBairro.Text;
            fornecedor.cidade = txtCidade.Text;
            fornecedor.complemento = txtComplemento.Text;
            fornecedor.cep = txtCep.Text;
            fornecedor.telefone = txtTelefone.Text;
            fornecedor.celular = textBox6.Text;

            //Inicio da validação
            if (fornecedor != null)
            {
                FornecedorValidation validator = new FornecedorValidation();
                ValidationResult results = validator.Validate(fornecedor);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            //Fim da validação



            if (modo == 1)
                {
                    resultado = _fornecedorService.Update(fornecedor.Id, fornecedor.tipoPessoa,fornecedor.cpf_cnpj,fornecedor.razaoSocial,fornecedor.Nome,fornecedor.rua,fornecedor.numero,fornecedor.bairro,fornecedor.cidade,fornecedor.complemento,fornecedor.cep,fornecedor.telefone,fornecedor.Email,fornecedor.celular);
                    if (resultado == "SUCESSO")
                    {
                        msg = "FORNECEDOR cadastrado com sucesso!";
                        carregaGridView();
                    }
                    else
                    {
                        msg = "Falha ao cadastrar FORNECEDOR!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (modo == 2)
                {
                    resultado = _fornecedorService.Update(fornecedor.Id, fornecedor.tipoPessoa, fornecedor.cpf_cnpj, fornecedor.razaoSocial, fornecedor.Nome, fornecedor.rua, fornecedor.numero, fornecedor.bairro, fornecedor.cidade, fornecedor.complemento, fornecedor.cep, fornecedor.telefone, fornecedor.Email, fornecedor.celular);
                    if (resultado == "SUCESSO")
                    {
                        msg = "FORNECEDOR atualizado com sucesso!";
                        carregaGridView();
                    }
                    else
                    {
                        msg = "Falha ao atualizar FORNECEDOR!";
                    }
                    MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
          
            modo = 0;
            Habilita();

        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            string resultado;
            String msg;
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                int idFornecedor = Convert.ToInt32(txtId.Text);
                resultado = _fornecedorService.Remove(idFornecedor);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR excluido com sucesso!";

                    carregaGridView();
                }
                else
                {
                    msg = "Falha ao excluir FORNECEDOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            modo = 1;
            Habilita();
            LimpaForm();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            modo = 2;
            Habilita();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            modo = 0;
            Habilita();
        }

        private void txtCpf_TextChanged_1(object sender, EventArgs e)
        {

        }

        private string _texto;
        public string Texto { get => _texto; set => _texto = value; }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    Texto = textBox1.Text;
                }

                DataTable tbFornecedor = _fornecedorService.filterByName(Texto);
                if (tbFornecedor != null)
                {
                    dgFornecedor.DataSource = tbFornecedor;
                    dgFornecedor.Refresh();
                }
             

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
         
            using ( var frm = new Form1(tblFornecedor))
            {
                frm.ShowDialog();
            }
        }
    }
}
