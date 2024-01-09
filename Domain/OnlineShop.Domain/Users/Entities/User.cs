namespace OnlineShop.Domain.Users.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
}
