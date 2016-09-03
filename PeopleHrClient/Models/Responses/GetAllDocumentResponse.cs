using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetAllDocumentResponse : PeopleHrResponse
    {
        public IEnumerable<Document> Result;
    }
}