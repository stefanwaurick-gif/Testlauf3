using UnityEngine;

namespace RacingManager.Vehicle
{
    public enum PreSeasonFocus
    {
        None,
        Aerodynamics,
        Engine,
        Chassis,
        Balanced
    }

    public class PreSeasonFocusManager : MonoBehaviour
    {
        public static PreSeasonFocusManager Instance { get; private set; }

        private static PreSeasonFocus currentFocus = PreSeasonFocus.None;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        /// <summary>
        /// Called by the UI at the end of the season to set the R&D focus.
        /// </summary>
        public void SetFocus(PreSeasonFocus focus)
        {
            currentFocus = focus;
            Debug.Log($"Pre-season R&D focus set to: {focus}");
            // In a real game, this would be saved to a save file.
        }

        /// <summary>
        /// Called at the start of a new season to apply the bonuses.
        /// </summary>
        public void ApplyFocusBonus()
        {
            if (currentFocus == PreSeasonFocus.None) return;

            Debug.Log($"Applying pre-season R&D focus bonus for: {currentFocus}");
            // Here you would implement the logic to grant the actual bonus,
            // e.g., giving a head start on research, a free part upgrade, etc.

            // Reset focus after applying
            currentFocus = PreSeasonFocus.None;
        }
    }
}
