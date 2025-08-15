using UnityEngine;
using System.Collections.Generic;
using RacingManager.Contracts;

namespace RacingManager.Staff
{
    [System.Serializable]
    public class Skill
    {
        public string SkillName;
        [Range(1, 20)]
        public int Rating;
    }

    [CreateAssetMenu(fileName = "New Staff Profile", menuName = "Racing Manager/Staff Profile")]
    public class StaffProfile : ScriptableObject
    {
        public string Name;
        public TeamRole Role;
        public List<Skill> Skills;

        [Range(1, 100)]
        public float Morale = 70; // Default morale

        [Header("Driver-Specific")]
        [Tooltip("Traits only apply if the role is Driver.")]
        public List<Trait> Traits;
    }
}
