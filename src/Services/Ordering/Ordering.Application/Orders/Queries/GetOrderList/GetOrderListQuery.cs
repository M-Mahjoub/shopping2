using Ordering.Application.Abstractions;

namespace Ordering.Application.Orders.Queries.GetOrderList
{
    public sealed record GetOrderListQuery(string userName) : IQuery<List<OrderVm>>
    {
    }
}
