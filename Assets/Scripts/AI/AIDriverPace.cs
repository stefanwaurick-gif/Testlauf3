using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace RacingManager.AI
{
    // --- PLACEHOLDER DATA STRUCTURES ---
    // In a real project, this would be defined in a shared 'Data' assembly
    // and likely be a ScriptableObject.

    /// <summary>
    /// Placeholder for a driver trait.
    /// </summary>
    public struct Trait
    {
        public string Name;
        public float PaceModifier; // e.g., +0.1 for a boost, -0.1 for a penalty
    }

    // --- END OF PLACEHOLDER ---

    /// <summary>
    /// Manages the pace of an AI driver based on their inherent traits.
    /// </summary>
    public class AIDriverPace : MonoBehaviour
    {
        [Tooltip("The list of traits this driver possesses.")]
        public List<Trait> driverTraits = new List<Trait>();

        private float cachedPaceModifier = 0f;

        void Start()
        {
            // Example traits for demonstration
            driverTraits.Add(new Trait { Name = "Overtaker", PaceModifier = 0.05f });
            driverTraits.Add(new Trait { Name = "Tire Whisperer", PaceModifier = -0.02f }); // Slightly slower to save tires

            cachedPaceModifier = CalculatePaceModifier();
            Debug.Log($"Driver pace modifier calculated to: {cachedPaceModifier}");
        }

        /// <summary>
        /// Calculates the total pace modifier from all of the driver's traits.
        /// </summary>
        /// <returns>A single float representing the combined pace modifier.</returns>
        public float CalculatePaceModifier()
        {
            if (driverTraits == null || driverTraits.Count == 0)
            {
                return 0f;
            }

            // Sum up all the modifiers from the traits.
            return driverTraits.Sum(trait => trait.PaceModifier);
        }

        /// <summary>
        /// Public getter for the cached pace modifier.
        /// </summary>
        public float GetPaceModifier()
        {
            return cachedPaceModifier;
        }
    }
}
