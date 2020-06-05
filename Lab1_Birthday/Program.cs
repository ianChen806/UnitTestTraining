using System;

namespace Lab1_Birthday
{
    public class Program
    {
        public static void MainAsync()
        {
            var helper = new DateTimeHelper();

            var isBirthday = helper.IsBirthday();

            Console.WriteLine(isBirthday);
        }
    }
}