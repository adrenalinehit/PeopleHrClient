using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetDocumentByIdResponse : PeopleHrResponse
    {
        public IEnumerable<Document> Result;
    }
}