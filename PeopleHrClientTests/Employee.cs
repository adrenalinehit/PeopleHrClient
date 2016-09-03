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
        public void SuccessfulGetAllEmployeeDetailRequestReturnsEmployees()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            Assert.IsTrue(peopleHrUsers.Result.Any());
        }

        [TestMethod]
        public void FailedGetAllEmployeeDetailRequestReturnsNoEmployees()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = "",
                IncludeLeavers = false
            });

            Assert.IsTrue(peopleHrUsers.Result == null);
        }

        [TestMethod]
        public void SuccessfulGetEmployeeDetailByIdRequestReturnsEmployee()
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

        [TestMethod]
        public void FailedGetEmployeeDetailByIdRequestReturnsNoEmployee()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetEmployeeDetailById(new GetEmployeeDetailByIdRequest
            {
                APIKey = "",
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue
            });

            Assert.IsTrue(peopleHrUser.Result == null);
        }
    }
}