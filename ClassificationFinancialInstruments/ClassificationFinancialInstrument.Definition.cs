using System;

namespace ClassificationFinancialInstruments
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/ISO_10962
    /// https://www.iotafinance.com/en/Attributes-CFI-Codes-Group-SR.html
    /// </summary>
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

        private static readonly Classification[] instrumentDependency = new Classification[]
       {
                new Classification('S', "Common/Ordinary Shares"),
                new Classification('P', "Preferred/Preference Shares"),
                new Classification('C', "Common/Ordinary Convertible Shares"),
                new Classification('F', "Preferred/Preference Convertible Shares"),
                new Classification('L', "Limited Partnership Units"),
                new Classification('M', "Others (Misc.)")
       };


        private static readonly Classification[] redemptionUnderlying = new Classification[]
       {
                new Classification('R', "Redeemable"),
                new Classification('N', "Perpetual"),
                new Classification('B', "Convertible"),
                new Classification('D', "Convertible/Redeemable"),
                new Classification('X', "Not Appl./Undefined")
       };

        private static readonly Classification[] type = new Classification[]
        {
                new Classification('A', "Tracker Certificate"),
                new Classification('B', "Outperforming Certificate"),
                new Classification('C', "Bonus Certificate"),
                new Classification('D', "Outperformance Bonus Certificate"),
                new Classification('E', "Twin-Win-Certificate"),
                new Classification('M', "Others (Misc.)")
        };

        private static readonly Classification[] distribution = new Classification[]
        {
                new Classification('D', "Dividend Payments"),
                new Classification('Y', "No Payments"),
                new Classification('M', "Others (Misc.)")
        };

        private static readonly Classification[] repayment = new Classification[]
        {
                new Classification('F', "Cash Repayment"),
                new Classification('V', "Physical Repayment"),
                new Classification('E', "Elect at Settlement"),
                new Classification('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAsset = new Classification[]
{
                new Classification('B', "Baskets"),
                new Classification('S', "Equities"),
                new Classification('D', "Debt Instruments"),
                new Classification('G', "Derivatives"),
                new Classification('T', "Commodities"),
                new Classification('C', "Currencies"),
                new Classification('I', "Indices"),
                new Classification('N', "Interest rates"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] closedOpenEnd = new Classification[]
        {
                new Classification('C', "Closed-end"),
                new Classification('O', "Open-end"),
        };
        private static readonly Classification[] distributionPolicy = new Classification[]
{
                new Classification('I', "Income funds"),
                new Classification('G', "Growth/Accumulation funds"),
                new Classification('M', "Mixed funds")
};


        private static readonly Classification[] assets = new Classification[]
        {
                new Classification('R', "Real estate"),
                new Classification('S', "Securities"),
                new Classification('M', "Mixed-general"),
                new Classification('C', "Commodities"),
                new Classification('D', "Derivatives")
        };

        private static readonly Classification[] typeOfInterest = new Classification[]
        {
                new Classification('F', "Fixed Rate"),
                new Classification('Z', "Zero rate/ discounted rate"),
                new Classification('V', "Variable"),
                new Classification('C', "Cash payment"),
                new Classification('K', "Payment in kind")
        };

        private static readonly Classification[] guarantee = new Classification[]
        {
                new Classification('T', "Government / State Guarantee"),
                new Classification('G', "Joint Guarantee"),
                new Classification('S', "Secured"),
                new Classification('U', "Unsecured / Unguaranteed"),
                new Classification('P', "Negative Pledge"),
                new Classification('N', "Senior"),
                new Classification('O', "Senior Subordinated"),
                new Classification('Q', "Junior"),
                new Classification('J', "Junior Subordinated"),
                new Classification('C', "Supranational")
        };

        private static readonly Classification[] reimbursement = new Classification[]
{
                new Classification('F', "Fixed Maturity"),
                new Classification('G', "Fixed Maturity with Call Feature"),
                new Classification('C', "Fixed Maturity with Put Feature"),
                new Classification('D', "Fixed Maturity with Put and Call"),
                new Classification('A', "Amortization Plan"),
                new Classification('B', "Amortization Plan with Call Feature"),
                new Classification('T', "Amortization Plan with Put Feature"),
                new Classification('L', "Amortization Plan with Put and Call"),
                new Classification('P', "Perpetual"),
                new Classification('Q', "Perpetual with Call Feature"),
                new Classification('R', "Perpetual with Put Feature"),
                new Classification('E', "Extendible")
};

        private static readonly Classification[] typeStructeredProductsProtected = new Classification[]
{
                new Classification('A', "Capital Protection Certificate with Participation"),
                new Classification('B', "Capital Protection Convertible Certificate"),
                new Classification('C', "Barrier Capital Protection Certificate"),
                new Classification('D', "Capital Protection Certificate with Coupons"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] typeStructeredProductsUnprotected = new Classification[]
{
                new Classification('A', "Discount Certificate"),
                new Classification('B', "Barrier Discount Certificate"),
                new Classification('C', "Reverse Convertible"),
                new Classification('D', "Barrier Reverse Convertible"),
                new Classification('E', "Express Certificate"),
                new Classification('M', "Others (Misc.)")
};
        private static readonly Classification[] distributionStructuredProducts = new Classification[]
{
                new Classification('F', "Fixed Interest Payments"),
                new Classification('D', "Dividend Payments"),
                new Classification('V', "Variable Interest Payments"),
                new Classification('Y', "No Payments"),
                new Classification('M', "Others (Misc.)")
};
        private static readonly Classification[] repaymentProtected = new Classification[]
{
                new Classification('F', "Fixed Cash Repayment (Only Protected Capital Level)"),
                new Classification('V', "Variable Cash Repayment"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] repaymentUnprotected = new Classification[]
{
                new Classification('R', "Repayment in Cash"),
                new Classification('S', "Repayment in Assets"),
                new Classification('C', "Repayment in Assets and Cash"),
                new Classification('T', "Repayment in Assets or Cash"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] underlyingAssetStructuredProducts = new Classification[]
{
                new Classification('B', "Baskets"),
                new Classification('S', "Equities"),
                new Classification('D', "Debt Instruments / Interest Rates"),
                new Classification('T', "Commodities"),
                new Classification('C', "Currencies"),
                new Classification('I', "Indices"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] typeOfInterestGAN = new Classification[]
{
                new Classification('F', "Fixed rate"),
                new Classification('Z', "Zero rate / discounted rate"),
                new Classification('V', "Variable"),
};

        private static readonly Classification[] typeOfInterestCashPayment = new Classification[]
{
                new Classification('F', "Fixed rate"),
                new Classification('Z', "Zero rate / discounted rate"),
                new Classification('V', "Variable"),
                new Classification('V', "Cash Payment"),
};

        private static readonly Classification[] typeOfInterestMoneyMarket = new Classification[]
{
                new Classification('F', "Fixed rate"),
                new Classification('Z', "Zero rate / discounted rate"),
                new Classification('V', "Variable"),
                new Classification('K', "Payment in Kind"),
};
        private static readonly Classification[] typeOthersDebt = new Classification[]
{
                new Classification('B', "Bank loan"),
                new Classification('P', "Promissory Note"),
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] collectiveAssets = new Classification[]
{
                new Classification('R', "Real Estate"),
                new Classification('B', "Debt Instruments"),
                new Classification('E', "Equities"),
                new Classification('V', "Convertible Securities"),
                new Classification('L', "Mixed"),
                new Classification('C', "Commodities"),
                new Classification('D', "Derivatives"),
                new Classification('F', "Referential Instruments"),
                new Classification('K', "Credits"),
                new Classification('M', "Others (Misc.)"),
};
        private static readonly Classification[] securityTypeInvestorRestrictions = new Classification[]
{
                new Classification('S', "Shares"),
                new Classification('Q', "Shares for QI"),
                new Classification('U', "Units"),
                new Classification('Y', "Units for QI"),
};

        private static readonly Classification[] investmentStrategy = new Classification[]
{
                new Classification('D', "Directional"),
                new Classification('R', "Relative Value"),
                new Classification('S', "Security Selection"),
                new Classification('E', "Event-Driven"),
                new Classification('A', "Artibrage"),
                new Classification('N', "Multi-Strategy"),
                new Classification('L', "Asset-Based Lending"),
                new Classification('M', "Others (Misc.)"),
};

        private static readonly Classification[] securityType = new Classification[]
{
                new Classification('S', "Shares"),
                new Classification('U', "Units")
            };

        private static readonly Classification[] pensionFundStrategy = new Classification[]
{
                new Classification('B', "Balanced/Conservative"),
                new Classification('G', "Growth"),
                new Classification('L', "Life Style"),
                new Classification('M', "Others (Misc.)")
    };

        private static readonly Classification[] pensionFundType = new Classification[]
{
                new Classification('R', "Defined Benefit"),
                new Classification('B', "Defined Contribution"), 
                new Classification('M', "Others (Misc.)")
};

        private static readonly Classification[] securityTypeFundOfFund = new Classification[]
{
                new Classification('I', "Standard (Vanilla)"),
                new Classification('H', "Hedge Funds"),
                new Classification('B', "REIT"),
                new Classification('E', "EFT"),
                new Classification('P', "Private Equity Funds"),
                new Classification('M', "Others (Misc.)")
    };

        private static readonly Classification[] Undefiend = new Classification[]
        {
                new Classification('X', "Not Appl./Undefined"),
        };

        private static readonly ClassificationGroup[] groupEquities = new ClassificationGroup[]
               {
                new ClassificationGroup('S', "Shares i.e. Common / Ordinary", votingRights, ownership, paymentStatus, form),
                new ClassificationGroup('P', "Preferred shares", votingRights, redemption, income, form),
                new ClassificationGroup('C', "Convertible shares",votingRights,redemption,income,form),
                new ClassificationGroup('F', "Preferred convertible shares",votingRights,ownership,paymentStatus,form),
                new ClassificationGroup('L', "Limited partnership units",votingRights,ownership,paymentStatus,form),
                new ClassificationGroup('D', "Depository receipts on equities",instrumentDependency,redemptionUnderlying,income,form),
                new ClassificationGroup('Y', "Structured instruments (participation)",type,distribution,repayment,underlyingAsset),
                new ClassificationGroup('P', "Preference shares",votingRights,redemption,income, form),
                new ClassificationGroup('V', "Preference convertibles shares",votingRights,redemption,income, form),
                new ClassificationGroup('U', "Units (from Unit trusts, Mutual funds, OPCVM or OICVM)",closedOpenEnd,distributionPolicy,assets,form),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,form),
               };

        private static readonly ClassificationGroup[] groupDebt = new ClassificationGroup[]
               {
                new ClassificationGroup('B', "Bonds", typeOfInterest, guarantee, reimbursement, form),
                new ClassificationGroup('C', "Convertible Bonds",typeOfInterest, guarantee, reimbursement, form),
                new ClassificationGroup('W', "Bonds with warrants attached", typeOfInterest, guarantee, reimbursement, form),
                new ClassificationGroup('T', "Medium-term notes", typeOfInterest, guarantee, reimbursement, form),
                new ClassificationGroup('S', "Structured products (with capital protection)",typeStructeredProductsProtected,distributionStructuredProducts,repaymentProtected,underlyingAssetStructuredProducts),
                new ClassificationGroup('E', "Structured products (without capital protection)",typeStructeredProductsUnprotected,distributionStructuredProducts,repaymentUnprotected,underlyingAssetStructuredProducts),
                new ClassificationGroup('G', "Mortgage-backed securities (MBS)",typeOfInterestGAN,guarantee,reimbursement,form),
                new ClassificationGroup('A', "Asset backed securities (ABS)",typeOfInterestGAN,guarantee,reimbursement,form),
                new ClassificationGroup('N', "Municipal bonds",typeOfInterestGAN,guarantee,reimbursement,form),
                new ClassificationGroup('D', "Depository receipts on debt instruments",instrumentDependency,typeOfInterestCashPayment,guarantee,reimbursement),
                new ClassificationGroup('Y', "Money market instruments",typeOfInterestMoneyMarket,guarantee,Undefiend,form),
                new ClassificationGroup('M', "Others (Misc.)",typeOthersDebt,Undefiend,Undefiend,form),

               };

        private static readonly ClassificationGroup[] groupInvestment = new ClassificationGroup[]
               {
                new ClassificationGroup('I', "Standard (vanilla)investment funds/mutual funds",closedOpenEnd,distributionPolicy, collectiveAssets,securityTypeInvestorRestrictions),
                new ClassificationGroup('H', "Hedge funds",investmentStrategy,Undefiend,Undefiend,Undefiend),
                new ClassificationGroup('B', "Real estate investment trusts (REITs)",closedOpenEnd,distributionPolicy,Undefiend,securityTypeInvestorRestrictions),
                new ClassificationGroup('E', "Exchange-traded funds (ETFs)",closedOpenEnd, distributionPolicy,collectiveAssets,securityType),
                new ClassificationGroup('S', "Pension funds",closedOpenEnd,pensionFundStrategy,pensionFundType,securityType),
                new ClassificationGroup('F', "Funds of funds",closedOpenEnd,distributionPolicy,securityTypeFundOfFund,securityTypeInvestorRestrictions),
                new ClassificationGroup('P', "Private equity funds",closedOpenEnd,distributionPolicy,collectiveAssets,securityTypeInvestorRestrictions),
                new ClassificationGroup('M', "Others (Misc.)",Undefiend,Undefiend,Undefiend,securityTypeInvestorRestrictions),

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