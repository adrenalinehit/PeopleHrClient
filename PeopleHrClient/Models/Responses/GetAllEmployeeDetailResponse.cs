using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetAllEmployeeDetailResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<Person> Result;
    }
}