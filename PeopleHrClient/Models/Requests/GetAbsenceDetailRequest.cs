namespace PeopleHrClient.Models.Requests
{
    public class GetAbsenceDetailRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetAbsenceDetail"; }
        }

        public string EmployeeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}