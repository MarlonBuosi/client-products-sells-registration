using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    class Cadastro
    {
        static List<Cliente> cliente = new List<Cliente>();
        static List<Vendedor> vendedor = new List<Vendedor>();
        static List<Produto> produto = new List<Produto>();
        static List<Venda> venda = new List<Venda>();
        public static bool ConsultarCpfCliente(string cpf)
        {
            foreach (Cliente a in cliente)
            {
                if (a.Cpf == cpf)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AddCliente (Cliente b)
        {
            cliente.Add(b);
        }
        public static bool ConsultarCpfVendedor(string cpf)
        {
            foreach (Vendedor a in vendedor)
            {
                if (a.Cpf == cpf)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AddVendedor(Vendedor b)
        {
            vendedor.Add(b);
        }
        public static bool ConsultarNomeProduto(string nome)
        {
            foreach (Produto c in produto)
            {
                if (c.Nome == nome)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AddProduto(Produto d)
        {
           produto.Add(d);
        }
        public static void AddVenda(Venda h)
        {
            venda.Add(h);
        }
        public static void ConsultarVenda(string cpf)
        {
            string nome;
            string quantidade;
            double precoParcial;
            double precoTotal = 0;

            foreach (Venda i in venda)
            {
                if (i.CpfCliente == cpf && i.NomeProduto != null)
                {
                    nome = i.NomeProduto;
                    quantidade = i.Quantidade;
                    Console.WriteLine("\nCPF do vendedor: " + i.CpfVendedor);
                    Console.WriteLine("Data da venda: " + i.Data);
                    Console.WriteLine("Nome do produto: " + i.NomeProduto);
                    Console.WriteLine("Quantidade do produto: " + i.Quantidade);
                    foreach (Produto j in produto)
                    {
                        if (nome == j.Nome)
                        {
                            precoParcial = double.Parse(quantidade) * double.Parse(j.PrecoCompra);
                            precoTotal += precoParcial;
                            Console.WriteLine("Total parcial da compra: " + Math.Round(precoParcial, 2) + " R$");
                        }
                    }
                }
            }
            Console.WriteLine("\nTotal da compra: " + Math.Round(precoTotal, 2) + " R$ \n");
        }
    }
}
