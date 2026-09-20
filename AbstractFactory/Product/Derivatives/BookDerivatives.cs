using AbstractFactory.Product.interfaces;

namespace AbstractFactory.Product.Derivatives
{
    public class BookDerivatives : IBookProduct
    {
        List<decimal> IBookProduct.ShowBook(string instrument)
        {
            var listaMock = new List<decimal>() { 5, 5,5, 5,5, 6 };
            return listaMock;
        }
    }
}
