using AbstractFactory.Product.Derivatives;
using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Factory
{
    class MarketDataDerivatives : MarketDataProvidersAbstractFactory
    {
        public MarketDataDerivatives()
        {
            
        }
        public override IBookProduct BookProduct()
        {
            var bookProducts = new BookDerivatives();
            return bookProducts;
        }

        public override IQuoteProduct QuoteProduct()
        {
            var quoteProducts = new QuoteDerivatives();
            return quoteProducts;
        }
    }
}
