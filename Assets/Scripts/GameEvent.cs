﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Name Game Event", menuName = "Game Event", order = 52)]
public class GameEvent : ScriptableObject
{
    private List<GameAction> listeners = new List<GameAction>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameAction listener)
    {
        listeners.Add(listener);
    }

    public void UnRegisterListener(GameAction listener)
    {
        listeners.Remove(listener);
    }
}
