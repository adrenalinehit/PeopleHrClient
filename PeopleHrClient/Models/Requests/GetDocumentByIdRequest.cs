namespace PeopleHrClient.Models.Requests
{
    public class GetDocumentByIdRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetDocumentById"; }
        }

        public string EmployeeId { get; set; }
        public string DocumentId { get; set; }
    }
}