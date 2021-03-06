﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PeopleHrClient.Enums;

namespace PeopleHrClient.Models.Requests
{
    public class GetHistoryByEmployeeIdAndFieldNameRequest : PeopleHrRequest
    {
        public new string Action
        {
            get { return "GetHistoryByEmployeeIdAndFieldName"; }
        }

        public string EmployeeId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FieldWithHistory FieldName { get; set; }
    }
}