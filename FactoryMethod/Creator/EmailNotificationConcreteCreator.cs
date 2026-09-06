using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class EmailNotificationConcreteCreator : NotificationCreator
    {
        public override INotification SendNotification()
        {
            return new EmailNotification();
        }
    }
}
