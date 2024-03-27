using OnlineShop.Domain.Users.ValueObjests;
using System.Security.Cryptography.X509Certificates;

namespace OnlineShop.Domain.Users.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; init; }
    public FirstName FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    #region Ctors
    //For EF
    private User()
    {
        
    }

    private User(string userName, FirstName firstName, string lastName, string email, string passWord)
    {
        this.UserName = userName;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Password = passWord;
    }

    #region Factories
    public static User CreateUserWithAutoPassword(string userName, FirstName firstName, string lastName, string email)
        => new User(userName: userName, firstName: firstName, lastName: lastName, email: email, passWord: Guid.NewGuid().ToString());

    public static User Main(string userName, FirstName firstName, string lastName, string email, string passWord)
        => new User(userName: userName, firstName: firstName, lastName: lastName, email: email, passWord: passWord);
    #endregion

    #endregion



}
