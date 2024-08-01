using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorValidation:AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(fornecedor => fornecedor.Nome).NotEmpty().WithMessage("Campo nome é OBREGATORIO!!");

            RuleFor(fornecedor => fornecedor.Nome).Length(10,45).WithMessage("Campo nome deve ser entre 10 e 45 caracteres");

            RuleFor(fornecedor => fornecedor.cpf_cnpj).NotEmpty().WithMessage("Campo cpf é obrigatorio");

            RuleFor(fornecedor => fornecedor.cpf_cnpj).Length(14).WithMessage("Campo cpf deve ter 14 caracteres");

            RuleFor(fornecedor => fornecedor.rua).NotEmpty().WithMessage("Campo rua obrigatorio");

            RuleFor(fornecedor => fornecedor.rua).Length(10,45).WithMessage("Campo rua deve ter no maximo 45 caracteres");

            RuleFor(fornecedor => fornecedor.numero).NotEmpty().WithMessage("Campo numero obrigatorio");

            RuleFor(fornecedor => fornecedor.bairro).NotEmpty().WithMessage("Campo bairro obrigatorio");

            RuleFor(fornecedor => fornecedor.bairro).Length(10, 45).WithMessage("Campo bairro deve ter no maximo 45 caracteres");

            RuleFor(fornecedor => fornecedor.cidade).NotEmpty().WithMessage("Campo cidade obrigatorio");

            RuleFor(fornecedor => fornecedor.cidade).Length(10, 45).WithMessage("Campo cidade deve ter no maximo 45 caracteres");

            RuleFor(fornecedor => fornecedor.complemento).Length(1, 45).WithMessage("Campo complmento deve ter no maximo 45 caracteres");

            RuleFor(fornecedor => fornecedor.cep).NotEmpty().WithMessage("Campo cep obrigatorio");

            RuleFor(fornecedor => fornecedor.cep).Length(9).WithMessage("Campo cep deve ter 9 caracteres");

            RuleFor(fornecedor => fornecedor.telefone).NotEmpty().WithMessage("Campo telefone obrigatorio");

            RuleFor(fornecedor => fornecedor.telefone).Length(8).WithMessage("Campo telefone deve ter 8 caracteres");

            RuleFor(fornecedor => fornecedor.celular).NotEmpty().WithMessage("Campo celular obrigatorio");

            RuleFor(fornecedor => fornecedor.celular).Length(8,14).WithMessage("Campo celular deve ter no maximo 14 caracteres");

            RuleFor(fornecedor => fornecedor.Email).NotEmpty().WithMessage("Campo email obrigatorio");

            RuleFor(fornecedor => fornecedor.Email).Length(10, 45).WithMessage("Campo email deve ter no maximo 45 caracteres");

            RuleFor(fornecedor => fornecedor.Email).EmailAddress().WithMessage("Insira um email valido");

            RuleFor(fornecedor => fornecedor.tipoPessoa).IsInEnum().WithMessage("Campo tipo pessoa obrigatorio");
          



        }

    }
}
