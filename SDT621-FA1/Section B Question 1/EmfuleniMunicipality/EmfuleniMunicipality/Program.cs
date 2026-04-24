using EmfuleniMunicipality;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        UtilitiesManager manager = new UtilitiesManager();

        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> requests = new List<ServiceRequest>();

        bool running = true;

        Console.WriteLine("===============================================");
        Console.WriteLine(" EMFULENI MUNICIPALITY SERVICE MANAGEMENT SYSTEM");
        Console.WriteLine("===============================================");

        while (running)
        {
            Console.WriteLine("\n1. Capture Residents");
            Console.WriteLine("2. Capture Service Requests");
            Console.WriteLine("3. View & Process Requests");
            Console.WriteLine("4. Exit");

            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CaptureResidents(residents);
                    break;

                case "2":
                    CaptureRequests(residents, requests, manager);
                    break;

                case "3":
                    ProcessRequests(requests, manager);
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        Console.ReadLine();
    }

    // =========================
    // CAPTURE RESIDENTS
    // =========================
    static void CaptureResidents(List<Resident> residents)
    {
        Console.Write("\nEnter number of residents: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nResident {i + 1}");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, acc, usage));
        }

        Console.WriteLine("Residents captured successfully.\n");
    }

    // =========================
    // CAPTURE SERVICE REQUESTS
    // =========================
    static void CaptureRequests(List<Resident> residents, List<ServiceRequest> requests, UtilitiesManager manager)
    {
        if (residents.Count == 0)
        {
            Console.WriteLine("No residents available. Capture residents first.");
            return;
        }

        Console.Write("\nEnter number of service requests: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nService Request {i + 1}");

            Console.WriteLine("Select Resident:");
            for (int j = 0; j < residents.Count; j++)
            {
                Console.WriteLine($"{j}. {residents[j].Name}");
            }

            int index = int.Parse(Console.ReadLine());

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority Level (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity Level (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Resolution Hours: ");
            int hours = int.Parse(Console.ReadLine());

            ServiceRequest request = new ServiceRequest(residents[index], type, priority, severity, hours);

            request.UrgencyScore = manager.CalculateUrgency(request);

            requests.Add(request);
        }

        Console.WriteLine("Requests captured successfully.\n");
    }

    // =========================
    // PROCESS REQUESTS
    // =========================
    static void ProcessRequests(List<ServiceRequest> requests, UtilitiesManager manager)
    {
        if (requests.Count == 0)
        {
            Console.WriteLine("No requests to process.");
            return;
        }

        List<ServiceRequest> processed = new List<ServiceRequest>();
        ServiceRequest highest = null;

        while (requests.Count > 0)
        {
            Console.WriteLine("\n===== PENDING REQUESTS =====");
            for (int i = 0; i < requests.Count; i++)
            {
                Console.WriteLine($"{i}. {requests[i].RequestType} | Urgency: {requests[i].UrgencyScore}");
            }

            Console.Write("Enter request index to process: ");
            int choice = int.Parse(Console.ReadLine());

            ServiceRequest req = requests[choice];

            manager.GenerateReport(req);

            processed.Add(req);

            if (highest == null || req.UrgencyScore > highest.UrgencyScore)
            {
                highest = req;
            }

            requests.RemoveAt(choice);
        }

        // =========================
        // SUMMARY REPORT
        // =========================
        Console.WriteLine("\n===== SUMMARY REPORT =====");
        Console.WriteLine("Resolved Requests: " + processed.Count);

        foreach (var r in processed)
        {
            Console.WriteLine("- " + r.RequestType + " (Urgency: " + r.UrgencyScore + ")");
        }

        Console.WriteLine("\nHighest Urgency Request:");
        Console.WriteLine(highest.RequestType + " - Score: " + highest.UrgencyScore);
    }
}