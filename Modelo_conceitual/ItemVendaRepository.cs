using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_conceitual
{
    public class ItemVendaRepository
    {
        private static List<ItemVenda> listaItemVenda = new List<ItemVenda>();

        public void Adicionar(ItemVenda itemVenda)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaItemVenda.Add(itemVenda);
        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return listaItemVenda;
        }
    }
}
