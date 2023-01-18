using CurrencyConverter.Models;
using CurrencyConverter.Models.ResultApi;
using CurrencyConverter.Services;
using CurrencyConverter.ViewModels;
using CurrencyConverter.Views;
using System;
using System.Collections.Generic;

namespace CurrencyConverter.Controllers
{
    public static class FlowCurrent
    {
        public static void Init()
        {
            do
            {
                var requestInitialValues = PrintView.PrintRequestInitialValues();

                if (requestInitialValues == null)
                {
                    Console.WriteLine("Sistema encerrado!");
                    break;
                }

                var requestCurrentConverter = new RequestCurrentConverter();
                var errors = new List<string>();

                var aux = requestCurrentConverter.SetFromIfValid(requestInitialValues.From);

                if (aux != null)
                    errors.Add(aux);

                aux = requestCurrentConverter.SetToIfValid(requestInitialValues.To);
                if (aux != null)
                    errors.Add(aux);

                aux = requestCurrentConverter.SetValueIfValid(requestInitialValues.Value);
                if (aux != null)
                    errors.Add(aux);

                if (errors.Count > 0)
                {
                    ErrorsView.PrintErros(errors);
                    continue;
                }

                var requestServer = CurrentConverterService.MakeRequestServer(requestCurrentConverter);

                aux = RequestIsValid(requestServer.Result);

                if (aux != null)
                {
                    errors.Add(aux);
                    ErrorsView.PrintErros(errors);
                    continue;
                }

                var resultViewModel = new ResultViewModel(
                    requestServer.Result.query.from,
                    requestServer.Result.query.to,
                    requestServer.Result.query.amount,
                    requestServer.Result.result,
                    requestServer.Result.info.rate);

                ResultView.PrintResult(resultViewModel);

            } while(true);
        }
        
        private static string RequestIsValid(ConvertionResult convertion)
        {
            if (convertion.result == null || convertion.info.rate == null)
                return "Moedas informadas inválidas.";

            return null;
        }
    }
}