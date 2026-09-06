using FactoryMethod.Creator;

Console.WriteLine("Hello, World!");

var whatsAppNotification = new WhatsAppNotificationConcreteCreator();

var emailNotification = new EmailNotificationConcreteCreator();

whatsAppNotification.SendNotification().NotifyUser("Hello, WhatsApp!");
emailNotification.SendNotification().NotifyUser("Hello, Email!");