namespace Api.Core.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public string? CrptToken { get; private set; }
    public Guid SecurityToken { get; private set; }
    private readonly List<DraftProduct> _draftProducts = new();
    public IReadOnlyCollection<DraftProduct> DraftProducts => _draftProducts.AsReadOnly();
    private readonly List<HardAlcoProduct> _hardAlcoProducts = new();
    public IReadOnlyCollection<HardAlcoProduct> HardAlcoProducts => _hardAlcoProducts.AsReadOnly();
    private readonly List<MarkingProduct> _markingProducts = new();
    public IReadOnlyCollection<MarkingProduct> MarkingProducts => _markingProducts.AsReadOnly();

    public User(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        //TODO: Сделать хеширование
        SecurityToken = Guid.NewGuid();
    }
    public void AddDraftProduct(DraftProduct draftProduct)
    {
        _draftProducts.Add(draftProduct);
    }
    public void AddHardAlcoProduct(HardAlcoProduct hardAlcoProduct)
    {
        _hardAlcoProducts.Add(hardAlcoProduct);
    }
    public void AddMarkingProduct(MarkingProduct markingProduct)
    {
        _markingProducts.Add(markingProduct);
    }
    public void SetCrptToken(string token)
    {
        //TODO: сделать хеширование
        CrptToken = token;
    }
}