using UnityEngine;
using System.Collections.Generic;
using RacingManager.Staff; // Assuming engineers will be a type of staff

namespace RacingManager.Vehicle
{
    [System.Serializable]
    public class RnDProject
    {
        public string ProjectName;
        public CarPartData TargetPart;
        public float Cost;
        public int DurationDays;
        public int ProgressDays;
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
    }
}
