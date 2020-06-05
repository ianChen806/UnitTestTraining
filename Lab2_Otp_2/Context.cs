using System.Collections.Generic;

namespace Lab2_Otp_2
{
    public static class Context
    {
        public static Dictionary<string, string> profiles;

        static Context()
        {
            profiles = new Dictionary<string, string>();
            profiles.Add("me", "123");
            profiles.Add("you", "666");
        }

        public static string GetPassword(string key)
        {
            return profiles[key];
        }
    }
}