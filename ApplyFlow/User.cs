namespace ApplyFlow
{
    internal class User
    {
        private string _username = "";
        private string _password = "";
        private static User _instance;
        public static User GetInstance()
        {
            if (_instance == null)
            {
                _instance = new User();
            }
            return _instance;
        }
        public void SetUsername(string username)
        {
            _username = username;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }
        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}




