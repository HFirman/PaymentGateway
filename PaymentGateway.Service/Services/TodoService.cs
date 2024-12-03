using Microsoft.Extensions.Logging;
using PaymentGateway.DataAccess;
using PaymentGateway.DataAccess.Models;
using PaymentGateway.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Services.Services
{
    public class TodoService
    {
        private readonly PaymentGatewayContext dbContext;
        private readonly ILogger<TodoService> logger;
        private readonly ITodoRepository todoRepo;

        public TodoService(
        ITodoRepository todoRepository
        , PaymentGatewayContext repository
        , ILogger<TodoService> logger)
        {

            this.todoRepo = todoRepository;
            this.dbContext = repository;
            this.logger = logger;
        }

        public List<Todo> TodoList()
        {
            return todoRepo.GetTodoList();
        }
        public Task<List<Todo>> TodoListAsync() => Task.Run(() => this.TodoList());
    }
}
