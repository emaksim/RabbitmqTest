using EventBus.Base.Standard;
using System.Threading.Tasks;

namespace SubscriberCore
{
    public class ItemCreatedIntegrationEventHandler : IIntegrationEventHandler<ItemCreatedIntegrationEvent>
    {
        public ItemCreatedIntegrationEventHandler()
        {
        }

        public async Task Handle(ItemCreatedIntegrationEvent @event)
        {
            //Handle the ItemCreatedIntegrationEvent event here.
        }
    }
}