namespace PeopleHrClient.Models.Responses
{
    public class GetEmployeeDetailByIdResponse
    {
        public bool isError;
        public int Status;
        public string Message;
        public Person Result;
    }
}