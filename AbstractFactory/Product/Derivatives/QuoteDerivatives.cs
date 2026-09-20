using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Product.Derivatives
{
    internal class QuoteDerivatives : IQuoteProduct
    {
        public List<decimal> ShowQuote(string instrument)
        {
            var listaMock = new List<decimal>() { 5, 5, 5, 5, 5, 6 };
            return listaMock;
        }
    }
}
