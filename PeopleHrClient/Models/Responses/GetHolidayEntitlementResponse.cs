using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetHolidayEntitlementResponse : PeopleHrResponse
    {
        public IEnumerable<HolidayEntitlement> Result;
    }
}