using UnityEngine;
using System.Collections.Generic;
using RacingManager.Staff; // Assuming engineers will be a type of staff

namespace RacingManager.Vehicle
{
    public enum ProjectType
    {
        Normal,
        Experimental
    }

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
        public ProjectType Type;
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
        /// Resolves an experimental R&D project with a random outcome.
        /// </summary>
        public void ResolveExperimentalProject(RnDProject project)
        {
            if (project.Type != ProjectType.Experimental) return;

            float outcome = Random.value;
            if (outcome <= 0.1f) // 10% chance
            {
                Debug.Log($"EXPERIMENTAL PROJECT SUCCESS: {project.ProjectName} was a massive success! Huge performance gain.");
                // In a real implementation, you would apply a large bonus to the target part's stats.
            }
            else if (outcome <= 0.5f) // 40% chance
            {
                Debug.Log($"EXPERIMENTAL PROJECT SUCCESS: {project.ProjectName} was a minor success. Small performance gain.");
                // Apply a small bonus.
            }
            else if (outcome <= 0.8f) // 30% chance
            {
                Debug.Log($"EXPERIMENTAL PROJECT FAILED: {project.ProjectName} yielded no results. Resources wasted.");
                // No changes to the part.
            }
            else // 20% chance
            {
                Debug.Log($"EXPERIMENTAL PROJECT DISASTER: {project.ProjectName} failed catastrophically! It caused a setback in the related car part.");
                // In a real implementation, you would apply a penalty to the target part's stats.
            }
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
