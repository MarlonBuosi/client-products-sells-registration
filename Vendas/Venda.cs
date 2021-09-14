using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    class Venda
    {
        public string CpfCliente { get; set; }
        public string CpfVendedor { get; set; }
        public string Data { get; set; }
        public string NomeProduto { get; set; } = null;
        public string Quantidade { get; set; }
        public string Unitario { get; set; }
    }
}
