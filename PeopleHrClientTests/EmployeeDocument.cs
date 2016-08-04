using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleHrClient;
using PeopleHrClient.Models.Requests;
using System.Linq;

namespace PeopleHrClientTests
{
    [TestClass]
    public class EmployeeDocument
    {
        private const string ApiKey = "";

        [TestMethod]
        public void GetAllDocumentReturnsDocuments()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetAllDocument(new GetAllDocumentRequest
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }

        [TestMethod]
        public void GetDocumentByIdReturnsDocument()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUserDocuments = PeopleHrService.GetAllDocument(new GetAllDocumentRequest
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue
            });

            var peopleHrUser = PeopleHrService.GetDocumentById(new GetDocumentByIdRequest()
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                DocumentId = peopleHrUserDocuments.Result.First().DocumentId
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }
    }
}