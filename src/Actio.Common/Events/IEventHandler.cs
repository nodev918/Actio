using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface IEventHandler<int T> where T : IEvent 
    {
        Task HandleAsync(T @event);
    }
}