using SendingPushNotifications.Logics;
using System;

namespace SendingPushNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "";
            string body = "";
            var data = new { action = "Play", userId = 5 };

            Console.WriteLine("Hello Everyone!");
            Console.WriteLine("Let's send push notifications!!!");

            Console.Write("Title of Notification: ");
            title = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ok, so now I have the title, I'll need a description");
            body = Console.ReadLine();

            Console.WriteLine();

            Console.Write("How many devices are going to receive this notification? ");
            int.TryParse(Console.ReadLine(), out int devicesCount);
            var tokens = new string[devicesCount];

            Console.WriteLine();

            for (int i = 0; i < devicesCount; i++)
            {
                Console.Write($"Token for device number {i + 1}: ");
                tokens[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Do you want to send notifications?");
            Console.WriteLine("1 - Yes!!!!");
            Console.WriteLine("0 - No, I'm wasting my time!!!");
            int.TryParse(Console.ReadLine(), out int sendNotification);
            if (sendNotification == 1)
            {
                var pushSent = PushNotificationLogic.SendPushNotification(tokens, title, body, data);
                Console.WriteLine($"Notification sent");
            }
            else
            {
                Console.WriteLine("BUUUUUU");
            }

            Console.ReadKey();
        }
    }
}
