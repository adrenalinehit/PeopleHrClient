namespace PeopleHrClient.Models.Requests
{
    public class GetEmployeeDetailByIdRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetEmployeeDetailById"; }
        }

        public string EmployeeId { get; set; }
    }
}