namespace PeopleHrClient.Models.Requests
{
    public class GetAllEmployeeDetailRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetAllEmployeeDetail"; }
        }

        public bool IncludeLeavers { get; set; }
    }
}