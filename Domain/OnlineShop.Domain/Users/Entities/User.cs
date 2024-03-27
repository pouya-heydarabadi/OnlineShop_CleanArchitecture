using OnlineShop.Domain.Users.ValueObjests;

using System.Security.Cryptography.X509Certificates;

namespace OnlineShop.Domain.Users.Entities;

public class User
{
    public Guid Id { get; set; }
    public UserName UserName { get; init; }
    public FirstName FirstName { get; init; }
    public LastName LastName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    #region Ctors
    #region Main Ctors
    //For EF
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private User()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {

    }

    private User(UserName userName, FirstName firstName, string lastName, string email, string passWord)
    {
        this.UserName = userName;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Password = passWord;
    }
    #endregion

    #region Factories
    public static User CreateUserWithAutoPassword(string userName,
                                                  FirstName firstName,
                                                  string lastName,
                                                  string email)
        => new User
            (userName: userName,
             firstName: firstName,
             lastName: lastName,
             email: email,
             passWord: Guid.NewGuid().ToString());

    public static User Main(string userName,
                            FirstName firstName,
                            string lastName,
                            string email,
                            string passWord)
        => new User(userName: userName,
                    firstName: firstName,
                    lastName: lastName,
                    email: email,
                    passWord: passWord);
    #endregion

    #endregion



}
