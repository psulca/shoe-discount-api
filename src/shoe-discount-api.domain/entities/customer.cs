namespace shoe_discount_api.domain.entities;

public class Customer
{
    public string MembershipStatus { get; private set; }
    public bool IsFirstPurchase { get; private set; }

    public Customer(string membershipStatus, bool isFirstPurchase)
    {
        MembershipStatus = membershipStatus;
        IsFirstPurchase = isFirstPurchase;
    }

    public bool IsPremium() => MembershipStatus?.ToLower() == "premium";
}
