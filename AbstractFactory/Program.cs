using AbstractFactory.Factory;

Console.WriteLine("Hello, World!");

MarketDataProvidersAbstractFactory MarketDataProviderDerivatives = new MarketDataDerivatives();

var bookResult = MarketDataProviderDerivatives.BookProduct().ShowBook("PETR4");
var quoteResult = MarketDataProviderDerivatives.QuoteProduct().ShowQuote("PETR4");

Console.WriteLine($"Book Result: {string.Join(", ", bookResult)}");
Console.WriteLine($"Quote Result: {string.Join(", ", quoteResult)}");
