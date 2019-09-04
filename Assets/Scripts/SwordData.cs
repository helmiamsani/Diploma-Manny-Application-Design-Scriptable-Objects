﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField] private string swordName;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private int goldCost;
    [SerializeField] private int attackDamage;
    [SerializeField] private AudioSource swordAudio;

    public string SwordName
    {
        get
        {
            return swordName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }

    public AudioSource SwordAudio
    {
        get
        {
            return swordAudio;
        }
    }
}
