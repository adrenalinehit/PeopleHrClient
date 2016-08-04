namespace PeopleHrClient.Models.Requests
{
    public class GetAllDocumentRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetAllDocument"; }
        }

        public string EmployeeId { get; set; }
    }
}