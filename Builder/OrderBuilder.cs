using Builder.Product;

namespace Builder
{
    public class OrderBuilder
    {
        public OrderProduct _order { get; set; }
        public OrderBuilder()
        {
            _order = new OrderProduct();
            _order.Id = Guid.NewGuid();
        }
        public OrderBuilder SetStock(string stock)
        {
            _order.Stock = stock;
            return this;
        }
        public OrderBuilder SetQuantity(decimal quantity)
        {
            _order.Quantity = quantity;
            return this;
        }
        public OrderBuilder SetSide(SideEnum side)
        {
            _order.Side = side;
            return this;
        }
        public OrderBuilder SetPrice(decimal price)
        {
            _order.Price = price;
            return this;
        }

        public OrderProduct Build()
        {
            return _order;
        }
    }
}
