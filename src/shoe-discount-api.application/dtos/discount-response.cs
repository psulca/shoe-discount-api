namespace shoe_discount_api.application.dtos;

public class DiscountResponse
{
    public decimal OriginalPrice { get; set; }
    public decimal DiscountedPrice { get; set; }
    public decimal DiscountPercentage { get; set; }
    public string DiscountReason { get; set; }
}