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
            var canParse = ClassificationFinancialInstrument.TryParse(value, out _);

            Assert.False(canParse);
        }

        [Theory]
        [InlineData("ESVTFB")]
        [InlineData("esvtfB")]
        [InlineData("DYKOXN")]
        [InlineData("DMPXXM")]
        public void Valid(string value)
        {
            var canParse = ClassificationFinancialInstrument.TryParse(value, out var code);

            Assert.True(canParse);
            Assert.NotNull(code);
            Assert.Equal(value, code.Value, true);
        }
    }
}