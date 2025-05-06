namespace ApplyFlow
{
    internal class UserService
    {
        private UserRepo _userRepo;
        public UserService()
        {
            _userRepo = new UserRepo();
        }

        public bool authenticateUser(string username, string password)
        {
            return _userRepo.queryUser(username, password);
        }
    }
}
