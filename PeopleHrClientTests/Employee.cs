using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleHrClient;
using PeopleHrClient.Models.Requests;
using System.Linq;

namespace PeopleHrClientTests
{
    [TestClass]
    public class Employee
    {
        private const string ApiKey = "";

        [TestMethod]
        public void GetAllEmployeeDetailRequestReturnsEmployees()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            Assert.IsTrue(peopleHrUsers.Result.Any());
        }

        [TestMethod]
        public void GetEmployeeDetailByIdRequestReturnsEmployee()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetEmployeeDetailById(new GetEmployeeDetailByIdRequest
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }
    }
}