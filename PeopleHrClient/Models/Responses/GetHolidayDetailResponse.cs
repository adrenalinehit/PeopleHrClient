using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHolidayDetailResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<Holiday> Result;
    }
}