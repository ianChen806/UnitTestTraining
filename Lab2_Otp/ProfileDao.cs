namespace Lab2_Otp
{
    public class ProfileDao 
    {
        public string GetPassword(string account)
        {
            return Context.GetPassword(account);
        }
    }
}