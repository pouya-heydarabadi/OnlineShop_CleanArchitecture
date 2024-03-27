using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.UserNames;

public class UserNameCannotBeEnterIntegerException : OnlineShopException
{
    public UserNameCannotBeEnterIntegerException(int userNameIntType)
        : base($"You Cant Enter Number To UserName -- UserName is {userNameIntType}")
    {
    }
}
