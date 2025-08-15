using UnityEngine;

namespace RacingManager.Finance
{
    public static class FinanceManager
    {
        public static float CurrentBudget { get; private set; } = 10000000; // Starting budget

        /// <summary>
        /// Processes a transaction.
        /// </summary>
        /// <param name="amount">Positive for income, negative for expense.</param>
        /// <returns>True if the transaction was successful, false otherwise.</returns>
        public static bool ProcessTransaction(float amount)
        {
            // If it's an expense, check if we can afford it
            if (amount < 0 && CurrentBudget + amount < 0)
            {
                Debug.LogWarning("Transaction failed: Insufficient funds.");
                return false;
            }

            CurrentBudget += amount;
            Debug.Log($"Transaction successful. New budget: {CurrentBudget}");
            return true;
        }

        public static void SetBudget(float newBudget)
        {
            CurrentBudget = newBudget;
        }
    }
}
