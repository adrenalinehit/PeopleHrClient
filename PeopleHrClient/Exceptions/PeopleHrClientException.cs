using System;

namespace PeopleHrClient.Exceptions
{
    [Serializable]
    public class PeopleHrClientException : Exception
    {
        public PeopleHrClientException()
        {
        }

        public PeopleHrClientException(string message) : base(message)
        {
        }

        public PeopleHrClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}