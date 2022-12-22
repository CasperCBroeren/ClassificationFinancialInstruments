namespace ClassificationFinancialInstruments.Tests
{
    public class CFI_Validate
    {
        [Theory]
        [InlineData("")]
        [InlineData("ja")]
        [InlineData("UBUBIAA")]
        public void NotSixCharacters(string value)
        {
            var result = ClassificationFinancialInstrument.Validate(value);

            Assert.True(result.Failed);
            Assert.Equal("CFI should contain 6 characters", result.Error!.Message);
        }

        [Fact]
        public void CategoryError()
        {
            var result = ClassificationFinancialInstrument.Validate("QSVTFB");

            Assert.True(result.Failed);
            Assert.Equal("First character should be a category [E,D,C,R,L,F,S,H,I,J,K,L,T,M]", result.Error!.Message);
        }

        [Fact]
        public void GroupError()
        {
            var result = ClassificationFinancialInstrument.Validate("EQVTFB");

            Assert.True(result.Failed);
            Assert.Equal("Second character should be a group [S,P,C,F,L,D,Y,P,V,U,M]", result.Error!.Message);
        }

        [Fact]
        public void Attribute1Error()
        {
            var result = ClassificationFinancialInstrument.Validate("ESQTFB");

            Assert.True(result.Failed);
            Assert.Equal("Third character should be a attribute [V,N,R,E]", result.Error!.Message);
        }

        [Fact]
        public void Attribute2Error()
        {
            var result = ClassificationFinancialInstrument.Validate("ESVQFB");

            Assert.True(result.Failed);
            Assert.Equal("Fourth character should be a attribute [T,U]", result.Error!.Message);
        }

        [Fact]
        public void Attribute3Error()
        {
            var result = ClassificationFinancialInstrument.Validate("ESVTQB");

            Assert.True(result.Failed);
            Assert.Equal("Fifth character should be a attribute [F,O,P]", result.Error!.Message);
        }

        [Fact]
        public void Attribute4Error()
        {
            var result = ClassificationFinancialInstrument.Validate("ESVTFQ");

            Assert.True(result.Failed);
            Assert.Equal("Sixt character should be a attribute [B,R,N,M]", result.Error!.Message);
        }

        [Theory]
        [InlineData("ESVTFB")]
        [InlineData("esvtfB")]
        [InlineData("DYKOXN")]
        [InlineData("DMPXXM")]
        [InlineData("CEOGRU")]
        [InlineData("RDAXXN")]
        [InlineData("RFDNPB")]
        public void Valid(string value)
        {
            var result = ClassificationFinancialInstrument.Validate(value);

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
            Assert.Equal(value, result.Data.Value, true);
        }

        [Theory]
        [InlineData("ESVTFB")]
        [InlineData("esvtfB")]
        [InlineData("DYKOXN")]
        [InlineData("DMPXXM")]
        [InlineData("CEOGRU")]
        [InlineData("RDAXXN")]
        [InlineData("RFDNPB")]
        [InlineData("HMPAAP")]
        public void ValidWithApply(string value)
        {
            var result = ClassificationFinancialInstrument.Validate(value);

            Assert.Equal(value, result.Apply((x) => x.Value), true);
        }

        [Fact]
        public void Attribute4ErrorWithApply()
        {
            var result = ClassificationFinancialInstrument.Validate("ESVTFQ");

            Assert.Equal("Sixt character should be a attribute [B,R,N,M]", result.Apply((x) => x.Value, (x) => x.Message));
        }

        [Fact]
        public void Explanation()
        {
            var result = ClassificationFinancialInstrument.Validate("ESVTFB");

            Assert.True(result.Success);
            Assert.NotNull(result.Data);
            Assert.Equal("An instrument classified as category Equities, group Shares i.e. Common / Ordinary and attributes[Voting|Restrictions|Fully Paid|Bearer]", result.Data.Explanation, true);
        }
    }
}