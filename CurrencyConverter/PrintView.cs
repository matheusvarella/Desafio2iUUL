using CurrencyConverter.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public static class PrintView
    {
        public static async Task Print()
        {
            Console.Write("Moeda de origem: ");
            var originCoin = Console.ReadLine();

            Console.Write("Moeda de destino: ");
            var destinyCoin = Console.ReadLine();

            Console.Write("Valor: ");
            var value = double.Parse(Console.ReadLine());

            HttpClient httpCliente = new HttpClient { BaseAddress = new Uri("https://api.exchangerate.host/") };
            var response = httpCliente.GetAsync($"convert?from={originCoin}&to={destinyCoin}&amount={value}");

            var js = new DataContractJsonSerializer(typeof(ConvertionResult));
            var content = await response.Result.Content.ReadAsStringAsync();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
            var convertionResult = (ConvertionResult)js.ReadObject(ms);

            Console.WriteLine(convertionResult.result);
        }
    }
}
