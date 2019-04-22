namespace ProxyPattern
{
    public class Client
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public Client(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void ClientCode(IService subject)
        {
            // ...

            subject.Request(this);

            // ...
        }
    }
}
