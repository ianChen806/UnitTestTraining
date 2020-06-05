namespace Lab2_Otp_2
{
    public class AuthenticationService
    {
        private IProfile _profile;
        private IToken _token;
        private ILog _log;

        public AuthenticationService(IProfile profile, IToken token, ILog log)
        {
            _profile = profile;
            _token = token;
            _log = log;
        }

        public bool IsValid(string account, string password)
        {
            // 根據 account 取得自訂密碼
            var passwordFromDao = _profile.GetPassword(account);

            // 根據 account 取得 RSA token 目前的亂數
            var randomCode = _token.GetRandom(account);

            // 驗證傳入的 password 是否等於自訂密碼 + RSA token亂數
            var validPassword = passwordFromDao + randomCode;
            var isValid = password == validPassword;

            if (!isValid)
            {
                // todo, 如何驗證當有非法登入的情況發生時，有正確的記錄log？
                var content = $"account:{account} try to login failed";
                _log.Save(content);
            }

            return isValid;
        }
    }
}