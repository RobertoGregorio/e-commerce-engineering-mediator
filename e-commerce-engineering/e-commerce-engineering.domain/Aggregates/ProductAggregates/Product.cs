using e_commerce_engineering.domain.SeedWork;

namespace e_commerce_engineering.domain.Aggregates.ProductAggregates;

public class Product : BaseEntity
{
    public int ProductId { get; set; }
    public int ProductContextId { get; set; }
    public string UUID { get; set; }
    public int UniqueCode { get; set; }
    public bool InBuyingProcess { get; set; }
}
