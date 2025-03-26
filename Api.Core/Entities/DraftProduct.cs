namespace Api.Core.Entities;

public class DraftProduct
{
    public Guid Id { get; private set; }
    public string Name { get; private  set; }
    private readonly List<Tap> _taps = new();
    public IReadOnlyCollection<Tap> Taps => _taps.AsReadOnly();

    public DraftProduct(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
    public void AddTap(Tap tap)
    {
        _taps.Add(tap);
    }
}