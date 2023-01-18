namespace CurrencyConverter.Models
{
    public partial class RequestCurrentConverter
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public double Value { get; private set; }

        public string SetFromIfValid(string from)
        {
            var isValid = CoinIsValid(from.Trim());
            if (isValid != null)
                return isValid;

            From = from.Trim();
            return null;
        }

        public string SetToIfValid(string to)
        {
            var isValid = CoinIsValid(to.Trim());
            if (isValid != null)
                return isValid;

            To = to.Trim();
            return null;
        }

        public string SetValueIfValid(double value)
        {
            var isValid = ValueIsValid(value);
            if (isValid != null)
                return isValid;

            Value = value;
            return null;
        }
    }
}
