using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IPAddress serverIp;
        private int serverPort;

        public MainWindow()
        {
            InitializeComponent();
            Client();

            VM vmModel = new VM(serverPort, serverIp);
        }

        private void Client()
        {
            settings.Content = "gfjfhd";
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
              //  IPEndPoint ipLocalEndPoint = new IPEndPoint(ipAddress, 8888);
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", 8888);

                NetworkStream ns = client.GetStream();

                byte[] bytes = new byte[1024];
                int bytesRead = ns.Read(bytes, 0, bytes.Length);

                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));

                serverPort = 9000;
                serverIp = ipAddress;
                client.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
