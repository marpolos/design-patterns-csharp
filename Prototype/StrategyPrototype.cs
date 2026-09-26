using Prototype.Interfaces;

namespace Prototype
{
    public abstract class StrategyPrototype
    {
        public IStrategy DeepCopy()
        {
            var clone = Clone();
            clone.Account = string.Empty;
            clone.CreatedAt = DateTime.Now + TimeSpan.FromDays(-1);
            clone.RiskConfiguration = new Risk();
            return clone;
        }
        public IStrategy ShallowCopy() 
        {
            return Clone();
        }
        public IStrategy Clone()
        {
            return (IStrategy)this.MemberwiseClone();
        }
    }
}
