namespace CurrencyConverter.ViewModels
{
    public class ResultViewModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
        public double? Result { get; set; }
        public double? Rate { get; set; }

        public ResultViewModel(string from, string to, double amount, double? result, double? rate)
        {
            From = from;
            To = to;
            Amount = amount;
            Result = result;
            Rate = rate;
        }
    }
}
