using UnityEngine;

namespace RacingManager.Infrastructure
{
    public class FacilityManager : MonoBehaviour
    {
        public WindTunnel WindTunnel;
        public Factory Factory;
        // Add other facilities here

        void Awake()
        {
            // This is just for demonstration. In a real game,
            // you would load the state of these facilities.
            if (WindTunnel == null) WindTunnel = gameObject.AddComponent<WindTunnel>();
            if (Factory == null) Factory = gameObject.AddComponent<Factory>();
        }

        public float GetAeroResearchBonus()
        {
            if (WindTunnel != null)
            {
                return WindTunnel.GetAeroResearchBonus();
            }
            return 0f;
        }

        public int GetProductionCapacityBonus()
        {
            if (Factory != null)
            {
                return Factory.GetProductionCapacityBonus();
            }
            return 0;
        }
    }
}
