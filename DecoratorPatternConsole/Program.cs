Console.WriteLine("Decorator Pattern");

INotification notifier = new SmsNotification(new EmailNotification());
notifier.Send("test");

Console.ReadLine();