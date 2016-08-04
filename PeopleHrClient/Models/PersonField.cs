using System.Collections.Generic;

namespace PeopleHrClient.Models
{
    public class PersonField
    {
        public string DisplayValue;
        public IEnumerable<PersonFieldHistory> FieldHistory;
        public IEnumerable<PersonFieldHistoryForJobRole> FieldHistoryForJobRole;
        public IEnumerable<PersonFieldHistoryForEffectiveDate> FieldHistoryForEffectiveDate;
    }
}