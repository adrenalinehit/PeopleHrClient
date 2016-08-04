using Newtonsoft.Json;
using PeopleHrClient.Exceptions;
using PeopleHrClient.Models.Requests;
using PeopleHrClient.Models.Responses;
using RestSharp;
using System;

namespace PeopleHrClient
{
    public class PeopleHrService
    {
        private static string DoPostRequest<T>(string url, T requestBody)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", JsonConvert.SerializeObject(requestBody), ParameterType.RequestBody);

            var restResponse = client.Execute(request);

            return restResponse.Content;
        }

        public static GetAllEmployeeDetailResponse GetAllEmployeeDetail(GetAllEmployeeDetailRequest getAllEmployeeDetailRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetAllEmployeeDetailResponse>(DoPostRequest("https://api.peoplehr.net/Employee", getAllEmployeeDetailRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetAllEmployeeDetail", error);
            }
        }

        public static GetEmployeeDetailByIdResponse GetEmployeeDetailById(GetEmployeeDetailByIdRequest getEmployeeDetailByIdRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetEmployeeDetailByIdResponse>(DoPostRequest("https://api.peoplehr.net/Employee", getEmployeeDetailByIdRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetEmployeeDetailById", error);
            }
        }

        public static GetHolidayDetailResponse GetHolidayDetail(GetHolidayDetailRequest getHolidayDetailRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetHolidayDetailResponse>(DoPostRequest("https://api.peoplehr.net/Holiday", getHolidayDetailRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetHolidayDetail", error);
            }
        }

        public static GetAbsenceDetailResponse GetAbsenceDetail(GetAbsenceDetailRequest getAbsenceDetailRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetAbsenceDetailResponse>(DoPostRequest("https://api.peoplehr.net/Absence", getAbsenceDetailRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetAbsenceDetail", error);
            }
        }

        public static GetAllDocumentResponse GetAllDocument(GetAllDocumentRequest getAllDocumentRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetAllDocumentResponse>(DoPostRequest("https://api.peoplehr.net/EmployeeDocument", getAllDocumentRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetAllDocument", error);
            }
        }

        public static GetDocumentByIdResponse GetDocumentById(GetDocumentByIdRequest getDocumentByIdRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetDocumentByIdResponse>(DoPostRequest("https://api.peoplehr.net/EmployeeDocument", getDocumentByIdRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetDocumentById", error);
            }
        }

        public static GetHolidayEntitlementResponse GetHolidayEntitlement(GetHolidayEntitlementRequest getHolidayEntitlementRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetHolidayEntitlementResponse>(DoPostRequest("https://api.peoplehr.net/HolidayEntitlements", getHolidayEntitlementRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetHolidayEntitlement", error);
            }
        }

        public static GetNextYearHolidayEntitlementResponse GetNextYearHolidayEntitlement(GetHolidayEntitlementRequest getNextYearHolidayEntitlementRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetNextYearHolidayEntitlementResponse>(DoPostRequest("https://api.peoplehr.net/HolidayEntitlements", getNextYearHolidayEntitlementRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetNextYearHolidayEntitlement", error);
            }
        }

        public static GetHistoryByEmployeeIdAndFieldNameResponse GetHistoryByEmployeeIdAndFieldName(GetHistoryByEmployeeIdAndFieldNameRequest getHistoryByEmployeeIdAndFieldNameRequest)
        {
            try
            {
                return JsonConvert.DeserializeObject<GetHistoryByEmployeeIdAndFieldNameResponse>(DoPostRequest("https://api.peoplehr.net/History", getHistoryByEmployeeIdAndFieldNameRequest));
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetHistoryByEmployeeIdAndFieldName", error);
            }
        }
    }
}