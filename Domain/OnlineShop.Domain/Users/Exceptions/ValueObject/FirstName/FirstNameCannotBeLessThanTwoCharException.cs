using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.FirstName;

public class FirstNameCannotBeLessThanTwoCharException : OnlineShopException
{
    public FirstNameCannotBeLessThanTwoCharException() : base("Your FirstName Cannot Be Less Than Two Char")
    {
    }
}
