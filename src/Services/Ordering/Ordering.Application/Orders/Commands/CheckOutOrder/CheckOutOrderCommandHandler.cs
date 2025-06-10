using Ordering.Application.Abstractions;
using Ordering.Domain.Abstractions;

namespace Ordering.Application.Orders.Commands.CheckOutOrder
{
    public sealed class CheckOutOrderCommandHandler : ICommandHandler<CheckOutOrderCommand, Guid>
    {
        private readonly IOrderRepository _orderRepository;
        public CheckOutOrderCommandHandler(IOrderRepository _orderRepository)
        {
            this._orderRepository = _orderRepository;
        }
        public Task<Guid> Handle(CheckOutOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
