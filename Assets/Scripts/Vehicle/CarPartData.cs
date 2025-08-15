using UnityEngine;
using System.Collections.Generic;

namespace RacingManager.Vehicle
{
    public enum CarPartType
    {
        Chassis,
        Engine,
        FrontWing,
        RearWing,
        Underbody,
        Sidepods
    }

    public enum StatType
    {
        TopSpeed,
        Acceleration,
        Downforce,
        Weight,
        Durability
    }

    [System.Serializable]
    public class StatModifier
    {
        public StatType Type;
        public float Value;
    }

    [CreateAssetMenu(fileName = "New Car Part", menuName = "Racing Manager/Car Part")]
    public class CarPartData : ScriptableObject
    {
        public CarPartType PartType;
        public List<StatModifier> Modifiers;
    }
}
