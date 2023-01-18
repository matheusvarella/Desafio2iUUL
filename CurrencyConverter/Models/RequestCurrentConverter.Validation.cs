namespace CurrencyConverter.Models
{
    public partial class RequestCurrentConverter
    {
        private string CoinIsValid(string coin)
        {
            if (coin.Length != 3)
                return "A moeda foi digitada incorretamente.";

            if (From != null && From == coin)
                return "As duas moedas são iguais.";

            return null;
        }

        private string ValueIsValid(double value)
        {
            if (value <= 0)
                return "Valor inválido.";

            return null;
        }
    }
}
