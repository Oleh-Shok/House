House house = new House();

Console.WriteLine($"House address: {house.MyAddress}.");
Console.WriteLine($"House nickname: {house.Nickname}.");
Console.WriteLine($"Checking Nickname (if null write house address): {house.ToString()}.");
Console.WriteLine($"Checking new address: {house.ChangedAddress}.");
Console.WriteLine($"Comparison of two houses: {house.MyAddress.Equals(house.ChangedAddress)}.");


class House
{
    public string MyAddress { get; private set; } = "Rivne, Bukovynska street";
    
    public string? Nickname { get; set; } = "Native home";

    public string ChangedAddress
    {
        get => MyAddress;
        set
        {
            if (MyAddress.Length < 5)
            {
                return;
            }
            else
            {
                MyAddress = value;
            }
        }
    }

    public override string ToString()
    {
        if (!string.IsNullOrWhiteSpace(Nickname))
        {
            return Nickname;
        }
        else
        {
            return MyAddress;
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj is House house)
        {
            return house.MyAddress == house.Nickname;
        }
        return false;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}
