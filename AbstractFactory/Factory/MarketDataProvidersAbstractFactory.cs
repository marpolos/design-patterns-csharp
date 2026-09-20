using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Factory
{
    abstract class MarketDataProvidersAbstractFactory
    {
        public abstract IBookProduct BookProduct();
        public abstract IQuoteProduct QuoteProduct();
    }
}
