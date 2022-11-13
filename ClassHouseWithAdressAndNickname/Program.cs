House house = new House(address: "Rivne, Bukovynska street");

Console.WriteLine($"House address: {house.Address}.");
Console.WriteLine($"House nickname: {house.Nickname}.");
Console.WriteLine($"Checking Nickname (if null write house address): {house.ToString()}.");
Console.WriteLine($"Checking new address: {house.ChangedAddress}.");
Console.WriteLine($"Comparison of two houses: {house.Address.Equals(house.ChangedAddress)}.");


class House
{
    public string Address { get; private set; }
    
    public string? Nickname { get; set; }

    public House (string address)
    {
        Address = address;
    }
        
    public string ChangedAddress
    {
        get => Address;
        set
        {
            if (Address.Length < 5)
            {
                return;
            }
            else
            {
                Address = value;
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
            return Address;
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj is House house)
        {
            return house.Address == house.Nickname;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Address);
    }
}
