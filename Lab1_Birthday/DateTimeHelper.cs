using System;

namespace Lab1_Birthday
{
    public class DateTimeHelper
    {
        public string IsBirthday()
        {
            var today = DateTime.Today;
            if (today.Month == 6 && today.Day == 10)
            {
                return "Is Birthday!";
            }

            return "Not Birthday.";
        }
    }
}