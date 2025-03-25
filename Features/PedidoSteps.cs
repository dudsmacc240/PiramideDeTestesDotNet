using TechTalk.SpecFlow;
using Xunit; 
using System.Collections.Generic;

namespace PiramideDeTestesDotNet.Domain.Tests.Steps
{
    [Binding] 
    public class PedidoSteps
    {
        private Pedido _pedido;

        
        [Given(@"que eu tenha um novo pedido")]
        public void DadoQueEuTenhaUmNovoPedido()
        {
            _pedido = new Pedido();
        }

        
        [When(@"eu adicionar um item com quantidade (.*) e preço unitário de (.*)")]
        public void QuandoEuAdicionarUmItem(int quantidade, decimal precoUnitario)
        {
            var item = new PedidoItem
            {
                ProdutoId = 1, 
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario
            };
            _pedido.Itens.Add(item);
        }

        
        [Then(@"o valor total do pedido deve ser (.*)")]
        public void EntaoOValorTotalDoPedidoDeveSer(decimal valorEsperado)
        {
            Assert.Equal(valorEsperado, _pedido.CalcularTotal());
        }

        
        [Then(@"o pedido deve ser considerado inválido")]
        public void EntaoOPedidoDeveSerConsideradoInvalido()
        {
            Assert.False(_pedido.ValidarPedido());
        }

        
        [Then(@"o frete deve ser grátis")]
        public void EntaoOFreteDeveSerGratis()
        {
            Assert.True(_pedido.CalcularTotal() > 500);
        }
    }
}
