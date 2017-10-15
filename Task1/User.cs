using System;

namespace Task1
{
    class User
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }

        public int Age {
            get {
                return CalculateAge(BirthDate);
            }
        }

        public User(string lastName, string firstName, string middleName, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return string.Format("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4}\n",
                LastName, FirstName, MiddleName, BirthDate.ToLongDateString(), Age);
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            // Go back to the year the person was born in case of a leap year
            if (BirthDate > today.AddYears(-age)) age--;
            return age;
        }
    }
}
