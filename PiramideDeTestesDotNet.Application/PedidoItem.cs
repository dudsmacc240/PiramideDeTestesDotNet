using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PiramideDeTestesDotNet.Application
{
    public class PedidoItem
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        
        public decimal CalcularSubtotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }
}
