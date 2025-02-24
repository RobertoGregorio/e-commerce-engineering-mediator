namespace e_commerce_engineering.domain.Aggregates.UserAggregates;

public class UserPaymentMethod
{
    public int UserPaymentMethodId { get; set; }
    public int UserId { get; set; }
    public int PaymentMethodId { get; set; }
    public bool IsMain { get; set; }
}
