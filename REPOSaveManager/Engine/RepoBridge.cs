namespace REPOSaveManager;

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;

class RepoSave
{
    public string saveFileName = "REPO_SAVE_xxxx_xx_xx_xx_xx_xx";
    public DirectoryInfo saveDir;

    public RepoSaveInfo FetchInfo()
    {
        return SaveReader.ReadSave(this);
    }

    public static RepoSave Create(string zipName)
    {
        var newSave = "REPO_SAVE_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "_clone1";

        var newSaveDir = new DirectoryInfo(Path.Combine(Config.RepoSaves.FullName, newSave));
        if (newSaveDir.Exists)
            throw new Exception("Save already exists!");

        newSaveDir.Create();

        var zipFile = new FileInfo(Path.Combine(Config.RepoSaves.FullName, zipName));
        if (!zipFile.Exists)
            throw new Exception("Zip file not found!");

        ZipFile.ExtractToDirectory(zipFile.FullName, newSaveDir.FullName);

        foreach (var file in newSaveDir.GetFiles())
        {
            if (file.Name.Contains("BACKUP")) // REPO_SAVE_2025_04_14_22_17_01.es3
                file.Delete();

            file.MoveTo(Path.Combine(newSaveDir.FullName, $"{newSave}.es3"));
        }

        return RepoBridge.GetSave(newSave);
    }

    internal bool Export()
    {
        var saveFileDialog = new SaveFileDialog()
        {
            Filter = "Repo World/save files (*.repoworld)|*.repoworld",
            Title = "Export REPO Save",
            FileName = saveFileName + ".repoworld",
            InitialDirectory = Config.RepoSaves.FullName
        };

        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return false;

        ZipFile.CreateFromDirectory(saveDir.FullName, saveFileDialog.FileName, CompressionLevel.Optimal, false);
        return true;
    }

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
