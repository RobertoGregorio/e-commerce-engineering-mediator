using e.commerce.engineering.domain.SeedWork;

namespace e.commerce.engineering.domain.Aggregates.UserAggregates;

public class UserPaymentMethod : BaseEntity
{
    public int UserPaymentMethodId { get; set; }
    public int UserId { get; set; }
    public int PaymentMethodId { get; set; }
    public bool IsMain { get; set; }
}
