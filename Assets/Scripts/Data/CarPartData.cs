using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A ScriptableObject that defines the data for a single car part.
/// This is a placeholder based on task G-004.
/// </summary>
[CreateAssetMenu(fileName = "NewCarPart", menuName = "Racing Manager/Car Part Data", order = 1)]
public class CarPartData : ScriptableObject
{
    [Tooltip("The type of this part (e.g., Engine, Chassis).")]
    public PartType Type;

    [Tooltip("A list of stat modifications that this part provides.")]
    public List<StatModifier> StatModifiers;
}
