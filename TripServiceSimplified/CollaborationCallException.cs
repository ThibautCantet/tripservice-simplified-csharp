namespace TripServiceSimplified;

using System;

public class CollaboratorCallException : Exception
{
    public CollaboratorCallException() : base()
    {
    }

    public CollaboratorCallException(string message) : base(message)
    {
    }

    public CollaboratorCallException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
