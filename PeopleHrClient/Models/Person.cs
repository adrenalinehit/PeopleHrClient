using System.Collections.Generic;

namespace PeopleHrClient.Models
{
    public class Person
    {
        public PersonField EmployeeId;
        public PersonField Title;
        public PersonField FirstName;
        public PersonField LastName;
        public PersonField OtherName;
        public PersonField KnownAs;
        public PersonField EmailId;
        public PersonField StartDate;
        public PersonField DateOfBirth;
        public PersonField JobRole;
        public PersonField Company;
        public PersonField CompanyEffectiveDate;
        public PersonField Location;
        public PersonField LocationEffectiveDate;
        public PersonField Department;
        public PersonField DepartmentEffectiveDate;
        public PersonField JobRoleChangeDate;
        public PersonField ReportsTo;
        public PersonField ReportsToEffectiveDate;
        public PersonField ReportsToEmployeeId;
        public PersonField ReportsToEmailAddress;
        public PersonField NISNumber;
        public PersonField Nationality;
        public PersonField EmploymentType;
        public PersonField EmploymentTypeEffectiveDate;
        public PersonField EmployeeStatus;
        public PersonField HolidayAllowanceDays;
        public PersonField HolidayAllowanceMins;
        public PersonField NoticePeriod;
        public PersonField ProbationEndDate;
        public PersonField Gender;
        public PersonContactDetail ContactDetail;
        public IEnumerable<PersonField> OtherContact;
        public IEnumerable<PersonField> RightToWork;
        public IEnumerable<PersonField> BackgroundDetail;
        public PersonBankDetail BankDetail;
        public string LeavingDate;
        public string ReasonForLeaving;
        public string EmployeeImage;
        public string APIColumn1;
        public string APIColumn2;
        public string APIColumn3;
        public string APIColumn4;
        public string APIColumn5;
        public string lstFieldHistoryJobrole;
    }
}