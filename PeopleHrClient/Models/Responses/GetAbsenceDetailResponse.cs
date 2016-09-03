using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetAbsenceDetailResponse : PeopleHrResponse
    {
        public IEnumerable<Absence> Result;
    }
}