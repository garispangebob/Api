namespace Api.Core.Entities;

public class MarkingProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Gtin { get; private set; }

    public MarkingProduct(string name, string gtin)
    {
        Id = Guid.NewGuid();
        Name = name;
        Gtin = gtin;
    }
}