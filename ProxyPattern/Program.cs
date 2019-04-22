using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Password: ");
            var pass = Console.ReadLine();

            var proxy = new Proxy();
            var client = new Client(login, pass);

            Console.WriteLine("Work with proxy:");
            client.ClientCode(proxy);
            proxy.ShowLogs();
            Console.WriteLine("\nWork with service:");
            var service = new Service();
            client.ClientCode(service);
            Console.ReadKey();
        }
    }
}
