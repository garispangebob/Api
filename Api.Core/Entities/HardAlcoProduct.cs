namespace Api.Core.Entities;

public class HardAlcoProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public User User { get; private set; }
    public Guid UserId { get; private set; }
    public HardAlcoProduct(string name, User user)
    {
        Id = Guid.NewGuid();
        Name = name;
        User = user;
    }
}