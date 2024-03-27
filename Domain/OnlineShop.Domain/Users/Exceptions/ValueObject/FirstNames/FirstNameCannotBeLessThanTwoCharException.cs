using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.FirstNames;

public class FirstNameCannotBeLessThanTwoCharException : OnlineShopException
{
    public FirstNameCannotBeLessThanTwoCharException() : base("Your FirstName Cannot Be Less Than Two Char")
    {
    }
}
