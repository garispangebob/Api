namespace Api.Core.Entities;

public class MarkingProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Gtin { get; private set; }
    public User User { get; private set; }
    public Guid UserId { get; private set; }

    public MarkingProduct(string name, string gtin, User user)
    {
        Name = name;
        Gtin = gtin;
        User = user;
    }
}