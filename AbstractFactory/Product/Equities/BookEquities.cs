using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Product.Equities
{
    public class BookEquities : IBookProduct
    {
        public List<decimal> ShowBook(string instrument)
        {
            var listaMock = new List<decimal>() { 5, 5, 5, 5, 5, 6 };
            return listaMock;
        }
    }
}
