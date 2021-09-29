using EventBus.Base.Standard;
using Microsoft.AspNetCore.Mvc;

namespace PublisherCore.Controller
{
    public class ItemController : ControllerBase
    {
        private readonly IEventBus _eventBus;

        public ItemController(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        [HttpPost]
        public IActionResult Publish()
        {
            var message = new ItemCreatedIntegrationEvent("Item title", "Item description");
            _eventBus.Publish(message);
            return Ok();
        }
    }
}