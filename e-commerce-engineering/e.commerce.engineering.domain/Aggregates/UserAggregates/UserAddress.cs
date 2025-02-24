namespace e.commerce.engineering.domain.Aggregates.UserAggregates;

public class UserAddress
{
    public int UserAddressId { get; set; }
    public int AddressId { get; set; }
    public int UserId { get; set; }
    public bool IsMain { get; set; }
}
