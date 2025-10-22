namespace shoe_discount_api.infrastructure.services;

using shoe_discount_api.domain.entities;
using shoe_discount_api.domain.services;

public class DiscountCalculator : IDiscountCalculator
{
    public (decimal Percentage, string Reason) Calculate(Customer customer, Shoe shoe)
    {
        if (customer.IsFirstPurchase)
            return (25, "Descuento por primera compra");

        if (shoe.IsPastSeason())
            return (20, "Descuento por temporada pasada");

        if (customer.IsPremium())
            return (15, "Descuento por membresía premium");

        if (shoe.IsPremiumBrand())
            return (10, "Descuento por marca premium");

        return (0, "Sin descuento");
    }
}