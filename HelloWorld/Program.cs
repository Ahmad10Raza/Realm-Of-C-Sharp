// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// using System;

// namespace Basics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int age = 25;                 // Integer type
//             double salary = 50000.50;     // Double type
//             string name = "Alice";        // String type
//             bool isEmployed = true;       // Boolean type

//             Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Employed: {isEmployed}");
//         }
//     }
// }

using System;

class Program
{
    static void Main()
    {
        // Change Foreground and Background Colors
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear(); // Clears the console with the new background color
        Console.WriteLine("Welcome to the Console Demonstration!");
        Console.ResetColor(); // Reset to default colors

        // Read a Key
        Console.WriteLine("\nPress any key to continue...");
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // Reads a key from the user
        Console.WriteLine($"\nYou pressed: {keyInfo.Key}");

        // Demonstrate Cursor Position
        Console.WriteLine("\nNow setting the cursor position...");
        Console.SetCursorPosition(10, 5); // Move cursor to column 10, row 5
        Console.Write("Cursor moved here!");

        // Read and Display User Input
        Console.SetCursorPosition(0, 7); // Move the cursor for neat output
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Show Progress Bar Using Console
        Console.WriteLine($"\nHello, {name}! Let's demonstrate a progress bar:");
        for (int i = 0; i <= 100; i += 10)
        {
            Console.Write($"Progress: {i}%".PadRight(20)); // Ensure alignment
            System.Threading.Thread.Sleep(200); // Simulate work
            Console.Write("\r"); // Move back to the start of the line
        }
        Console.WriteLine("\nProgress complete!");

        // Demonstrate Console.Beep()
        Console.WriteLine("\nNow playing a beep sound...");
        Console.Beep(1000, 500); // Play a beep sound (frequency: 1000 Hz, duration: 500 ms)

        // Clearing the Console
        Console.WriteLine("\nClearing the console in 3 seconds...");
        System.Threading.Thread.Sleep(3000);
        Console.Clear(); // Clears the console content

        // Display Final Message
        Console.WriteLine("Console demonstration complete. Thank you!");
    }
}

