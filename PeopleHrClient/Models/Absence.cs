using System.Collections.Generic;

namespace PeopleHrClient.Models
{
    public class Absence
    {
        public string StartDate;
        public string EndDate;
        public string DurationType;
        public string DurationInDaysThisPeriod;
        public string PartOfDay;
        public string BackToWorkInterviewRequried;
        public string BackToWorkInterviewDate;
        public string MedicalCertificateType;
        public string MedicalCertificateReceivedDate;
        public string Reason;
        public IEnumerable<string> Comments;
        public string AbsencePaidStatus;
        public string EmergencyLeave;
    }
}