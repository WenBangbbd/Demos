namespace Dapr.PubSub.Controllers
{
    public class Order
    {
        public string orderId { get; set; }
        public string productId { get; set; }
        public int amount { get; set; }
    }
}