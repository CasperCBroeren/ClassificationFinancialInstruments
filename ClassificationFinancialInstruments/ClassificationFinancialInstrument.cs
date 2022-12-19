namespace ClassificationFinancialInstruments
{

    public partial class ClassificationFinancialInstrument
    {        
        private readonly ClassificationCategory cat;
        private readonly ClassificationGroup grp;
        private Classification a1;
        private Classification a2;
        private Classification a3;
        private Classification a4;

        private ClassificationFinancialInstrument(ClassificationCategory cat, ClassificationGroup grp, Classification a1, Classification a2, Classification a3, Classification a4)
        {
            this.cat = cat;
            this.grp = grp;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
        }

        public string Value => new string(new char[] {cat.Charachter,
            grp.Charachter,
            a1.Charachter ,
            a2.Charachter ,
            a3.Charachter ,
            a4.Charachter });

        public static bool TryParse(string value, out ClassificationFinancialInstrument? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value)
                || value.Length != 6)
            {
                return false;
            }

            value = value.ToUpperInvariant();

            var cat = category
                .Where(x => x.Charachter == value[0])
                .FirstOrDefault();

            if (cat == null)
            {
                return false;
            }

            var grp = cat.Groups.Where(x => x.Charachter == value[1]).FirstOrDefault();
            if (grp == null)
            {
                return false;
            }

            var a1 = grp.Attribute1.Where(x => x.Charachter == value[2]).FirstOrDefault();
            var a2 = grp.Attribute2.Where(x => x.Charachter == value[3]).FirstOrDefault();
            var a3 = grp.Attribute3.Where(x => x.Charachter == value[4]).FirstOrDefault();
            var a4 = grp.Attribute4.Where(x => x.Charachter == value[5]).FirstOrDefault();
            if (a1 == null ||
                a2 == null ||
                a3 == null ||
                a4 == null)
            {
                return false;
            }

            result = new ClassificationFinancialInstrument(cat, grp, a1, a2, a3, a4);
            return true;
        }
    }
}