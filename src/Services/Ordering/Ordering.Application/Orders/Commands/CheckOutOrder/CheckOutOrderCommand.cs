using Ordering.Application.Abstractions;

namespace Ordering.Application.Orders.Commands.CheckOutOrder
{
    public sealed record CheckOutOrderCommand : ICommand<Guid>;
}
