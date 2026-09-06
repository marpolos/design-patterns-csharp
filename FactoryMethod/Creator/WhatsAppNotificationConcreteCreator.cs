using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class WhatsAppNotificationConcreteCreator : NotificationCreator
    {
        public override INotification SendNotification()
        {
            return new WhatsAppNotification();
        }
    }
}
