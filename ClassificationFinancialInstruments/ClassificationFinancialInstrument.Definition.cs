namespace ClassificationFinancialInstruments
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/ISO_10962
    /// https://www.iotafinance.com/en/Attributes-CFI-Codes-Group-SR.html
    /// </summary>
    public partial class ClassificationFinancialInstrument
    {
        private static readonly Classification[] votingRights =
        {
            new('V', "Voting"),
            new('N', "Non-Voting"),
            new('R', "Restricted"),
            new('E', "Enhanced voting")
        };

        private static readonly Classification[] ownership =
        {
            new('T', "Restrictions"),
            new('U', "Free")
        };

        private static readonly Classification[] paymentStatus =
        {
            new('F', "Fully Paid"),
            new('O', "Nil Paid"),
            new('P', "Partly Paid")
        };

        private static readonly Classification[] form =
        {
            new('B', "Bearer"),
            new('R', "Registered"),
            new('N', "Bearer/Registered"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] redemption =
        {
            new('R', "Redeemable"),
            new('E', "Extendible"),
            new('T', "Redeemable / Extendible"),
            new('G', "Exchangeable"),
            new('A', "Redeemable / Exchangeable / Extendible"),
            new('C', "Redeemable/Exchangeable"),
            new('N', "Perpetual")
        };

        private static readonly Classification[] income =
        {
            new('F', "Fixed Rate"),
            new('C', "Cumulative, Fixed Rate"),
            new('P', "Participating"),
            new('Q', "Cumulative, Participating"),
            new('A', "Adjustable/Variable Rate"),
            new('N', "Normal Rate"),
            new('U', "Auction Rate"),
            new('D', "Dividends")
        };

        private static readonly Classification[] instrumentDependency =
        {
            new('S', "Common/Ordinary Shares"),
            new('P', "Preferred/Preference Shares"),
            new('C', "Common/Ordinary Convertible Shares"),
            new('F', "Preferred/Preference Convertible Shares"),
            new('L', "Limited Partnership Units"),
            new('M', "Others (Misc.)")
        };


        private static readonly Classification[] redemptionUnderlying =
        {
            new('R', "Redeemable"),
            new('N', "Perpetual"),
            new('B', "Convertible"),
            new('D', "Convertible/Redeemable"),
            new('X', "Not Appl./Undefined")
        };

        private static readonly Classification[] type =
        {
            new('A', "Tracker Certificate"),
            new('B', "Outperforming Certificate"),
            new('C', "Bonus Certificate"),
            new('D', "Outperformance Bonus Certificate"),
            new('E', "Twin-Win-Certificate"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] distribution =
        {
            new('D', "Dividend Payments"),
            new('Y', "No Payments"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] repayment =
        {
            new('F', "Cash Repayment"),
            new('V', "Physical Repayment"),
            new('E', "Elect at Settlement"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAsset =
        {
            new('B', "Baskets"),
            new('S', "Equities"),
            new('D', "Debt Instruments"),
            new('G', "Derivatives"),
            new('T', "Commodities"),
            new('C', "Currencies"),
            new('I', "Indices"),
            new('N', "Interest rates"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] closedOpenEnd =
        {
            new('C', "Closed-end"),
            new('O', "Open-end")
        };

        private static readonly Classification[] distributionPolicy =
        {
            new('I', "Income funds"),
            new('G', "Growth/Accumulation funds"),
            new('M', "Mixed funds")
        };

        private static readonly Classification[] assets =
        {
            new('R', "Real estate"),
            new('S', "Securities"),
            new('M', "Mixed-general"),
            new('C', "Commodities"),
            new('D', "Derivatives")
        };

        private static readonly Classification[] typeOfInterest =
        {
            new('F', "Fixed Rate"),
            new('Z', "Zero rate/ discounted rate"),
            new('V', "Variable"),
            new('C', "Cash payment"),
            new('K', "Payment in kind")
        };

        private static readonly Classification[] guarantee =
        {
            new('T', "Government / State Guarantee"),
            new('G', "Joint Guarantee"),
            new('S', "Secured"),
            new('U', "Unsecured / Unguaranteed"),
            new('P', "Negative Pledge"),
            new('N', "Senior"),
            new('O', "Senior Subordinated"),
            new('Q', "Junior"),
            new('J', "Junior Subordinated"),
            new('C', "Supranational")
        };

        private static readonly Classification[] reimbursement =
        {
            new('F', "Fixed Maturity"),
            new('G', "Fixed Maturity with Call Feature"),
            new('C', "Fixed Maturity with Put Feature"),
            new('D', "Fixed Maturity with Put and Call"),
            new('A', "Amortization Plan"),
            new('B', "Amortization Plan with Call Feature"),
            new('T', "Amortization Plan with Put Feature"),
            new('L', "Amortization Plan with Put and Call"),
            new('P', "Perpetual"),
            new('Q', "Perpetual with Call Feature"),
            new('R', "Perpetual with Put Feature"),
            new('E', "Extendible")
        };

        private static readonly Classification[] typeStructeredProductsProtected =
        {
            new('A', "Capital Protection Certificate with Participation"),
            new('B', "Capital Protection Convertible Certificate"),
            new('C', "Barrier Capital Protection Certificate"),
            new('D', "Capital Protection Certificate with Coupons"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] typeStructeredProductsUnprotected =
        {
            new('A', "Discount Certificate"),
            new('B', "Barrier Discount Certificate"),
            new('C', "Reverse Convertible"),
            new('D', "Barrier Reverse Convertible"),
            new('E', "Express Certificate"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] distributionStructuredProducts =
        {
            new('F', "Fixed Interest Payments"),
            new('D', "Dividend Payments"),
            new('V', "Variable Interest Payments"),
            new('Y', "No Payments"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] repaymentProtected =
        {
            new('F', "Fixed Cash Repayment (Only Protected Capital Level)"),
            new('V', "Variable Cash Repayment"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] repaymentUnprotected =
        {
            new('R', "Repayment in Cash"),
            new('S', "Repayment in Assets"),
            new('C', "Repayment in Assets and Cash"),
            new('T', "Repayment in Assets or Cash"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetStructuredProducts =
        {
            new('B', "Baskets"),
            new('S', "Equities"),
            new('D', "Debt Instruments / Interest Rates"),
            new('T', "Commodities"),
            new('C', "Currencies"),
            new('I', "Indices"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] typeOfInterestGan =
        {
            new('F', "Fixed rate"),
            new('Z', "Zero rate / discounted rate"),
            new('V', "Variable")
        };

        private static readonly Classification[] typeOfInterestCashPayment =
        {
            new('F', "Fixed rate"),
            new('Z', "Zero rate / discounted rate"),
            new('V', "Variable"),
            new('V', "Cash Payment")
        };

        private static readonly Classification[] typeOfInterestMoneyMarket =
        {
            new('F', "Fixed rate"),
            new('Z', "Zero rate / discounted rate"),
            new('V', "Variable"),
            new('K', "Payment in Kind")
        };

        private static readonly Classification[] typeOthersDebt =
        {
            new('B', "Bank loan"),
            new('P', "Promissory Note"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] collectiveAssets =
        {
            new('R', "Real Estate"),
            new('B', "Debt Instruments"),
            new('E', "Equities"),
            new('V', "Convertible Securities"),
            new('L', "Mixed"),
            new('C', "Commodities"),
            new('D', "Derivatives"),
            new('F', "Referential Instruments"),
            new('K', "Credits"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] securityTypeInvestorRestrictions =
        {
            new('S', "Shares"),
            new('Q', "Shares for QI"),
            new('U', "Units"),
            new('Y', "Units for QI")
        };

        private static readonly Classification[] investmentStrategy =
        {
            new('D', "Directional"),
            new('R', "Relative Value"),
            new('S', "Security Selection"),
            new('E', "Event-Driven"),
            new('A', "Artibrage"),
            new('N', "Multi-Strategy"),
            new('L', "Asset-Based Lending"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] securityType =
        {
            new('S', "Shares"),
            new('U', "Units")
        };

        private static readonly Classification[] pensionFundStrategy =
        {
            new('B', "Balanced/Conservative"),
            new('G', "Growth"),
            new('L', "Life Style"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] pensionFundType =
        {
            new('R', "Defined Benefit"),
            new('B', "Defined Contribution"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] securityTypeFundOfFund =
        {
            new('I', "Standard (Vanilla)"),
            new('H', "Hedge Funds"),
            new('B', "REIT"),
            new('E', "EFT"),
            new('P', "Private Equity Funds"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] entitlementAsset =
        {
            new('S', "Common/Ordinary Shares"),
            new('P', "Preferred/Preference Shares"),
            new('C', "Common/Ordinary Convertible Shares"),
            new('F', "Preferred/Preference Convertible Shares"),
            new('B', "Bonds"),
            new('I', "Combined Instruments"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] warrantType =
        {
            new('T', "Taditional Warrants"),
            new('N', "Naked Warrants"),
            new('C', "Covered Warrants")
        };

        private static readonly Classification[] callPut =
        {
            new('C', "Call"),
            new('P', "Put"),
            new('B', "Call and Put")
        };

        private static readonly Classification[] barrierDependencyType =
        {
            new('T', "Barrier Underlying Based"),
            new('N', "Barrier Instrument Based"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] longShort =
        {
            new('C', "Long"),
            new('P', "Short"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] exerciseOptionStyle =
        {
            new('A', "American"),
            new('E', "European"),
            new('B', "Bermudan"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] depositoryInstrumentDependency =
        {
            new('A', "Allotment (Bonus) Rights"),
            new('S', "Subscription Rights"),
            new('P', "Purchase Rights"),
            new('W', "Warrants"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] exerciseOptionStyleExOthers =
        {
            new('A', "American"),
            new('E', "European"),
            new('B', "Bermudan")
        };

        private static readonly Classification[] underlyingAssetOptionProducts =
        {
            new('B', "Baskets"),
            new('S', "Stock-Equities"),
            new('D', "Debt Instruments"),
            new('T', "Commodities"),
            new('C', "Currencies"),
            new('I', "Indices"),
            new('O', "Options"),
            new('F', "Futures"),
            new('W', "Swaps"),
            new('N', "Interest Rates"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] deliveryOption =
        {
            new('P', "Physical"),
            new('C', "Cash"),
            new('N', "Non-Deliverable"),
            new('E', "Elect at Exercise")
        };

        private static readonly Classification[] standardNonStandard =
        {
            new('S', "Standard"),
            new('N', " Non-Standardized")
        };

        private static readonly Classification[] underlyingAssetFutureFinancialProducts =
        {
            new('B', "Baskets"),
            new('S', "Stock-Equities"),
            new('D', "Debt Instruments"),
            new('C', "Currencies"),
            new('I', "Indices"),
            new('O', "Options"),
            new('F', "Futures"),
            new('W', "Swaps"),
            new('N', "Interest Rates"),
            new('V', "Stock Dividend"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetFutureCommoditiesProducts =
        {
            new('E', "Extraction Resources"),
            new('A', "Agriculture"),
            new('I', "Industrial Products"),
            new('S', "Services"),
            new('N', "Environmental"),
            new('P', "Polypropylene Products"),
            new('H', "Generated Resources"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] physicalCashNonDeliverable =
        {
            new('P', "Physical"),
            new('C', "Cash"),
            new('N', "Non-Deliverable")
        };

        private static readonly Classification[] underlyingAssetSwapRate =
        {
            new('A', "Basis swap"),
            new('C', "Fixed-Floating"),
            new('D', "Fixed-Fixed"),
            new('G', "Inflation rate index"),
            new('H', "Overnight Index Swap (OIS)"),
            new('Z', "Zero coupon"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] notional =
        {
            new('C', "Constant"),
            new('D', "Accreting"),
            new('I', "Amortizing"),
            new('Y', "Custom")
        };

        private static readonly Classification[] currency =
        {
            new('S', "Single-Currency"),
            new('C', "Cross-Currency")
        };

        private static readonly Classification[] cashPhysical =
        {
            new('C', "Cash"),
            new('P', "Physical")
        };

        private static readonly Classification[] underlyingAssetSwapCommodities =
        {
            new('J', "Energy"),
            new('K', "Metals"),
            new('A', "Agriculture"),
            new('N', "Environmental"),
            new('G', "Freight"),
            new('P', "Polypropylene Products"),
            new('S', "Fertilizer"),
            new('T', "Paper"),
            new('I', "Index"),
            new('Q', "Multi-Commodity"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] payoutTrigger =
        {
            new('P', "Price"),
            new('D', "Dividend"),
            new('V', "Variance"),
            new('L', "Volatility"),
            new('T', "Total return"),
            new('C', "Contract for difference"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] deliverSwap =
        {
            new('P', "Physical"),
            new('C', "Cash"),
            new('E', "Elect at settlement")
        };

        private static readonly Classification[] underlyingAssetSwapEquity =
        {
            new('S', "Single stock"),
            new('I', "Index"),
            new('B', "Basket"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] payoutTriggerSwapEquity =
        {
            new('P', "Price"),
            new('D', "Dividend"),
            new('V', "Variance"),
            new('L', "Volatility"),
            new('T', "Total return"),
            new('C', "Contract for difference"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetSwapCredit =
        {
            new('U', "Single name"),
            new('V', "Index tranche"),
            new('I', "Index"),
            new('B', "Basket"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] payoutSwapCredit =
        {
            new('C', "Credit default"),
            new('T', "Total return"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingIssuerType =
        {
            new('C', "Corporate"),
            new('S', "Sovereign"),
            new('L', "Local")
        };

        private static readonly Classification[] deliverSwapCredit =
        {
            new('C', "Cash"),
            new('P', "Physical"),
            new('A', "Auction")
        };

        private static readonly Classification[] underlyingAssetFx =
        {
            new('A', "Spot-Forward swap"),
            new('C', "Forward-forward swap"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] deliveryFx =
        {
            new('P', "Physical"),
            new('N', "Non-Deliverable")
        };

        private static readonly Classification[] underlyingAssetMisc =
        {
            new('P', "Commercial property (or proerty derivative)"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetNonListedRates =
       {
            new('A', "Basic swap"),
            new('C', "Fixed-Floating"),
            new('D', "Fixed-Fixed"),
            new('G', "Inflation rate index"),
            new('H', "Overnight index swap (OIS)"),
            new('O', "Options"),
            new('R', "Forwards"),
            new('F', "Futures"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] optionStyleNonListed =
       {
            new('A', "European Call"),
            new('B', "American Call"),
            new('C', "Bermudan Call"),
            new('D', "European Put"),
            new('E', "American Put"),
            new('F', "Bermudan Put"),
            new('G', "European Chooser"),
            new('H', "American Chooser"),
            new('I', "Bermudan Chooser"),
        };

        private static readonly Classification[] valuationNonListed =
  {
            new('V', "Vanilla"),
            new('A', "Asian"),
            new('D', "Digital (Binary)"),
            new('B', "Barrier"),
            new('G', "Digital barrier"),
            new('L', "Lookback"),
            new('P', "Other path dependent"),
            new('M', "Others (Misc.)")

        };

        private static readonly Classification[] deliveryNonListed =
              {
            new('C', "Cash"),
            new('P', "Physical"),
            new('E', "Elect at Exercise")
        };

        private static readonly Classification[] underlyingAssetNonListedCommodities =
{
            new('J', "Energy"),
            new('K', "Metals"),
            new('A', "Agriculture"),
            new('N', "Environmental"),
            new('G', "Freight"),
            new('P', "Polypropylene Products"),
            new('S', "Fertilizer"),
            new('T', "Paper"),
            new('I', "Index"),
            new('Q', "Multi-Commodity"),
            new('O', "Options"),
            new('R', "Forwards"),
            new('F', "Futures"),
            new('W', "Swaps"),
            new('M', "Others (Misc.)")
        };
        private static readonly Classification[] underlyingAssetNonListedEquity=
{
            new('S', "Single stock"),
            new('I', "Index"),
            new('B', "Basket"),
            new('O', "Options"),
            new('R', "Forwards"),
            new('F', "Futures"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetNonListedCredit =
{
            new('U', "CDS on a single name"),
            new('V', "CDS on an index tranche"),
            new('I', "CDS on an index"),
            new('W', "Swaps"), 
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetNonListedFx =
{
            new('R', "Forwards"),
            new('F', "Futures"),
            new('T', "Spot-Forward swap"),
            new('V', "Volatility"), 
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetNonListedMisc =
{
            new('P', "Commercial property (or proerty derivative)"), 
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] deliverySpotFx =
{
            new('P', "Physical")
        };

        private static readonly Classification[] underlyingAssetSpotCommodities =
{

            new('A', "Agriculture"),
            new('J', "Energy"),
            new('K', "Metals"),
            new('N', "Environmental"),
            new('P', "Polypropylene Products"),
            new('S', "Fertilizer"),
            new('T', "Paper"), 
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetForwardEquity =
{
            new('S', "Single stock"),
            new('I', "Index"),
            new('B', "Basket"),
            new('O', "Options"), 
            new('F', "Futures"), 
        };

        private static readonly Classification[] payoutTriggerForward =
{
            new('C', "Contract for difference"),
            new('S', "Spread-bet"),
            new('F', "Forward price of underlying instrument"),
        };

        private static readonly Classification[] underlyingAssetForwardFx =
{
            new('S', "Spot"),
            new('I', "Forward"),
            new('B', "Options"),            
            new('F', "Futures"),
        };

        private static readonly Classification[] underlyingAssetForwardCredit =
{
            new('A', "Single name"),
            new('I', "Index"),
            new('B', "Basket"),
            new('C', "CDS on a single name"),
            new('D', "CDS on an index"),
            new('G', "CDS on a basket"),
            new('O', "Options"),
        };

        private static readonly Classification[] payoutTriggerForwardCredit =
{
            new('S', "Spread-bet"),
            new('F', "Forward price of underlying instrument"),
        };

        private static readonly Classification[] underlyingAssetForwardRates =
{            
            new('I', "Interest rate index"),            
            new('O', "Options"),
                        new('M', "Others (Misc.)")
        };

        private static readonly Classification[] payoutTriggerForwardCommodities =
{
            new('C', "Contract for difference"),
            new('F', "Forward price of underlying instrument"),
        };

        private static readonly Classification[] underlyingAssetForwardCommodities =
{
            new('A', "Agriculture"),            
            new('B', "Basket"),
            new('G', "Freight"),
            new('I', "Index"),
            new('J', "Energy"),
            new('K', "Metals"),
            new('N', "Environmental"),
            new('P', "Polypropylene Products"),
            new('S', "Fertilizer"),
            new('T', "Paper"),
            new('M', "Others (Misc.)") 
        };

        private static readonly Classification[] underlyingAssetFinancingLoanLease =
{
            new('A', "Agriculture"),
            new('B', "Basket"), 
            new('J', "Energy"),
            new('K', "Metals"),
            new('N', "Environmental"),
            new('P', "Polypropylene Products"),
            new('S', "Fertilizer"),
            new('T', "Paper"),
            new('M', "Others (Misc.)")
        };


        private static readonly Classification[] underlyingAssetFinancingRepurchaseAgreements =
{
            new('G', "General collateral"),
            new('S', "Specific security collateral"),
            new('C', "Cash collateral"), 
        };

        private static readonly Classification[] terminationRepurchaseAgreements =
{
            new('F', "Flexible"),
            new('N', "Overnight"),
            new('O', "Open"),
            new('T', "Term")

        };

        private static readonly Classification[] deliveryFinancingRepurcharseAgreements =
{
            new('D', "Delivery versus payment"),
            new('H', "Hold-in-custody"),
            new('T', "Tri-party"),

        };

        private static readonly Classification[] underlyingAssetFinancingSecuritiesLending =
{
            new('C', "Cash collateral"),
            new('G', "Government bonds"),
            new('P', "Corporate bonds"),
            new('T', "Convertible bonds"),
            new('E', "Equity"),
            new('L', "Letter of credit"),
            new('D', "Certificate of deposit"),
            new('W', "Warrants"),
            new('K', "Money Market Instruments"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] terminationSecuritiesLending =
{
            new('N', "Overnight"),
            new('O', "Open"),
            new('T', "Term")

        };

        private static readonly Classification[] deliveryFinancing =
{
            new('D', "Delivery versus payment"),
            new('F', "Free of payment"),
            new('H', "Hold-in-custody"),
            new('T', "Tri-party"),

        };

        private static readonly Classification[] typeInstrumentCurrencies =
{
            new('N', "National Currency"),
            new('L', "Legacy Currency"),
            new('C', "Bullion Coins"),
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] underlyingAssetInstrumentCommodities =
{
            new('E', "Extraction Resources"),
            new('A', "Agriculture"),
            new('I', "Industrial Products"),
            new('S', "Services"),
            new('N', "Environmental"),
            new('P', "Polypropylene Products"),
            new('H', "Generated Resources"),
              new('M', "Others (Misc.)")
        };

        private static readonly Classification[] typeOfInterestRates =
{
            new('N', "Nominal"),
            new('V', "Variable"),
            new('F', "Fixed"),
            new('R', "Real")
            new('M', "Others (Misc.)")
        };

        private static readonly Classification[] frequencyOfCalculation =
{
            new('D', "Daily"),
            new('W', "Weekly"),
            new('N', "Monthly"),
            new('Q', "Quarterly"),
            new('S', "Semi-Annually"),
            new('A', "Annually), 
              new('M', "Others (Misc.)")
        };

        private static readonly Classification[] assetClasses =
{
            new('E', "Equities"),
            new('D', "Debt"),
            new('F', "Collective Investment Vehicles"),
            new('R', "Real Estate"),
            new('T', "Commodities"),
            new('C', "Currencies), 
              new('M', "Others (Misc.)")
        };

        private static readonly Classification[] weightingTypes =
{
            new ('P', "Price Weighted"),
            new('C', "Capitalization Weighted"),
            new('E', "Equal Weighted"),
            new('F', "Modified Market Capitalization Weighted"),
              new('M', "Others (Misc.)")
        };

        private static readonly Classification[] indexReturnType =
{
            new ('P', "Price Return"),
            new('N', "Net Total Return"),
            new('G', "Gross Total Return"),
              new('M', "Others (Misc.)")
        };
        private static readonly Classification[] compositions =
{
            new('E', "Equities"),
            new('D', "Debt"),
            new('F', "Collective Investment Vehicles"),
            new('I', "Indices"),
            new('T', "Commodities"),
            new('C', "Currencies), 
              new('M', "Others (Misc.)")
        };

        private static readonly Classification[] typeOfEquity =
        {
            new('S', "Common/Ordinary Shares"),
            new('P', "Preferred/Preference Shares"),
            new('C', "Common/Ordinary Convertible Shares"),
            new('F', "Preferred/Preference Convertible Shares"),
            new('L', "Limited Partnership Units\r\n"),
            new('K', "Collective Investment Vehicles\r\n"),
            new('M', "Others (Misc.)")
        };


        private static readonly Classification[] undefiend =
        {
            new('X', "Not Appl./Undefined")
        };

        private static readonly ClassificationGroup[] groupEquities =
        {
            new('S', "Shares i.e. Common / Ordinary",
                votingRights, ownership, paymentStatus, form),
            new('P', "Preferred shares",
                votingRights, redemption, income, form),
            new('C', "Convertible shares",
                votingRights, redemption, income, form),
            new('F', "Preferred convertible shares",
                votingRights, ownership, paymentStatus, form),
            new('L', "Limited partnership units",
                votingRights, ownership, paymentStatus, form),
            new('D', "Depository receipts on equities",
                instrumentDependency, redemptionUnderlying, income, form),
            new('Y', "Structured instruments (participation)",
                type, distribution, repayment, underlyingAsset),
            new('P', "Preference shares",
                votingRights, redemption, income, form),
            new('V', "Preference convertibles shares",
                votingRights, redemption, income, form),
            new('U', "Units (from Unit trusts, Mutual funds, OPCVM or OICVM)",
                closedOpenEnd, distributionPolicy, assets, form),
            new('M', "Others (Misc.)",
                undefiend, undefiend, undefiend, form)
        };

        private static readonly ClassificationGroup[] groupDebt =
        {
            new('B', "Bonds",
                typeOfInterest, guarantee, reimbursement, form),
            new('C', "Convertible Bonds",
                typeOfInterest, guarantee, reimbursement, form),
            new('W', "Bonds with warrants attached",
                typeOfInterest, guarantee, reimbursement, form),
            new('T', "Medium-term notes",
                typeOfInterest, guarantee, reimbursement, form),
            new('S', "Structured products (with capital protection)",
                typeStructeredProductsProtected, distributionStructuredProducts, repaymentProtected,
                underlyingAssetStructuredProducts),
            new('E', "Structured products (without capital protection)",
                typeStructeredProductsUnprotected, distributionStructuredProducts, repaymentUnprotected,
                underlyingAssetStructuredProducts),
            new('G', "Mortgage-backed securities (MBS)",
                typeOfInterestGan, guarantee, reimbursement, form),
            new('A', "Asset backed securities (ABS)",
                typeOfInterestGan, guarantee, reimbursement, form),
            new('N', "Municipal bonds",
                typeOfInterestGan, guarantee, reimbursement, form),
            new('D', "Depository receipts on debt instruments",
                instrumentDependency, typeOfInterestCashPayment, guarantee, reimbursement),
            new('Y', "Money market instruments",
                typeOfInterestMoneyMarket, guarantee, undefiend, form),
            new('M', "Others (Misc.)",
                typeOthersDebt, undefiend, undefiend, form)
        };

        private static readonly ClassificationGroup[] groupInvestment =
        {
            new('I', "Standard (vanilla)investment funds/mutual funds",
                closedOpenEnd, distributionPolicy, collectiveAssets, securityTypeInvestorRestrictions),
            new('H', "Hedge funds",
                investmentStrategy, undefiend, undefiend, undefiend),
            new('B', "Real estate investment trusts (REITs)",
                closedOpenEnd, distributionPolicy, undefiend, securityTypeInvestorRestrictions),
            new('E', "Exchange-traded funds (ETFs)",
                closedOpenEnd, distributionPolicy, collectiveAssets, securityType),
            new('S', "Pension funds",
                closedOpenEnd, pensionFundStrategy, pensionFundType, securityType),
            new('F', "Funds of funds",
                closedOpenEnd, distributionPolicy, securityTypeFundOfFund, securityTypeInvestorRestrictions),
            new('P', "Private equity funds",
                closedOpenEnd, distributionPolicy, collectiveAssets, securityTypeInvestorRestrictions),
            new('M', "Others (Misc.)",
                undefiend, undefiend, undefiend, securityTypeInvestorRestrictions)
        };

        private static readonly ClassificationGroup[] groupEntitlement =
        {
            new('A', "Allotments (Bonus Rights)",
                undefiend, undefiend, undefiend, form),
            new('S', "Subscription Rights",
                entitlementAsset, undefiend, undefiend, form),
            new('P', "Purchase Rights",
                entitlementAsset, undefiend, undefiend, form),
            new('W', "Warrants",
                underlyingAssetStructuredProducts, warrantType, callPut, exerciseOptionStyle),
            new('F', "Mini-future certificates/constant leverage certificates",
                underlyingAssetStructuredProducts, barrierDependencyType, longShort, exerciseOptionStyle),
            new('D', "Depository receipts on entitlements",
                depositoryInstrumentDependency, undefiend, undefiend, form),
            new('M', "Others (Misc.)",
                undefiend, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationGroup[] groupOptions =
        {
            new('C', "Call Options",
                exerciseOptionStyleExOthers, underlyingAssetOptionProducts, deliveryOption, standardNonStandard),
            new('P', "Put Options",
                exerciseOptionStyleExOthers, underlyingAssetOptionProducts, deliveryOption, standardNonStandard),
            new('M', "Others (Misc.)",
                undefiend, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationGroup[] groupFutures =
        {
            new('F', "Financial futures",
                underlyingAssetFutureFinancialProducts, physicalCashNonDeliverable, standardNonStandard, undefiend),
            new('C', "Commodities futures",
                underlyingAssetFutureCommoditiesProducts, physicalCashNonDeliverable, standardNonStandard, undefiend)
        };

        private static readonly ClassificationGroup[] groupSwaps =
        {
            new('R', "Rates",
                underlyingAssetSwapRate, notional, currency, cashPhysical),
            new('T', "Commodities",
                underlyingAssetSwapCommodities, payoutTrigger, undefiend, deliverSwap),
            new('E', "Equity",
                underlyingAssetSwapEquity, payoutTriggerSwapEquity, undefiend, deliverSwap),
            new('C', "Credit",
                underlyingAssetSwapCredit, payoutSwapCredit, underlyingIssuerType, deliverSwapCredit),
            new('F', "Foreign exchange (FX)",
                underlyingAssetFx, undefiend, undefiend, deliveryFx),
            new('M', "Others (Misc.)",
                underlyingAssetMisc, undefiend, undefiend, cashPhysical)
        };

        private static readonly ClassificationGroup[] groupNonListed =
        {
            new('R', "Rates",
                underlyingAssetNonListedRates, optionStyleNonListed, valuationNonListed, deliveryNonListed),
            new('T', "Commodities",
                underlyingAssetNonListedCommodities, optionStyleNonListed, valuationNonListed, deliveryNonListed),
            new('E', "Equity", 
                underlyingAssetNonListedEquity, optionStyleNonListed, valuationNonListed, deliveryNonListed),
            new('C', "Credit",
                underlyingAssetNonListedCredit, optionStyleNonListed, valuationNonListed, deliveryNonListed),
            new('F', "Foreign exchange (FX)",
                underlyingAssetNonListedFx, optionStyleNonListed, valuationNonListed, deliveryNonListed),
            new('M', "Others (Misc.)",
                underlyingAssetNonListedMisc, optionStyleNonListed, valuationNonListed, deliveryNonListed)
        };

        private static readonly ClassificationGroup[] groupSpot =
        {
            new('F', "Foreign exchange (FX)", 
                undefiend, undefiend, undefiend, deliverySpotFx),
            new('T', "Commodities", 
                underlyingAssetSpotCommodities, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationGroup[] groupForwards =
        {
            new('E', "Equity", 
                underlyingAssetForwardEquity, undefiend, payoutTriggerForward, cashPhysical),
            new('F', "Foreign exchange (FX)", 
                underlyingAssetForwardFx, undefiend, payoutTriggerForward, physicalCashNonDeliverable),
            new('C', "Credit",
                underlyingAssetForwardCredit, undefiend, payoutTriggerForwardCredit, physicalCashNonDeliverable),
            new('R', "Rates",
                underlyingAssetForwardRates, undefiend, payoutTriggerForwardCredit, physicalCashNonDeliverable),
            new('T', "Commodities",
                underlyingAssetForwardCommodities, undefiend, payoutTriggerForwardCommodities, physicalCashNonDeliverable)
        };

        private static readonly ClassificationGroup[] groupStrategies =
        {
            new('R', "Rates", 
                undefiend, undefiend, undefiend, undefiend),
            new('T', "Commodities", 
                undefiend, undefiend, undefiend, undefiend),
            new('E', "Equity", 
                undefiend, undefiend, undefiend, undefiend),
            new('C', "Credit", 
                undefiend, undefiend, undefiend, undefiend),
            new('F', "Foreign exchange (FX)", 
                undefiend, undefiend, undefiend, undefiend),
            new('Y', "Mixed assets", 
                undefiend, undefiend, undefiend, undefiend),
            new('M', "Others (Misc.)", 
                undefiend, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationGroup[] groupFinancing =
        {
            new('L', "Loan Lease",
                underlyingAssetFinancingLoanLease, undefiend, undefiend, physicalCashNonDeliverable),
            new('R', "Repurchase agreements", 
                underlyingAssetFinancingRepurchaseAgreements, terminationRepurchaseAgreements, undefiend, deliveryFinancingRepurcharseAgreements),
            new('S', "Securities Lending", 
                underlyingAssetFinancingSecuritiesLending, terminationSecuritiesLending, undefiend, deliveryFinancing)
        };

        private static readonly ClassificationGroup[] groupInstruments =
        {
            new('C', "Currencies", 
                typeInstrumentCurrencies, undefiend, undefiend, undefiend),
            new('T', "Commodities", 
                underlyingAssetInstrumentCommodities, undefiend, undefiend, undefiend),
            new('R', "Interest rates", 
                typeOfInterestRates, frequencyOfCalculation, undefiend, undefiend),
            new('I', "Indices", 
                assetClasses, weightingTypes, indexReturnType, undefiend),
            new('B', "Baskets",
                compositions, undefiend, undefiend, undefiend),
            new('D', "Stock dividends", 
                typeOfEquity, undefiend, undefiend, undefiend),
            new('M', "Others (Misc.)", 
                undefiend, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationGroup[] groupMisc =
        {
            new('C', "Combined instruments", undefiend, undefiend, undefiend, undefiend),
            new('M', "Others (Misc.)", undefiend, undefiend, undefiend, undefiend)
        };

        private static readonly ClassificationCategory[] categories =
        {
            new('E', "Equities", groupEquities),
            new('D', "Debt Instruments", groupDebt),
            new('C', "Collective Investment Vehicles", groupInvestment),
            new('R', "Entitlement (Rights)", groupEntitlement),
            new('L', "Listed Options", groupOptions),
            new('F', "Futures", groupFutures),
            new('S', "Swaps", groupSwaps),
            new('H', "Non-listed and complex listed options", groupNonListed),
            new('I', "Spots", groupSpot),
            new('J', "Forwards", groupForwards),
            new('K', "Strategies", groupStrategies),
            new('L', "Financing", groupFinancing),
            new('T', "Referential instruments", groupInstruments),
            new('M', " Misc. / Others", groupMisc)
        };
    }
}
