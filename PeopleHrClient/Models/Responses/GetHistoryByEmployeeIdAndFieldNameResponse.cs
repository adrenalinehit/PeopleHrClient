using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHistoryByEmployeeIdAndFieldNameResponse : PeopleHrResponse
    {
        public IEnumerable<PersonFieldHistory> Result;
    }
}