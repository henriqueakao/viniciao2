using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStore.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public List<ItemCompra> Produtos { get; set; }
        public String CPFCliente { get; set; }
        public Funcionario Vendedor { get; set; }
    }
}
