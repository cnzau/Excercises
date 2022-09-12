
using System.Numerics;

namespace TestExcercise01
{
    public class UnitTestTowards
    {
        [Fact]
        public void TestUlongInteger()
        {
            var number = new ExtendNumber();
            var input = "18,000,000";
            input = input.Replace(",", "");
            number.UlongNumber = ulong.Parse(input);
            Assert.Equal("Eighteen Million", number.Towards());
        }
        [Fact]
        public void TestBigIntegerInteger()
        {
            var number = new ExtendNumber();
            var input = "18,456,002,032,011,000,007";
            input = input.Replace(",", "");
            number.BigIntegerNumber = BigInteger.Parse(input);
            Assert.Equal("Eighteen Quintillion, Four Hundred and Fifty Six Quadrillion, Two Trillion and Thirty Two Billion" +
                         " and Eleven Million and Seven", number.Towards());
        }
    }
}