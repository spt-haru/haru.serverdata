using System;
using Haru.ServerData.Tables;
using Haru.ServerData.Utils;

namespace Haru.ServerData.Servers
{
    public class ServerManager
    {
        private const string _certpath = "./Haru/certs/cert.pfx";
        private const string _certpass = "";

        private readonly Cert _certUtil;
        private readonly MainServer _mainServer;

        public ServerManager()
        {
            _certUtil = new Cert(_certpath);
            _mainServer = new MainServer();
        }

        public void Start()
        {
            // load database
            Database.Instance.LoadAll();

            // load certificate
            if (!_certUtil.IsValid(_certpass))
            {
                Console.WriteLine("[certificate]: Generating new certificate...");
                _certUtil.CreateCertificate("Haru", _certpass);
            }

            Console.WriteLine("[certificate]: Loaded certificate");

            // load servers
            _mainServer.Load(_certpath, _certpass);

            // start servers
            _mainServer.Start();
        }
    }
}