using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace iRobot.HostCmdLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            linqSample();

            ServiceHost host = null;
            try
            {

                host =
                    new ServiceHost(typeof(iRobot.HelloWorldWcfService.HelloWorldService),
                        new Uri("http://localhost:9001/iRobot.HostCmdLineApp/iRobot.HelloWorldWcfService.svc"));

                host.Open();
                Console.WriteLine("HelloWorldService is no running.");
                Console.WriteLine("Press any key to stop is ...");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                if (host != null)
                {
                    host.Close();
                }
            }
        }
        static void linqSample()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 100 };
            var list1 = new List<int>();


            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    list1.Add(item);
                }
            }

            var list2 = from item in list
                        where item % 2 == 0
                        select item;

            foreach (var item in list1)
            {
                Console.WriteLine(item.ToString());

            }
            foreach (var item in list2)
            {
                Console.WriteLine(item.ToString());

            }
        }
    }
}
