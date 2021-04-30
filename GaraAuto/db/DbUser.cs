namespace GaraAuto.db
{
    public class DbUser
    {
        public string username;
        public string password;

        public DbUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}