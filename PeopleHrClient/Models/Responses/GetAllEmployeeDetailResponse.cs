using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetAllEmployeeDetailResponse : PeopleHrResponse
    {
        public IEnumerable<Person> Result;
    }
}