namespace PeopleHrClient.Models.Requests
{
    public class GetEmployeeDetailByIdRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetEmployeeDetailById"; }
        }

        public string EmployeeId { get; set; }
    }
}