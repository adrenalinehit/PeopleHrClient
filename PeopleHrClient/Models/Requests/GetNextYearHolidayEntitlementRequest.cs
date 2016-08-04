namespace PeopleHrClient.Models.Requests
{
    public class GetNextYearHolidayEntitlementRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetNextYearHolidayEntitlement"; }
        }

        public string EmployeeId { get; set; }
    }
}