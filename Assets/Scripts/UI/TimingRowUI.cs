using UnityEngine;
using UnityEngine.UI;

// Holds the UI element references for a single row in the timing table.
public class TimingRowUI : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text positionText;
    [SerializeField] private Text driverNameText;
    [SerializeField] private Text lapTimeText;
    [SerializeField] private Text gapText;

    // Sets the data for this row.
    public void SetData(int pos, string name, string time, string gap)
    {
        positionText.text = pos.ToString();
        driverNameText.text = name;
        lapTimeText.text = time;
        gapText.text = gap;
    }
}
