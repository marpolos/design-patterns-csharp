using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Product.Equities
{
    public class QuoteEquities : IQuoteProduct
    {
        public List<decimal> ShowQuote(string instrument)
        {
            var listaMock = new List<decimal>() { 1, 2, 3, 4, 5, 6 };
            return listaMock;
        }
    }
}
