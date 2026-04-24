using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    class CitizenProfile
    {
        public string FullName;
        public string IDNumber;
        public string CitizenshipStatus;
        public int Age;

        public CitizenProfile(string name, string id, string citizenship)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = citizenship;
        }

        private int CalculateAge()
        {
            if (IDNumber.Length < 6)
                throw new Exception("Invalid ID length.");

            string dobPart = IDNumber.Substring(0, 6); // YYMMDD

            int year = int.Parse(dobPart.Substring(0, 2));
            int month = int.Parse(dobPart.Substring(2, 2));
            int day = int.Parse(dobPart.Substring(4, 2));

            int currentYear = DateTime.Now.Year % 100;
            int century = (year <= currentYear) ? 2000 : 1900;

            DateTime birthDate = new DateTime(century + year, month, day);

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now < birthDate.AddYears(age))
                age--;

            return age;
        }

        public string ValidateID()
        {
            if (string.IsNullOrWhiteSpace(IDNumber))
                return "ID cannot be empty.";

            if (IDNumber.Length != 13)
                return "Invalid ID: Must be 13 digits.";

            if (!long.TryParse(IDNumber, out _))
                return "Invalid ID: Must contain only numbers.";

            try
            {
                Age = CalculateAge();
            }
            catch
            {
                return "Invalid ID: Invalid date of birth.";
            }

            if (Age <= 0 || Age > 120)
                return "Invalid ID: Age not realistic.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}