using e_commerce_engineering.domain.SeedWork;

namespace e_commerce_engineering.domain.Aggregates;

public class Buy : BaseEntity
{
    public int BuyId { get; set; }
    public int UserPaymentMethodId { get; set; }
    public int ProductId { get; set; }
    public int ShippingId { get; set; }
    public string UUID { get; set; }
    public decimal TotalValue { get; set; }

}
