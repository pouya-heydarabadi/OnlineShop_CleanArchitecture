using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.FirstNames;

internal class FirstNameCannotBeMoreThanTwoCharException : OnlineShopException
{
    public FirstNameCannotBeMoreThanTwoCharException() : base("FirstName Cannot By More Than Two Char")
    {
    }
}
