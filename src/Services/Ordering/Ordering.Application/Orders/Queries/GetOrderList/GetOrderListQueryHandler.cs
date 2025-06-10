using AutoMapper;
using Ordering.Application.Abstractions;
using Ordering.Domain.Abstractions;

namespace Ordering.Application.Orders.Queries.GetOrderList
{
    public class GetOrderListQueryHandler : IQueryHandler<GetOrderListQuery, List<OrderVm>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper mapper;

        public GetOrderListQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public Task<List<OrderVm>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
