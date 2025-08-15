using UnityEngine;

namespace RacingManager.Infrastructure
{
    public abstract class Facility : MonoBehaviour
    {
        public int Level { get; protected set; } = 1;

        public abstract void Upgrade();
        public abstract float GetUpgradeCost();
        public abstract int GetUpgradeTime();
    }

    public class WindTunnel : Facility
    {
        public override void Upgrade()
        {
            // Logic to handle the upgrade process
            Level++;
            Debug.Log($"Wind Tunnel upgraded to Level {Level}");
        }

        public override float GetUpgradeCost()
        {
            return Level * 500000; // Example cost calculation
        }

        public override int GetUpgradeTime()
        {
            return Level * 30; // Example time in days
        }

        public float GetAeroResearchBonus()
        {
            return (Level - 1) * 0.1f; // 10% bonus per level above 1
        }
    }

    public class Factory : Facility
    {
        public override void Upgrade()
        {
            Level++;
            Debug.Log($"Factory upgraded to Level {Level}");
        }

        public override float GetUpgradeCost()
        {
            return Level * 750000; // Example cost calculation
        }

        public override int GetUpgradeTime()
        {
            return Level * 45; // Example time in days
        }

        public int GetProductionCapacityBonus()
        {
            return (Level - 1) * 5; // +5 capacity per level
        }
    }
}
