namespace REPOSaveManager;

using System;
using System.IO;

class Config
{
    public static DirectoryInfo RepoSaves = new DirectoryInfo(Path.Combine(
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow"),
        "semiwork", "Repo", "saves"
    ));
}
