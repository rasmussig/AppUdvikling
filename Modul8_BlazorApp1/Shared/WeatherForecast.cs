namespace Modul8_BlazorApp1.Shared
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public string? Location { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    
    }
}