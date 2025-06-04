using MediatR;

namespace Ordering.Application.Abstractions
{
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
                                                            where TCommand : ICommand<TResponse>
    { }
    public interface ICommandHandler<in TCommand>
     : IRequestHandler<TCommand>
     where TCommand : ICommand
    { }

    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
                                                           where TQuery : IQuery<TResponse>
    { }
    public interface IQueryHandler<in TQuery>
     : IRequestHandler<TQuery>
     where TQuery : IQuery
    { }
}
