// See https://aka.ms/new-console-template for more information
using Internship_task;

Console.WriteLine("Hello, World!");

int hours = getInt("Hour");
int minutes = getInt("Minute");

Clock userClock = new Clock(hours, minutes);

Console.WriteLine(clockAngleTask.CalculateAngle(userClock));


int getInt(string purpose)
{
    while (true)
    {
        Console.WriteLine("You are now entering number for " + purpose);
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();
        int inputNumber;
        if (int.TryParse(number, out inputNumber))
        {
            Console.Clear();
            return inputNumber;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong input Try again.");
        }
    }
}