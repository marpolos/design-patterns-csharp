using Prototype.Enum;
using Prototype.Interfaces;

namespace Prototype
{
    public class Strategy : StrategyPrototype, IStrategy
    {
        public string Account { get; set; }
        public OrderTypeEnum OrderType { get; set; }
        public string Instrument { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal LossLimit { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Risk RiskConfiguration { get; set; }
    }
}
