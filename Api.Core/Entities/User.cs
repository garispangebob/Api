namespace Api.Core.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public string? CrptToken { get; private set; }
    public Guid SecurityToken { get; private set; }
    private readonly List<DraftProduct> _draftProducts = new();
    public IReadOnlyCollection<DraftProduct> DraftProducts => _draftProducts.AsReadOnly();
    private readonly List<HardAlcoProduct> _hardAlcoProducts = new();
    public IReadOnlyCollection<HardAlcoProduct> HardAlcoProducts => _hardAlcoProducts.AsReadOnly();
    private readonly List<MarkingProduct> _markingProducts = new();
    public IReadOnlyCollection<MarkingProduct> MarkingProducts => _markingProducts.AsReadOnly();

    public User(string login, string password)
    {
        Id = Guid.NewGuid();
        Login = login;
        Password = password;
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
    public void SetPassword(string password)
    {
        Password = password;
    }
}