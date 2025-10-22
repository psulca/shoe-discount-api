namespace shoe_discount_api.infrastructure.data;

public static class CatalogData
{
    public static List<string> MembershipStatuses => new() { "Premium", "Regular" };
    
    public static List<string> ShoeBrands => new() 
    { 
        "Nike", "Adidas", "Reebok", "Puma", "New Balance" 
    };
    
    public static List<string> ShoeSeasons => new() { "Current", "Past" };
}