namespace Builder.Product
{
    public class OrderProduct
    {
        public string Stock { get; set; }
        public decimal Quantity { get; set; }
        public SideEnum Side { get; set; }
        public decimal Price { get; set; }
        public Guid Id { get; set; }

        public string ShowOrder()
        {
            return $"{Id}: {Stock}, Quantity: {Quantity}, Side: {Side}, Price: {Price}";
        }
    }
}
