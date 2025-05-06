namespace Api.Core.Entities;

public abstract class HardAlcoProduct : Product
{
    public User User { get; private set; }
    public Guid UserId { get; private set; }

    protected HardAlcoProduct(string name, User user) : base(name)
    {
        User = user;
    }
}