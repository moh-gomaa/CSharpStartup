namespace CSharpStartup.Project1
{
    public class ConsoleHelper
    {
        public static void WriteColorLine(string value)
        {
            // Write an entire line to the console with the string.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));

            // Reset the color.
            Console.ResetColor();
        }
    }
}
