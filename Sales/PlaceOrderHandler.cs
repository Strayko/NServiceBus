using System;
using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Sales
{
    public class PlaceOrderHandler :
        IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();

        static Random random = new Random();

        #region UpdatedHandler

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            if (random.Next(0, 5) == 0)
            {
                throw new Exception("Again Exception");
            }
            
            // This is normally where some business logic would occur

            var orderPlaced = new OrderPlaced
            {
                OrderId = message.OrderId
            };
            return context.Publish(orderPlaced);
        }

        #endregion
    }
}
