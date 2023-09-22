namespace TripServiceSimplified;

public interface TripDao
{
    List<Trip> FindTripsByUser(User user);
}