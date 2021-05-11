using System.Threading.Tasks;
using NServiceBus;

namespace ClientUI
{
    public class SomethingHappenedHandler : IHandleMessages<SomethingHappened>
    {
        public Task Handle(SomethingHappened message, IMessageHandlerContext context)
        {
            // Do something with the event here
            return Task.CompletedTask;
        }
    }
}