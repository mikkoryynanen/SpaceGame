using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class DataLoader 
{
    static readonly string dataSource = Application.dataPath +  "/Code/Data/data.json";

    public static void SaveData(List<Stat> stats)
    {
        using (StreamWriter sw = new StreamWriter(dataSource))
        {
            string json = JsonConvert.SerializeObject(stats,Formatting.Indented);
            sw.WriteLine(json);
        }
    }

    public static void UpdateData(Stat stat)
    {
        List<Stat> loadedStats = LoadData();
        int statIndex = loadedStats.FindIndex(x => x.Name == stat.Name);
        if (statIndex < 0)
        {
            Debug.LogError($"Failed to update stat {stat.Name}");
            return;
        }

        loadedStats[statIndex] = stat;
        
        SaveData(loadedStats);
    }

    public static List<Stat> LoadData()
    {
        using (StreamReader sr = new StreamReader(dataSource))
        {
            string json = sr.ReadToEnd();
            List<Stat> loadedData = JsonConvert.DeserializeObject<List<Stat>>(json);
            return loadedData;
        }
    }
}