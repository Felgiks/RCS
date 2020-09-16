using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

namespace Day23_Still_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://my-json-server.typicode.com/RediGt/FakeRest/db";

            WebClient client = new WebClient();

            String response = client.DownloadString(url);

            Console.WriteLine(response);

           // List<Student> rec = JsonConvert.DeserializeObject<Student>(response);
            Container rec = JsonConvert.DeserializeObject<Container>(response);

            foreach (Student st in rec.Students)
            {
                Console.WriteLine(st);
            }

        }
    }
}
