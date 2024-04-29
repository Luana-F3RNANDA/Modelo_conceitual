using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Negocio;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService cliServ = new ClienteService();
            ProdutoService prodServ = new ProdutoService();
            VendaService vendaServ = new VendaService();
            ItemVendaService itemVendaServ = new ItemVendaService();

            //Insere alguns clientes
            cliServ.CadastrarCliente(1, TipoPessoa.PESSOA_FISICA,"123456789", "José Alberto Matioli",DateTime.Now,"José","Rua feliz",2,"Bairro Alegre","Porto Alegre", "22","3333333","9999999999", " matioli@unicamp.br","88888888888","30000");
            Console.WriteLine("CLIENTES");
            foreach (Cliente cliente in cliServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",
                    cliente.Id, cliente.Nome, cliente.tipoPessoa, cliente.Email);
            }



            //Insere alguns produtos
            //prodServ.CadastrarProduto(2, "Monitor LG Flatron", 1245);
            //prodServ.CadastrarProduto(1, "Papel Sulfite", 25.50);
            

            Console.WriteLine("\nPRODUTOS");
            foreach (Produto produto in prodServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2}",
                    produto.Id, produto.Nome, produto.Preco);
            }

            //Insere algumas vendas
            Console.WriteLine("\nVENDAS");
            vendaServ.CadastrarVenda(1, cliServ.FindById(1), DateTime.Now, "Primeira venda, uhul", 0, 550.79);
            //Itens desta venda
            itemVendaServ.Insert(1, vendaServ.FindById(1), prodServ.FindById(1), 12, 0, 4.75);
            itemVendaServ.Insert(2, vendaServ.FindById(1), prodServ.FindById(2), 24, 0, 6.25);
            itemVendaServ.Insert(3, vendaServ.FindById(1), prodServ.FindById(3), 2, 0, 16.90);


            vendaServ.Insert(2, cliServ.FindById(3), DateTime.Now, "Venda novo OS Ruindows", 0, 99874.50);
            itemVendaServ.Insert(4, vendaServ.FindById(2), prodServ.FindById(2), 1550, 0, 2590.75);
            itemVendaServ.Insert(5, vendaServ.FindById(2), prodServ.FindById(5), 1350, 0, 1389.76);

            foreach (Venda v in vendaServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2:0.00}",
                    v.Instante.Date, v.Cliente.Nome, v.ValorTotal);
                Console.WriteLine("------- ITENS ------------");
                foreach (ItemVenda itemVenda in itemVendaServ.getItensPorVendaId(v.Id))
                {
                    Console.WriteLine("\t{0} - {1} - {2}",
                    itemVenda.Produto.Nome, itemVenda.Quantidade,
                    itemVenda.Preco);
                }
                Console.WriteLine(Environment.NewLine);
            }



            Console.ReadKey();
        }
    }
}
