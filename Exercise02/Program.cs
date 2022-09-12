using Excercise01;
using System.Numerics;

Console.WriteLine("Hello there! Enter a number to convert to word or type 'exit' to exit the program");
while (true)
{
    Console.Write("Enter a number: ");
    var input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
    else
    {
        //check if string contains commas
        if (input.Contains(","))
        {
            //remove commas
            input = input.Replace(",", "");
        }

        if (ulong.TryParse(input, out ulong number))
        {
            var extendNumber = new ExtendNumber();
            extendNumber.UlongNumber = number;
            Console.WriteLine(extendNumber.Towards());
        }
        else if (BigInteger.TryParse(input, out BigInteger bigNumber))
        {
            var extendNumber = new ExtendNumber();
            extendNumber.BigIntegerNumber = bigNumber;
            Console.WriteLine(extendNumber.Towards());
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }

}