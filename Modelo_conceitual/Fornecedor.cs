﻿using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_conceitual
{
    public class Fornecedor
    {
        public int Id { get; set; }
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
    }
}
