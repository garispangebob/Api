namespace Api.Core.Entities;

public class Tap
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    
    public Keg? Keg { get; private set; }
    public Guid? KegId { get; private set; }
    private readonly List<DraftProduct> _draftProducts = new();
    public IReadOnlyCollection<DraftProduct> DraftProducts => _draftProducts.AsReadOnly();
    public Tap(string name, Keg keg)
    {
        Id = Guid.NewGuid();
        Name = name;
        Keg = keg;
    }
    public void AddDraftProduct(DraftProduct draftProduct)
    {
        _draftProducts.Add(draftProduct);
    }
    public void AssignToKeg(Keg keg)
    {
        Keg = keg ?? throw new ArgumentNullException(nameof(keg));
        KegId = keg.Id;
    }
    public void RemoveFromKeg()
    {
        Keg = null;
        KegId = null;
    }

}