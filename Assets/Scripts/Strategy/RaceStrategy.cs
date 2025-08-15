using System.Collections.Generic;
using UnityEngine;

namespace RacingManager.Strategy
{
    public enum TireCompound
    {
        Soft,
        Medium,
        Hard,
        Intermediate,
        Wet
    }

    [System.Serializable]
    public struct PitStop
    {
        public int LapNumber;
        public TireCompound TireCompound;
    }

    public enum PaceMode
    {
        Conserve,
        Standard,
        Attack
    }

    // G-010 asks for ERSMode, G-016 extends it
    public enum ERSMode
    {
        None,
        Build,
        Overtake,
        Defend, // From G-016
        Hotlap  // From G-016
    }

    public enum TeamOrder
    {
        None,
        HoldPosition,
        AllowPass
    }

    [System.Serializable]
    public class RaceStrategy
    {
        public List<PitStop> PitStops;
        public PaceMode CurrentPaceMode;
        public ERSMode CurrentERSMode;
        public TeamOrder CurrentTeamOrder;

        // Placeholder for team order logic from G-016
        public void IssueTeamOrder(TeamOrder order)
        {
            CurrentTeamOrder = order;
            Debug.Log($"Team order issued: {order}");

            if (order == TeamOrder.AllowPass)
            {
                // This would trigger an event that the MoraleManager (from G-011) would listen to.
                // For now, just a log message.
                Debug.Log("This team order could affect driver morale.");
            }
        }
    }
}
