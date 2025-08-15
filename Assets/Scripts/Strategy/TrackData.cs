using UnityEngine;
using System.Collections.Generic;

namespace RacingManager.Strategy
{
    public enum TrackCharacteristic
    {
        PowerDependent,
        AeroDependent,
        HighWear,
        LowWear,
        Bumpy,
        HighAltitude
    }

    [CreateAssetMenu(fileName = "New Track Data", menuName = "Racing Manager/Track Data")]
    public class TrackData : ScriptableObject
    {
        public string TrackName;
        public List<TrackCharacteristic> Characteristics;
    }
}
