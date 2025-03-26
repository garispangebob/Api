namespace Api.Core.Entities;

public class Tap
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Keg? Keg { get; private set; }

    public Tap(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public Tap(string name, Keg? keg)
    {
        Id = Guid.NewGuid();
        Name = name;
        Keg = keg;
    }

    public void SetKegOnTap(Keg? keg)
    {
        Keg = keg;
    }
}