using CalculaJurosService.Controllers;
using CalculaJurosService.Model.DTOs;
using CalculaJurosService.Service;
using Xunit;

namespace CalculoJurosTest
{
    public class CalculaJurosControllerTest
    {
        readonly CalculaJurosController _controller;
        readonly ICalculoService _service;

        public CalculaJurosControllerTest()
        {
            _service = new CalculoService();
            _controller = new CalculaJurosController(_service);
        }

        [Fact]
        public void Get_ReturnsOkResult()
        {
            var fakeData = new CalculoValuesDto()
            {
                Periodo = 5,
                ValorInicial = 100
            };

            // Act
            var okResult = _controller.Get(fakeData);
            // Assert
            Assert.Equal("Success", okResult.StatusReply);
        }

        [Theory]
        [InlineData(0, 1000)]
        [InlineData(10, 0)]
        [InlineData(10, -1)]
        [InlineData(-10, 1000)]
        [InlineData(10, 100001)]
        [InlineData(10, 100000.05)]
        [InlineData(10.9, 10000)]
        public void Get_InlineData_ReturnsOkResult(int periodo, double valorInicial)
        {
            var fakeData = new CalculoValuesDto()
            {
                Periodo = periodo,
                ValorInicial = valorInicial
            };

            // Act
            var okResult = _controller.Get(fakeData);
            // Assert
            Assert.Equal("BusinessError", okResult.StatusReply);
        }

    }
}
