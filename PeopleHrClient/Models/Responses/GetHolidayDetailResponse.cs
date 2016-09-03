using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHolidayDetailResponse : PeopleHrResponse
    {
        public IEnumerable<Holiday> Result;
    }
}