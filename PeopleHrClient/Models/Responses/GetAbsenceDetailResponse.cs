using System.Collections.Generic;

namespace PeopleHrClient.Models.Responses
{
    public class GetAbsenceDetailResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public IEnumerable<Absence> Result;
    }
}