using OnlineShop.Domain.Users.Exceptions.ValueObject.FirstName;

namespace OnlineShop.Domain.Users.ValueObjests;

public class FirstName
{
    #region Fields
    public string Value { get; init; }
    #endregion

    #region Ctors
    private FirstName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new FirstNameCannotBeEmptyException();
        if (value.Length <= 2)
            throw new FirstNameCannotBeLessThanTwoCharException();
        else if (value.Length < 13)
            throw new FirstNameCannotBeMoreThanTwoCharException();
        this.Value = value;
    }


    #region Factories
    public static FirstName FromString(string value)
        => new FirstName(value);
    #endregion

    #endregion

    // Codes that are repeated repeatedly in the  Value Objects
    #region Functions
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
    public static bool operator ==(FirstName right, FirstName left)
    {
        return right.Equals(left);
    }
    public static bool operator !=(FirstName right, FirstName left)
    {
        return !(right == left);
    }
    #endregion
}
