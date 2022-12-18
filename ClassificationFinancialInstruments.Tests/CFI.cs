namespace ClassificationFinancialInstruments.Tests
{
    public class CFI
    {
        [Theory]
        [InlineData("")]
        [InlineData("JAJAJA")]
        [InlineData("ja")]
        [InlineData("UBUBIAA")]
        public void NotValidAtAll(string value)
        {
            var code = ClassificationFinancialInstrument.Parse(value);

            Assert.Null(code);
        }

        [Theory]
        [InlineData("ESVTFB")]
        public void Valid(string value)
        {
            var code = ClassificationFinancialInstrument.Parse(value);

            Assert.NotNull(code);
            Assert.Equal(value, code.Value);
        }
    }
}