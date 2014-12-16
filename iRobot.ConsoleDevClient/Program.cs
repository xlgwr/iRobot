using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRobot.ConsoleDevClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldServiceClient client = new HelloWorldServiceClient();
            Console.WriteLine(client.GetMessage("xlgwr coming,irobot."));
            Console.Read();
        }
    }
}
