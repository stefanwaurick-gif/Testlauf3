using UnityEngine;

/// <summary>
/// Defines the possible strategic states for an AI team.
/// </summary>
public enum StrategyState
{
    AggressiveDevelopment, // Focus on R&D and car upgrades, even at a high cost.
    Balanced,              // A moderate approach to spending and development.
    SaveMoney              // Prioritize saving money, avoid expensive development.
}

/// <summary>
/// Manages the strategic decisions for an AI-controlled team.
/// This includes R&D focus and financial strategy.
/// </summary>
public class AITeamStrategy : MonoBehaviour
{
    [Tooltip("The current strategic state of the AI team.")]
    public StrategyState CurrentState { get; private set; }

    // For demonstration, we can allow changing the state change interval in the inspector.
    [Tooltip("How often the AI re-evaluates its strategy, in seconds.")]
    [SerializeField] private float strategyChangeInterval = 10.0f;

    private float timeSinceLastChange = 0.0f;

    /// <summary>
    /// Sets the initial state randomly.
    /// </summary>
    void Start()
    {
        ChangeState();
    }

    /// <summary>
    /// Periodically re-evaluates the strategy.
    /// </summary>
    void Update()
    {
        timeSinceLastChange += Time.deltaTime;

        if (timeSinceLastChange >= strategyChangeInterval)
        {
            ChangeState();
            timeSinceLastChange = 0.0f;
        }
    }

    /// <summary>
    /// Changes the current strategy to a new, random state.
    /// In the future, this will be driven by more complex logic.
    /// </summary>
    private void ChangeState()
    {
        // Get all possible values from the enum.
        System.Array states = System.Enum.GetValues(typeof(StrategyState));

        // Pick a random state.
        StrategyState newState = (StrategyState)states.GetValue(Random.Range(0, states.Length));

        // Ensure the new state is actually different, to make changes more meaningful.
        // For a small number of states, a loop is fine.
        while (newState == CurrentState)
        {
            newState = (StrategyState)states.GetValue(Random.Range(0, states.Length));
        }

        CurrentState = newState;

        // Log the state change for debugging purposes.
        Debug.Log($"AI team strategy changed to: {CurrentState}");
    }
}
