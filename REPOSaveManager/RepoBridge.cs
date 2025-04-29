namespace REPOSaveManager;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RepoSave
{
    public string saveFileName = "REPO_SAVE_xxxx_xx_xx_xx_xx_xx";
    public DirectoryInfo saveDir;

    internal RepoSave Clone()
    {
        var newSave = saveFileName;

    repeatTilWorks:
        Console.WriteLine("old " + newSave);

        // generate a new unique name for the save
        var match = Regex.Match(newSave, @"^(REPO_SAVE_\d{4}(?:_\d{2}){5})(?:_clone(\d+))?$");
        if (match.Success)
        {
            var baseName = match.Groups[1].Value;
            var cloneNum = match.Groups[2].Success ? int.Parse(match.Groups[2].Value) + 1 : 1;
            newSave = $"{baseName}_clone{cloneNum}";
        }

        // shallow copy save
        DirectoryInfo newSaveDir = new DirectoryInfo(Path.Combine(Config.RepoSaves.FullName, newSave));

        if (newSaveDir.Exists)
            goto repeatTilWorks;

        newSaveDir.Create();

        foreach (var file in saveDir.GetFiles())
        {
            if (!file.Name.Contains("BACKUP")) // REPO_SAVE_2025_04_14_22_17_01.es3
                file.CopyTo(Path.Combine(newSaveDir.FullName, $"{newSave}.es3"));
        }

        return RepoBridge.GetSave(newSave);
    }

    internal void Destroy() => saveDir.Delete(true); // sketchy
}

class RepoBridge
{
    public static RepoSave GetSave(string fileName)
    {
        return new RepoSave()
        {
            saveFileName = fileName,
            saveDir = new DirectoryInfo(Path.Combine(Config.RepoSaves.FullName, fileName))
        };
    }

    public static List<RepoSave> GetSaves()
    {
        var saves = new List<RepoSave>();

        foreach (var file in Config.RepoSaves.GetDirectories())
            saves.Add(GetSave(file.Name));

        return saves;
    }
}
