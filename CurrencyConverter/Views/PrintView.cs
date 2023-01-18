using CurrencyConverter.ViewModels;
using System;

namespace CurrencyConverter.Views
{
    public static class PrintView
    {
        public static RequestInitialValues PrintRequestInitialValues()
        {
            Console.Write("Moeda de origem: ");
            var originCoin = Console.ReadLine();

            if (originCoin.Trim() == "")
                return null;

            Console.Write("Moeda de destino: ");
            var destinyCoin = Console.ReadLine();

            Console.Write("Valor: ");
            var value = double.Parse(Console.ReadLine());

            return new RequestInitialValues(originCoin, destinyCoin, value);
        }
    }
}
