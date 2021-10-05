// PROGRAMA REFATORADO POR FREDERICO LEITE SAUER EM ATIVIDADE PARA FAETERJ-RIO

using Api.LojaTav2021.Interfaces;
using Api.LojaTav2021.Model;
using Moq;
using System;
using Xunit;

namespace Teste.LojaTav2021
{
    public class PedidoUnitTest
    {
        private Mock<ICliente> _mockCliente;

        [Fact]
        public void ValidaEntregaIdZerado()
        {
            // Arrange
            Pedido pedido = new Pedido(1, 13, 1, 26.99);
            bool esperado = false;
            IEntrega entrega = new Entrega();
            Mock<IEntrega> mock = new Mock<IEntrega>();
            mock.Setup(m => m.ValidaEntrega(entrega)).Returns(true);

            //ACT
            var result = pedido.ValidaEntrega(entrega);

            // Assert
            Assert.Equal(result, esperado);
        }
        [Fact]
        public void CalculaFreteTest1()
        {
            // Arrange
            _mockCliente = new Mock<ICliente>();
            Cliente cliente = new Cliente()
            {
                idCliente = 7,
                paisOrigem = "Canada",
                endereco = "311 W Cordova St, Vancouver BC",
                cep = 98663
            };
            double esperado = 44.67;
            int cep = 98663;
            _mockCliente.Setup(x => x.getCepById(3)).Returns(cliente.cep);

            Mock<IFrete> _mockFrete = new Mock<IFrete>();
            Frete frete = new Frete()
            {
                idFrete = 66,
                cep = 98663,
                valorFrete = 44.67
            };
            _mockFrete.Setup(y => y.GetValorFrete(cep)).Returns(frete.valorFrete);

            // ACT
            Pedido pedido = new Pedido(1, 6, _mockCliente.Object, _mockFrete.Object, 10, 77.43);
            double resultado = pedido.CalcularFrete();

            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
