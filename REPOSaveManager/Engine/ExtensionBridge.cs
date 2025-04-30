using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace REPOSaveManager;
#nullable enable

class ExtensionBridge
{
    static string[] extensions = { ".repoworld" };

    public static void RegisterExtension()
    {
        var exePath = Assembly.GetExecutingAssembly().Location;
        var progId = $"REPOSaveManager.World";

        Registry.CurrentUser.CreateSubKey($@"Software\Classes\{progId}")?.SetValue("FriendlyTypeName", "R.E.P.O Save Manager");

        var key = Registry.CurrentUser.CreateSubKey($@"Software\Classes\{progId}");
        key?.CreateSubKey("DefaultIcon")?.SetValue("", $"{exePath},0");
        key?.CreateSubKey("shell\\Open\\command")?.SetValue("", $"\"{exePath}\" \"%1\"");

        foreach (var ext in extensions)
        {
            try
            {
                var extKey = Registry.CurrentUser.CreateSubKey($@"Software\Classes\{ext}");
                extKey?.SetValue("", progId);
                extKey?.CreateSubKey($"{progId}\\ShellNew");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Failed to register file extension '{ext}': Access denied.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to register file extension: {e.Message}");
            }
        }
    }

    public static bool LaunchedWithExtension()
    {
        var args = Environment.GetCommandLineArgs();
        if (args.Length < 2) return false;
        var ext = Path.GetExtension(args[1]);
        foreach (var handled in extensions)
            if (string.Equals(ext, handled, StringComparison.OrdinalIgnoreCase))
                return true;
        return false;
    }

    public static FileInfo? GetLaunchedFile()
    {
        if (!LaunchedWithExtension()) return null;
        var path = Environment.GetCommandLineArgs()[1];
        return File.Exists(path) ? new FileInfo(path) : null;
    }

    public static void HandleNewWorld(FileInfo file)
    {
        var newSave = RepoSave.Create(file.FullName);
        Console.WriteLine($"Created new save: {newSave.saveFileName}");
    }
}
