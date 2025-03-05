using e.commerce.engineering.domain.SeedWork;

namespace e.commerce.engineering.domain.Aggregates.UserAggregates;

public class User : BaseEntity
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public bool IsActive { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string ProfileImageUrl { get; set; }
    public string Identity { get; set; }
}
