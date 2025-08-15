using UnityEngine;
using System.Collections.Generic;

namespace RacingManager.Finance
{
    public class SponsorManager : MonoBehaviour
    {
        public static SponsorManager Instance { get; private set; }

        public List<SponsorDeal> activeDeals;

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
        /// Updates a sponsor's satisfaction based on the team's placement.
        /// </summary>
        public void UpdateSponsorSatisfaction(SponsorDeal deal, int currentPlacement)
        {
            if (deal == null) return;

            // Simple logic: if we are meeting or exceeding the required placement, satisfaction goes up.
            // Otherwise, it goes down.
            if (currentPlacement <= deal.RequiredPlacement)
            {
                deal.Satisfaction = Mathf.Clamp(deal.Satisfaction + 5, 0, 100);
                Debug.Log($"Sponsor '{deal.SponsorName}' is pleased. Satisfaction increased.");
            }
            else
            {
                deal.Satisfaction = Mathf.Clamp(deal.Satisfaction - 5, 0, 100);
                Debug.Log($"Sponsor '{deal.SponsorName}' is disappointed. Satisfaction decreased.");
            }
        }

        /// <summary>
        /// Periodically called to check if a sponsor has a special request.
        /// </summary>
        public void GenerateSponsorRequest()
        {
            if (activeDeals.Count == 0) return;

            // 20% chance each time this is called for a random sponsor to make a request.
            if (Random.value < 0.2f)
            {
                var sponsor = activeDeals[Random.Range(0, activeDeals.Count)];
                Debug.Log($"Sponsor Request from '{sponsor.SponsorName}': 'We would like you to sign a driver from our home country!'");
                // This would trigger a GameEvent (from G-014) in a real implementation.
            }
        }
    }
}
