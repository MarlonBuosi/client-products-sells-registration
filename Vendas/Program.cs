using System;
using System.Text;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {

            int menu;

            do
            {

                Console.WriteLine("1) Cadastrar Clientes.");
                Console.WriteLine("2) Cadastrar Vendedores.");
                Console.WriteLine("3) Cadastrar Produtos.");
                Console.WriteLine("4) Realizar Vendas.");
                Console.WriteLine("5) Consultar Venda.");
                Console.WriteLine("6) Sair.");
                Console.Write("Sua opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Cliente cliente = new Cliente();

                        Console.Write("Insira o CPF do cliente: ");
                        cliente.Cpf = Console.ReadLine();

                        if(Cadastro.ConsultarCpfCliente(cliente.Cpf) == true)
                        {
                            Console.Write("Insira o nome do cliente: ");
                            cliente.Nome = Console.ReadLine();
                            Console.Write("Insira o ID do cliente: ");
                            cliente.Id = Console.ReadLine();

                            Cadastro.AddCliente(cliente);   
                        }
                        else
                        {
                            Console.WriteLine("\nCPF do cliente já esta cadastrado no sistema.");
                        }
                        
                        break;

                    case 2:

                        Console.Clear();
                        Vendedor vendedor = new Vendedor();

                        Console.Write("Insira o CPF do vendedor: ");
                        vendedor.Cpf = Console.ReadLine();

                        if (Cadastro.ConsultarCpfVendedor(vendedor.Cpf) == true)
                        {
                            Console.Write("Insira o nome do vendedor: ");
                            vendedor.Nome = Console.ReadLine();
                            Console.Write("Insira o ID do vendedor: ");
                            vendedor.Id = Console.ReadLine();

                            Cadastro.AddVendedor(vendedor);
                        }
                        else
                        {
                            Console.WriteLine("\nCPF do vendedor já esta cadastrado no sistema.");
                        }

                        break;

                    case 3:

                        Console.Clear();
                        Produto produto = new Produto();

                        Console.Write("Insira nome do produto: ");
                        produto.Nome = Console.ReadLine();

                        if (Cadastro.ConsultarNomeProduto(produto.Nome) == true)
                        {
                            Console.Write("Insira o preço do produto: ");
                            produto.PrecoCompra = Console.ReadLine();

                            Cadastro.AddProduto(produto);
                        }
                        else
                        {
                            Console.WriteLine("\nUm produto com esse nome já está cadastrado no sistema.");
                        }

                        break;

                    case 4:

                        Console.Clear();
                        Venda venda = new Venda();

                        Console.Write("Insira o CPF do cliente: ");
                        venda.CpfCliente = Console.ReadLine();
                        Console.Write("Insira o CPF do vendedor: ");
                        venda.CpfVendedor = Console.ReadLine();

                        if (Cadastro.ConsultarCpfCliente(venda.CpfCliente) == false && Cadastro.ConsultarCpfVendedor(venda.CpfVendedor) == false)
                        {
                            Console.Write("Insira a data da venda: ");
                            venda.Data = Console.ReadLine();
                            Console.Write("Insira o nome do produto: ");
                            venda.NomeProduto = Console.ReadLine();
                            Console.Write("Insira a quantidade do produto: ");
                            venda.Quantidade = Console.ReadLine();
                            if (Cadastro.ConsultarNomeProduto(venda.NomeProduto) == true)
                            {
                                    Console.WriteLine("\nO nome do  produto inserido não está cadastrado no sistema.");
                                    break;
                            }
                            Console.WriteLine("\nVenda concluída com sucesso!");
                            Cadastro.AddVenda(venda);
                        }
                        else
                        {
                            Console.WriteLine("\nCPF do cliente ou do vendedor não está cadastrado no sistema!");
                        }
                        
                        break;

                    case 5:

                        Console.Clear();

                        string cpf;
                        Console.Write("Insira o CPF do cliente: ");
                        cpf = Console.ReadLine();

                        if (Cadastro.ConsultarCpfCliente(cpf) == false)
                        {
                            Cadastro.ConsultarVenda(cpf); 
                        }
                        else
                        {
                            Console.WriteLine("\nCPF do cliente inserido não está cadastrado no sistema.");
                        }

                        break;

                    case 6:

                        Console.WriteLine("\nO sistema será finalizado...");
                        break;

                    default:

                        Console.WriteLine("\nATENÇÃO: Opção inválida! Digite novamente...");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (menu != 6);
        }
    }
}
