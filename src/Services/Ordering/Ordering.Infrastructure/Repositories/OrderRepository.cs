using Ordering.Domain.Abstractions;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public ApplicationDbContext _dbContext { get; set; }
        public OrderRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
        public void Insert(Order order) => _dbContext.Set<Order>().Add(order);
    }
}
