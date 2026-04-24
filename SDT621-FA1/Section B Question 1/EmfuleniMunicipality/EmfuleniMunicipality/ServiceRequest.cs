using System;

namespace EmfuleniMunicipality
{
    class ServiceRequest
    {
        public Resident Resident;
        public string RequestType;
        public int PriorityLevel; // 1 - 5
        public int SeverityLevel; // 1 - 10
        public int ResolutionHours;

        public double UrgencyScore;

        public ServiceRequest(Resident resident, string type, int priority, int severity, int hours)
        {
            Resident = resident;
            RequestType = type;
            PriorityLevel = priority;
            SeverityLevel = severity;
            ResolutionHours = hours;
        }
    }
}