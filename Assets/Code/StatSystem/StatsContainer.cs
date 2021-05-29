using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StatsContainer 
{
    Dictionary<StatType, Stat> _stats = new Dictionary<StatType, Stat>();
    public int AvailablePoints { get; private set; } = 10;

    public StatsContainer()
    {
        var stats = DataLoader.LoadData();
        foreach (var stat in stats)
        {
            AddStat((StatType)Enum.Parse(typeof(StatType), stat.Name), stat);       
        }
    }

    public void AddStat(StatType type, Stat stat)
    {
        _stats.Add(type, stat);
    }

    public Stat GetStat(StatType type)
    {
        try
        {
            return _stats[type];
        }
        catch (System.Exception)
        { Debug.LogError($"Could not find stat for {type.ToString()}"); }
        return null;
    }

    public List<Stat> GetStats()
    {
        return _stats.Select(x => x.Value).ToList();
    }

    // public void LevelUpStat(Stat stat)
    // {
    //     if (AvailablePoints <= 0)
    //     {
    //         Debug.LogError("Did not enough points available for upgrade");
    //         return;
    //     }

    //     Stat s = GetStat();
    //     s.LevelUp();
    //     Debug.Log($"stat '{s.Name}' levelled up to level {s.CurrentLevel}. New stat = {s.CurrentValue}");
    // }

    public void Reset()
    {
        AvailablePoints = 10;
    }
}