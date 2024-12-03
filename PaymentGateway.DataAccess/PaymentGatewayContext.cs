using Microsoft.EntityFrameworkCore;
using PaymentGateway.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.DataAccess;

public class PaymentGatewayContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public PaymentGatewayContext(DbContextOptions<PaymentGatewayContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().HasData(new Todo
        {
            Id = 1,
            Title = "Get books for school - DB",
            Description = "Get some text books for school",
            Created = DateTime.Now,
            Due = DateTime.Now.AddDays(5),

        });
    }

}

