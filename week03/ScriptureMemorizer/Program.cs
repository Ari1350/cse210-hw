using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Deuteronomy", 31, 8), "And the Lord, he it is that doth go before thee; he will be with thee, he will not fail thee, neither forsake thee: fear not, neither be dismayed.."),
            new Scripture(new Reference("Ecclesiastes", 5, 4, 5), "When thou vowest a vow unto God, defer not to pay it; for he hath no pleasure in fools: pay that which thou hast vowed. Better is it that thou shouldest not vow, than that thou shouldest vow and not pay"),
            new Scripture(new Reference("Mosiah", 23, 10), "Nevertheless, after much tribulation, the Lord did hear my cries, and did answer my prayers, and has made me an instrument in his hands in bringing so many of you to a knowledge of his truth."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.")
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        Console.Clear();
        Console.WriteLine("Memorize this scripture:");
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine();

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("¡Goodbye, see you again to practice!");
                break;
            }

            selectedScripture.HideRandomWords(4); 
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
        }

        if (selectedScripture.IsCompletelyHidden())
        {
            Console.WriteLine("¡Congratulations, you memorize a scripture!");
        }
    }
}
