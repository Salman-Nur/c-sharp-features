namespace AnnonymousTypes
{
    public class Membership
    {
        public object CreateUser(string username, string password)
        {
            User newUser = new User() { Username = username, Password = password };
            AccountCreationStatus status = StoreInDatabase(newUser);

            return new { status = status, user = newUser };




        }

        public AccountCreationStatus StoreInDatabase(User user)
        {
            return AccountCreationStatus.Success;

        }








    }



}


