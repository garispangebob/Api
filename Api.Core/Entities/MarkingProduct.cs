namespace Api.Core.Entities;

public abstract class MarkingProduct: Product
{
    public string Gtin { get; private set; }
    public User User { get; private set; }
    public Guid UserId { get; private set; }

    protected MarkingProduct(string name, string gtin, User user) : base(name)
    {
        Gtin = gtin;
        User = user;
    }
}