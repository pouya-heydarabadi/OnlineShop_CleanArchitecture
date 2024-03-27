using OnlineShop.Shared.Exceptions;

namespace OnlineShop.Domain.Users.Exceptions.ValueObject.LastName;

public class LastNameBadFormatException : OnlineShopException
{
    public LastNameBadFormatException(string message, string newValue) : base($"{message} -- Value Is {newValue}")
    {
    }
}
