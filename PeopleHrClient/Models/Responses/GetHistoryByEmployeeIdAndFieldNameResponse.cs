using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHistoryByEmployeeIdAndFieldNameResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<PersonFieldHistory> Result;
    }
}