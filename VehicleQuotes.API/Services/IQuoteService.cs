using ALDQuoteService.Models;
using ALDQuoteService.QuoteEngines;

namespace ALDQuoteService.Services
{
    public interface IQuoteService
    {
        Quote CalculateQuote(QuoteType quoteType, decimal vehiclePrice, short termMonths, decimal deposit);
    }
}