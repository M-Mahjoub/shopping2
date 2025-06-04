using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Abstractions
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }

    public interface ICommand : IRequest
    {

    }

    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }

    public interface IQuery : IRequest
    {

    }
}
