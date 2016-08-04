namespace PeopleHrClient.Models.Requests
{
    public class GetAbsenceDetailRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetAbsenceDetail"; }
        }

        public string EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}