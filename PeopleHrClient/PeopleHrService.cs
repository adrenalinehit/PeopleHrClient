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
                var responseContent = DoPostRequest("https://api.peoplehr.net/Employee", getAllEmployeeDetailRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetAllEmployeeDetailResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetAllEmployeeDetailResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/Employee", getEmployeeDetailByIdRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetEmployeeDetailByIdResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetEmployeeDetailByIdResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/Holiday", getHolidayDetailRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetHolidayDetailResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetHolidayDetailResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/Absence", getAbsenceDetailRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetAbsenceDetailResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetAbsenceDetailResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/EmployeeDocument", getAllDocumentRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetAllDocumentResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetAllDocumentResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/EmployeeDocument", getDocumentByIdRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetDocumentByIdResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetDocumentByIdResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/HolidayEntitlements", getHolidayEntitlementRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetHolidayEntitlementResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetHolidayEntitlementResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/HolidayEntitlements", getNextYearHolidayEntitlementRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetNextYearHolidayEntitlementResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetNextYearHolidayEntitlementResponse>(responseContent);
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
                var responseContent = DoPostRequest("https://api.peoplehr.net/History", getHistoryByEmployeeIdAndFieldNameRequest);
                var response = JsonConvert.DeserializeObject<PeopleHrResponse>(responseContent);

                if (response.isError)
                {
                    return new GetHistoryByEmployeeIdAndFieldNameResponse
                    {
                        isError = response.isError,
                        Message = response.Message,
                        Status = response.Status
                    };
                }

                return JsonConvert.DeserializeObject<GetHistoryByEmployeeIdAndFieldNameResponse>(responseContent);
            }
            catch (Exception error)
            {
                throw new PeopleHrClientException("Unable to perform GetHistoryByEmployeeIdAndFieldName", error);
            }
        }
    }
}