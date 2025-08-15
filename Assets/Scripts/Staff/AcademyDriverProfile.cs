using UnityEngine;
using System.Collections.Generic;

namespace RacingManager.Staff
{
    [CreateAssetMenu(fileName = "New Academy Driver", menuName = "Racing Manager/Academy Driver")]
    public class AcademyDriverProfile : ScriptableObject
    {
        public string Name;
        public int Age;

        public List<Skill> CurrentSkills;

        // As per the task, PotentialSkills should be "hidden".
        // In a real game, this might be handled by UI logic or be private with a special getter.
        // For the data model, making it public is fine, but we add a note.
        [Tooltip("Potential skills should be hidden from the player in the UI.")]
        public List<Skill> PotentialSkills;

        /// <summary>
        /// Ages up the driver by one year and improves skills based on potential.
        /// </summary>
        public void AgeUp()
        {
            Age++;
            Debug.Log($"{Name} is now {Age} years old.");

            // Simple skill improvement logic
            foreach (var potentialSkill in PotentialSkills)
            {
                var currentSkill = CurrentSkills.Find(s => s.SkillName == potentialSkill.SkillName);
                if (currentSkill != null)
                {
                    // Improve skill by a random amount, but not exceeding the potential
                    int improvement = Random.Range(0, 2);
                    currentSkill.Rating = Mathf.Min(currentSkill.Rating + improvement, potentialSkill.Rating);
                }
            }
        }
    }
}
