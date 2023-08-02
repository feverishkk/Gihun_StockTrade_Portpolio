using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrade.Application.ViewModel.API.WatchList
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class _52WeekChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Actual
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class AnnualHoldingsTurnover
    {
    }

    public class AnnualReportExpenseRatio
    {
    }

    public class Ask
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class AskSize
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class AverageDailyVolume10Day
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class AverageDailyVolume3Month
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class AverageVolume
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class AverageVolume10days
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Beta
    {
    }

    public class Beta3Year
    {
    }

    public class Bid
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class BidSize
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class BookValue
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class BuyInfoCount
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class BuyInfoShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class BuyPercentInsiderShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class CalendarEvents
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings earnings { get; set; }

        [JsonPropertyName("exDividendDate")]
        public ExDividendDate exDividendDate { get; set; }

        [JsonPropertyName("dividendDate")]
        public DividendDate dividendDate { get; set; }
    }

    public class CirculatingSupply
    {
    }

    public class CurrentPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class CurrentQuarterEstimate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class CurrentRatio
    {
    }

    public class DateShortInterest
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class DayHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class DayLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class DebtToEquity
    {
    }

    public class DefaultKeyStatistics
    {
        [JsonPropertyName("annualHoldingsTurnover")]
        public AnnualHoldingsTurnover annualHoldingsTurnover { get; set; }

        [JsonPropertyName("enterpriseToRevenue")]
        public EnterpriseToRevenue enterpriseToRevenue { get; set; }

        [JsonPropertyName("beta3Year")]
        public Beta3Year beta3Year { get; set; }

        [JsonPropertyName("profitMargins")]
        public ProfitMargins profitMargins { get; set; }

        [JsonPropertyName("enterpriseToEbitda")]
        public EnterpriseToEbitda enterpriseToEbitda { get; set; }

        [JsonPropertyName("52WeekChange")]
        public _52WeekChange _52WeekChange { get; set; }

        [JsonPropertyName("morningStarRiskRating")]
        public MorningStarRiskRating morningStarRiskRating { get; set; }

        [JsonPropertyName("forwardEps")]
        public ForwardEps forwardEps { get; set; }

        [JsonPropertyName("revenueQuarterlyGrowth")]
        public RevenueQuarterlyGrowth revenueQuarterlyGrowth { get; set; }

        [JsonPropertyName("sharesOutstanding")]
        public SharesOutstanding sharesOutstanding { get; set; }

        [JsonPropertyName("fundInceptionDate")]
        public FundInceptionDate fundInceptionDate { get; set; }

        [JsonPropertyName("annualReportExpenseRatio")]
        public AnnualReportExpenseRatio annualReportExpenseRatio { get; set; }

        [JsonPropertyName("totalAssets")]
        public TotalAssets totalAssets { get; set; }

        [JsonPropertyName("bookValue")]
        public BookValue bookValue { get; set; }

        [JsonPropertyName("sharesShort")]
        public SharesShort sharesShort { get; set; }

        [JsonPropertyName("sharesPercentSharesOut")]
        public SharesPercentSharesOut sharesPercentSharesOut { get; set; }

        [JsonPropertyName("fundFamily")]
        public object fundFamily { get; set; }

        [JsonPropertyName("lastFiscalYearEnd")]
        public LastFiscalYearEnd lastFiscalYearEnd { get; set; }

        [JsonPropertyName("heldPercentInstitutions")]
        public HeldPercentInstitutions heldPercentInstitutions { get; set; }

        [JsonPropertyName("netIncomeToCommon")]
        public NetIncomeToCommon netIncomeToCommon { get; set; }

        [JsonPropertyName("trailingEps")]
        public TrailingEps trailingEps { get; set; }

        [JsonPropertyName("lastDividendValue")]
        public LastDividendValue lastDividendValue { get; set; }

        [JsonPropertyName("SandP52WeekChange")]
        public SandP52WeekChange SandP52WeekChange { get; set; }

        [JsonPropertyName("priceToBook")]
        public PriceToBook priceToBook { get; set; }

        [JsonPropertyName("heldPercentInsiders")]
        public HeldPercentInsiders heldPercentInsiders { get; set; }

        [JsonPropertyName("nextFiscalYearEnd")]
        public NextFiscalYearEnd nextFiscalYearEnd { get; set; }

        [JsonPropertyName("yield")]
        public Yield yield { get; set; }

        [JsonPropertyName("mostRecentQuarter")]
        public MostRecentQuarter mostRecentQuarter { get; set; }

        [JsonPropertyName("shortRatio")]
        public ShortRatio shortRatio { get; set; }

        [JsonPropertyName("sharesShortPreviousMonthDate")]
        public SharesShortPreviousMonthDate sharesShortPreviousMonthDate { get; set; }

        [JsonPropertyName("floatShares")]
        public FloatShares floatShares { get; set; }

        [JsonPropertyName("beta")]
        public Beta beta { get; set; }

        [JsonPropertyName("enterpriseValue")]
        public EnterpriseValue enterpriseValue { get; set; }

        [JsonPropertyName("priceHInt64")]
        public PriceHInt64 priceHInt64 { get; set; }

        [JsonPropertyName("threeYearAverageReturn")]
        public ThreeYearAverageReturn threeYearAverageReturn { get; set; }

        [JsonPropertyName("lastSplitDate")]
        public LastSplitDate lastSplitDate { get; set; }

        [JsonPropertyName("lastSplitFactor")]
        public string lastSplitFactor { get; set; }

        [JsonPropertyName("legalType")]
        public object legalType { get; set; }

        [JsonPropertyName("lastDividendDate")]
        public LastDividendDate lastDividendDate { get; set; }

        [JsonPropertyName("morningStarOverallRating")]
        public MorningStarOverallRating morningStarOverallRating { get; set; }

        [JsonPropertyName("earningsQuarterlyGrowth")]
        public EarningsQuarterlyGrowth earningsQuarterlyGrowth { get; set; }

        [JsonPropertyName("priceToSalesTrailing12Months")]
        public PriceToSalesTrailing12Months priceToSalesTrailing12Months { get; set; }

        [JsonPropertyName("dateShortInterest")]
        public DateShortInterest dateShortInterest { get; set; }

        [JsonPropertyName("pegRatio")]
        public PegRatio pegRatio { get; set; }

        [JsonPropertyName("ytdReturn")]
        public YtdReturn ytdReturn { get; set; }

        [JsonPropertyName("forwardPE")]
        public ForwardPE forwardPE { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("lastCapGain")]
        public LastCapGain lastCapGain { get; set; }

        [JsonPropertyName("shortPercentOfFloat")]
        public ShortPercentOfFloat shortPercentOfFloat { get; set; }

        [JsonPropertyName("sharesShortPriorMonth")]
        public SharesShortPriorMonth sharesShortPriorMonth { get; set; }

        [JsonPropertyName("impliedSharesOutstanding")]
        public ImpliedSharesOutstanding impliedSharesOutstanding { get; set; }

        [JsonPropertyName("category")]
        public object category { get; set; }

        [JsonPropertyName("fiveYearAverageReturn")]
        public FiveYearAverageReturn fiveYearAverageReturn { get; set; }
    }

    public class Details
    {
    }

    public class DividendDate
    {
    }

    public class DividendRate
    {
    }

    public class DividendYield
    {
    }

    public class Earnings
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("earningsChart")]
        public EarningsChart earningsChart { get; set; }

        [JsonPropertyName("financialsChart")]
        public FinancialsChart financialsChart { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }

        [JsonPropertyName("earningsDate")]
        public List<EarningsDate> earningsDate { get; set; }

        [JsonPropertyName("earningsAverage")]
        public EarningsAverage earningsAverage { get; set; }

        [JsonPropertyName("earningsLow")]
        public EarningsLow earningsLow { get; set; }

        [JsonPropertyName("earningsHigh")]
        public EarningsHigh earningsHigh { get; set; }

        [JsonPropertyName("revenueAverage")]
        public RevenueAverage revenueAverage { get; set; }

        [JsonPropertyName("revenueLow")]
        public RevenueLow revenueLow { get; set; }

        [JsonPropertyName("revenueHigh")]
        public RevenueHigh revenueHigh { get; set; }
    }

    public class EarningsAverage
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EarningsChart
    {
        [JsonPropertyName("quarterly")]
        public List<Quarterly> quarterly { get; set; }

        [JsonPropertyName("currentQuarterEstimate")]
        public CurrentQuarterEstimate currentQuarterEstimate { get; set; }

        [JsonPropertyName("currentQuarterEstimateDate")]
        public string currentQuarterEstimateDate { get; set; }

        [JsonPropertyName("currentQuarterEstimateYear")]
        public double currentQuarterEstimateYear { get; set; }

        [JsonPropertyName("earningsDate")]
        public List<EarningsDate> earningsDate { get; set; }
    }

    public class EarningsDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EarningsGrowth
    {
    }

    public class EarningsHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EarningsLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EarningsQuarterlyGrowth
    {
    }

    public class Ebitda
    {
    }

    public class EbitdaMargins
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EnterpriseToEbitda
    {
    }

    public class EnterpriseToRevenue
    {
    }

    public class EnterpriseValue
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class EnvironmentScore
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class EsgScores
    {
        [JsonPropertyName("palmOil")]
        public bool palmOil { get; set; }

        [JsonPropertyName("peerSocialPerformance")]
        public PeerSocialPerformance peerSocialPerformance { get; set; }

        [JsonPropertyName("controversialWeapons")]
        public bool controversialWeapons { get; set; }

        [JsonPropertyName("ratingMonth")]
        public double ratingMonth { get; set; }

        [JsonPropertyName("gambling")]
        public bool gambling { get; set; }

        [JsonPropertyName("socialScore")]
        public SocialScore socialScore { get; set; }

        [JsonPropertyName("nuclear")]
        public bool nuclear { get; set; }

        [JsonPropertyName("furLeather")]
        public bool furLeather { get; set; }

        [JsonPropertyName("alcoholic")]
        public bool alcoholic { get; set; }

        [JsonPropertyName("gmo")]
        public bool gmo { get; set; }

        [JsonPropertyName("catholic")]
        public bool catholic { get; set; }

        [JsonPropertyName("socialPercentile")]
        public object socialPercentile { get; set; }

        [JsonPropertyName("peerGovernancePerformance")]
        public PeerGovernancePerformance peerGovernancePerformance { get; set; }

        [JsonPropertyName("peerCount")]
        public double peerCount { get; set; }

        [JsonPropertyName("relatedControversy")]
        public List<string> relatedControversy { get; set; }

        [JsonPropertyName("governanceScore")]
        public GovernanceScore governanceScore { get; set; }

        [JsonPropertyName("environmentPercentile")]
        public object environmentPercentile { get; set; }

        [JsonPropertyName("animalTesting")]
        public bool animalTesting { get; set; }

        [JsonPropertyName("peerEsgScorePerformance")]
        public PeerEsgScorePerformance peerEsgScorePerformance { get; set; }

        [JsonPropertyName("tobacco")]
        public bool tobacco { get; set; }

        [JsonPropertyName("totalEsg")]
        public TotalEsg totalEsg { get; set; }

        [JsonPropertyName("highestControversy")]
        public double highestControversy { get; set; }

        [JsonPropertyName("esgPerformance")]
        public string esgPerformance { get; set; }

        [JsonPropertyName("coal")]
        public bool coal { get; set; }

        [JsonPropertyName("peerHighestControversyPerformance")]
        public PeerHighestControversyPerformance peerHighestControversyPerformance { get; set; }

        [JsonPropertyName("pesticides")]
        public bool pesticides { get; set; }

        [JsonPropertyName("adult")]
        public bool adult { get; set; }

        [JsonPropertyName("ratingYear")]
        public double ratingYear { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("percentile")]
        public Percentile percentile { get; set; }

        [JsonPropertyName("peerGroup")]
        public string peerGroup { get; set; }

        [JsonPropertyName("smallArms")]
        public bool smallArms { get; set; }

        [JsonPropertyName("peerEnvironmentPerformance")]
        public PeerEnvironmentPerformance peerEnvironmentPerformance { get; set; }

        [JsonPropertyName("environmentScore")]
        public EnvironmentScore environmentScore { get; set; }

        [JsonPropertyName("governancePercentile")]
        public object governancePercentile { get; set; }

        [JsonPropertyName("militaryContract")]
        public bool militaryContract { get; set; }
    }

    public class Estimate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class ExDividendDate
    {
    }

    public class ExpireDate
    {
    }

    public class FiftyDayAverage
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FiftyTwoWeekLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FinancialData
    {
        [JsonPropertyName("ebitdaMargins")]
        public EbitdaMargins ebitdaMargins { get; set; }

        [JsonPropertyName("profitMargins")]
        public ProfitMargins profitMargins { get; set; }

        [JsonPropertyName("grossMargins")]
        public GrossMargins grossMargins { get; set; }

        [JsonPropertyName("operatingCashflow")]
        public OperatingCashflow operatingCashflow { get; set; }

        [JsonPropertyName("revenueGrowth")]
        public RevenueGrowth revenueGrowth { get; set; }

        [JsonPropertyName("operatingMargins")]
        public OperatingMargins operatingMargins { get; set; }

        [JsonPropertyName("ebitda")]
        public Ebitda ebitda { get; set; }

        [JsonPropertyName("targetLowPrice")]
        public TargetLowPrice targetLowPrice { get; set; }

        [JsonPropertyName("recommendationKey")]
        public string recommendationKey { get; set; }

        [JsonPropertyName("grossProfits")]
        public GrossProfits grossProfits { get; set; }

        [JsonPropertyName("freeCashflow")]
        public FreeCashflow freeCashflow { get; set; }

        [JsonPropertyName("targetMedianPrice")]
        public TargetMedianPrice targetMedianPrice { get; set; }

        [JsonPropertyName("currentPrice")]
        public CurrentPrice currentPrice { get; set; }

        [JsonPropertyName("earningsGrowth")]
        public EarningsGrowth earningsGrowth { get; set; }

        [JsonPropertyName("currentRatio")]
        public CurrentRatio currentRatio { get; set; }

        [JsonPropertyName("returnOnAssets")]
        public ReturnOnAssets returnOnAssets { get; set; }

        [JsonPropertyName("numberOfAnalystOpinions")]
        public NumberOfAnalystOpinions numberOfAnalystOpinions { get; set; }

        [JsonPropertyName("targetMeanPrice")]
        public TargetMeanPrice targetMeanPrice { get; set; }

        [JsonPropertyName("debtToEquity")]
        public DebtToEquity debtToEquity { get; set; }

        [JsonPropertyName("returnOnEquity")]
        public ReturnOnEquity returnOnEquity { get; set; }

        [JsonPropertyName("targetHighPrice")]
        public TargetHighPrice targetHighPrice { get; set; }

        [JsonPropertyName("totalCash")]
        public TotalCash totalCash { get; set; }

        [JsonPropertyName("totalDebt")]
        public TotalDebt totalDebt { get; set; }

        [JsonPropertyName("totalRevenue")]
        public TotalRevenue totalRevenue { get; set; }

        [JsonPropertyName("totalCashPerShare")]
        public TotalCashPerShare totalCashPerShare { get; set; }

        [JsonPropertyName("financialCurrency")]
        public string financialCurrency { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("revenuePerShare")]
        public RevenuePerShare revenuePerShare { get; set; }

        [JsonPropertyName("quickRatio")]
        public QuickRatio quickRatio { get; set; }

        [JsonPropertyName("recommendationMean")]
        public RecommendationMean recommendationMean { get; set; }
    }

    public class FinancialsChart
    {
        [JsonPropertyName("yearly")]
        public List<Yearly> yearly { get; set; }

        [JsonPropertyName("quarterly")]
        public List<Quarterly> quarterly { get; set; }
    }

    public class FinancialsTemplate
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class FiveYearAverageReturn
    {
    }

    public class FiveYearAvgDividendYield
    {
    }

    public class FloatShares
    {
    }

    public class ForwardEps
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class ForwardPE
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class FreeCashflow
    {
    }

    public class FundInceptionDate
    {
    }

    public class FundOwnership
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public List<OwnershipList> ownershipList { get; set; }
    }

    public class GovernanceScore
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class GrossMargins
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class GrossProfits
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class HeldPercentInsiders
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class HeldPercentInstitutions
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class History
    {
        [JsonPropertyName("epochGradeDate")]
        public double epochGradeDate { get; set; }

        [JsonPropertyName("firm")]
        public string firm { get; set; }

        [JsonPropertyName("toGrade")]
        public string toGrade { get; set; }

        [JsonPropertyName("fromGrade")]
        public string fromGrade { get; set; }

        [JsonPropertyName("action")]
        public string action { get; set; }
    }

    public class Holder
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("relation")]
        public string relation { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("transactionDescription")]
        public string transactionDescription { get; set; }

        [JsonPropertyName("latestTransDate")]
        public LatestTransDate latestTransDate { get; set; }

        [JsonPropertyName("positionDirect")]
        public PositionDirect positionDirect { get; set; }

        [JsonPropertyName("positionDirectDate")]
        public PositionDirectDate positionDirectDate { get; set; }

        [JsonPropertyName("positionIndirect")]
        public PositionIndirect positionIndirect { get; set; }

        [JsonPropertyName("positionIndirectDate")]
        public PositionIndirectDate positionIndirectDate { get; set; }
    }

    public class ImpliedSharesOutstanding
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public object fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class InsiderHolders
    {
        [JsonPropertyName("holders")]
        public List<Holder> holders { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class InsidersPercentHeld
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class InsiderTransactions
    {
        [JsonPropertyName("transactions")]
        public List<Transaction> transactions { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class InstitutionOwnership
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("ownershipList")]
        public List<OwnershipList> ownershipList { get; set; }
    }

    public class InstitutionsCount
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class InstitutionsFloatPercentHeld
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class InstitutionsPercentHeld
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class LastCapGain
    {
    }

    public class LastDividendDate
    {
    }

    public class LastDividendValue
    {
    }

    public class LastFiscalYearEnd
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class LastSplitDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class LatestTransDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class MajorDirectHolders
    {
        [JsonPropertyName("holders")]
        public List<object> holders { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class MajorHoldersBreakdown
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("insidersPercentHeld")]
        public InsidersPercentHeld insidersPercentHeld { get; set; }

        [JsonPropertyName("institutionsPercentHeld")]
        public InstitutionsPercentHeld institutionsPercentHeld { get; set; }

        [JsonPropertyName("institutionsFloatPercentHeld")]
        public InstitutionsFloatPercentHeld institutionsFloatPercentHeld { get; set; }

        [JsonPropertyName("institutionsCount")]
        public InstitutionsCount institutionsCount { get; set; }
    }

    public class MarketCap
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class MaxSupply
    {
    }

    public class MorningStarOverallRating
    {
    }

    public class MorningStarRiskRating
    {
    }

    public class MostRecentQuarter
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class NavPrice
    {
    }

    public class NetIncomeToCommon
    {
    }

    public class NetInfoCount
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class NetInfoShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class NetPercentInsiderShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class NetSharePurchaseActivity
    {
        [JsonPropertyName("period")]
        public string period { get; set; }

        [JsonPropertyName("netPercentInsiderShares")]
        public NetPercentInsiderShares netPercentInsiderShares { get; set; }

        [JsonPropertyName("netInfoCount")]
        public NetInfoCount netInfoCount { get; set; }

        [JsonPropertyName("totalInsiderShares")]
        public TotalInsiderShares totalInsiderShares { get; set; }

        [JsonPropertyName("buyInfoShares")]
        public BuyInfoShares buyInfoShares { get; set; }

        [JsonPropertyName("buyPercentInsiderShares")]
        public BuyPercentInsiderShares buyPercentInsiderShares { get; set; }

        [JsonPropertyName("sellInfoCount")]
        public SellInfoCount sellInfoCount { get; set; }

        [JsonPropertyName("sellInfoShares")]
        public SellInfoShares sellInfoShares { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("buyInfoCount")]
        public BuyInfoCount buyInfoCount { get; set; }

        [JsonPropertyName("netInfoShares")]
        public NetInfoShares netInfoShares { get; set; }
    }

    public class NextFiscalYearEnd
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class NumberOfAnalystOpinions
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Open
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class OpenInterest
    {
    }

    public class OperatingCashflow
    {
    }

    public class OperatingMargins
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class OwnershipList
    {
        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("reportDate")]
        public ReportDate reportDate { get; set; }

        [JsonPropertyName("organization")]
        public string organization { get; set; }

        [JsonPropertyName("pctHeld")]
        public PctHeld pctHeld { get; set; }

        [JsonPropertyName("position")]
        public Position position { get; set; }

        [JsonPropertyName("value")]
        public Value value { get; set; }

        [JsonPropertyName("pctChange")]
        public PctChange pctChange { get; set; }
    }

    public class PageViews
    {
        [JsonPropertyName("shortTermTrend")]
        public string shortTermTrend { get; set; }

        [JsonPropertyName("midTermTrend")]
        public string midTermTrend { get; set; }

        [JsonPropertyName("longTermTrend")]
        public string longTermTrend { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class PayoutRatio
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PctChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PctHeld
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PeerEnvironmentPerformance
    {
        [JsonPropertyName("min")]
        public double min { get; set; }

        [JsonPropertyName("avg")]
        public double avg { get; set; }

        [JsonPropertyName("max")]
        public double max { get; set; }
    }

    public class PeerEsgScorePerformance
    {
        [JsonPropertyName("min")]
        public double min { get; set; }

        [JsonPropertyName("avg")]
        public double avg { get; set; }

        [JsonPropertyName("max")]
        public double max { get; set; }
    }

    public class PeerGovernancePerformance
    {
        [JsonPropertyName("min")]
        public double min { get; set; }

        [JsonPropertyName("avg")]
        public double avg { get; set; }

        [JsonPropertyName("max")]
        public double max { get; set; }
    }

    public class PeerHighestControversyPerformance
    {
        [JsonPropertyName("min")]
        public double min { get; set; }

        [JsonPropertyName("avg")]
        public double avg { get; set; }

        [JsonPropertyName("max")]
        public double max { get; set; }
    }

    public class PeerSocialPerformance
    {
        [JsonPropertyName("min")]
        public double min { get; set; }

        [JsonPropertyName("avg")]
        public double avg { get; set; }

        [JsonPropertyName("max")]
        public double max { get; set; }
    }

    public class PegRatio
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Percentile
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class PositionDirect
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class PositionDirectDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PositionIndirect
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class PositionIndirectDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PostMarketChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PostMarketChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PostMarketPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PreMarketChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PreMarketChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PreMarketPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PreviousClose
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("quoteSourceName")]
        public string quoteSourceName { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public RegularMarketOpen regularMarketOpen { get; set; }

        [JsonPropertyName("averageDailyVolume3Month")]
        public AverageDailyVolume3Month averageDailyVolume3Month { get; set; }

        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("regularMarketTime")]
        public double regularMarketTime { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24Hr volume24Hr { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public AverageDailyVolume10Day averageDailyVolume10Day { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("regularMarketChange")]
        public RegularMarketChange regularMarketChange { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string currencySymbol { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }

        [JsonPropertyName("postMarketTime")]
        public double postMarketTime { get; set; }

        [JsonPropertyName("preMarketPrice")]
        public PreMarketPrice preMarketPrice { get; set; }

        [JsonPropertyName("preMarketTime")]
        public double preMarketTime { get; set; }

        [JsonPropertyName("exchangeDataDelayedBy")]
        public double exchangeDataDelayedBy { get; set; }

        [JsonPropertyName("toCurrency")]
        public object toCurrency { get; set; }

        [JsonPropertyName("postMarketChange")]
        public PostMarketChange postMarketChange { get; set; }

        [JsonPropertyName("postMarketPrice")]
        public PostMarketPrice postMarketPrice { get; set; }

        [JsonPropertyName("exchangeName")]
        public string exchangeName { get; set; }

        [JsonPropertyName("preMarketChange")]
        public PreMarketChange preMarketChange { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupply circulatingSupply { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public RegularMarketDayLow regularMarketDayLow { get; set; }

        [JsonPropertyName("priceHInt64")]
        public PriceHInt64 priceHInt64 { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("regularMarketPrice")]
        public RegularMarketPrice regularMarketPrice { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public RegularMarketVolume regularMarketVolume { get; set; }

        [JsonPropertyName("lastMarket")]
        public object lastMarket { get; set; }

        [JsonPropertyName("regularMarketSource")]
        public string regularMarketSource { get; set; }

        [JsonPropertyName("openInterest")]
        public OpenInterest openInterest { get; set; }

        [JsonPropertyName("marketState")]
        public string marketState { get; set; }

        [JsonPropertyName("underlyingSymbol")]
        public object underlyingSymbol { get; set; }

        [JsonPropertyName("marketCap")]
        public MarketCap marketCap { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("preMarketChangePercent")]
        public PreMarketChangePercent preMarketChangePercent { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrencies volumeAllCurrencies { get; set; }

        [JsonPropertyName("postMarketSource")]
        public string postMarketSource { get; set; }

        [JsonPropertyName("strikePrice")]
        public StrikePrice strikePrice { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("postMarketChangePercent")]
        public PostMarketChangePercent postMarketChangePercent { get; set; }

        [JsonPropertyName("preMarketSource")]
        public string preMarketSource { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("fromCurrency")]
        public object fromCurrency { get; set; }

        [JsonPropertyName("regularMarketChangePercent")]
        public RegularMarketChangePercent regularMarketChangePercent { get; set; }
    }

    public class PriceHInt64
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class PriceToBook
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class PriceToSalesTrailing12Months
    {
    }

    public class ProfitMargins
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Quarterly
    {
        [JsonPropertyName("date")]
        public string date { get; set; }

        [JsonPropertyName("actual")]
        public Actual actual { get; set; }

        [JsonPropertyName("estimate")]
        public Estimate estimate { get; set; }

        [JsonPropertyName("revenue")]
        public Revenue revenue { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings earnings { get; set; }
    }

    public class QuickRatio
    {
    }

    public class QuoteType
    {
        [JsonPropertyName("exchange")]
        public string exchange { get; set; }

        [JsonPropertyName("shortName")]
        public string shortName { get; set; }

        [JsonPropertyName("longName")]
        public string longName { get; set; }

        [JsonPropertyName("exchangeTimezoneName")]
        public string exchangeTimezoneName { get; set; }

        [JsonPropertyName("exchangeTimezoneShortName")]
        public string exchangeTimezoneShortName { get; set; }

        [JsonPropertyName("isEsgPopulated")]
        public bool isEsgPopulated { get; set; }

        [JsonPropertyName("gmtOffSetMilliseconds")]
        public string gmtOffSetMilliseconds { get; set; }

        [JsonPropertyName("quoteType")]
        public string quoteType { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("messageBoardId")]
        public string messageBoardId { get; set; }

        [JsonPropertyName("market")]
        public string market { get; set; }
    }

    public class RecommendationMean
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RecommendationTrend
    {
        [JsonPropertyName("trend")]
        public List<Trend> trend { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class RegularMarketChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketChangePercent
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketDayHigh
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketDayLow
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketOpen
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketPreviousClose
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RegularMarketVolume
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class ReportDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class ReturnOnAssets
    {
    }

    public class ReturnOnEquity
    {
    }

    public class Revenue
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class RevenueAverage
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class RevenueGrowth
    {
    }

    public class RevenueHigh
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class RevenueLow
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class RevenuePerShare
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class RevenueQuarterlyGrowth
    {
    }

    public class WatchList
    {
        [JsonPropertyName("defaultKeyStatistics")]
        public DefaultKeyStatistics defaultKeyStatistics { get; set; }

        [JsonPropertyName("details")]
        public Details details { get; set; }

        [JsonPropertyName("summaryProfile")]
        public SummaryProfile summaryProfile { get; set; }

        [JsonPropertyName("recommendationTrend")]
        public RecommendationTrend recommendationTrend { get; set; }

        [JsonPropertyName("financialsTemplate")]
        public FinancialsTemplate financialsTemplate { get; set; }

        [JsonPropertyName("majorDirectHolders")]
        public MajorDirectHolders majorDirectHolders { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings earnings { get; set; }

        [JsonPropertyName("price")]
        public Price price { get; set; }

        [JsonPropertyName("fundOwnership")]
        public FundOwnership fundOwnership { get; set; }

        [JsonPropertyName("insiderTransactions")]
        public InsiderTransactions insiderTransactions { get; set; }

        [JsonPropertyName("insiderHolders")]
        public InsiderHolders insiderHolders { get; set; }

        [JsonPropertyName("netSharePurchaseActivity")]
        public NetSharePurchaseActivity netSharePurchaseActivity { get; set; }

        [JsonPropertyName("majorHoldersBreakdown")]
        public MajorHoldersBreakdown majorHoldersBreakdown { get; set; }

        [JsonPropertyName("financialData")]
        public FinancialData financialData { get; set; }

        [JsonPropertyName("quoteType")]
        public QuoteType quoteType { get; set; }

        [JsonPropertyName("institutionOwnership")]
        public InstitutionOwnership institutionOwnership { get; set; }

        [JsonPropertyName("calendarEvents")]
        public CalendarEvents calendarEvents { get; set; }

        [JsonPropertyName("summaryDetail")]
        public SummaryDetail summaryDetail { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("esgScores")]
        public EsgScores esgScores { get; set; }

        [JsonPropertyName("upgradeDowngradeHistory")]
        public UpgradeDowngradeHistory upgradeDowngradeHistory { get; set; }

        [JsonPropertyName("pageViews")]
        public PageViews pageViews { get; set; }
    }

    public class SandP52WeekChange
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class SellInfoCount
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class SellInfoShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Shares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class SharesOutstanding
    {
        [JsonPropertyName("raw")]
        public long raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class SharesPercentSharesOut
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class SharesShort
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class SharesShortPreviousMonthDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class SharesShortPriorMonth
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class ShortPercentOfFloat
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class ShortRatio
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class SocialScore
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class StartDate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class StrikePrice
    {
    }

    public class SummaryDetail
    {
        [JsonPropertyName("previousClose")]
        public PreviousClose previousClose { get; set; }

        [JsonPropertyName("regularMarketOpen")]
        public RegularMarketOpen regularMarketOpen { get; set; }

        [JsonPropertyName("twoHundredDayAverage")]
        public TwoHundredDayAverage twoHundredDayAverage { get; set; }

        [JsonPropertyName("trailingAnnualDividendYield")]
        public TrailingAnnualDividendYield trailingAnnualDividendYield { get; set; }

        [JsonPropertyName("payoutRatio")]
        public PayoutRatio payoutRatio { get; set; }

        [JsonPropertyName("volume24Hr")]
        public Volume24Hr volume24Hr { get; set; }

        [JsonPropertyName("regularMarketDayHigh")]
        public RegularMarketDayHigh regularMarketDayHigh { get; set; }

        [JsonPropertyName("navPrice")]
        public NavPrice navPrice { get; set; }

        [JsonPropertyName("averageDailyVolume10Day")]
        public AverageDailyVolume10Day averageDailyVolume10Day { get; set; }

        [JsonPropertyName("totalAssets")]
        public TotalAssets totalAssets { get; set; }

        [JsonPropertyName("regularMarketPreviousClose")]
        public RegularMarketPreviousClose regularMarketPreviousClose { get; set; }

        [JsonPropertyName("fiftyDayAverage")]
        public FiftyDayAverage fiftyDayAverage { get; set; }

        [JsonPropertyName("trailingAnnualDividendRate")]
        public TrailingAnnualDividendRate trailingAnnualDividendRate { get; set; }

        [JsonPropertyName("open")]
        public Open open { get; set; }

        [JsonPropertyName("toCurrency")]
        public object toCurrency { get; set; }

        [JsonPropertyName("averageVolume10days")]
        public AverageVolume10days averageVolume10days { get; set; }

        [JsonPropertyName("expireDate")]
        public ExpireDate expireDate { get; set; }

        [JsonPropertyName("yield")]
        public Yield yield { get; set; }

        [JsonPropertyName("algorithm")]
        public object algorithm { get; set; }

        [JsonPropertyName("dividendRate")]
        public DividendRate dividendRate { get; set; }

        [JsonPropertyName("exDividendDate")]
        public ExDividendDate exDividendDate { get; set; }

        [JsonPropertyName("beta")]
        public Beta beta { get; set; }

        [JsonPropertyName("circulatingSupply")]
        public CirculatingSupply circulatingSupply { get; set; }

        [JsonPropertyName("startDate")]
        public StartDate startDate { get; set; }

        [JsonPropertyName("regularMarketDayLow")]
        public RegularMarketDayLow regularMarketDayLow { get; set; }

        [JsonPropertyName("priceHInt64")]
        public PriceHInt64 priceHInt64 { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; }

        [JsonPropertyName("trailingPE")]
        public TrailingPE trailingPE { get; set; }

        [JsonPropertyName("regularMarketVolume")]
        public RegularMarketVolume regularMarketVolume { get; set; }

        [JsonPropertyName("lastMarket")]
        public object lastMarket { get; set; }

        [JsonPropertyName("maxSupply")]
        public MaxSupply maxSupply { get; set; }

        [JsonPropertyName("openInterest")]
        public OpenInterest openInterest { get; set; }

        [JsonPropertyName("marketCap")]
        public MarketCap marketCap { get; set; }

        [JsonPropertyName("volumeAllCurrencies")]
        public VolumeAllCurrencies volumeAllCurrencies { get; set; }

        [JsonPropertyName("strikePrice")]
        public StrikePrice strikePrice { get; set; }

        [JsonPropertyName("averageVolume")]
        public AverageVolume averageVolume { get; set; }

        [JsonPropertyName("priceToSalesTrailing12Months")]
        public PriceToSalesTrailing12Months priceToSalesTrailing12Months { get; set; }

        [JsonPropertyName("dayLow")]
        public DayLow dayLow { get; set; }

        [JsonPropertyName("ask")]
        public Ask ask { get; set; }

        [JsonPropertyName("ytdReturn")]
        public YtdReturn ytdReturn { get; set; }

        [JsonPropertyName("askSize")]
        public AskSize askSize { get; set; }

        [JsonPropertyName("volume")]
        public Volume volume { get; set; }

        [JsonPropertyName("fiftyTwoWeekHigh")]
        public FiftyTwoWeekHigh fiftyTwoWeekHigh { get; set; }

        [JsonPropertyName("forwardPE")]
        public ForwardPE forwardPE { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("fromCurrency")]
        public object fromCurrency { get; set; }

        [JsonPropertyName("fiveYearAvgDividendYield")]
        public FiveYearAvgDividendYield fiveYearAvgDividendYield { get; set; }

        [JsonPropertyName("fiftyTwoWeekLow")]
        public FiftyTwoWeekLow fiftyTwoWeekLow { get; set; }

        [JsonPropertyName("bid")]
        public Bid bid { get; set; }

        [JsonPropertyName("tradeable")]
        public bool tradeable { get; set; }

        [JsonPropertyName("dividendYield")]
        public DividendYield dividendYield { get; set; }

        [JsonPropertyName("bidSize")]
        public BidSize bidSize { get; set; }

        [JsonPropertyName("dayHigh")]
        public DayHigh dayHigh { get; set; }

        [JsonPropertyName("coinMarketCapLink")]
        public object coinMarketCapLink { get; set; }
    }

    public class SummaryProfile
    {
        [JsonPropertyName("industryDisp")]
        public string industryDisp { get; set; }

        [JsonPropertyName("zip")]
        public string zip { get; set; }

        [JsonPropertyName("sector")]
        public string sector { get; set; }

        [JsonPropertyName("fullTimeEmployees")]
        public double fullTimeEmployees { get; set; }

        [JsonPropertyName("longBusinessSummary")]
        public string longBusinessSummary { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("phone")]
        public string phone { get; set; }

        [JsonPropertyName("state")]
        public string state { get; set; }

        [JsonPropertyName("country")]
        public string country { get; set; }

        [JsonPropertyName("companyOfficers")]
        public List<object> companyOfficers { get; set; }

        [JsonPropertyName("website")]
        public string website { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }

        [JsonPropertyName("address1")]
        public string address1 { get; set; }

        [JsonPropertyName("industry")]
        public string industry { get; set; }
    }

    public class TargetHighPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TargetLowPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TargetMeanPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TargetMedianPrice
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class ThreeYearAverageReturn
    {
    }

    public class TotalAssets
    {
    }

    public class TotalCash
    {
    }

    public class TotalCashPerShare
    {
    }

    public class TotalDebt
    {
    }

    public class TotalEsg
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TotalInsiderShares
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class TotalRevenue
    {
    }

    public class TrailingAnnualDividendRate
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TrailingAnnualDividendYield
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TrailingEps
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class TrailingPE
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class Transaction
    {
        [JsonPropertyName("filerName")]
        public string filerName { get; set; }

        [JsonPropertyName("transactionText")]
        public string transactionText { get; set; }

        [JsonPropertyName("moneyText")]
        public string moneyText { get; set; }

        [JsonPropertyName("ownership")]
        public string ownership { get; set; }

        [JsonPropertyName("startDate")]
        public StartDate startDate { get; set; }

        [JsonPropertyName("value")]
        public Value value { get; set; }

        [JsonPropertyName("filerRelation")]
        public string filerRelation { get; set; }

        [JsonPropertyName("shares")]
        public Shares shares { get; set; }

        [JsonPropertyName("filerUrl")]
        public string filerUrl { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class Trend
    {
        [JsonPropertyName("period")]
        public string period { get; set; }

        [JsonPropertyName("strongBuy")]
        public double strongBuy { get; set; }

        [JsonPropertyName("buy")]
        public double buy { get; set; }

        [JsonPropertyName("hold")]
        public double hold { get; set; }

        [JsonPropertyName("sell")]
        public double sell { get; set; }

        [JsonPropertyName("strongSell")]
        public double strongSell { get; set; }
    }

    public class TwoHundredDayAverage
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }
    }

    public class UpgradeDowngradeHistory
    {
        [JsonPropertyName("history")]
        public List<History> history { get; set; }

        [JsonPropertyName("maxAge")]
        public double maxAge { get; set; }
    }

    public class Value
    {
        [JsonPropertyName("raw")]
        public object raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Volume
    {
        [JsonPropertyName("raw")]
        public double raw { get; set; }

        [JsonPropertyName("fmt")]
        public string fmt { get; set; }

        [JsonPropertyName("longFmt")]
        public string longFmt { get; set; }
    }

    public class Volume24Hr
    {
    }

    public class VolumeAllCurrencies
    {
    }

    public class Yearly
    {
        [JsonPropertyName("date")]
        public double date { get; set; }

        [JsonPropertyName("revenue")]
        public Revenue revenue { get; set; }

        [JsonPropertyName("earnings")]
        public Earnings earnings { get; set; }
    }

    public class Yield
    {
    }

    public class YtdReturn
    {
    }


}
