using UnityEngine;
using System.Collections.Generic;
using System.Linq;

// Manages the Pre-Race Screen, specifically the track characteristics display.
public class PreRaceUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject characteristicDisplayPrefab;
    [SerializeField] private Transform contentParent;

    [Header("Data")]
    [Tooltip("Assign all possible track characteristic info objects here in the Inspector.")]
    [SerializeField] private List<TrackCharacteristicInfo> allCharacteristicsInfo;

    void Start()
    {
        // Example data for the current track (e.g., Monaco)
        List<TrackCharacteristicType> currentTrackCharacteristics = new List<TrackCharacteristicType>
        {
            TrackCharacteristicType.HighDownforce,
            TrackCharacteristicType.LowGrip,
            TrackCharacteristicType.BumpySurface
        };

        DisplayTrackCharacteristics(currentTrackCharacteristics);
    }

    public void DisplayTrackCharacteristics(List<TrackCharacteristicType> characteristics)
    {
        // Clear previous entries
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        // Find and display the info for each characteristic of the current track
        foreach (var type in characteristics)
        {
            // Find the corresponding info object from the master list
            TrackCharacteristicInfo? info = allCharacteristicsInfo.FirstOrDefault(i => i.Type == type);

            if (info.HasValue)
            {
                GameObject instance = Instantiate(characteristicDisplayPrefab, contentParent);
                CharacteristicDisplayUI displayUI = instance.GetComponent<CharacteristicDisplayUI>();
                if (displayUI != null)
                {
                    displayUI.SetData(info.Value.Icon, info.Value.Description);
                }
            }
        }
    }
}
