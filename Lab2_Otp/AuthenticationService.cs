namespace Lab2_Otp
{
    public class AuthenticationService
    {
        public bool IsValid(string account, string passcode)
        {
            // 根據 account 取得自訂密碼
            var passwordFromDao = new ProfileDao().GetPassword(account);

            // 根據 account 取得 RSA token 目前的亂數
            var randomCode = new RsaTokenDao().GetRandom(account);

            // 驗證傳入的 password 是否等於自訂密碼 + RSA token亂數
            var validPassword = passwordFromDao + randomCode;
            var isValid = passcode == validPassword;

            if (isValid)
            {
                return true;
            }

            return false;
        }
    }
}