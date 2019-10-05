using MediatR;

namespace MediaThor
{
    public abstract class Command : Message, IRequest
    {        
    }

    public abstract class Command<TResponse> : Command, IRequest<TResponse>
    {
    }
}