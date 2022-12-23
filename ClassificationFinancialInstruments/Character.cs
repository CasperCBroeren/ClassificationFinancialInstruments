namespace ClassificationFinancialInstruments
{
    internal record Classification(char Charachter, string Explanation);

    internal record ClassificationCategory(char Charachter, string Explanation, ClassificationGroup[] Groups);

    internal record ClassificationGroup(
        char Charachter,
        string Explanation,
        Classification[] Attribute1,
        Classification[] Attribute2,
        Classification[] Attribute3,
        Classification[] Attribute4);
}
