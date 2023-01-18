using CurrencyConverter.ViewModels;
using System;
using System.Globalization;

namespace CurrencyConverter.Views
{
    public static class ResultView
    {
        public static void PrintResult(ResultViewModel model)
        {
            decimal amount = Convert.ToDecimal(model.Amount, new CultureInfo("pt-BR"));
            decimal result = Convert.ToDecimal(model.Result, new CultureInfo("pt-BR"));
            decimal rate = Convert.ToDecimal(model.Rate, new CultureInfo("pt-BR"));

            Console.WriteLine(@$"{model.From} {amount.ToString("N2")} => {model.To} {result.ToString("N2")}");
            Console.WriteLine();
            Console.WriteLine($"Taxa: {rate.ToString("N6")}");
            Console.WriteLine();
        }
    }
}
