using System.Globalization;

namespace Testes
{
    internal class Program
    {
        public static void Main()
        {
            // Suponha que esta é a data decimal recebida no formato yyyyMMdd
            decimal dateDecimal = 20240517m;

            // Converter o decimal para string
            string dateString = dateDecimal.ToString();

            // Analisar a string para criar um objeto DateTime
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);

            // Formatar o objeto DateTime no formato "dd.MM.yy"
            string formattedDate = parsedDate.ToString("dd.MM.yy");

            // Exibir a data formatada
            Console.WriteLine("Data formatada: " + formattedDate); // Ex: 17.05.24
        }
    }
}


