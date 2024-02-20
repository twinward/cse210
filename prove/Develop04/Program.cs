using System;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int listeningCount = 0;
        int reflectingCount = 0;
        int choice;

        do
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listening Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingCount++;
                    break;
                case 2:
                    ListeningActivity listeningActivity = new ListeningActivity();
                    listeningActivity.Run();
                    listeningCount++;
                    break;
                case 3:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    reflectingCount++;
                    break;
                case 0:
                    Console.WriteLine($"You've completed {breathingCount} breathing sessions, {listeningCount} listening sessions, and {reflectingCount} reflecting sessions.");
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 0);
    }
}