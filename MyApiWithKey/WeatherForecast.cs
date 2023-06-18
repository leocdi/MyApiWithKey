namespace MyApiWithKey
{
    public class WeatherForecast
    {

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public PartOfDay Part { get; set; }

    }

    public class MiniForecast
    {

        public string? TemperatureC { get; set; }

        public string? TemperatureF { get; set; }

        public string? Summary { get; set; }

        public string? Part { get; set; }

    }

    public enum PartOfDay
    {
        Morning ,
        Afternoon ,
        Evening ,
        Night
    }
}