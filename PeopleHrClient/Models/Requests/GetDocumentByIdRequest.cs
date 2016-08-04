namespace PeopleHrClient.Models.Requests
{
    public class GetDocumentByIdRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetDocumentById"; }
        }

        public string EmployeeId { get; set; }
        public string DocumentId { get; set; }
    }
}