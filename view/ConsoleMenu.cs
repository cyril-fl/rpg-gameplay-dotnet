namespace rpg_gameplay.view;

public static class ConsoleMenu
{
    public static int Select<T>(string prompt, T[] options)
    {
        int selected = 0;

        ConsoleKey key;
        do
        {
            Console.Clear();
            Console.WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {options[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {options[i]}");
                }
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow && selected > 0)
                selected--;
            else if (key == ConsoleKey.DownArrow && selected < options.Length - 1)
                selected++;
        }
        while (key != ConsoleKey.Enter);

        return selected;
    }
    
    public static void Display(List<string> dialog)
    {
        Console.Clear();
        for (int i = 0; i < dialog.Count; i++)
        {
            string line = dialog[i];
            string displayedLine = (i == dialog.Count - 1) ? line : line + "..";
            Console.WriteLine(displayedLine);
            Console.ReadKey(true);
            Console.Clear();
        }
    }

    public static string Ask(string prompt)
    {
        string? response;

        do
        {
            Console.WriteLine(prompt);
            response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please enter a valid response.");
            }
        }
        while (string.IsNullOrWhiteSpace(response));

        return response;
    }
}