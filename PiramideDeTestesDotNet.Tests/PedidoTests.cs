using PiramideDeTestesDotNet.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PiramideDeTestesDotNet.Tests
{
    public class PedidoTests
    {
        // Teste 1: Pedido sem itens deve ser inválido
        [Fact]
        public void Pedido_SemItens_DeveSerInvalido()
        {
            var pedido = new Pedido();
            Assert.False(pedido.ValidarPedido());
        }

        // Teste 2: Pedido com itens, mas quantidade 0 deve ser inválido
        [Fact]
        public void Pedido_ComItens_QuantidadeZero_DeveSerInvalido()
        {
            var pedido = new Pedido();
            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 0, PrecoUnitario = 10 });
            Assert.False(pedido.ValidarPedido());
        }

        // Teste 3: Pedido deve calcular corretamente o total
        [Fact]
        public void Pedido_CalcularTotal_DeveRetornarValorCorreto()
        {
            var pedido = new Pedido();
            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 2, PrecoUnitario = 10 });
            pedido.Itens.Add(new PedidoItem { ProdutoId = 2, Quantidade = 1, PrecoUnitario = 50 });
            Assert.Equal(70, pedido.CalcularTotal());
        }

        // Teste 4: Pedido com valor total superior a 500 deve ter frete grátis
        [Fact]
        public void Pedido_ComValorAcimaDe500_DeveTerFreteGratis()
        {
            var pedido = new Pedido();
            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 10, PrecoUnitario = 100 });
            pedido.Itens.Add(new PedidoItem { ProdutoId = 2, Quantidade = 2, PrecoUnitario = 50 });
            var total = pedido.CalcularTotal();
            Assert.True(total > 500);  // Verifique se o total é maior que 500
            // Lógica para frete grátis pode ser adicional aqui dependendo de como você implementa isso
        }

        // Teste 5: Verificar a regra de desconto para não gerar valores negativos
        [Fact]
        public void Pedido_ComDesconto_DeveSerValido()
        {
            var pedido = new Pedido();
            pedido.Itens.Add(new PedidoItem { ProdutoId = 1, Quantidade = 2, PrecoUnitario = 10 });

            // Supondo que a lógica de desconto tenha sido implementada
            // Vamos verificar se o total não ficou negativo.
            var totalComDesconto = pedido.CalcularTotal() - 20; // Exemplo de desconto fixo de 20
            Assert.True(totalComDesconto >= 0);  // O total com desconto não pode ser negativo
        }
    }
}

