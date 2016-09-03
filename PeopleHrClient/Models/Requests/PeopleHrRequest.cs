namespace PeopleHrClient.Models.Requests
{
    public abstract class PeopleHrRequest
    {
        public string APIKey { get; set; }

        public string Action { get { return ""; } }
    }
}