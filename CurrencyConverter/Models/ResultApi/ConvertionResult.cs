namespace CurrencyConverter.Models.ResultApi
{
    public class ConvertionResult
    {
        public Motd motd { get; set; }
        public bool success { get; set; }
        public Query query { get; set; }
        public Info info { get; set; }
        public bool historical { get; set; }
        public string date { get; set; }
        public double? result { get; set; }
    }
}
