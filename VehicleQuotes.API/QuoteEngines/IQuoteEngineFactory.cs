namespace ALDQuoteService.QuoteEngines
{
    public interface IQuoteEngineFactory
    {
        IQuoteEngine Create(QuoteType quoteType);
    }
}