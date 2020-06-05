using System;

namespace Lab1_Birthday
{
    public class DateTimeHelper
    {
        public string IsBirthday()
        {
            var today = DateTime.Today;
            var now = DateTime.Now;
            if (today.Month == now.Month && today.Day == now.Day)
            {
                return "Is Birthday!";
            }

            return "Not Birthday.";
        }
    }
}