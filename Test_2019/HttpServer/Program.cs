using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace HttpServer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            server.Start();
        }

        public interface IHttpServer
        {
            void Start();

            void Stop();
        }

        public class HttpServer : IHttpServer
        {
            private TcpListener tcpListener;
            private bool isWorking;

            public HttpServer()
            {
                this.tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 654));
            }
            public void Start()
            {
                this.isWorking = true;
                this.tcpListener.Start();
                Console.WriteLine("Started.");

                while (isWorking)
                {
                    var client = this.tcpListener.AcceptTcpClient();
                    var stream = client.GetStream();
                    var buffer = new byte[1024];
                   var readLength = stream.Read(buffer, 0, buffer.Length);
                   var requestText = Encoding.UTF8.GetString(buffer, 0,readLength);
                    Console.WriteLine(new string('=',60));
                   Console.WriteLine(requestText);
                  // Thread.Sleep(5000);
                   var responseText = File.ReadAllText("./Index.html");
                   var responseBytes = Encoding.UTF8.GetBytes("HTTP/1.0 200 OK" +
                                                         Environment.NewLine +
                                                         "Content Length: " + responseText.Length + 
                                                         Environment.NewLine + 
                                                         Environment.NewLine + responseText);
                   stream.Write(responseBytes);
                }
            }

            public void Stop()
            {
                this.isWorking = false;
            }
        }
    }
}
