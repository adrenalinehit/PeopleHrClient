namespace PeopleHrClient.Models.Requests
{
    public class GetHolidayDetailRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetHolidayDetail"; }
        }

        public string EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}