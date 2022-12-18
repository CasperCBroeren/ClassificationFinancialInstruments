namespace ClassificationFinancialInstruments
{
    public partial class ClassificationFinancialInstrument
    {
        private static readonly Classification[] votingRights = new Classification[]
{
                new Classification('V', "Voting"),
                new Classification('N', "Non-Voting"),
                new Classification('R', "Restricted"),
                new Classification('E', "Enhanced voting")
};

        private static readonly Classification[] ownership = new Classification[]
    {
                new Classification('T', "Restrictions"),
                new Classification('U', "Free"),
    };

        private static readonly Classification[] paymentStatus = new Classification[]
{
                new Classification('F', "Fully Paid"),
                new Classification('O', "Nil Paid"),
                new Classification('P', "Partly Paid"),
};

        private static readonly Classification[] form = new Classification[]
{
                new Classification('B', "Bearer"),
                new Classification('R', "Registered"),
                new Classification('N', "Bearer/Registered"),
                new Classification('M', "Others (Misc.)"),
};

        private static readonly Classification[] redemption = new Classification[]
{
                new Classification('R', "Redeemable"),
                new Classification('E', "Extendible"),
                new Classification('T', "Redeemable / Extendible"),
                new Classification('G', "Exchangeable"),
                new Classification('A', "Redeemable / Exchangeable / Extendible"),
                new Classification('C', "Redeemable/Exchangeable"),
                new Classification('N', "Perpetual"),
};

        private static readonly Classification[] income = new Classification[]
        {
                new Classification('F', "Fixed Rate"),
                new Classification('C', "Cumulative, Fixed Rate"),
                new Classification('P', "Participating"),
                new Classification('Q', "Cumulative, Participating"),
                new Classification('A', "Adjustable/Variable Rate"),
                new Classification('N', "Normal Rate"),
                new Classification('U', "Auction Rate"),
                new Classification('D', "Dividends"),
        };

        private static readonly Classification[] Undefiend = new Classification[]
        {
                new Classification('X', "Not Appl./Undefined"),
        };

        private static readonly ClassificationGroup[] groupEquities = new ClassificationGroup[]
               {
                new ClassificationGroup('S', "Shares i.e. Common / Ordinary", votingRights, ownership, paymentStatus, form),
                new ClassificationGroup('P', "Preferred shares", votingRights, redemption, income, form),
                new ClassificationGroup('C', "Convertible shares",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Preferred convertible shares",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('L', "Limited partnership units",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('D', "Depository receipts on equities",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('Y', "Structured instruments (participation)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('P', "Preference shares",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('V', "Preference convertibles shares",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('U', "Units (from Unit trusts, Mutual funds, OPCVM or OICVM)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
               };

        private static readonly ClassificationGroup[] groupDebt = new ClassificationGroup[]
               {
                new ClassificationGroup('B', "Bonds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('P', "Preferred shares",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('C', "Convertible Bonds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('W', "Bonds with warrants attached",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Medium-term notes",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('S', "Structured products (with capital protection)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('E', "Structured products (without capital protection)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('G', "Mortgage-backed securities (MBS)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('A', " Asset backed securities (ABS)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('N', "Municipal bonds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('D', "Depository receipts on debt instruments",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('Y', "Money market instruments",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),

               };

        private static readonly ClassificationGroup[] groupInvestment = new ClassificationGroup[]
               {
                new ClassificationGroup('I', "Standard (vanilla)investment funds/mutual funds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('H', "Hedge funds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('B', "Real estate investment trusts (REITs)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('E', "Exchange-traded funds (ETFs)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('S', "Pension funds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Funds of funds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('P', " Private equity funds",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),

               };

        private static readonly ClassificationGroup[] groupEntitlement = new ClassificationGroup[]
               {
                new ClassificationGroup('A', "Allotments (Bonus Rights)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('S', "Subscription Rights",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('P', "Purchase Rights",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('W', "Warrants",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Mini-future certificates/constant leverage certificates",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('D', "Depository receipts on entitlements", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('M', "Others (Misc.)", Undefiend, Undefiend, Undefiend, Undefiend),
               };

        private static readonly ClassificationGroup[] groupOptions = new ClassificationGroup[]
               {
                new ClassificationGroup('C', "Call Options", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('P', "Put Options", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('M', "Others (Misc.)", Undefiend, Undefiend, Undefiend, Undefiend)  ,
               };

        private static readonly ClassificationGroup[] groupFutures = new ClassificationGroup[]
              {
                new ClassificationGroup('F', "Financial futures",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('C', "Commodities futures", Undefiend, Undefiend, Undefiend, Undefiend),
              };

        private static readonly ClassificationGroup[] groupSwaps = new ClassificationGroup[]
       {
                new ClassificationGroup('R', "Rates", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('T', "Commodities", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('E', "Equity", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('C', "Credit", Undefiend, Undefiend, Undefiend, Undefiend),
                new ClassificationGroup('F', "Foreign exchange (FX)" ,Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
       };

        private static readonly ClassificationGroup[] groupNonListed = new ClassificationGroup[]
        {
                new ClassificationGroup('R', "Rates",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Commodities",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('E', "Equity",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('C', "Credit",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Foreign exchange (FX)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
        };

        private static readonly ClassificationGroup[] groupSpots = new ClassificationGroup[]
        {
                new ClassificationGroup('F', "Foreign exchange (FX)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Commodities",Undefiend,Undefiend,Undefiend,Undefiend),
        };

        private static readonly ClassificationGroup[] groupForwards = new ClassificationGroup[]
        {
                new ClassificationGroup('E', "Equity",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Foreign exchange (FX)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('C', "Credit",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('R', "Rates",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Commodities",Undefiend,Undefiend,Undefiend,Undefiend),
        };

        private static readonly ClassificationGroup[] groupStrategies = new ClassificationGroup[]
        {
                new ClassificationGroup('R', "Rates",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Commodities",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('E', "Equity",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('C', "Credit",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('F', "Foreign exchange (FX)",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('Y', "Mixed assets",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
        };

        private static readonly ClassificationGroup[] groupFinancing = new ClassificationGroup[]
{
                new ClassificationGroup('R', "Loan Lease",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('R', "Repurchase agreements",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('S', "Securities Lending",Undefiend,Undefiend,Undefiend,Undefiend),
};

        private static readonly ClassificationGroup[] groupInstruments = new ClassificationGroup[]
{

                new ClassificationGroup('C', "Currencies",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('T', "Commodities",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('R', "Interest rates",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('I', "Indices",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('B', "Baskets",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('D', "Stock dividends",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
};

        private static readonly ClassificationGroup[] groupMisc = new ClassificationGroup[]
{

                new ClassificationGroup('C', "Combined instruments",Undefiend,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,Undefiend),
};



        private static readonly ClassificationCategory[] category = new ClassificationCategory[]
           {
                new ClassificationCategory('E', "Equities", groupEquities),
                new ClassificationCategory('D', "Debt Instruments", groupDebt),
                new ClassificationCategory('C', "Collective Investment Vehicles", groupInvestment),
                new ClassificationCategory('R', "Entitlement (Rights)", groupEntitlement),
                new ClassificationCategory('L', "Listed Options", groupOptions),
                new ClassificationCategory('F', "Futures", groupFutures),
                new ClassificationCategory('S', "Swaps", groupSwaps),
                new ClassificationCategory('H', "Non-listed and complex listed options", groupNonListed),
                new ClassificationCategory('I', "Spots", groupSpots),
                new ClassificationCategory('J', "Forwards", groupForwards),
                new ClassificationCategory('K', "Strategies", groupStrategies),
                new ClassificationCategory('L', "Financing", groupFinancing),
                new ClassificationCategory('T', "Referential instruments", groupInstruments),
                new ClassificationCategory('M', " Misc. / Others", groupMisc),
           };
    }
}