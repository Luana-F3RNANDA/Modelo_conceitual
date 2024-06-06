using Dados;
using Modelo_conceitual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Negocio
{
    public class FornecedorService
    {
        private  FornecedorRepository _FornecedorRepository;

        public FornecedorService()
        {
            _FornecedorRepository = new FornecedorRepository();
        }

        public string Update(int? id, TipoPessoa tipoPessoa, string cpf_cnpj, string razaoSocial, string nome, string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone, string email, string celular)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor
            {
                Id = id,
                tipoPessoa = tipoPessoa,
                cpf_cnpj = cpf_cnpj,
                razaoSocial = razaoSocial,

                Nome = nome,
                rua = rua,
                numero = numero,

                bairro = bairro,
                cidade = cidade,
                complemento = complemento,
                cep = cep,
                telefone = telefone,
                Email = email,
                celular = celular,

            };
            if (id == null)
                return _FornecedorRepository.Insert(fornecedor);
            else
                return _FornecedorRepository.Update(fornecedor);

        }

        public string Insert(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _FornecedorRepository.Insert(fornecedor);

        }
        public string Remove(int idFornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _FornecedorRepository.Remove(idFornecedor);

        }

        public DataTable getAll()
        {
            return _FornecedorRepository.getAll();
        }
        public DataTable filterByName(string nome)
        {
            return _FornecedorRepository.filterByName(nome);
        }

    }
}

