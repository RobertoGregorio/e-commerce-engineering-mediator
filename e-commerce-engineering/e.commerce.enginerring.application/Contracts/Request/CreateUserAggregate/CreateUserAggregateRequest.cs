namespace e_commerce_enginerring.application.Contracts.Request.CreateUserAggregate;

public class CreateUserAggregateRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string ProfileImageUrl { get; set; }
    public string Identity { get; set; }
}
