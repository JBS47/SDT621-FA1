using EmfuleniMunicipality;
using System;
using System.Collections.Generic;

namespace EmfuleniMunicipality
{
    class UtilitiesManager
    {
        // Calculate urgency score
        public double CalculateUrgency(ServiceRequest request)
        {
            return (request.PriorityLevel * 2) + (request.SeverityLevel * 3) + (request.ResolutionHours * 0.5);
        }

        // Generate report
        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("\n===== SERVICE REPORT =====");
            Console.WriteLine("Resident Name: " + request.Resident.Name);
            Console.WriteLine("Address: " + request.Resident.Address);
            Console.WriteLine("Account Number: " + request.Resident.AccountNumber);
            Console.WriteLine("Request Type: " + request.RequestType);
            Console.WriteLine("Priority Level: " + request.PriorityLevel);
            Console.WriteLine("Severity Level: " + request.SeverityLevel);
            Console.WriteLine("Resolution Hours: " + request.ResolutionHours);
            Console.WriteLine("Urgency Score: " + request.UrgencyScore);
            Console.WriteLine("==========================\n");
        }
    }
}