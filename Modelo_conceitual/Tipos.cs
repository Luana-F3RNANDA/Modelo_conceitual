using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public enum TipoPessoa { PESSOA_FISICA = 1, PESSOA_JURIDICA = 2 };
    public enum MeioPagamento { CREDITO = 1, DEBITO = 2, PIX = 3, DINHEIRO_FISICO = 4 };
    public enum EstadoPagamento { PAGO = 1, DEVENDO = 0 };
    public enum TipoConta { CONTA_RECEBER = 1, CONTA_PAGAR = 2 };
}
