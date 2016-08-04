namespace PeopleHrClient.Models.Responses
{
    public class GetNextYearHolidayEntitlementResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public HolidayEntitlement Result;
    }
}