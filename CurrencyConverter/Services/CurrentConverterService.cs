using CurrencyConverter.Models.ResultApi;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System;
using System.Threading.Tasks;
using CurrencyConverter.Models;

namespace CurrencyConverter.Services
{
    public static class CurrentConverterService
    {
        public static async Task<ConvertionResult> MakeRequestServer(RequestCurrentConverter model)
        {
            HttpClient httpCliente = new HttpClient { BaseAddress = new Uri("https://api.exchangerate.host/") };
            var response = httpCliente.GetAsync($"convert?from={model.From}&to={model.To}&amount={model.Value}");

            var js = new DataContractJsonSerializer(typeof(ConvertionResult));
            var content = await response.Result.Content.ReadAsStringAsync();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(content));
            var convertionResult = (ConvertionResult)js.ReadObject(ms);

            return convertionResult;
        }
    }
}
