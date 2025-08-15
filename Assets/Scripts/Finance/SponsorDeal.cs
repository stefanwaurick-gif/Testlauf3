using UnityEngine;

namespace RacingManager.Finance
{
    [CreateAssetMenu(fileName = "New Sponsor Deal", menuName = "Racing Manager/Sponsor Deal")]
    public class SponsorDeal : ScriptableObject
    {
        public string SponsorName;
        public float UpfrontPayment;
        public float RaceBonus;
        public float ChampionshipBonus;
        public int RequiredPlacement;
    }
}
