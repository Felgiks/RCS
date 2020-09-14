using Newtonsoft.Json;
using System;
using System.Net;

namespace Day23_RestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://my-json-server.typicode.com/Felgiks/RestFake/db";

            WebClient client = new WebClient();

            String response = client.DownloadString(url);

            Console.WriteLine(response);

            Container rec = JsonConvert.DeserializeObject<Container>(response);

            if (rec.status == "success")
            {
                foreach (Student person in rec.data)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
