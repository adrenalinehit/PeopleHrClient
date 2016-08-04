using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHolidayEntitlementResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<HolidayEntitlement> Result;
    }
}