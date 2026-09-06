using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public abstract class NotificationCreator
    {
        public abstract INotification SendNotification();
    }
}
