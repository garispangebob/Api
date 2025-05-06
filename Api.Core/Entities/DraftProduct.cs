namespace Api.Core.Entities;

public abstract class DraftProduct : Product
{
    private readonly List<Tap> _taps = new();
    public IReadOnlyCollection<Tap> Taps => _taps.AsReadOnly();
    public User User { get; private set; }
    public Guid UserId { get; private set; }

    protected DraftProduct(string name, User user) : base(name)
    {
        User = user;
    }
    public void AddTap(Tap tap)
    {
        _taps.Add(tap);
    }
}