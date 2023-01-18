namespace CurrencyConverter.Models.ResultApi
{
    public class Query
    {
        public string from { get; set; }
        public string to { get; set; }
        public int amount { get; set; }
    }
}
