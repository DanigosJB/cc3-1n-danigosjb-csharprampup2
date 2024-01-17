using System;

class Program
{
    static void Main()
    {
        // Converting of pounds to kilograms
        Console.Write("Enter weight in pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Weight: {pounds} lbs = {kilograms} kg");

        // Converting of miles to kilometers
        Console.Write("Enter distance in miles: ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Distance: {miles} mi = {kilometers} km");

        // Converting of Fahrenheit to Celsius
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature: {fahrenheit} °F = {celsius} °C");

        // Calculation of the average age of students
        int totalAges = 0;
        int numberOfStudents = 10;

        for (int i = 1; i <= numberOfStudents; i++)
        {
            Console.Write($"Enter age of student {i}: ");
            totalAges += int.Parse(Console.ReadLine());
        }

        double averageAge = (double)totalAges / numberOfStudents;
        Console.WriteLine($"Average Age: {averageAge:F2}");

        // The Fantasy Story
        string character1 = "Zavosk";
        string character2 = "Hawkeye";
        string character3 = "Braum";
        string character4 = "Josh Wa";
        string character5 = "Jhin";

        string equipment1 = "Murasama";
        string equipment2 = "Golden Bow";
        string equipment3 = "Shield of Cthulhu";
        string equipment4 = "Universe Splitter";
        string equipment5 = "Elysian Tracers";

        Console.WriteLine($"\nFantasy Story:\nOnce upon a time in the vast world of Airarret, there lived five adventurers: {character1}, {character2}, {character3}, {character4}, and {character5}.");
        Console.WriteLine($"{character1} wielded the godly {equipment1}, while {character2} possessed the enchanted {equipment2}.");
        Console.WriteLine($"{character3} guarded the realm with the unbreakable {equipment3}, and {character4} cast powerful spells with the legendary {equipment4}.");
        Console.WriteLine($"{character5}, the swift and agile, roamed the lands wearing the legendary {equipment5}.");
        Console.WriteLine("Their destinies intertwined as they embarked on a quest to save Airarret from an impending corruption.");

       
    }
}
