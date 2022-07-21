using LeetCode_13_RomanToInt;

namespace UnitTests
{
    public class ConvertRomanToInt
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XII", 12)]
        [InlineData("XIII", 13)]
        [InlineData("XIV", 14)]
        [InlineData("XV", 15)]
        [InlineData("XVI", 16)]
        [InlineData("XVII", 17)]
        [InlineData("XVIII", 18)]
        [InlineData("XIX", 19)]
        [InlineData("XX", 20)]
        [InlineData("XXI", 21)]
        [InlineData("XXII", 22)]
        [InlineData("XXIII", 23)]
        [InlineData("XXIV", 24)]
        [InlineData("XXV", 25)]
        [InlineData("XXVI", 26)]
        [InlineData("XXVII", 27)]
        [InlineData("XXVIII", 28)]
        [InlineData("XXIX", 29)]
        [InlineData("XXX", 30)]
        [InlineData("XXXI", 31)]
        [InlineData("XXXII", 32)]
        [InlineData("XXXIII", 33)]
        [InlineData("XXXIV", 34)]
        [InlineData("XXXV", 35)]
        [InlineData("XXXVI", 36)]
        [InlineData("XXXVII", 37)]
        [InlineData("XXXVIII", 38)]
        [InlineData("XXXIX", 39)]
        [InlineData("XL", 40)]
        [InlineData("XLI", 41)]
        [InlineData("XLII", 42)]
        [InlineData("XLIII", 43)]
        [InlineData("XLIV", 44)]
        [InlineData("XLV", 45)]
        [InlineData("XLVI", 46)]
        [InlineData("XLVII", 47)]
        [InlineData("XLVIII", 48)]
        [InlineData("XLIX", 49)]
        [InlineData("L", 50)]
        [InlineData("LI", 51)]
        [InlineData("LII", 52)]
        [InlineData("LIII", 53)]
        [InlineData("LIV", 54)]
        [InlineData("LV", 55)]
        [InlineData("LVI", 56)]
        [InlineData("LVII", 57)]
        [InlineData("LVIII", 58)]
        [InlineData("LIX", 59)]
        [InlineData("LX", 60)]
        [InlineData("LXI", 61)]
        [InlineData("LXII", 62)]
        [InlineData("LXIII", 63)]
        [InlineData("LXIV", 64)]
        [InlineData("LXV", 65)]
        [InlineData("LXVI", 66)]
        [InlineData("LXVII", 67)]
        [InlineData("LXVIII", 68)]
        [InlineData("LXIX", 69)]
        [InlineData("LXX", 70)]
        [InlineData("LXXI", 71)]
        [InlineData("LXXII", 72)]
        [InlineData("LXXIII", 73)]
        [InlineData("LXXIV", 74)]
        [InlineData("LXXV", 75)]
        [InlineData("LXXVI", 76)]
        [InlineData("LXXVII", 77)]
        [InlineData("LXXVIII", 78)]
        [InlineData("LXXIX", 79)]
        [InlineData("LXXX", 80)]
        [InlineData("LXXXI", 81)]
        [InlineData("LXXXII", 82)]
        [InlineData("LXXXIII", 83)]
        [InlineData("LXXXIV", 84)]
        [InlineData("LXXXV", 85)]
        [InlineData("LXXXVI", 86)]
        [InlineData("LXXXVII", 87)]
        [InlineData("LXXXVIII", 88)]
        [InlineData("LXXXIX", 89)]
        [InlineData("XC", 90)]
        [InlineData("XCI", 91)]
        [InlineData("XCII", 92)]
        [InlineData("XCIII", 93)]
        [InlineData("XCIV", 94)]
        [InlineData("XCV", 95)]
        [InlineData("XCVI", 96)]
        [InlineData("XCVII", 97)]
        [InlineData("XCVIII", 98)]
        [InlineData("XCIX", 99)]
        [InlineData("C", 100)]
        [InlineData("CI", 101)]
        [InlineData("CII", 102)]
        [InlineData("CIII", 103)]
        [InlineData("CIV", 104)]
        [InlineData("CV", 105)]
        [InlineData("CVI", 106)]
        [InlineData("CVII", 107)]
        [InlineData("CVIII", 108)]
        [InlineData("CIX", 109)]
        [InlineData("CX", 110)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MM", 2000)]
        [InlineData("MMCD", 2400)]
        [InlineData("MMMCDXCIX", 3499)]
        public void ReturnsConvertedNumber(string romanStr, int expectedResult)
        {
            // Arrange

            // Act
            int actualResult = new Class1().RomanToInt(romanStr);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ThrowsExceptionOnInputTooSmall()
        {
            // Arrange
            string romanStr = "";

            // Act
            Action action = () => new Class1().RomanToInt(romanStr);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);
        }

        [Fact]
        public void ThrowsExceptionOnInputTooLarge()
        {
            // Arrange
            string romanStr = "IIIIIIIIIIIIIIII";

            // Act
            Action action = () => new Class1().RomanToInt(romanStr);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);
        }

        [Fact]
        public void ThrowsExceptionOnInvalidInputCharacters()
        {
            // Arrange
            string romanStr = "A";

            // Act
            Action action = () => new Class1().RomanToInt(romanStr);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);
        }
    }
}