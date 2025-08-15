using UnityEngine;
using System;
using System.Collections.Generic;

public class GameTimeManager : MonoBehaviour
{
    public static GameTimeManager Instance { get; private set; }

    public DateTime CurrentDate { get; private set; }
    public List<GameEvent> AllGameEvents { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            AllGameEvents = new List<GameEvent>();
            InitializeDate();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeDate()
    {
        CurrentDate = new DateTime(2026, 1, 1);
        Debug.Log($"Game time initialized. Current date: {CurrentDate.ToShortDateString()}");
        SetupTestEvents();
    }

    private void SetupTestEvents()
    {
        AllGameEvents.Add(new GameEvent(new DateTime(2026, 3, 15), "Season Opener: Bahrain Grand Prix"));
        Debug.Log("Test events have been set up.");
    }

    public void AdvanceDay()
    {
        CurrentDate = CurrentDate.AddDays(1);
        Debug.Log($"Day advanced. New date: {CurrentDate.ToShortDateString()}");
        CheckForEvents();
    }

    private void CheckForEvents()
    {
        foreach (var gameEvent in AllGameEvents)
        {
            if (gameEvent.EventDate.Date == CurrentDate.Date)
            {
                Debug.Log($"EVENT TODAY: {gameEvent.Description}");
            }
        }
    }
}
