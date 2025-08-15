using System;

namespace RacingManager.Contracts
{
    public enum TeamRole
    {
        Driver,
        RaceEngineer,
        TechnicalStaff,
        Scout
    }

    [Serializable]
    public class Contract
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public float Salary;
        public TeamRole Role;
        public string PerformanceBonuses; // Placeholder as per instructions
    }
}
