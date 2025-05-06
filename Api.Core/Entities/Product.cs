namespace Api.Core.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }

    protected Product(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}