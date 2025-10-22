namespace shoe_discount_api.domain.entities;

public class Shoe
{
    public string Brand { get; private set; }
    public string Season { get; private set; }
    public decimal Price { get; private set; }

    public Shoe(string brand, string season, decimal price)
    {
        Brand = brand;
        Season = season;
        Price = price;
    }

    public bool IsPremiumBrand() => Brand?.ToLower() is "nike" or "adidas";
    public bool IsPastSeason() => Season?.ToLower() == "past";
}