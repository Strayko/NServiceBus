using NServiceBus;

namespace ClientUI
{
    public class SomethingHappened : IEvent
    {
        public string SomeProperty { get; set; }
    }
}