namespace REPOSaveManager;

using System;

class Program
{
    static void ShowSaves()
    {
        Console.WriteLine("R.E.P.O Save files:");

        var saves = RepoBridge.GetSaves();
        for (int i = 0; i < saves.Count; ++i)
        {
            var save = saves[i];
            Console.WriteLine($"{i}: {save.saveFileName}"); // TODO: have GetSave also return gameplay info like currency and level completions from the base es3 file
        }
    }

    static void HandleCommand(string command, int index)
    {
        var saves = RepoBridge.GetSaves();
        if (index < 0 || index >= saves.Count)
        {
            Console.WriteLine("Invalid saves index.");
            return;
        }

        var save = saves[index];

        switch (command.ToLower())
        {
            case "clone":
                var newSave = save.Clone();
                Console.WriteLine($"Soft clone saved to {newSave.saveFileName}");
                break;
            case "delete":
                save.Destroy();
                Console.WriteLine($"Destroyed save {save.saveFileName}");
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            ShowSaves();
            Console.WriteLine("Enter command (e.g., clone, delete) and save index (e.g., 0):");
            Console.Write(">");
            string input = Console.ReadLine();
            var parts = input.Split(' ');

            if (parts.Length != 2 || !int.TryParse(parts[1], out var value))
            {
                Console.WriteLine("Invalid input. Format: <command> <index>");
                continue;
            }

            HandleCommand(parts[0], value);
            Console.ReadKey();
        }
    }
}
