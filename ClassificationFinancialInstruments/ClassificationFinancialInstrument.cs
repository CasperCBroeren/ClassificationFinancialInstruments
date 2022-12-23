namespace ClassificationFinancialInstruments
{
    public partial class ClassificationFinancialInstrument
    {
        private readonly ClassificationCategory category;
        private readonly ClassificationGroup group;
        private readonly Classification attribute1;
        private readonly Classification attribute2;
        private readonly Classification attribute3;
        private readonly Classification attribute4;

        private ClassificationFinancialInstrument(ClassificationCategory category,
            ClassificationGroup group,
            Classification attribute1,
            Classification attribute2,
            Classification attribute3,
            Classification attribute4)
        {
            this.category = category;
            this.group = group;
            this.attribute1 = attribute1;
            this.attribute2 = attribute2;
            this.attribute3 = attribute3;
            this.attribute4 = attribute4;
        }

        public string Value =>
            new(new[]
            {
                this.category.Charachter, this.group.Charachter, this.attribute1.Charachter, this.attribute2.Charachter,
                this.attribute3.Charachter, this.attribute4.Charachter
            });

        public string Explanation =>
            $"An instrument classified as category {this.category.Explanation}, group {this.group.Explanation} and attributes[{this.attribute1.Explanation}|{this.attribute2.Explanation}|{this.attribute3.Explanation}|{this.attribute4.Explanation}]";

        public static bool TryParse(string value, out ClassificationFinancialInstrument? result)
        {
            var success = false;
            result = Validate(value)
                .Apply<ClassificationFinancialInstrument>(x =>
                {
                    success = true;
                    return x;
                });
            return success;
        }

        public static CfiValidation Validate(string value)
        {
            if (string.IsNullOrEmpty(value)
                || value.Length != 6)
            {
                return new CfiValidation(new CfiError("CFI should contain 6 characters"));
            }

            value = value.ToUpperInvariant();

            var cat = categories
                .Where(x => x.Charachter == value[0])
                .FirstOrDefault();

            if (cat == null)
            {
                return new CfiValidation(new CfiError(
                    $"First character should be a category [{string.Join(',', categories.Select(x => x.Charachter))}]"));
            }

            var grp = cat.Groups.Where(x => x.Charachter == value[1]).FirstOrDefault();
            if (grp == null)
            {
                return new CfiValidation(new CfiError(
                    $"Second character should be a group [{string.Join(',', Enumerable.Select<ClassificationGroup, char>(cat.Groups, (Func<ClassificationGroup, char>) (x => x.Charachter)))}]"));
            }

            var a1 = grp.Attribute1.Where(x => x.Charachter == value[2]).FirstOrDefault();
            var a2 = grp.Attribute2.Where(x => x.Charachter == value[3]).FirstOrDefault();
            var a3 = grp.Attribute3.Where(x => x.Charachter == value[4]).FirstOrDefault();
            var a4 = grp.Attribute4.Where(x => x.Charachter == value[5]).FirstOrDefault();
            if (a1 == null)
            {
                return new CfiValidation(new CfiError(
                    $"Third character should be a attribute [{string.Join(',', grp.Attribute1.Select(x => x.Charachter))}]"));
            }

            if (a2 == null)
            {
                return new CfiValidation(new CfiError(
                    $"Fourth character should be a attribute [{string.Join(',', grp.Attribute2.Select(x => x.Charachter))}]"));
            }

            if (a3 == null)
            {
                return new CfiValidation(new CfiError(
                    $"Fifth character should be a attribute [{string.Join(',', grp.Attribute3.Select(x => x.Charachter))}]"));
            }

            if (a4 == null)
            {
                return new CfiValidation(new CfiError(
                    $"Sixt character should be a attribute [{string.Join(',', grp.Attribute4.Select(x => x.Charachter))}]"));
            }

            return new CfiValidation(new ClassificationFinancialInstrument(cat, grp, a1, a2, a3, a4));
        }
    }
}
