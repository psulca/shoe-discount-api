namespace shoe_discount_api.domain.services;

using shoe_discount_api.domain.entities;

public interface IDiscountCalculator
{
    (decimal Percentage, string Reason) Calculate(Customer customer, Shoe shoe);
}