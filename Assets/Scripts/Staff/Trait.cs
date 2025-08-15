using UnityEngine;
using System.Collections.Generic;
using RacingManager.Vehicle; // For reusing StatModifier

namespace RacingManager.Staff
{
    [CreateAssetMenu(fileName = "New Trait", menuName = "Racing Manager/Trait")]
    public class Trait : ScriptableObject
    {
        public string TraitName;
        [TextArea(2, 4)]
        public string Description;

        // A trait can modify one or more stats
        public List<StatModifier> StatEffects;
    }
}
