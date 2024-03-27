using System.ComponentModel.DataAnnotations.Schema;

using OnlineShop.Domain.Users.Exceptions.ValueObject.UserNames;

namespace OnlineShop.Domain.Users.ValueObjests;

public sealed record UserName
{
    public string value { get; } = "";

    // For Base
    private UserName(string newUserName)
    {
        this.value = newUserName;
    }

    public static UserName Create(string newUserName)
    {
        if (newUserName.Length < 3)
            throw new UserNameCannotBeLessThanThreeCharacterException(userName: newUserName);

        if (int.TryParse(newUserName, out int userNameInt))
            throw new UserNameCannotBeEnterIntegerException(userNameInt);

        return new UserName(newUserName);
    }
}
