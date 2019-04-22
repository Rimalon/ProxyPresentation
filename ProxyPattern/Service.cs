using System;
using System.Threading;

namespace ProxyPattern
{
    class Service : IService
    {
        public Service()
        {
            Console.WriteLine("RealSubject: Start init");
            Thread.Sleep(1500);
            Console.WriteLine("RealSubject: End init");
        }

        public void Request(Client client)
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
