namespace shoe_discount_api.application.dtos;

public class DiscountRequest
{
    public string MembershipStatus { get; set; }
    public string ShoeBrand { get; set; }
    public string ShoeSeason { get; set; }
    public bool IsFirstPurchase { get; set; }
    public decimal OriginalPrice { get; set; }
}