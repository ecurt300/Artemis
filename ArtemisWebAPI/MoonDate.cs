namespace ArtemisWebAPI
{
    public class MoonDate
    {
        public DateOnly Date { get; set; }

        public int Days { get; set; }

        public int TemperatureF => 32 + (int)(Days / 0.5556);

        public string? Summary { get; set; }
    }
}
