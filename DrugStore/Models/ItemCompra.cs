using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStore.Models
{
    public class ItemCompra
    {
        public int Id { get; set; }
        public Medicamento Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
