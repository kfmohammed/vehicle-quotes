namespace ALDQuoteService.QuoteEngines
{
    public class HPFinanceCalculator : FinanceCalculatorBase
    {
        /// <summary>
        /// Calculates the APR (interest rate) applicable to specified contract term.
        /// </summary>
        /// <param name="termMonths">The contract term in months</param>
        /// <returns></returns>
        public override decimal GetAnnualPercentageRate(short termMonths)
        {
            // TODO - Implement specific APR calculation for HP contracts
            //return base.GetAnnualPercentageRate(termMonths);

            if (termMonths <= 24)
            {
                return 7.9M;
            }
            else if (termMonths <= 36)
            {
                return 6.9M;
            }
            else
            {
                return 5.9M;
            }
        }
    }
}