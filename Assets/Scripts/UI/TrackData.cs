using UnityEngine;

// Shared data structures for Track Characteristics.

// We can define the characteristics as an enum
public enum TrackCharacteristicType
{
    HighWear,
    PowerDependent,
    HighDownforce,
    LowGrip,
    BumpySurface
}

// A struct to hold the display information for a characteristic
[System.Serializable]
public struct TrackCharacteristicInfo
{
    public TrackCharacteristicType Type;
    public Sprite Icon;
    public string Description;
}
