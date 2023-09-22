namespace TripServiceSimplified;

public class UserSession
{
    private static readonly UserSession userSession = new UserSession();

    private UserSession()
    {
    }

    public static UserSession GetInstance()
    {
        return userSession;
    }

    public User GetLoggedUser()
    {
        throw new CollaboratorCallException(
            "UserSession.GetLoggedUser() should not be called in a unit test");
    }
}
