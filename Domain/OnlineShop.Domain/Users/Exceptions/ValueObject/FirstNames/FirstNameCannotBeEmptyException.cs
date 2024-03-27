using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.FirstNames;

public class FirstNameCannotBeEmptyException : OnlineShopException
{
    public FirstNameCannotBeEmptyException() : base("FirstName Cannot Be Empty Value")
    {
    }
}
