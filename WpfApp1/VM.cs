using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    //this is the view model
    class VM
    {
        private int port;
        private IPAddress ip;
        private MainWindow mainWindow;

        public VM(int serverPort , IPAddress serverIP, MainWindow mainWindow) {

            port = serverPort;
            ip = serverIP;

        }

        public string ReadSocket()
        {
            return "s";
        }

        public string WriteSocket()
        {
            return "S";
        }
    }
}
