public class Stat 
{
    public string Name { get; private set; }
    public float BaseValue { get; private set; }
    public float CurrentValue 
    { 
        get
        {
            float valuePerLevel = (BaseValue / MaxLevel);
            if (BaseValue > MaxValue)
            {
                return BaseValue - (valuePerLevel * CurrentLevel);
            }
            else
            {
                return BaseValue + (valuePerLevel * CurrentLevel);
            }
        }
    }

    public float MaxValue { get; private set; }
    public int CurrentLevel { get; private set; }
    public int MaxLevel { get; private set; }

    public Stat(string name, float baseValue, float maxValue, int currentLevel, int maxLevel)
    {
        Name = name;
        BaseValue = baseValue;
        MaxValue = maxValue;
        CurrentLevel = currentLevel;
        MaxLevel = maxLevel;
    }

    public void LevelUp()
    {
        if (CurrentLevel + 1 <= MaxLevel)
        {
            CurrentLevel++;
        }
    }

    public void Reset()
    {
        CurrentLevel = 1;
    }
}