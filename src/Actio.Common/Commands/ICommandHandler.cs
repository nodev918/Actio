using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// command handler interface: impl of command handler pattern

namespace Actio.Common.Commands
{
    public interface ICommandHandler<int T> where T : ICommand 
    {
        Task HandleAsync(T command);
    }
}