using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.FirstName;

public class FirstNameCannotBeEmptyException : OnlineShopException
{
    public FirstNameCannotBeEmptyException() : base("FirstName Cannot Be Empty Value")
    {
    }
}
