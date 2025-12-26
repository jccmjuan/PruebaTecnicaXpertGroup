using Application.Services;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaXpertGroup.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;

namespace PruebaTecnicaXpertGroup.Application.Tests
{
    public class GatosControllerTest
    {
        [Fact]
        public async Task GetBreeds_ReturnsOkResult_WithList()
        {
            // Arrange
            var mockService = new Mock<ICatService>();
            mockService.Setup(s => s.GetBreedsAsync()).ReturnsAsync(new List<dynamic>());
            var catService = new CatService(mockService.Object);
            var controller = new GatosController(catService);

            // Act
            var result = await controller.GetBreeds();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }
    }
}
