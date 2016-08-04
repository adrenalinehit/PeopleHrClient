using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetDocumentByIdResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<Document> Result;
    }
}