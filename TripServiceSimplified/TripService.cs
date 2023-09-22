namespace TripServiceSimplified;

using System.Collections.Generic;

public class TripService
{
    private readonly TripDao tripDAO;

    public TripService(TripDao tripDAO)
    {
        this.tripDAO = tripDAO;
    }

    public List<Trip> GetTripsByUser(User user)
    {
        List<Trip> tripList = new List<Trip>();
        User loggedUser = UserSession.GetInstance().GetLoggedUser();
        bool isFriend = false;
        if (loggedUser != null)
        {
            foreach (User friend in user.GetFriends())
            {
                if (friend.Equals(loggedUser))
                {
                    isFriend = true;
                    break;
                }
            }
            if (isFriend)
            {
                tripList = tripDAO.FindTripsByUser(user);
            }
            return tripList;
        }
        else
        {
            throw new UserNotLoggedInException();
        }
    }
}
