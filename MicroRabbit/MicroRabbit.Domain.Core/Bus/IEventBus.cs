using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void PublishEvent<T>(T @event) where T : Event; //to use c# reserved keyword use @ prior to it, event is c# reserve ketword.
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
