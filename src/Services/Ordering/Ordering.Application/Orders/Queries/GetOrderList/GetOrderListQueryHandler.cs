using Ordering.Application.Abstractions;

namespace Ordering.Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQueryHandler : IQueryHandler<GetOrderListQuery, List<OrderVm>>
    {
        public Task<List<OrderVm>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
