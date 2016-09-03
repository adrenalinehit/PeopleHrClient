namespace PeopleHrClient.Models.Requests
{
    public class GetAllDocumentRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetAllDocument"; }
        }

        public string EmployeeId { get; set; }
    }
}