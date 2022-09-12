using System.Numerics;

namespace Excercise01
{
    public class ExtendNumber
    {
        private string[] Ones = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private string[] Tens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private string[] Tens2 = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private string[] Thousands = new string[] { "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion" };

        public BigInteger BigIntegerNumber { get; set; }
        public ulong UlongNumber { get; set; }
        public string Towards()
        {

            //convert number to word and return it
            if (BigIntegerNumber > 0)
            {
                return ConvertBigIntegerToWord(BigIntegerNumber);
            }
            else
            {
                return ConvertUlongNumberToWord(UlongNumber);
            }

        }
        private string ConvertUlongNumberToWord(ulong number)
        {
            if (number < 10)
            {
                return Ones[number];
            }
            else if (number < 20)
            {
                return Tens[number - 10];
            }
            else if (number < 100)
            {
                return Tens2[number / 10 - 2] + (number % 10 != 0 ? " " + Ones[number % 10] : "");
            }
            else if (number < 1000)
            {
                var word = Ones[number / 100] + " Hundred" + (number % 100 != 0 ? " and " + ConvertUlongNumberToWord(number % 100) : "");

                return word;

            }
            else
            {
                for (int i = 0; i < Thousands.Length; i++)
                {
                    if (number < BigInteger.Pow(1000, i + 2))
                    {
                        var word = ConvertUlongNumberToWord((ulong)(number / BigInteger.Pow(1000, i + 1))) + " " + Thousands[i] + (number % BigInteger.Pow(1000, i + 1) != 0 ? ", " + ConvertUlongNumberToWord((ulong)(number % BigInteger.Pow(1000, i + 1))) : "");
                        //check if word contains thousand and does not contain hundred
                        if (word.Contains("Thousand") && !word.Contains("Hundred"))
                        {

                            word = word.Replace("Thousand", "Thousand and");
                            word = word.Replace("and, ", "and ");

                        }

                        if (word.Contains("Thousand"))
                        {

                            word = word.Replace("Thousand", "Thousand and");
                            word = word.Replace("and, ", "and ");
                        }

                        //check if word contains million and does not contain hundred
                        if (word.Contains("Million") && !word.Contains("Hundred and"))
                        {
                            //check whether the millon is the last word in the string and add and if it is not
                            if (!word.EndsWith("Million"))
                            {
                                word = word.Replace("Million", "Million and");
                                word = word.Replace("and, ", "and ");
                            }


                        }
                        //check if word contains billion and does not contain hundred
                        if (word.Contains("Billion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Billion"))
                            {
                                word = word.Replace("Billion", "Billion and");
                                word = word.Replace("and, ", "and ");
                            }


                        }
                        //check if word contains trillion and does not contain hundred
                        if (word.Contains("Trillion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Trillion"))
                            {
                                word = word.Replace("Trillion", "Trillion and");
                                word = word.Replace("and, ", "and ");
                            }

                        }
                        //check if word contains quadrillion and does not contain hundred
                        if (word.Contains("Quadrillion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Quadrillion"))
                            {
                                word = word.Replace("Quadrillion", "Quadrillion and");
                                word = word.Replace("and, ", "and ");
                            }

                        }
                        //check if word contains consecutive ands and remove redundant ands
                        if (word.Contains("Thousand and and"))
                        {
                            word = word.Replace("Thousand and and", "Thousand and");
                        }



                        return word;
                    }
                }
                return "";
            }
        }
        private string ConvertBigIntegerToWord(BigInteger number)
        {
            if (number < 10)
            {
                return Ones[(int)number];
            }
            else if (number < 20)
            {
                return Tens[(int)number - 10];
            }
            else if (number < 100)
            {
                return Tens2[(int)number / 10 - 2] + (number % 10 != 0 ? " " + Ones[(int)number % 10] : "");
            }
            else if (number < 1000)
            {
                var word = Ones[(int)number / 100] + " Hundred" + (number % 100 != 0 ? " and " + ConvertBigIntegerToWord(number % 100) : "");
                return word;

            }
            else
            {
                for (int i = 0; i < Thousands.Length; i++)
                {
                    if (number < BigInteger.Pow(1000, i + 2))
                    {
                        var word = ConvertBigIntegerToWord(number / BigInteger.Pow(1000, i + 1)) + " " + Thousands[i] + (number % BigInteger.Pow(1000, i + 1) != 0 ? ", " + ConvertBigIntegerToWord(number % BigInteger.Pow(1000, i + 1)) : "");
                        //check if word contains quintillion and does not contain hundred

                        //check if word contains thousand and does not contain hundred
                        if (word.Contains("Thousand") && !word.Contains("Hundred"))
                        {

                            word = word.Replace("Thousand", "Thousand and");
                            word = word.Replace("and, ", "and ");

                        }
                        //check if word contains million and does not contain hundred
                        if (word.Contains("Million") && !word.Contains("Hundred and"))
                        {
                            //check whether the millon is the last word in the string and add and if it is not
                            if (!word.EndsWith("Million"))
                            {
                                word = word.Replace("Million", "Million and");
                                word = word.Replace("and, ", "and ");
                            }


                        }
                        //check if word contains billion and does not contain hundred
                        if (word.Contains("Billion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Billion"))
                            {
                                word = word.Replace("Billion", "Billion and");
                                word = word.Replace("and, ", "and ");
                            }


                        }
                        //check if word contains trillion and does not contain hundred
                        if (word.Contains("Trillion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Trillion"))
                            {
                                word = word.Replace("Trillion", "Trillion and");
                                word = word.Replace("and, ", "and ");
                            }

                        }
                        //check if word contains quadrillion and does not contain hundred
                        if (word.Contains("Quadrillion") && !word.Contains("Hundred and"))
                        {

                            if (!word.EndsWith("Quadrillion"))
                            {
                                word = word.Replace("Quadrillion", "Quadrillion and");
                                word = word.Replace("and, ", "and ");
                            }

                        }
                        if (word.Contains("Quintillion") && !word.Contains("Hundred and"))
                        {


                            if (!word.EndsWith("Quintillion"))
                            {
                                word = word.Replace("Quintillion", "Quintillion and");
                                word = word.Replace("and, ", "and ");
                            }


                        }
                        if (word.Contains("Thousand and and"))
                        {
                            word = word.Replace("Thousand and and", "Thousand and");
                        }

                        if (word.Contains("Million and and"))
                        {

                            word = word.Replace("Million and and", "Million and");
                        }
                        if (word.Contains("Billion and and"))
                        {

                            word = word.Replace("Billion and and", "Billion and");
                        }
                        return word;
                    }
                }
                return "";
            }
        }

    }

}