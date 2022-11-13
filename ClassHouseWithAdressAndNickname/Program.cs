﻿House house = new House(address: "Rivne, Bukovynska street")
{
    Nickname = "Green house"
};

house.SetName("Kostopil, Independece square");

Console.WriteLine($"House address: {house.Address}.");
Console.WriteLine($"House nickname: {house.Nickname}.");
Console.WriteLine($"Checking Nickname (if null write house address): {house.ToString()}.");
Console.WriteLine($"Comparison of two houses: {house.Address.Equals(house.Address)}.");


class House
{
    public string Address { get; private set; }
    
    public string? Nickname { get; set; }

    public House (string address)
    {
        Address = address;
    }

    public void SetName(string NewAddress)
    {
        if (NewAddress.Length < 5)
        {
            return;
        }

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
            return house.Address == house.Nickname;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Address);
    }
}
