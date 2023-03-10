namespace ClassificationFinancialInstruments.Tests
{
    public class CFI_TryParse
    {
        [Theory]
        [InlineData("")]
        [InlineData("JAJAJA")]
        [InlineData("ja")]
        [InlineData("UBUBIAA")]
        public void NotValid(string value)
        {
            var canParse = ClassificationFinancialInstrument.TryParse(value, out _);

            Assert.False(canParse);
        }

        [Theory]
        [InlineData("ESVTFB")]
        [InlineData("esvtfB")]
        [InlineData("DYKOXN")]
        [InlineData("DMPXXM")]
        [InlineData("CEOGRU")]
        [InlineData("RDAXXN")]
        [InlineData("RFDNPB")]
        [InlineData("MMNXXX")]
        [InlineData("MMRXXX")]
        [InlineData("MMPXXX")]
        [InlineData("MMMXXX")]
        public void Valid(string value)
        {
            var canParse = ClassificationFinancialInstrument.TryParse(value, out var code);

            Assert.True(canParse);
            Assert.NotNull(code);
            Assert.Equal(value, code.Value, true);
        }
    }
}