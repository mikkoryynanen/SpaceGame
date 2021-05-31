using UnityEngine;

public class Entity : EntityMover 
{
    protected StatsContainer _statsContainer;

    public virtual void Awake()
    {
        _statsContainer = new StatsContainer();
        Stat health = _statsContainer.GetStat(StatType.Health);

        Debug.Log($"Loaded {health.CurrentValue} health");
    }  

    public void ResetStats()
    {
       _statsContainer.Reset();
    }
}