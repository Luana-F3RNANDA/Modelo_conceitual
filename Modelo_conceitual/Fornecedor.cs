using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public int? Id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string cpf_cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string Nome { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public string celular { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(int? id, TipoPessoa tipoPessoa, string cpf_cnpj, string razaoSocial, string nome, string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone, string email, string celular)
        {
            Id = id;
            this.tipoPessoa = tipoPessoa;
            this.cpf_cnpj = cpf_cnpj;
            this.razaoSocial = razaoSocial;
            Nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.complemento = complemento;
            this.cep = cep;
            this.telefone = telefone;
            Email = email;
            this.celular = celular;
        }

        public override bool Equals(object obj)
        {
            return obj is Fornecedor fornecedor &&
                   Id == fornecedor.Id &&
                   tipoPessoa == fornecedor.tipoPessoa &&
                   cpf_cnpj == fornecedor.cpf_cnpj &&
                   razaoSocial == fornecedor.razaoSocial &&
                   Nome == fornecedor.Nome &&
                   rua == fornecedor.rua &&
                   numero == fornecedor.numero &&
                   bairro == fornecedor.bairro &&
                   cidade == fornecedor.cidade &&
                   complemento == fornecedor.complemento &&
                   cep == fornecedor.cep &&
                   telefone == fornecedor.telefone &&
                   Email == fornecedor.Email &&
                   celular == fornecedor.celular;
        }

        public override int GetHashCode()
        {
            int hashCode = 1873879414;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + tipoPessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf_cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(razaoSocial);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rua);
            hashCode = hashCode * -1521134295 + numero.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(celular);
            return hashCode;
        }
    }
}
