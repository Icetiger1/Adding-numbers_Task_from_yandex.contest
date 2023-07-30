using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleApp3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string serverurl = Console.ReadLine();
            if (serverurl != null && serverurl != "")
            {
                //port
                int port = int.Parse(Console.ReadLine());

                //a
                int a = int.Parse(Console.ReadLine());

                //b
                int b = int.Parse(Console.ReadLine());

                string url = serverurl + ":" + port + "?a=" + a + "&b=" + b;
                var webClient = new WebClient();
                var response = webClient.DownloadString(url);
                List<long> numbers = JsonConvert.DeserializeObject<List<long>>(response);
                long sum = 0;
                foreach (int i in numbers)
                {
                    sum += i;

                }
                Console.WriteLine(sum);
            }
        }
    }
}