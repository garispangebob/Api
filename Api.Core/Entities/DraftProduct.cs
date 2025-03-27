namespace Api.Core.Entities;

public class DraftProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private  set; }
    private readonly List<Tap> _taps = new();
    public IReadOnlyCollection<Tap> Taps => _taps.AsReadOnly();
    public User User { get; private set; }
    public Guid UserId { get; private set; }
    public DraftProduct(string name, User user)
    {
        Name = name;
        User = user;
    }
    public void AddTap(Tap tap)
    {
        _taps.Add(tap);
    }
}