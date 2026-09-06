namespace FactoryMethod.Product
{
    public class EmailNotification : INotification
    {
        public void NotifyUser(string message)
        {
            Console.WriteLine("Sending an Email Notification: " + message);
        }
    }
}
