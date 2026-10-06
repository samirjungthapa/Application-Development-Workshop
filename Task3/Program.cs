using System;

class Program
{
    static void Main()
    {

        byte byteValue = 10;
        short shortValue = 20;
        int intValue = 30;
        long longValue = 40;
        float floatValue = 3.14f;
        double doubleValue = 6.28;
        decimal decimalValue = 9.99m;
        char charValue = 'A';
        bool boolValue = true;
        
        int number = 42;
        string numberString = number.ToString();
        
        string text = "3.14";
        double convertedDouble = Convert.ToDouble(text);
        

        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine($"42 converted to string: {numberString}");
        Console.WriteLine($"3.14 converted to double: {convertedDouble}");
    }
}