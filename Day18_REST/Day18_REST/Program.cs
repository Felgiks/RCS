using System;
using System.Net;
using Newtonsoft.Json;

namespace Day18_REST
{
    class Program
    {
        static void Main(string[] args)
        {
           // String url = "http://dummy.restapiexample.com/api/v1/employees";
            String url = "http://pi.openweathermap.org/data/2.5/weather?q={cityname}&appid={yourapikey}";

            WebClient client = new WebClient();

            // client.Headers.Add("Autentification-Token", "12h-1234afa-1245sgrgz-KEY");
           
            String response = client.DownloadString(url);

            //Console.WriteLine(response);

            Container rec = JsonConvert.DeserializeObject<Container>(response);

            if (rec.status == "success")
            {
                foreach (Employee e in rec.data)
                {
                    Console.WriteLine(e.employee_name);
                }
            }

        }
    }
}