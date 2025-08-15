using UnityEngine;
using System.Collections.Generic;

namespace RacingManager.Staff
{
    public class MoraleManager : MonoBehaviour
    {
        // In a real implementation, this would hold all staff members
        public List<StaffProfile> allStaff;

        // Example event handler
        public void OnRaceWin()
        {
            Debug.Log("A race was won! Increasing morale for all staff.");
            foreach (var staff in allStaff)
            {
                staff.Morale = Mathf.Clamp(staff.Morale + 10, 0, 100);
            }
        }

        // Example event handler
        public void OnSalaryPaid()
        {
            Debug.Log("Salaries paid. Small morale boost.");
            foreach (var staff in allStaff)
            {
                staff.Morale = Mathf.Clamp(staff.Morale + 2, 0, 100);
            }
        }

        // Example of a negative event
        public void OnTeamOrderControversy(StaffProfile affectedStaff)
        {
            if (affectedStaff != null)
            {
                Debug.Log($"Team order controversy! Morale decreased for {affectedStaff.Name}.");
                affectedStaff.Morale = Mathf.Clamp(affectedStaff.Morale - 20, 0, 100);
            }
        }
    }
}
