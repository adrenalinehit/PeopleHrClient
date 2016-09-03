namespace PeopleHrClient.Models.Requests
{
    public class GetHolidayDetailRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetHolidayDetail"; }
        }

        public string EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}