using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Api.DTO.Response;
using PaymentGateway.Services.Services;

namespace PaymentGateway.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{
    private readonly TodoService _todoSvc;
    private readonly IWebHostEnvironment environment;
    private readonly ILogger<TodoController> _logger;
    private readonly IConfiguration _config;

    public TodoController(
    ILogger<TodoController> logger,
    IWebHostEnvironment environment,
    IConfiguration configuration,
    TodoService todoService)
    {
        this.environment = environment;
        this._logger = logger;
        this._config = configuration;

        this._todoSvc = todoService;
    }

    [HttpGet, Route("GetList")]
    public async Task<IActionResult> GetList()
    {
        try
        {
            var todoList = await _todoSvc.TodoListAsync();
            return Ok(ResponseBase.Success(todoList));

        }
        catch (Exception ex)
        {
            return BadRequest(ResponseBase.Error(ex.Message, ex.ToString()));
        }
    }
}
