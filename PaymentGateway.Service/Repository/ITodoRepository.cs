using PaymentGateway.DataAccess;
using PaymentGateway.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Services.Repository;
public sealed class ITodoRepository
{
    private readonly PaymentGatewayContext _dbContext;

    public ITodoRepository(PaymentGatewayContext dbContext)
    {
        this._dbContext = dbContext;
    }

    internal List<Todo> GetTodoList()
    {
        return this._dbContext.Todos.OrderBy(x => x.Id).ToList();
    }
}

