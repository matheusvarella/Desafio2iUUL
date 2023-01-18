namespace CurrencyConverter.ViewModels
{
    public class RequestInitialValues
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Value { get; set; }

        public RequestInitialValues(string from, string to, double value)
        {
            From = from;
            To = to;
            Value = value;
        }
    }
}
