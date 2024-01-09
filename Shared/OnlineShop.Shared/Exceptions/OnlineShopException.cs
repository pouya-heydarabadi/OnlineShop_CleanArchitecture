namespace OnlineShop.Shared.Exceptions;

public abstract class OnlineShopException : Exception
{
    protected OnlineShopException(string message) : base(message) { }
}