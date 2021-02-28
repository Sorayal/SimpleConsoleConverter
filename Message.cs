using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleConsoleConverter
{
    public class Message
    {
        public string EnterANumber() => "Enter an Integer";
        public string ReturnIntToHexResult(int inputInteger) => $"Hex-Value {inputInteger:X}";
        public string ReturnHexToIntResult(int inputInteger) => $"Value {inputInteger}";
        public string ReturnConvertingError() => "The input to convert was not valid.";
        public string ReturnOutOfRangeError() => "The result was out of range.";
    }
}
