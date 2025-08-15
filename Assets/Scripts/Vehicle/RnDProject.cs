using UnityEngine;
using System.Collections.Generic;
using RacingManager.Staff; // Assuming engineers will be a type of staff

namespace RacingManager.Vehicle
{
    public enum RiskLevel
    {
        None,
        Low,
        High
    }

    [System.Serializable]
    public class RnDProject
    {
        public string ProjectName;
        public CarPartData TargetPart;
        public float Cost;
        public int DurationDays;
        public int ProgressDays;
        public RiskLevel Risk;
        // public List<StaffProfile> AssignedEngineers; // Placeholder for now

        public bool IsComplete => ProgressDays >= DurationDays;

        public void AdvanceDay()
        {
            if (!IsComplete)
            {
                ProgressDays++;
            }
        }
    }

    public class RnDManager : MonoBehaviour
    {
        public List<RnDProject> ActiveProjects = new List<RnDProject>();

        // This would be called once per simulated day
        public void UpdateProjects()
        {
            foreach (var project in ActiveProjects)
            {
                project.AdvanceDay();
            }

            // Optional: Remove completed projects from the active list
            ActiveProjects.RemoveAll(p => p.IsComplete);
        }

        /// <summary>
        /// Calculates if a part is discovered as illegal after a race.
        /// </summary>
        /// <param name="part">The car part to inspect.</param>
        /// <returns>True if the part is discovered, false otherwise.</returns>
        public bool PostRaceInspection(CarPartData part)
        {
            if (part == null) return false;

            float discoveryChance = 0f;
            switch (part.Risk)
            {
                case RiskLevel.None:
                    discoveryChance = 0f;
                    break;
                case RiskLevel.Low:
                    discoveryChance = 0.1f; // 10% chance
                    break;
                case RiskLevel.High:
                    discoveryChance = 0.5f; // 50% chance
                    break;
            }

            if (Random.value < discoveryChance)
            {
                Debug.LogWarning($"Illegal part {part.name} has been discovered!");
                return true;
            }

            return false;
        }
    }
}
