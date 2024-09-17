namespace DraftProspects
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class NCAAHockeyStats
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string College { get; set; }
        public string Year { get; set; }
        public string Height { get; set; }
        public string Position { get; set; }
        public string GamesPlayed { get; set; }
        public string Goals { get; set; }
        public string Assists { get; set; }
        public string Points { get; set; }
        public string PPGAvg { get; set; }
    }
}