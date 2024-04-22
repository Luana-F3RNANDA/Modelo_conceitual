using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    internal class ContaReceberService
    {
        private readonly ContaReceberRepository contaReceberRepository;

        public ContaReceberService()
        {
            contaReceberRepository = new ContaReceberRepository();
        }

        public void CadastrarConta(int Id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, DateTime dataRecebimento, decimal valorRecebido, MeioPagamento meioPagamento, EstadoPagamento situacao)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new ContaReceber
            {
                id = Id,
                valor = valor,
                dataCadastro = dataCadastro,
                dataRecebimento = dataRecebimento,
                dataVencimento = dataVencimento,
                valorRecebido = valorRecebido,
                meioPgamento = meioPagamento,
                situacao = situacao
            };

            contaReceberRepository.Adicionar(conta);

        }

        public void CadastrarConta(ContaReceber conta)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            contaReceberRepository.Adicionar(conta);

        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return contaReceberRepository.ObterTodos();
        }
        public List<ContaReceber> getAll()
        {
            return contaReceberRepository.ObterTodos().ToList<ContaReceber>();
        }

    }
}
