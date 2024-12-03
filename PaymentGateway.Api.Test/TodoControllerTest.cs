using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PaymentGateway.Api.Controllers;
using PaymentGateway.Services.Services;

namespace PaymentGateway.Api.Test
{
    public class TodoControllerTest
    {
        [Fact]
        public void GetTodo_Returns_OkResult()
        {
            var mockLogger = new Mock<ILogger<TodoController>>();
            var mockwebHost = new Mock<IWebHostEnvironment>();
            var mockConfg = new Mock<IConfiguration>();
            var mockService = new Mock<TodoService>();
            // Arrange
            TodoController controller = new TodoController(mockLogger, mockwebHost, mockConfg, mockService);

            // Act
            var result = controller.GetList();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}