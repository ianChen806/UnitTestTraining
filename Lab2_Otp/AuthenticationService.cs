using System;

namespace Lab2_Otp
{
    public class AuthenticationService
    {
        public bool IsValid(string account, string passcode)
        {
            // 根據 account 取得自訂密碼
            var passwordFromDao = Context.GetPassword(account);

            // 根據 account 取得 RSA token 目前的亂數
            var seed = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            var result = seed.Next(0, 999999).ToString("000000");
            Console.WriteLine("randomCode:{0}", result);
            var randomCode = result;

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