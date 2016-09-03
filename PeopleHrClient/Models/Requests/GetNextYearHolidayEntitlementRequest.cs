namespace PeopleHrClient.Models.Requests
{
    public class GetNextYearHolidayEntitlementRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetNextYearHolidayEntitlement"; }
        }

        public string EmployeeId { get; set; }
    }
}