using UnityEngine;
using System.Collections.Generic;
using System;

namespace RacingManager.Events
{
    // The delegate for the consequence of a choice
    public delegate void Consequence();

    [System.Serializable]
    public class Choice
    {
        public string ChoiceText;
        public Consequence OnChoose;

        public Choice(string text, Consequence consequence)
        {
            ChoiceText = text;
            OnChoose = consequence;
        }
    }

    public enum EventTrigger
    {
        None,
        BudgetBelowZero,
        MajorSponsorOffer,
        DriverFeud
    }

    [CreateAssetMenu(fileName = "New Game Event", menuName = "Racing Manager/Game Event")]
    public class GameEvent : ScriptableObject
    {
        public string EventTitle;
        [TextArea(3, 5)]
        public string Description;
        public EventTrigger Trigger; // How this event is triggered
        public List<Choice> Choices;
    }

    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance { get; private set; }

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

        public void TriggerEvent(GameEvent gameEvent)
        {
            Debug.Log($"EVENT TRIGGERED: {gameEvent.EventTitle}");
            Debug.Log(gameEvent.Description);
            for (int i = 0; i < gameEvent.Choices.Count; i++)
            {
                Debug.Log($"Choice {i + 1}: {gameEvent.Choices[i].ChoiceText}");
            }
            // In a real game, you would now show a UI and wait for player input.
            // For now, let's just execute the first choice as an example.
            if (gameEvent.Choices.Count > 0)
            {
                gameEvent.Choices[0].OnChoose?.Invoke();
            }
        }
    }
}
