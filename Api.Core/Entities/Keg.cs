namespace Api.Core.Entities;

public class Keg
{
    public Guid Id { get; private set; }
    public string Gtin { get; private set; }
    public string Cis { get; private set; }
    private readonly List<Tap> _taps = new();
    public IReadOnlyCollection<Tap> Taps => _taps.AsReadOnly();

    public void AddTap(Tap tap)
    {
        _taps.Add(tap);
    }

    public Keg(string gtin, string cis)
    {
        Id = Guid.NewGuid();
        Gtin = gtin;
        Cis = cis;
    }
}