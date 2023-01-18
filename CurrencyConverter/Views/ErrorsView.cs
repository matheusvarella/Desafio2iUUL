using System;
using System.Collections.Generic;

namespace CurrencyConverter.Views
{
    public static class ErrorsView
    {
        public static void PrintErros(List<string> errors)
        {
            Console.WriteLine("\nOcorreram alguns erros!");
            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("Digite novamente \n");
        }
    }
}
