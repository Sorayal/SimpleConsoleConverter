using System;
using System.Globalization;

namespace SimpleConsoleConverter
{
    
    class Program
    {
        static void Main()
        {
            Message message = new Message();

            Console.WriteLine(message.EnterANumber());
            string input = Console.ReadLine();
            bool successfulTransformed = int.TryParse(input, out int inputInteger);
            string result = successfulTransformed == true ? (message.ReturnIntToHexResult(inputInteger)) : message.ReturnConvertingError();
            Console.WriteLine(result);

            CultureInfo cultureInfo = new CultureInfo("en-US");

            successfulTransformed = int.TryParse(input, NumberStyles.HexNumber, cultureInfo, out int inputHex);
            result = successfulTransformed == true ? (message.ReturnHexToIntResult(inputHex)) : message.ReturnConvertingError();
            Console.WriteLine(result);


            //Umwandlung auslagern in MEthoden  :   Rückgabe String(input string)
        }
    }
}
