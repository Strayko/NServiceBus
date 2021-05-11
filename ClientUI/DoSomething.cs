using NServiceBus;

namespace ClientUI
{
    public class DoSomething : ICommand
    {
        public string SomeProperty { get; set; }
    }
}