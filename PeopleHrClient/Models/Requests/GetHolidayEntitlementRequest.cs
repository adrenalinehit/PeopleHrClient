namespace PeopleHrClient.Models.Requests
{
    public class GetHolidayEntitlementRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetHolidayEntitlement"; }
        }

        public string EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}