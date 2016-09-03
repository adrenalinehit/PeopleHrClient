using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleHrClient;
using PeopleHrClient.Models.Requests;
using System;
using System.Linq;

namespace PeopleHrClientTests
{
    [TestClass]
    public class EmployeeHoliday
    {
        private const string ApiKey = "";

        [TestMethod]
        public void SuccessfulGetHolidayDetailReturnsHolidays()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetHolidayDetail(new GetHolidayDetailRequest
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                StartDate = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd"),
                EndDate = DateTime.Now.ToString("yyyy-MM-dd")
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }

        [TestMethod]
        public void FailedGetHolidayDetailReturnsNoHolidays()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetHolidayDetail(new GetHolidayDetailRequest
            {
                APIKey = "",
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                StartDate = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd"),
                EndDate = DateTime.Now.ToString("yyyy-MM-dd")
            });

            Assert.IsTrue(peopleHrUser.Result == null);
        }
    }
}