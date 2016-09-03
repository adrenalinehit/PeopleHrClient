using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleHrClient;
using PeopleHrClient.Enums;
using PeopleHrClient.Models.Requests;
using System.Linq;

namespace PeopleHrClientTests
{
    [TestClass]
    public class History
    {
        private const string ApiKey = "";

        [TestMethod]
        public void SuccessfulGetHistoryByEmployeeIdAndFieldNameReturnsFieldHistorys()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetHistoryByEmployeeIdAndFieldName(new GetHistoryByEmployeeIdAndFieldNameRequest
            {
                APIKey = ApiKey,
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                FieldName = FieldWithHistory.EMPLOYEE_CONTACT_INFORMATION_ADDRESS
            });

            Assert.IsTrue(peopleHrUser.Result != null);
        }

        [TestMethod]
        public void FailedGetHistoryByEmployeeIdAndFieldNameReturnsNoFieldHistorys()
        {
            var peopleHrUsers = PeopleHrService.GetAllEmployeeDetail(new GetAllEmployeeDetailRequest
            {
                APIKey = ApiKey,
                IncludeLeavers = false
            });

            var peopleHrUser = PeopleHrService.GetHistoryByEmployeeIdAndFieldName(new GetHistoryByEmployeeIdAndFieldNameRequest
            {
                APIKey = "",
                EmployeeId = peopleHrUsers.Result.First().EmployeeId.DisplayValue,
                FieldName = FieldWithHistory.EMPLOYEE_CONTACT_INFORMATION_ADDRESS
            });

            Assert.IsTrue(peopleHrUser.Result == null);
        }
    }
}