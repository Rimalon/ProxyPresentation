using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    class Proxy : IService
    {
        private List<String> _logs;
        private Dictionary<string, string> _users;
        private Service _realService;

        public Proxy()
        {
            _realService = null;
            _logs = new List<string>();
            _users = new Dictionary<string, string>();
            _users.Add("Ilya", "qwerty1234");
        }

        public Proxy(Service s)
        {
            _realService = s;
            _logs = new List<string>();
            _users = new Dictionary<string, string>();
            _users.Add("Ilya", "qwerty1234");
        }

        public void Request(Client client)
        {
            Console.WriteLine("Proxy: Handling Request.");
            if (CheckAccess(client.Login, client.Password))
            {
                if (_realService == null)
                {
                    _realService = new Service();
                }
                _realService.Request(client);
                _logs.Add("Time of request : " + DateTime.Now.ToString() + " Access is allowed;");
            }
            else
            {
                _logs.Add("Time of request : " + DateTime.Now.ToString() + " Access is denied;");
            }
            
        }

        public bool CheckAccess(string login, string password)
        {
            bool result = _users.ContainsKey(login) && (_users[login] == password);
            if (result)
            {
                Console.WriteLine("Proxy: Access is allowed");
            }
            else
            {
                Console.WriteLine("Proxy: Access is denied");
            }
            return result;
        }
        
        public void ShowLogs()
        {
            foreach (var l in _logs)
            {
                Console.WriteLine(l);
            }
        }
    }
}
