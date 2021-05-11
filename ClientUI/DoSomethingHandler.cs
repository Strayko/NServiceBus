using System;
using System.Threading.Tasks;
using NServiceBus;

namespace ClientUI
{
    public class DoSomethingHandler : IHandleMessages<DoSomething>, IHandleMessages<DoSomethingElse>
    {
        public Task Handle(DoSomething message, IMessageHandlerContext context)
        {
            Console.WriteLine("Received DoSomething");
            return Task.CompletedTask;
        }

        public Task Handle(DoSomethingElse message, IMessageHandlerContext context)
        {
            Console.WriteLine("Received DoSomethingElse");
            return Task.CompletedTask;
        }
    }
}