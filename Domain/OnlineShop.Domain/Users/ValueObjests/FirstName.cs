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

        this.Value = value;
    }


    #region Factories
    public static FirstName FromString(string value)
        => new FirstName(value);
    #endregion

    #endregion
}
