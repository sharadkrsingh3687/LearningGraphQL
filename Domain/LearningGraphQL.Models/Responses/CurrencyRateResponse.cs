
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Currency exchange rates.
    /// </summary>
    public partial class CurrencyRateResponse
    {
        public CurrencyRateResponse()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeaderResponse>();
        }

        /// <summary>
        /// Primary key for CurrencyRate records.
        /// </summary>
        public int CurrencyRateId { get; set; }
        /// <summary>
        /// Date and time the exchange rate was obtained.
        /// </summary>
        public DateTime CurrencyRateDate { get; set; }
        /// <summary>
        /// Exchange rate was converted from this currency code.
        /// </summary>
        public string FromCurrencyCode { get; set; }
        /// <summary>
        /// Exchange rate was converted to this currency code.
        /// </summary>
        public string ToCurrencyCode { get; set; }
        /// <summary>
        /// Average exchange rate for the day.
        /// </summary>
        public decimal AverageRate { get; set; }
        /// <summary>
        /// Final exchange rate for the day.
        /// </summary>
        public decimal EndOfDayRate { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual CurrencyResponse FromCurrencyCodeNavigation { get; set; }
        public virtual CurrencyResponse ToCurrencyCodeNavigation { get; set; }
        public virtual ICollection<SalesOrderHeaderResponse> SalesOrderHeader { get; set; }
    }
}