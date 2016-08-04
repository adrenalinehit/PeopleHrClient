namespace PeopleHrClient.Models.Requests
{
    public class GetAllEmployeeDetailRequest
    {
        public string APIKey { get; set; }

        public string Action
        {
            get { return "GetAllEmployeeDetail"; }
        }

        public bool IncludeLeavers { get; set; }
    }
}