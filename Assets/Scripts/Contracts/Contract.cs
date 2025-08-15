using System;
using System.Collections.Generic;

namespace RacingManager.Contracts
{
    public enum TeamRole
    {
        Driver,
        RaceEngineer,
        TechnicalStaff,
        Scout
    }

    public enum PerformanceBonusType
    {
        Win,
        Podium
    }

    [Serializable]
    public class PerformanceBonus
    {
        public PerformanceBonusType Type;
        public float Amount;
    }

    [Serializable]
    public class Contract
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public float Salary;
        public TeamRole Role;
        public float BuyoutClause;
        public List<PerformanceBonus> PerformanceBonuses;
    }
}
