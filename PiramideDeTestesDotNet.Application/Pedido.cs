using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideDeTestesDotNet.Application
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        
        public decimal CalcularTotal()
        {
            return Itens.Sum(item => item.CalcularSubtotal());
        }

        
        public bool ValidarPedido()
        {
            return Itens.Count > 0 && Itens.All(item => item.Quantidade > 0);
        }
    }
}
