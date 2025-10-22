namespace shoe_discount_api.application.services;

using shoe_discount_api.application.dtos;
using shoe_discount_api.domain.entities;
using shoe_discount_api.domain.services;

public class DiscountApplicationService
{
    private readonly IDiscountCalculator _discountCalculator;

    public DiscountApplicationService(IDiscountCalculator discountCalculator)
    {
        _discountCalculator = discountCalculator;
    }

    public DiscountResponse CheckDiscount(DiscountRequest request)
    {
        var customer = new Customer(request.MembershipStatus, request.IsFirstPurchase);
        var shoe = new Shoe(request.ShoeBrand, request.ShoeSeason, request.OriginalPrice);

        var (percentage, reason) = _discountCalculator.Calculate(customer, shoe);
        var discountedPrice = request.OriginalPrice * (1 - percentage / 100);

        return new DiscountResponse
        {
            OriginalPrice = request.OriginalPrice,
            DiscountedPrice = discountedPrice,
            DiscountPercentage = percentage,
            DiscountReason = reason
        };
    }
}