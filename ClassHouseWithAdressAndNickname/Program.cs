House house = new House(address: "Rivne, Bukovynska street")
{
    Nickname = "Green house"
};

house.SetAddress("Kostopil, Independece square");

House house1 = new House("Blue house");
House house2 = new House("Blue house");

Console.WriteLine($"House address: {house.Address}.");
Console.WriteLine($"House nickname: {house.Nickname}.");
Console.WriteLine($"Checking Nickname (if null write house address): {house.ToString()}.");
Console.WriteLine($"Comparison of two houses: {house1.Equals(house2)}.");


class House
{
    public string Address { get; private set; }
    
    public string? Nickname { get; set; }

    public House (string address)
    {
        Address = address;
    }

    public void SetAddress(string NewAddress)
    {
        if (NewAddress.Length < 5)
        {
            throw new NotImplementedException();
        };

        Address = NewAddress;
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
            return house.Address == Address;
        }
        return false;
    }

    public static bool operator ==(House house1, House house2)
    {
        return house1 == house2;
    }

    public static bool operator !=(House house1, House house2)
    {
        return house1 != house2;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Address);
    }
}
