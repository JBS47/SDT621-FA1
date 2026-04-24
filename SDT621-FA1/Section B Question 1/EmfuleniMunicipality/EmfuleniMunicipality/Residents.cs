using System;

namespace EmfuleniMunicipality
{
    class Resident
    {
        public string Name;
        public string Address;
        public string AccountNumber;
        public double MonthlyUsage;

        public Resident(string name, string address, string accountNumber, double usage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUsage = usage;
        }
    }
}