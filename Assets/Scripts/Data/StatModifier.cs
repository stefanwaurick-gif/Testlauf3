/// <summary>
/// Represents a single modification to a car's statistic.
/// e.g., "+500 EnginePower" or "-0.1 Drag".
/// </summary>
[System.Serializable]
public class StatModifier
{
    public StatType Stat;
    public float Value;
}
