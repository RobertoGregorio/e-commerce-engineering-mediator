using e_commerce_engineering.domain.Enumerables;
using e_commerce_engineering.domain.SeedWork;

namespace e_commerce_engineering.domain.Aggregates.ProductAggregates;

public class ProductContext : BaseEntity
{
    public ProductContextType ConextType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsStock { get; set; }
    public string ImageUrl { get; set; }
}
