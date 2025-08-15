using UnityEngine;
using UnityEngine.UI;

// Manages the content of the main Finance Overview tab.
public class FinanceOverviewTab : MonoBehaviour
{
    [Header("UI Text Fields")]
    [SerializeField] private Text budgetText;
    [SerializeField] private Text incomeText; // E.g., per race or month
    [SerializeField] private Text expensesText; // E.g., per race or month

    void Start()
    {
        // Populate with test data. In a real game, this would come from a FinanceManager.
        UpdateDisplay(15000000, 1200000, -850000);
    }

    // Updates the text fields with financial data.
    public void UpdateDisplay(float budget, float income, float expenses)
    {
        if (budgetText != null)
        {
            // "C0" formats the number as currency with no decimal places.
            budgetText.text = $"Aktuelles Budget: {budget:C0}";
        }

        if (incomeText != null)
        {
            incomeText.text = $"Einnahmen (p. Monat): {income:C0}";
        }

        if (expensesText != null)
        {
            expensesText.text = $"Ausgaben (p. Monat): {expenses:C0}";
        }
    }
}
