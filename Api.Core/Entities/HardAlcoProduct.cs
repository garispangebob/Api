namespace Api.Core.Entities;

public class HardAlcoProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public decimal Quantity { get; private set; }

    public HardAlcoProduct(string name, decimal price, decimal quantity)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}