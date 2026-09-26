using Prototype.Enum;

namespace Prototype.Interfaces
{
    public interface IStrategy
    {
        public string Account { get; set; }
        public OrderTypeEnum OrderType { get; set; }
        public string Instrument { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal LossLimit { get; set; }
        public DateTime CreatedAt { get; set; }
        public Risk RiskConfiguration { get; set; }
    }
}
