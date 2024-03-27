using OnlineShop.Domain.Users.ValueObjests;
using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.UserNames;

public class UserNameCannotBeLessThanThreeCharacterException : OnlineShopException
{
    public UserNameCannotBeLessThanThreeCharacterException(string userName)
        : base($"Your UserName Cannot Be Less Than To Three Character {userName} -- Lenght is {userName.Length}")
    {

    }
}
