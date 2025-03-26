namespace Api.Core.Entities;

public class Keg
{
    public Guid PublicId { get; private set; }
    public string Gtin { get; private set; }
    public string Cis { get; private set; }

    public Keg(string gtin, string cis)
    {
        PublicId = Guid.NewGuid();
        Gtin = gtin;
        Cis = cis;
    }
}