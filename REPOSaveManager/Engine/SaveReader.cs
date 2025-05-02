namespace REPOSaveManager;

using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

class RepoSaveInfo
{
    public int level;
    public int currency;
    public int totalHaul;
}

class SaveReader
{
    private static string EncryptionKey = "Why would you want to cheat?... :o It's no fun. :') :'D";

    private static byte[] Encrypt(string content, string password)
    {
        byte[] data = Encoding.UTF8.GetBytes(content);
        using (var aes = new AesManaged())
        {
            aes.Mode = CipherMode.CBC;
            aes.KeySize = 128;
            aes.BlockSize = 128;
            aes.GenerateIV();
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, aes.IV, 100, HashAlgorithmName.SHA1))
            {
                aes.Key = pbkdf2.GetBytes(16);
                using (var encryptor = aes.CreateEncryptor())
                using (var msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(aes.IV, 0, aes.IV.Length);
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var writer = new BinaryWriter(csEncrypt))
                    {
                        writer.Write(data);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
    }
    private static string Decrypt(RepoSave save, string password)
    {
        byte[] encryptedData = File.ReadAllBytes(save.saveDir.GetFiles().FirstOrDefault().FullName);

        byte[] iv = encryptedData.Take(16).ToArray();

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, iv, 100, HashAlgorithmName.SHA1))
        {
            byte[] key = pbkdf2.GetBytes(16);

            using (var aes = new AesManaged())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor())
                using (var msDecrypt = new MemoryStream(encryptedData))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var reader = new BinaryReader(csDecrypt))
                {
                    byte[] decryptedData = reader.ReadBytes(encryptedData.Length);
                    decryptedData = Unpad(decryptedData);

                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
        }
    }

    // removepadding
    private static byte[] Unpad(byte[] data)
    {
        if (data.Length <= 16) return Array.Empty<byte>();
        return data.Skip(16).ToArray();
    }

    public static RepoSaveInfo ReadSave(RepoSave save)
    {
        RepoSaveInfo saveInfo = new RepoSaveInfo();

        string decryptedSave = Decrypt(save, EncryptionKey);
        dynamic saveRoot = JsonConvert.DeserializeObject<dynamic>(decryptedSave);
        dynamic runStats = saveRoot.dictionaryOfDictionaries.value.runStats;
        
        saveInfo.level = runStats.level + 1;
        saveInfo.currency = runStats.currency;
        saveInfo.totalHaul = runStats.totalHaul;

        return saveInfo;
    }
}

/*

public void LoadGame(string fileName)
	{
		if (!SemiFunc.IsMasterClientOrSingleplayer())
		{
			return;
		}
		string text = string.Concat(new string[]
		{
			Application.persistentDataPath,
			"/saves/",
			fileName,
			"/",
			fileName,
			".es3"
		});
		if (File.Exists(text))
		{
			this.saveFileCurrent = fileName;
			ES3Settings settings = new ES3Settings(text, ES3.EncryptionType.AES, this.totallyNormalString, null);
			this.teamName = ES3.Load<string>("teamName", settings);
			this.dateAndTime = ES3.Load<string>("dateAndTime", settings);
			this.timePlayed = ES3.Load<float>("timePlayed", settings);
			this.playerNames = ES3.Load<Dictionary<string, string>>("playerNames", settings);
			using (Dictionary<string, Dictionary<string, int>>.Enumerator enumerator = ES3.Load<Dictionary<string, Dictionary<string, int>>>("dictionaryOfDictionaries", settings).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, Dictionary<string, int>> keyValuePair = enumerator.Current;
					Dictionary<string, int> dictionary;
					if (this.dictionaryOfDictionaries.TryGetValue(keyValuePair.Key, out dictionary))
					{
						using (Dictionary<string, int>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								KeyValuePair<string, int> keyValuePair2 = enumerator2.Current;
								dictionary[keyValuePair2.Key] = keyValuePair2.Value;
							}
							continue;
						}
					}
					this.dictionaryOfDictionaries.Add(keyValuePair.Key, new Dictionary<string, int>(keyValuePair.Value));
				}
				goto IL_166;
			}
		}
		Debug.LogWarning("Save file not found in " + text);
		IL_166:
		RunManager.instance.levelsCompleted = this.GetRunStatLevel();
		RunManager.instance.runLives = this.GetRunStatLives();
		RunManager.instance.loadLevel = this.GetRunStatSaveLevel();
		this.PlayersAddAll();
		this.saveFileReady = true;
	}

*/
