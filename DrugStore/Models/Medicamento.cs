using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugStore.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public string Dosagem { get; set; }
        public string Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
