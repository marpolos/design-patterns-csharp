using Builder;
using Builder.Product;

OrderBuilder orderBuilder = new();

Guid GenerateGuid()
{
    return Guid.NewGuid();
}

var order_1 = orderBuilder.SetStock("PETR4")
    .SetQuantity(100)
    .SetSide(SideEnum.Buy)
    .SetPrice(30.50m)
    .Build();

Console.WriteLine($"Order 1: {order_1.ShowOrder()}");

var order_2 = new OrderBuilder()
    .SetStock("VALE3")
    .SetQuantity(200)
    .SetSide(SideEnum.Sell)
    .SetPrice(80.75m)
    .Build();

Console.WriteLine($"Order 2: {order_2.ShowOrder()}");
Console.WriteLine($"Order 1: {order_1.ShowOrder()}");
