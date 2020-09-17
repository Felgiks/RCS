using System;

namespace Day23_TestApi
{
    public class WeatherForecast
    {//seit liktu ieksaa studentus
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
