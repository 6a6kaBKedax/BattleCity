using UnityEngine;
using System;
using Assets.BuilderPattern.enums.Base;

public class Base : MonoBehaviour
{
    public UnityEngine.Color Fracktion;
    public int HP;
    public int ActiveTanks;
    public bool IsPlayer { get; set; }
    public void Inicialization(UnityEngine.Color fracktion, bool isPlayer)
    {
        Fracktion = fracktion;
        IsPlayer = isPlayer;
        HP = (int)BaseHp.Level1;
        ActiveTanks = (int)BaseTanks.Level1;
    }
}

