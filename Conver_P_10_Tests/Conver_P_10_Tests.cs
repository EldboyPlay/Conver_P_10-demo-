using NUnit.Framework;
using Конвертор;

namespace Conver_P_10_Tests
{
    [TestFixture]
    public class Conver_P_10_Tests
    {
        [TestCase('A', ExpectedResult = 10)]
        [TestCase('0', ExpectedResult = 0)]
        [TestCase('9', ExpectedResult = 9)]
        public double Char_To_Num_ValidInput(char ch)
        {
            return Конвертор.Conver_P_10.char_To_num(ch);
        }

        [TestCase('G')]
        [TestCase('-')]
        [TestCase(' ')]
        public void Char_To_Num_InvalidInput(char ch)
        {
            Assert.Throws<ArgumentException>(() => Конвертор.Conver_P_10.char_To_num(ch));
        }

        [TestCase("A5E", 16, 1, ExpectedResult = 2654)]
        [TestCase("101", 2, 1, ExpectedResult = 5)]
        public double Convert_ValidInput(string P_num, int P, double weight)
        {
            return Конвертор.Conver_P_10.convert(P_num, P, weight);
        }

        [TestCase("A5.E", 16, ExpectedResult = 165.875)]
        [TestCase("101.1", 2, ExpectedResult = 5.5)]
        public double Dval_ValidInput(string P_num, int P)
        {
            return Конвертор.Conver_P_10.dval(P_num, P);
        }

        // Здесь оставлено место для новых тестов
    }
}
