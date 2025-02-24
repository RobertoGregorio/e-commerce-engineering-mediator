using e_commerce_engineering.domain.Enumerables;

namespace e_commerce_engineering.domain.Aggregates;

public class PaymentMethod
{
    public int PaymentMethodId { get; set; }
    public PaymentSubType PaymentSubType { get; set; }
    public PaymentType PaymentType { get; set; }
    public CardCompanyType? CardCompanyType { get; set; }
    public string PaymentIdentifier { get; set; }
    public string Details { get; set; }
}
