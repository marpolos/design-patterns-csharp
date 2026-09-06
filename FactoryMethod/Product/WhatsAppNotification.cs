namespace FactoryMethod.Product
{
    public class WhatsAppNotification : INotification
    {
        public void NotifyUser(string message)
        {
            Console.WriteLine("Sending a WhatsApp Notification: " + message);
        }
    }
}
