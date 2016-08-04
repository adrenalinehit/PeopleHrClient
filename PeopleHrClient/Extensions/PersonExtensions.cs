using PeopleHrClient.Models;

namespace PeopleHrClient.Extensions
{
    public static class PersonExtensions
    {
        public static string GetFullName(this Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }
}