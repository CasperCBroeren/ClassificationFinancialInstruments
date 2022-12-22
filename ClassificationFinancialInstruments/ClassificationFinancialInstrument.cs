namespace ClassificationFinancialInstruments
{
    public partial class ClassificationFinancialInstrument
    {
        private readonly ClassificationCategory category;
        private readonly ClassificationGroup group;
        private Classification attribute1;
        private Classification attribute2;
        private Classification attribute3;
        private Classification attribute4;

        private ClassificationFinancialInstrument(ClassificationCategory cat, ClassificationGroup grp, Classification a1, Classification a2, Classification a3, Classification a4)
        {
            this.category = cat;
            this.group = grp;
            this.attribute1 = a1;
            this.attribute2 = a2;
            this.attribute3 = a3;
            this.attribute4 = a4;
        }

        public string Value => new(new char[] {
            category.Charachter,
            group.Charachter,
            attribute1.Charachter ,
            attribute2.Charachter ,
            attribute3.Charachter ,
            attribute4.Charachter });

        public string Explanation => $"An instrument classified as category {category.Explanation}, group {group.Explanation} and attributes[{attribute1.Explanation}|{attribute2.Explanation}|{attribute3.Explanation}|{attribute4.Explanation}]";

        public static bool TryParse(string value, out ClassificationFinancialInstrument? result)
        {
            var success = false;
            result = Validate(value).Apply<ClassificationFinancialInstrument>((x) =>
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
                return new CfiValidation(new CfiError($"First character should be a category [{string.Join(',', categories.Select(x => x.Charachter))}]"));
            }

            var grp = cat.Groups.Where(x => x.Charachter == value[1]).FirstOrDefault();
            if (grp == null)
            {
                return new CfiValidation(new CfiError($"Second character should be a group [{string.Join(',', Enumerable.Select<ClassificationGroup, char>(cat.Groups, (Func<ClassificationGroup, char>)(x => x.Charachter)))}]"));
            }

            var a1 = grp.Attribute1.Where(x => x.Charachter == value[2]).FirstOrDefault();
            var a2 = grp.Attribute2.Where(x => x.Charachter == value[3]).FirstOrDefault();
            var a3 = grp.Attribute3.Where(x => x.Charachter == value[4]).FirstOrDefault();
            var a4 = grp.Attribute4.Where(x => x.Charachter == value[5]).FirstOrDefault();
            if (a1 == null)
            {
                return new CfiValidation(new CfiError($"Third character should be a attribute [{string.Join(',', grp.Attribute1.Select(x => x.Charachter))}]"));
            }
            if (a2 == null)
            {
                return new CfiValidation(new CfiError($"Fourth character should be a attribute [{string.Join(',', grp.Attribute2.Select(x => x.Charachter))}]"));
            }
            if (a3 == null)
            {
                return new CfiValidation(new CfiError($"Fifth character should be a attribute [{string.Join(',', grp.Attribute3.Select(x => x.Charachter))}]"));
            }
            if (a4 == null)
            {
                return new CfiValidation(new CfiError($"Sixt character should be a attribute [{string.Join(',', grp.Attribute4.Select(x => x.Charachter))}]"));
            }

            return new CfiValidation(new ClassificationFinancialInstrument(cat, grp, a1, a2, a3, a4));
        }
    }
}