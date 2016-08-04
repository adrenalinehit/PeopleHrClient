using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleHrClient;
using PeopleHrClient.Models.Requests;
using System;
using System.Linq;

namespace PeopleHrClientTests
{
    [TestClass]
    public class HolidayEntitlement
    {
        private const string ApiKey = "";

        [TestMethod]
        public void GetHolidayEntitlementReturnsHolidayEntitlements()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetHolidayEntitlement(new GetHolidayEntitlementRequest()
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                StartDate = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd"),
                EndDate = DateTime.Now.ToString("yyyy-MM-dd")
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }

        [TestMethod]
        public void GetNextYearHolidayEntitlementReturnsHolidayEntitlements()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetNextYearHolidayEntitlement(new GetHolidayEntitlementRequest()
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }
    }
}