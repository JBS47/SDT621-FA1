using System;

class Program
{
    static void Main()
    {
        // Student name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // Variables
        double mark1 = GetValidMark("Enter mark for Subject 1: ");
        double mark2 = GetValidMark("Enter mark for Subject 2: ");
        double mark3 = GetValidMark("Enter mark for Subject 3: ");

        // Calculations
        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        // ROUNDING (IMPORTANT CHANGE)
        average = Math.Round(average, 1);

        // Result
        string result = (average >= 50) ? "PASS" : "FAIL";

        // Date issued
        string dateIssued = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

        // Output
        Console.WriteLine("\n===== STUDENT RESULTS =====");
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Issued On: " + dateIssued);

        Console.ReadLine();
    }

    // Method to validate numeric input
    static double GetValidMark(string message)
    {
        double mark;
        bool isValid;

        do
        {
            Console.Write(message);
            string input = Console.ReadLine();

            isValid = double.TryParse(input, out mark);

            if (!isValid)
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
            }

        } while (!isValid);

        return mark;
    }
}