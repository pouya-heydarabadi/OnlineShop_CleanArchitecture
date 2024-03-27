using OnlineShop.Domain.Users.Exceptions.ValueObject.LastName;

namespace OnlineShop.Domain.Users.ValueObjests;

public record LastName
{
    public string value { get; }

    private LastName(string newValue)
    {
        this.value = newValue;
    }

    public static LastName Create(string newValue)
    {
        if(newValue.Length < 15)
            throw new LastNameBadFormatException("Your Value Is Bad Format Because LastName Cannot Be Less Than 15 Character Lenght", newValue)
        return new LastName(newValue);
    }
}
